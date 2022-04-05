using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogClock
{
    class MyAnalogClock : PictureBox
    {
        public Color BackgroundColor { get; set; }
        public Color HourArrowColor { get; set; }
        public Color MinuteArrowColor { get; set; }
        public Color SecondArrowColor { get; set; }
        public int HourArrowWidth { get; set; }
        public int MinuteArrowWidth { get; set; }
        public int SecondArrowWidth { get; set; }
        public Image BackgroundClockImage { get; set; }
        public bool UseImage { get; set; }//картинка или фон
        private DateTime time;
        private Timer timer;
        private Graphics graphics;

        public MyAnalogClock()
        {
            BackgroundColor = Color.Aqua;
            HourArrowColor = Color.Black;
            MinuteArrowColor = Color.Red;
            SecondArrowColor = Color.Blue;
            HourArrowWidth = 6;
            MinuteArrowWidth = 4;
            SecondArrowWidth = 2;
            Width = 250;
            Height = 250;
            UseImage = false;
            timer = new Timer();
            timer.Interval = 1000;//1 раз в секунду будет обновляться
            timer.Tick += TimerTick;
            graphics = CreateGraphics();
        }
        void DrawCircle()
        {
            SolidBrush brush = new SolidBrush(BackgroundColor);
            graphics.FillEllipse(brush, 0, 0, Width, Height);
        }
        private void DrawArrow(Color arrowColor, int width,
            int length, float angle)
        {
            angle -= 90;
            float x = Width / 2;
            float y = Height / 2;

            float x1 = (float)Math.Cos((Math.PI / 180) * angle) * length + x;
            float y1 = (float)Math.Sin((Math.PI / 180) * angle) * length + y;
            Pen pen = new Pen(arrowColor, width);
            graphics.DrawLine(pen, x, y, x1, y1);
        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }
        void TimerTick(object sender, EventArgs e)
        {
            int arrowLength = Width > Height ? Height : Width;//берем по меньшей стороне
            arrowLength /= 2;
            graphics = CreateGraphics();
            if (UseImage == true && BackgroundClockImage != null)
            {
                graphics.DrawImage(BackgroundClockImage, 0, 0, Width, Height);
            }
            else DrawCircle();
           
            time = DateTime.Now;//берем время сейчас
            DrawArrow(HourArrowColor, HourArrowWidth, (int)(arrowLength * 0.5),
                time.Hour * 30+time.Minute/2);//30=360/12
            DrawArrow(MinuteArrowColor, MinuteArrowWidth, (int)(arrowLength * 0.7), time.Minute * 6);
            DrawArrow(SecondArrowColor, SecondArrowWidth, (int)(arrowLength * 0.9), time.Second * 6);//==360/60
        }
    }
}