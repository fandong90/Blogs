using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace Blog.Data
{
    public class MysqlHelper
    {

        private MySqlConnection _mysqlCon;
        private MySqlCommand _myComand;
        /// <summary>
        /// 配置连接的字符串
        /// </summary>
        private  readonly string connStr = string.Format(@"server={0};User ID='{1}';password='{2}';Database='{3}'",
                                                             "localhost", "root", "fandong0920", "BLOG");
        /// <summary>
        /// 配置连接
        /// </summary>
        private void MysqlCon(){
            _mysqlCon = new MySqlConnection(this.connStr); 
        }

        /// <summary>
        /// 返回一个数据集合
        /// </summary>
        /// <returns>The data set.</returns>
        /// <param name="sqlText">Sql text.</param>
        public DataSet ExecuteDataSet(string sqlText)
        {

            if (this._mysqlCon.State != ConnectionState.Open)
                this._mysqlCon.Open();
            this._myComand = new MySqlCommand();
            this._myComand.Connection = this._mysqlCon;
            this._myComand.CommandType = CommandType.Text;
            this._myComand.CommandText = sqlText;
            MySqlDataAdapter da = new MySqlDataAdapter(this._myComand);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
                
        }


        public MysqlHelper()
        {
            MysqlCon();
        }
    }
}
