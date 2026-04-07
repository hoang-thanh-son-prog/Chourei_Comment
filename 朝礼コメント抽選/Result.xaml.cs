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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 朝礼コメント抽選
{
    /// <summary>
    /// Result.xaml の相互作用ロジック
    /// </summary>
    public partial class Result : Window
    {
        public Result()
        {
            InitializeComponent();
        }
        // Sự kiện khi bấm Nút 1
        private void BtnYasumi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Nút số 1!");
        }

        // Sự kiện khi bấm Nút 2
        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Nút số 2!");
        }
    }
}
