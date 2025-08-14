using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            string fullPath = Path.Combine(AppContext.BaseDirectory, ImagePath);
            
            if (!File.Exists(fullPath))
                throw new FileNotFoundException($"Image not found: {fullPath}");
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullPath, UriKind.Absolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // avoids file lock
            bitmap.EndInit();
            
           return new Image
            {
                Width = TokenSize * Size,
                Height = TokenSize * Size,
                Source = bitmap
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