using System.Data.SqlClient;

namespace ProyectoFinal
{
    class Conexion
    {
        public static SqlConnection GetSqlWinAuthenticationConnetion()
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROYECTOFC#;Integrated Security=true;");
            cn.Open();
            return cn;
        }
    }
}
