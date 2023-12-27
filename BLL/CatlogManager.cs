namespace BLL;
using Dal.DisConnection;
using BOL;

public class CatlogManager
{
  public List<Student> Getallstudent()
  {
    List<Student> AllStudent=new List<Student>();
    AllStudent=DBmanager.GetstudentDetail();
    return AllStudent;

  }
}
