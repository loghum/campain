using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.Classes
{
    public class Token
    {
        public string Name { get; set; }
        public string Owner { get; set; } // "DM" of "Player"
        public double X { get; set; }
        public double Y { get; set; }

        public string ImagePath { get; set; } 
        public double TokenSize { get; set; }
        public int Size { get; set; }


        public Image CreateToken()
        {
           return new Image
            {
                Width = TokenSize * Size,
                Height = TokenSize * Size,
                Source = new BitmapImage(new Uri(ImagePath, UriKind.RelativeOrAbsolute))
            };
        }

        public TextBlock CreateNameText()
        {
            return new TextBlock
            {
                Text = Name,
                Foreground = Brushes.White,
                FontSize = 12,
                HorizontalAlignment = HorizontalAlignment.Center,
                TextAlignment = TextAlignment.Center
            };
        }
        
        
    }
}