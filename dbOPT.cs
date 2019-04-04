using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//引用SQL命名空间
using System.Windows.Forms;  //引用Forms命名空间
using System.Data;     //引用数据库命名空间
using System.IO; //引用文件操作命名空间 2018-11-5 08:48:21

namespace login
{
    class dbOPT
    {
        SqlConnection conn = MyConnection();//得到数据库连接对象
        public static SqlConnection MyConnection()
        {
            //此处连接数据库字符串参见文档《【数据库】C#与数据库连接.docx》
            // Data Source=APPLEMACBOOKPRO\SQLEXPRESS;Initial Catalog=EMR;Integrated Security=True
            // Data Source=DESKTOP-6VVOFLH\SQLEXPRESS;Initial Catalog=hisdata;Integrated Security=True
            return new SqlConnection(@"Data Source=APPLEMACBOOKPRO\SQLEXPRESS;Initial Catalog=EMR;Integrated Security=True");
        }

        /// <summary>
        /// 操作数据库，执行各种SQL语句
        /// </summary>
         /// <param name="strSql">SQL语句</param>
        /// <returns>方法返回受影响的行数</returns>
         public int OperateData(string strSql)
         {
             try
             {
                 if (conn.State == ConnectionState.Closed)
                 {
                     conn.Open();//打开数据库连接
                 }
                 SqlCommand cmd = new SqlCommand(strSql, conn);//创建命令对象
                 int i = (int)cmd.ExecuteNonQuery();//执行SQL命令
                 conn.Close();//关闭数据库连接
                 return i;//返回数值
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
                 return -1;
             }
         }


         /// <summary>
         /// 方法用于绑定DataGridView控件
         /// </summary>
         /// <param name="dgv">DataGridView控件</param>
         /// <param name="sql">SQL语句</param>
         public void BindDataGridView(DataGridView dgv, string sql)
         {
             try
             {
                 SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//创建数据适配器对象
                 DataSet ds = new DataSet();//创建数据集对象
                 sda.Fill(ds);//填充数据集
                 dgv.DataSource = ds.Tables[0];//绑定到数据表
                 ds.Dispose();//释放资源
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }
         }


         /// <summary>
         /// 使用此方法可以得到数据集
         /// </summary>
         /// <param name="sql">SQL语句</param>
         /// <returns>方法返回数据集</returns>
         public DataSet GetTable(string sql)
         {
             try
             {
                 SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//创建数据适配器对象
                 DataSet ds = new DataSet();//创建数据集
                 sda.Fill(ds);//填充数据集
                 ds.Dispose();//释放资源
                 return ds;//返回数据集
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
                 return null;
             }
         }

        /// <summary>
        /// //绑定下拉列表
        /// </summary>
        /// <param name="strTable">数据库表名</param>
        /// <param name="queryCondition">附加查询语句</param>
        /// <param name="cb">ComboBox对象</param>
        /// <param name="i">指定数据列索引</param>
        public void BindDropdownlist(string strTable, string queryCondition, ComboBox cb, int i)
         {
             try
             {
                 if (conn.State == ConnectionState.Closed)
                 {
                     conn.Open();//打开数据库连接
                 }

                // 清空items
                cb.SelectedIndex = -1;
                cb.Items.Clear();

                 SqlCommand cmd = new SqlCommand(//创建命令对象
                     "select * from " + strTable + " " + queryCondition, conn);
                 SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器
                 while (sdr.Read())
                 {
                     cb.Items.Add(sdr[i].ToString());//添加信息
                 }
                 conn.Close();//关闭数据库连接
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }

         }
    }
}
    
