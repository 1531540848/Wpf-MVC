
using Microsoft.EntityFrameworkCore;
using WPFDAL;
using WPFMODEL;

namespace WPFBLL
{
    public class StudentManager
    {

        public static StudentContext studentContext = new StudentContext();
        
        //��ѯ����ѧ������
        public static List<Students> GetStudent()
        {
            //����
            //var transaction = studentContext.Database.BeginTransaction();
            //transaction.Rollback();
            //transaction.Commit();
            return studentContext.Students.ToList();
        }
        //����µ�ѧ����Ϣ
        public static void InsertStu(Students students)
        {
            studentContext.Students.Add(students);
            studentContext.SaveChanges();
        }
        //�޸�ѧ����Ϣ
        public static void UpdateStu(Students students)
        {
            var id = studentContext.Students.Find(students.Id);
            var entry = studentContext.Entry(id);
            entry.CurrentValues.SetValues(students);
            entry.Property(p => p.Id).IsModified = false;
            studentContext.SaveChanges();
        }
        //ɾ��ѧ����Ϣ
        public static void DeleteStu(int ids)
        {
            studentContext.Students.Where(p => p.Id == ids).ExecuteDelete();
            //Students student = studentContext.Students.FirstOrDefault(p => p.Id == ids);
            //studentContext.Students.Remove(student);
            //studentContext.SaveChanges();
        }
        //ѧ����Ϣ�ؼ��ֲ�ѯ
        public static List<Students> SetKeyStudent(string StuName)
        {
            return studentContext.Students.Where(p => p.StudentName.Contains(StuName)).ToList();
        }
        //ѧ����ϢID��ѯ
        public static Students SetIdStudent(int ids)
        {
            return studentContext.Students.FirstOrDefault(p => p.Id == ids);
        }
        
    }

}
