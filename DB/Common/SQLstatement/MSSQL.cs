using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBschemaTool.DB.Common.SQLstatement
{
    class MSSQL
    {   
        public static string GetViewStruct = @"select 
    st.name[Table],
    ic.COLUMN_NAME [Column],
    ic.is_nullable[Isnull],
    ic.ORDINAL_POSITION[orderId],
    ic.DATA_TYPE,
	ic.CHARACTER_MAXIMUM_LENGTH [MaxLength],
	sc.is_identity [IsKey],
    sep.value[Description]
from sys.views st
inner JOIN INFORMATION_SCHEMA.COLUMNS ic ON ( st.name=ic.TABLE_NAME   )
left join sys.columns sc on st.object_id = sc.object_id  and sc.name= ic.COLUMN_NAME
left join sys.extended_properties sep on (st.object_id = sep.major_id
                                        and sc.column_id = sep.minor_id
                                        and sep.name = 'MS_Description')

                                        order by[Table],[orderId]";
        public static string GetTableStruct = @"select 
    st.name[Table],
    ic.COLUMN_NAME[Column],
    ic.is_nullable[Isnull],
    ic.ORDINAL_POSITION[orderId],
    ic.DATA_TYPE,
	ic.CHARACTER_MAXIMUM_LENGTH [MaxLength],
	sc.is_identity [IsKey],
    sep.value[Description]
from sys.tables st
inner JOIN INFORMATION_SCHEMA.COLUMNS ic ON ( st.name=ic.TABLE_NAME   )
left join sys.columns sc on st.object_id = sc.object_id  and sc.name= ic.COLUMN_NAME
left join sys.extended_properties sep on (st.object_id = sep.major_id
                                        and sc.column_id = sep.minor_id
                                        and sep.name = 'MS_Description')

                                        order by[Table],[orderId]";
    }
}
