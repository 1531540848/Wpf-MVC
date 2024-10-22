using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFBLL;
using WPFMODEL;
using WPFUI;

namespace WPFMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Students> ds = StudentManager.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
        //查询数据
        private void SetStudent_Click(object sender, RoutedEventArgs e)
        {
            string key = StuKey.Text;
            List<Students> ds = StudentManager.SetKeyStudent(key).ToList();
            StudentShow.ItemsSource = ds;
        }
        //新增弹窗
        private void AddStu_Click(object sender, RoutedEventArgs e)
        {
            StudentAdd isw = new StudentAdd();
            isw.Title = "添加";
            isw.Owner = this;//设置父窗口，这样可以在父窗口中居中
            isw.ShowDialog();//模式，弹出！
            RefreshList();
        }
        //删除详情
        private void DeleteDetail_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dr = MessageBox.Show("确定要删除吗 ?，删除后不可恢复", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (dr == MessageBoxResult.OK)
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    int id = Convert.ToInt32(btn.Tag);
                    StudentManager.DeleteStu(id);
                }
            }
            List<Students> ds = StudentManager.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
        //刷新页面数据
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            List<Students> ds = StudentManager.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
            StuKey.Text = "";
        }
        //编辑信息
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int id = Convert.ToInt32(btn.Tag);
                StudentUpdate isw = new StudentUpdate(id);
                isw.Title = "编辑";
                isw.Owner = this;//设置父窗口，这样可以在父窗口中居中
                isw.ShowDialog();//模式，弹出！
                RefreshList();
            }
        }
        private void SetManager_Click(object sender, RoutedEventArgs e)
        {
                ManagersList isw = new ManagersList();
                isw.Owner = this;//设置父窗口，这样可以在父窗口中居中
                isw.ShowDialog();//模式，弹出！
                RefreshList();           
        }
        
        private void RefreshList()
        {
            List<Students> ds = StudentManager.GetStudent().ToList();
            StudentShow.ItemsSource = ds;
        }
    }
}