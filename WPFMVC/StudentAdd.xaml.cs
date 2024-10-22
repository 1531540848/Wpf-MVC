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
    /// StudentAdd.xaml 的交互逻辑
    /// </summary>
    public partial class StudentAdd : Window
    {
        public StudentAdd()
        {
            WindowStartupLocation = WindowStartupLocation.CenterOwner;//在父窗口中居中
            InitializeComponent();
        }
        //取消新增
        private void Addout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //新增学生信息
        private void AddNewStu_Click(object sender, RoutedEventArgs e)
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
                student.StudentName = Name;
                student.Gender = Gender;
                student.Birthday = DateTime.Parse(Birthday);
                student.Address = Address;
                student.PatriarchTel = PatriarchTel;
                StudentManager.InsertStu(student);
                this.Close();//关闭当前窗口
            }
            else
            {
                MessageBoxResult dr = MessageBox.Show("数据填写不完整", "提示", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
    }
}
