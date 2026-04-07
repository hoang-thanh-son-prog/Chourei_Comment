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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Random(List<string> participantsList)
        {
            // Kiểm tra nếu danh sách trống thì báo lỗi hoặc trả về chuỗi rỗng
            if (participantsList == null || participantsList.Count == 0)
            {
                return "Danh sách trống!";
            }

            // Khởi tạo đối tượng Random
            Random rand = new Random();

            // Lấy một số thứ tự ngẫu nhiên từ 0 đến (số lượng người - 1)
            int viTriNgauNhien = rand.Next(participantsList.Count);

            // Trả về tên người ở vị trí đó
            return participantsList[viTriNgauNhien];
        }

        private void BtnRandom_Click(object sender, RoutedEventArgs e)
        {
            List<string> participantsList = new List<string>{"1. Sato Akira",
                                                            "2. Suzuki Ichiro",
                                                            "3. Takahashi Yuki",
                                                            "4. Tanaka Kenji",
                                                            "5. Watanabe Haruto",
                                                            "6. Ito Yuna",
                                                            "7. Yamamoto Daiki",
                                                            "8. Nakamura Ren",
                                                            "9. Kobayashi Hana",
                                                            "10. Kato Sosuke",
                                                            "11. Yoshida Mei",
                                                            "12. Yamada Taro",
                                                            "13. Sasaki Kaito",
                                                            "14. Yamaguchi Sakura",
                                                            "15. Saito Takumi",
                                                            "16. Matsumoto Akiko",
                                                            "17. Inoue Hiroshi",
                                                            "18. Kimura Riku",
                                                            "19. Hayashi Nanami",
                                                            "20. Shimizu Kazuki" };
            Result result = new Result();
            result.Show();
            string p = Random(participantsList);
            result.txtName.Text = p;
        }

    }
}
