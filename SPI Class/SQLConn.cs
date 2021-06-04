using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;


namespace SPI_Class
{
    public abstract class SQLConn
    {
        private readonly string cs;
        public SQLConn()
        {
            cs = "Data Source = Gurutech; initial catalog=CSharp;user id= sa; password= 123";
        }
        protected SqlConnection con()
        {
            return new SqlConnection(cs);
        }
    }
}