using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

/// <summary>
/// Summary description for OleDbClass
/// </summary>
public class DbClass
{
    static string cnnstr = "Data Source=.\\SQLExpress;initial catalog=ikizler;Trusted_Connection=True;";
    static SqlConnection cnn = new SqlConnection(cnnstr);

    //static string cnnstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +  calismayolu +"/App_Data/evrensel.mdb;user id=admin;password=;";
    //static OleDbConnection cnn = new OleDbConnection(cnnstr);

	public DbClass()
	{

    }

    public  DataSet Fill2(string sql, string tablo, params OleDbParameter[] prms)
    {
        SqlCommand cmd = new SqlCommand(sql, cnn);
        //OleDbCommand cmd = new OleDbCommand(sql, cnn);
        if (prms!=null)
          cmd.Parameters.AddRange(prms); //sql'in parametreleri ekleniyor
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds,tablo);
        return ds;
    }

    public  DataTable Fill(string sql,params OleDbParameter[] prms)
    {
        SqlCommand cmd = new SqlCommand(sql, cnn);
        //OleDbCommand cmd = new OleDbCommand(sql, cnn);
        if (prms != null)
          cmd.Parameters.AddRange(prms); //sql'in parametreleri ekleniyor
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        
        da.Fill(dt);
        return dt;
    }

    public DataTable Filldt(string sql, params OleDbParameter[] prms)
    {
        SqlCommand cmd = new SqlCommand(sql, cnn);
        //OleDbCommand cmd = new OleDbCommand(sql, cnn);
        if (prms != null)
            cmd.Parameters.AddRange(prms); //sql'in parametreleri ekleniyor
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();

        da.Fill(dt);
        return dt;
    }

    public  int ExecuteNonQuery(string sql,params OleDbParameter[] prms)
    {//her türlü sorgu çalışır.

        int sonuc=-1;
        SqlCommand cmd = new SqlCommand(sql, cnn);
        //OleDbCommand cmd = new OleDbCommand(sql, cnn);
        if (prms != null)
          cmd.Parameters.AddRange(prms); //sql'in parametreleri ekleniyor
        if (cnn.State == ConnectionState.Closed)
        {
            cnn.Open(); //Command çalışırken bağlantı açık olmalıdır
        }

        try
        {
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SELECT @@IDENTITY AS SAYI", cnn);
            //OleDbCommand cmd1 = new OleDbCommand("SELECT @@IDENTITY AS SAYI", cnn);
            object s = cmd1.ExecuteScalar();
            if (s != DBNull.Value)
            {
                sonuc = Convert.ToInt32(s);
            }
            else
            {
                s = 0;
            }
        }
        finally
        {
            cnn.Close();//Komut çalıştıktan sonra ister hata oluşsun ister oluşmasın
                        //bağlantı kapatılır.
        }

        return sonuc;
    }

    public  object ExecuteScalar(string sql, params SqlParameter[] prms)
    {//her türlü sorgu çalışır.

        object sonuc = null;
        SqlCommand cmd = new SqlCommand(sql, cnn);
        //OleDbCommand cmd = new OleDbCommand(sql, cnn);
        if (prms != null)
           cmd.Parameters.AddRange(prms); //sql'in parametreleri ekleniyor
        
        if (cnn.State == ConnectionState.Closed)
        {
            cnn.Open(); //Command çalışırken bağlantı açık olmalıdır
        }

        try
        {
            sonuc=cmd.ExecuteScalar();
        }
        finally
        {
            cnn.Close();//Komut çalıştıktan sonra ister hata oluşsun ister oluşmasın
            //bağlantı kapatılır.
        }
        return sonuc;
    }

    public static DataSet DataSetGetir2(string sqlstr, string tabloadi)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(sqlstr, cnn);
        //OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, cnn);
        da.Fill(ds, tabloadi);
        return ds;
    }

    public static void ExecuteNonQuery2(string sqlstr)
    {
        SqlCommand cmd = new SqlCommand(sqlstr, cnn);
        //OleDbCommand cmd = new OleDbCommand(sqlstr, cnn);
        if (cnn.State == ConnectionState.Closed)
        {
            cnn.Open();
        }

        try
        {
            cmd.ExecuteNonQuery();
        }
        finally
        {
            //cnn.Close();
        }

    }

    /// <summary>
    /// Sadece tek bir değer döner.
    /// Örnek : textBox.Text=Convert.ToString(DbClassSQL.ExecuteScalar("SELECT * FROM TABLO WHERE SUTUN='" + sutunverisi + "'"));
    /// </summary>
    /// <param name="sqlstr"></param>
    public static object ExecuteScalar2(string sqlstr)
    {
        object sonuc;
        SqlCommand cmd = new SqlCommand(sqlstr, cnn);
        //OleDbCommand cmd = new OleDbCommand(sqlstr, cnn);


        if (cnn.State == ConnectionState.Closed)
        {
            cnn.Open();
        }

        try
        {
            sonuc = cmd.ExecuteScalar();
        }
        finally
        {
            cnn.Close();
        }
        return sonuc;
    }

    //public static OleDbDataReader ExecuteReader2(string sqlstr)
    //{
    //    OleDbDataReader dr;
    //    OleDbCommand cmd = new OleDbCommand(sqlstr, cnn);

    //    if (cnn.State == ConnectionState.Closed)
    //    {
    //        cnn.Open();
    //    }

    //    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//datareader kapatılırsa connection da kapatılsın
    //    return dr;
    //}

    public DataTable Filldt(string sql)
    {
        throw new NotImplementedException();
    }

    //public static SqlDataReader ExecuteReader2(string sqlstr)
    //{
        //SqlDataReader dr;
        //SqlCommand cmd = new SqlCommand(sqlstr, cnn);
        //OleDbDataAdapter dr;
        //OleDbCommand cmd = new OleDbCommand(sqlstr, cnn);

        //if (cnn.State == ConnectionState.Closed)
        //{
        //    cnn.Open();
        //}

        //dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);//datareader kapatılırsa connection da kapatılsın
        //return dr;
    //}


   
}