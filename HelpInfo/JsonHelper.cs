using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
/*Json转换*/
namespace labdata
{
    public class JsonHelper
    {
        ///<summary>
        /// 返回easyui/extjs中datagrid使用的json格式
        ///</summary>
        ///<param name="dt">datatable数据</param>
        ///<param name="count">总的条数</param>
        ///<returns></returns>
        public static string DataToJson(DataTable dt, int count)
        {
            StringBuilder sbjson = new StringBuilder();
            sbjson.Append("[");
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sbjson.Append(",\r\n");
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");

                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");

                            }
                        }
                        sbjson.Append("}");
                    }
                    else
                    {
                        sbjson.Append("{");
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (dt.Columns.IndexOf(dc) > 0)
                            {
                                sbjson.Append(",");
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");

                            }
                            else
                            {
                                sbjson.Append("\"" + dc.ColumnName + "\":\"" + dt.Rows[i][dc.ColumnName].ToString().Trim() + "\"");

                            }
                        }
                        sbjson.Append("}");
                    }
                }
            }

            sbjson.Append("]");
            return sbjson.ToString();
        }
    }
}
