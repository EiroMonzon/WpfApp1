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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        int c1x = 160;
        int c2x = 160;
        int c1y = 160;
        int c2y = 160;
        int direction = 0;
        int turn = 0;
        int move = 1;
        public MainWindow()
        {
            InitializeComponent();
            for (int x = 0; x < 100; x++)
            {
                if (direction == 1)
                {
                    for (int y = 0; y <= move; y++)
                    {
                        c2x += 40;
                    }
                    turn++;
                }
                if (direction == 2)
                {
                    for (int y = 0; y <= move; y++)
                    {
                        c2y += 40;
                    }
                    turn++;
                }
                if (direction == 3)
                {
                    for (int y = 0; y <= move; y++)
                    {
                        c2x -= 40;
                    }
                    turn++;
                }
                if (direction == 4)
                {
                    for (int y = 0; y <= move; y++)
                    {
                        c2y -= 40;
                    }
                    turn++;
                }
                direction++;
                if (direction < 4)
                {
                    direction = 1;
                }
                if(turn == 2)
                {
                    move++;
                    turn = 0;
                }

                line();

                if (Math.Sqrt(x) % 1 != 0)
                {
                    if (x % 2 != 0 || x == 2)
                    {
                        if (x % 3 != 0 || x == 3)
                        {
                            if (x % 5 != 0 || x == 5)
                            {
                                if (x % 7 != 0 || x == 7)
                                {
                                    circle();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void line()
        {
            Line aLine = new Line();
            aLine.X1 = c1x;
            aLine.Y1 = c1y;
            aLine.X2 = c2x;
            aLine.Y2 = c2y;
            aLine.Stroke = System.Windows.Media.Brushes.Black;
            grids.Children.Add(aLine);

            c1y = c2y;
            c1x = c2x;
            c2y = 0;
            c2x = 0;
        }

        private void circle()
        {
            Ellipse aCircle = new Ellipse();
            aCircle.Width = 20;
            aCircle.Height = 20;
            grids.Children.Add(aCircle);
        }
    }
}
