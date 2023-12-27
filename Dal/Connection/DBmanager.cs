namespace Dal.Connection;
using BOL;

using MySql.Data.MySqlClient;

public class DBmanager
{
    
 public static string conString=@"server=192.168.10.150;port=3306;user=dac38;password=welcome;database=dac38";
   public static List<Student> GetstudentDetail()
   {
    List<Student> GetstudentDetail=new List<Student>();
    MySqlConnection conn=new MySqlConnection();
    conn.ConnectionString=conString;
    string query="select * from student";
    try{
        MySqlCommand  cmd=new MySqlCommand();
        cmd.Connection=conn;
        conn.Open();
        cmd.CommandText=query;
        MySqlDataReader reader=cmd.ExecuteReader();
        while(reader.Read())
        {
            int id =int.Parse(reader["id"].ToString());
            string namefirst=reader["namefirst"].ToString();
            string namelast=reader["namelast"].ToString();
            string dob=reader["dob"].ToString();
            string emailid=reader["emailid"].ToString();
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
    finally{

        conn.Close();
    }
    return GetstudentDetail;
   } 
   }


