using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SuperWCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“User”。
    public class User : IUser
    {
        public void DoWork()
        {
        }

        public DataSet GetDataUser()
        {
            SqlConnection sqlcon= new SqlConnection(ConfigurationManager.ConnectionStrings["SuperConnection"].ConnectionString);
            SqlCommand sqlcom = new SqlCommand("Select * from Sys_User ",sqlcon);
            SqlDataAdapter ada = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            return ds;
        }
    }
}
