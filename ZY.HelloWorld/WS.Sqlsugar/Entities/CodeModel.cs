using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Sqlsugar
{
    [SugarTable("Base_Code")]
    public partial class CodeModel
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =false,ColumnName ="C_ID")]
        public Guid ID { get; set; }
        [SugarColumn(ColumnName ="C_TypeCode")]
        public string TypeCode { get; set; }
    }
}
