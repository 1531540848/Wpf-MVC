
using Microsoft.EntityFrameworkCore;
using WPFDAL;
using WPFMODEL;

namespace WPFBLL
{
    public class StudentManager
    {

        public static StudentContext studentContext = new StudentContext();
        
        //查询所有学生数据
        public static List<Students> GetStudent()
        {
            //事务
            //var transaction = studentContext.Database.BeginTransaction();
            //transaction.Rollback();
            //transaction.Commit();
            return studentContext.Students.ToList();
        }
        //添加新的学生信息
        public static void InsertStu(Students students)
        {
            studentContext.Students.Add(students);
            studentContext.SaveChanges();
        }
        //修改学生信息
        public static void UpdateStu(Students students)
        {
            var id = studentContext.Students.Find(students.Id);
            var entry = studentContext.Entry(id);
            entry.CurrentValues.SetValues(students);
            entry.Property(p => p.Id).IsModified = false;
            studentContext.SaveChanges();
        }
        //删除学生信息
        public static void DeleteStu(int ids)
        {
            studentContext.Students.Where(p => p.Id == ids).ExecuteDelete();
            //Students student = studentContext.Students.FirstOrDefault(p => p.Id == ids);
            //studentContext.Students.Remove(student);
            //studentContext.SaveChanges();
        }
        //学生信息关键字查询
        public static List<Students> SetKeyStudent(string StuName)
        {
            return studentContext.Students.Where(p => p.StudentName.Contains(StuName)).ToList();
        }
        //学生信息ID查询
        public static Students SetIdStudent(int ids)
        {
            return studentContext.Students.FirstOrDefault(p => p.Id == ids);
        }
        
    }

}
