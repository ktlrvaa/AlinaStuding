using System;

namespace GiftForVodimium
{
     class Program
    {
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOZORDER = 0x0004;
        const UInt32 SWP_NOREDRAW = 0x0008;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        const UInt32 SWP_FRAMECHANGED = 0x0020;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const UInt32 SWP_HIDEWINDOW = 0x0080;
        const UInt32 SWP_NOCOPYBITS = 0x0100;
        const UInt32 SWP_NOOWNERZORDER = 0x0200;
        const UInt32 SWP_NOSENDCHANGING = 0x0400;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        static void Main(string[] args)
        {
            // Задаем цвет текста в консоли. 
            Console.ForegroundColor = ConsoleColor.Red;
            // Инициализируем массив.
            int height = 150;
            int width = 150;
            char[,] buffer = new char[height, width];
            //Задаем размеры консоли. 
            /*Console.SetWindowSize(height, width);
            Console.SetBufferSize(height, width);*/

            IntPtr ConsoleHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            const UInt32 WINDOW_FLAGS = SWP_SHOWWINDOW;

            SetWindowPos(ConsoleHandle, HWND_NOTOPMOST, 0, 0, height, width, WINDOW_FLAGS);


            // Заполняем массив с помощью цикла for.
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    // Выводим точку в центр.
                    int x = j - width / 2;
                    int y = -1 * (i - height / 2);
                    // Пишем функцию, по которой будет рисоваться график.
                    int firstPart = x * x;
                    int secondPart = (int)((y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));
                    // Размер сердца.
                    int heartSize = 80; 
                    // Заполяем сердце символом.
                    if (firstPart + secondPart <= heartSize)
                    {
                        buffer[i, j] = '0';
                    }
                    // Заполняем "пустую" часть символом.
                    else
                    {
                        buffer[i, j] = ' ';
                    }
                }
            }
            // Выводим массив.
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(buffer[i, j]);
                }
                Console.WriteLine();
            }
            // Delay.
            Console.ReadLine();

        }
    }
}
