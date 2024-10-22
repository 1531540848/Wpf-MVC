using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFBLL;
using WPFMODEL;

namespace WPFUI
{
    /// <summary>
    /// StudentUpdate.xaml 的交互逻辑
    /// </summary>
    public partial class StudentUpdate : Window
    {
        public static int ids;
        public StudentUpdate(int id)
        {
            ids = id;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;//在父窗口中居中
            InitializeComponent();
            Students student = StudentManager.SetIdStudent(ids);
            if (student != null)
            {
                StuName.Text = student.StudentName;
                StuGender.SelectedIndex = int.Parse(student.Gender == "男" ? "0" : "1");
                StuBirthday.Text = student.Birthday.ToString("yyyy/MM/dd");
                StuAddress.Text = student.Address;
                StuPatriarchTel.Text = student.PatriarchTel;
            }
        }
        //修改数据
        private void UpdateNewStu_Click(object sender, RoutedEventArgs e)
        {
            //学生写姓名
            string Name = StuName.Text;
            //学生性别
            string Gender = StuGender.Text;
            //出生年月
            string Birthday = StuBirthday.Text;
            //家庭住址
            string Address = StuAddress.Text;
            //家长电话
            string PatriarchTel = StuPatriarchTel.Text;
            if (Name != "" && Gender != "" && Birthday != "" && Address != "" && PatriarchTel != "")
            {
                Students student = new Students();
                student.Id = ids;
                student.StudentName = Name;
                student.Gender = Gender;
                student.Birthday = DateTime.Parse(Birthday);
                student.Address = Address;
                student.PatriarchTel = PatriarchTel;
                StudentManager.UpdateStu(student);
                this.Close();//关闭当前窗口
            }
            else
            {
                MessageBoxResult dr = MessageBox.Show("数据填写不完整", "提示", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
        //取消修改
        private void Updateout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();//关闭页面
        }
    }
}
