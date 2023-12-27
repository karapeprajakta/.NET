namespace Dal.DisConnection;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;

public class DBmanager
{
    
 public static string conString=@"server=192.168.10.150;port=3306;user=dac38;password=welcome;database=dac38";
   public static List<Student> GetstudentDetail()
   {
    List<Student> GetstudentDetail=new List<Student>();
    MySqlConnection conn=new MySqlConnection();
    conn.ConnectionString=conString;
   
    try{
        DataSet ds=new DataSet();  
        MySqlCommand  cmd=new MySqlCommand();
        cmd.Connection=conn;
         string query="select * from student";
      
        cmd.CommandText=query;
         MySqlDataAdapter da=new MySqlDataAdapter();
       da.SelectCommand=cmd;
       da.Fill(ds);
         DataTable dt=ds.Tables[0];
            DataRowCollection rows=dt.Rows;
          
       
            foreach(DataRow row in rows)
            {
                  int id =int.Parse(row["id"].ToString());
             string namefirst=row["namefirst"].ToString();
             string namelast=row["namelast"].ToString();
             string dob=row["dob"].ToString();
            string emailid=row["emailid"].ToString();
              Student s=new Student{
                Id=id,
                Namefirst=namefirst,
                Namelast=namelast,
                Dob=dob,
                Emailid=emailid
                };
           
           
            GetstudentDetail.Add(s);
        }
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    
    return GetstudentDetail;
   } 
   }





