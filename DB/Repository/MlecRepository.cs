using Dapper;
using DBschemaTool.DB.Common.SQLstatement;
using DBschemaTool.Model;
using DBschemaTool.Repository.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBschemaTool.Repository
{
    /// <summary>
    /// Pchome資料Repository
    /// </summary>
    public class MlecRepository : IDisposable
    {
        private IDatabaseConnectionHelper _DatabaseConnection { get; }

        internal MlecRepository(IDatabaseConnectionHelper databaseConnectionHelper)
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
        ~MlecRepository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


        public IEnumerable<MsSQLTableDes> GetTable()
        {
            string sqlCommand = MSSQL.GetTableStruct;
            using (var conn = _DatabaseConnection.Create())
            {
                var result = conn.Query<MsSQLTableDes>(sqlCommand);

                return result;
            }

        }
        public IEnumerable<MsSQLTableDes> GetView()
        {
            string sqlCommand = MSSQL.GetViewStruct;
            using (var conn = _DatabaseConnection.Create())
            {
                var result = conn.Query<MsSQLTableDes>(sqlCommand);

                return result;
            }


        }




    }
}
