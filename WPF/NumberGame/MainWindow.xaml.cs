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

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;
        private int answerNum;
        private const int Rows = 10;     //行
        private const int Columns = 10;  //列

        private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Yellow);
        private SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Red);

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            answerNum = random.Next(Rows * Columns) + 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Button> buttons = new List<Button>();

            for (int i = 0; i < Rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            
            for (int j = 0; j < Columns; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var bt = new Button();
                    bt.Width = MainDisp.Width/ Columns;
                    bt.Height = (MainDisp.Height-textDisp.Height) / Rows;
                    bt.Content = (j + 1) + (i * Columns);
                    bt.FontSize = 20;
                    bt.Click += Bt_Click; ;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt, j);
                   
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));
            MainDisp.Height += textDisp.Height;
        }

        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button clickButton = (Button)sender;
            int selectNum = (int)clickButton.Content;
            if (answerNum == selectNum)
            {
                textDisp.Text = "あたり！";
                clickButton.Background = hitButtonColor;
            }
            else
            {
                if (answerNum < selectNum)
                {
                    textDisp.Text = selectNum + "より小さいです。";
                }
                else
                {
                    textDisp.Text = selectNum + "より大きいです。";
                }
                clickButton.Background = selectedButtonColor;
            }
        }
    }
}
