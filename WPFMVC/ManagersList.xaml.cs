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
    /// ManagersList.xaml 的交互逻辑
    /// </summary>
    public partial class ManagersList : Window
    {
        public ManagersList()
        {
            InitializeComponent();
            List<Managers> ds = TeacherManager.GetManager().ToList();
            StudentShow.ItemsSource = ds;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null) {
                
            }
        }
    }
}
