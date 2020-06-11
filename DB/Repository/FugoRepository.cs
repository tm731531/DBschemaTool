﻿using Dapper;
using DBschemaTool.Repository.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBschemaTool.Repository
{
    /// <summary>
    /// Pchome資料Repository
    /// </summary>
    public class FugoRepository : IDisposable
    {
        private IDatabaseConnectionHelper _DatabaseConnection { get; }

        internal FugoRepository(IDatabaseConnectionHelper databaseConnectionHelper)
        {
            this._DatabaseConnection = databaseConnectionHelper;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    return;
                }
                disposedValue = true;
            }
        }
        ~FugoRepository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion





        public IEnumerable<int> GetTbx001Dto()
        {
            string sqlCommand = @"select TBX001Seq from tbx_001";

            using (var conn = _DatabaseConnection.Create())
            {
                var result = conn.Query<int>(sqlCommand);

                return result;
            }

        }

        public List<string> GetSpDto(string des)
        {
            var getset = " { get; set; }";
            string sqlCommand = $@"declare
    cur number;
    cnt number;
    cols_desc dbms_sql.desc_tab;
    v_acur sys_refcursor;
    v_col_type varchar2(100);
    v_col_scale number;
    v_col_precision number;    
    v_csharp_col_type varchar2(100);
    
begin
    
    {des};    
    cur := dbms_sql.to_cursor_number(v_acur); 
    
  
    -- common  
    dbms_sql.describe_columns(cur, cnt, cols_desc );
    
    
    FOR i IN 1..cols_desc.COUNT
    LOOP
      v_col_scale := cols_desc(i).col_scale;
      v_col_precision := cols_desc(i).col_precision;
    
      v_col_type := case when cols_desc(i).col_type = 1 then 'NVARCHAR2' 
                      when cols_desc(i).col_type = 2 then      'NUMBER' 
                      when cols_desc(i).col_type = 12 then     'DATE'  
                      when cols_desc(i).col_type = 96 then     'NCHAR'  
                      when cols_desc(i).col_type = 112 then    'NCLOB'  
                      when cols_desc(i).col_type = 113 then    'BLOB'  
                      when cols_desc(i).col_type = 114 then    'BFILE'                                             
                      end;
       if v_col_type = 'NUMBER' then
         if v_col_scale>0 then
            v_csharp_col_type := 'double';
         elsif v_col_scale = -127 then
            v_csharp_col_type := 'decimal';          
         elsif v_col_scale=0 and (power(10,v_col_precision) -1) <= (power(2,7) -1) then
            v_csharp_col_type := 'short'; --'byte';         
         elsif v_col_scale=0 and (power(10,v_col_precision) -1) <= (power(2,15) -1) then
            v_csharp_col_type := 'short';
         elsif v_col_scale=0 and (power(10,v_col_precision) -1) <= (power(2,31) -1) then
            v_csharp_col_type := 'int'; 
         elsif v_col_scale=0 and (power(10,v_col_precision) -1) <= (power(2,63) -1) then
            v_csharp_col_type := 'long';                                     
         end if;
       elsif v_col_type = 'NVARCHAR2' or v_col_type = 'NCHAR' or v_col_type = 'NCLOB' then
             v_csharp_col_type := 'string';  
       elsif v_col_type = 'DATE' then
             v_csharp_col_type := 'DateTime';  
       elsif v_col_type = 'BLOB' or v_col_type = 'BFILE' then
             v_csharp_col_type := 'byte[]';                            
       end if;
         
       if cols_desc(i).col_null_ok = true and (v_col_type = 'NUMBER' or v_col_type = 'DATE') then
            v_csharp_col_type :=v_csharp_col_type||'?'; 
       end if;
                
       dbms_output.put_line(
           v_csharp_col_type  
          ||' ' || cols_desc(i).col_name
          ||' '
          
          );
       
       v_csharp_col_type := '';
       
    END LOOP;


    dbms_sql.close_cursor(cur);
end;



";

            List<string> classStruct = new List<string>();
            using (var conn = _DatabaseConnection.Create())
            {
                conn.Execute("dbms_output.enable",
                   commandType: CommandType.StoredProcedure);
                DynamicParameters p = new DynamicParameters();
                p.Add("line", dbType: DbType.String,
                    direction: ParameterDirection.Output, size: 4000);
                p.Add("status", dbType: DbType.Int32,
                    direction: ParameterDirection.Output);
                conn.Execute(sqlCommand);
                int status;
                do
                {
                    conn.Execute("dbms_output.get_line", p,
                        commandType: CommandType.StoredProcedure);

                    var tempString = p.Get<string>("line");
                    if (!string.IsNullOrEmpty(tempString))
                    {
                        classStruct.Add("public " + p.Get<string>("line") + getset);
                        // Console.WriteLine(p.Get<string>("line"));
                        
                    }
                    status = p.Get<int>("status");

                } while (status == 0);
                return classStruct;
            }

        }
        public IEnumerable<string> GetSpInputDto(string des) {
            string sqlCommand = $@"Select text FROM ALL_SOURCE where OwnER= 'FUGO21' and Name='{des}'";

            using (var conn = _DatabaseConnection.Create())
            {
                var result = conn.Query<string>(sqlCommand);

                return result;
            }

        }

    }
}
