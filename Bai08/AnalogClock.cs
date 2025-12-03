namespace Bai08
{
    public partial class AnalogClock : Form
    {
        PointF _centerPoint;
        Image secondHandle;
        Image minuteHandle;
        Image hourHandle;

        DateTime _currentTime;
        public AnalogClock()
        {
            InitializeComponent();

            secondHandle = Image.FromFile("ClockHandle/secondHandle.png");
            minuteHandle = Image.FromFile("ClockHandle/minuteHandle.png");
            hourHandle = Image.FromFile("ClockHandle/hourHandle.png");


            Paint += AnalogClock_Paint;
            Resize += (_, _) => Invalidate();

            secondTimer.Tick += SecondTimer_Tick;
            _currentTime = DateTime.Now;

            secondTimer.Start();
        }


        private void SecondTimer_Tick(object? sender, EventArgs e)
        {
            _currentTime = DateTime.Now;
            Invalidate();
        }

        private void AnalogClock_Paint(object? sender, PaintEventArgs e)
        {
            // draw the dots
            var g = e.Graphics;

            var radius = 250f;
            var dotRadius = 10f;
            _centerPoint = new PointF(ClientSize.Width / 2f, ClientSize.Height / 2f);

            // center point

            for (int i = 0; i < 12; i++)
            {
                var angle = i * 360 / 12 * Math.PI / 180; // convert to radians
                var x = _centerPoint.X + radius * Math.Cos(angle);
                var y = _centerPoint.Y + radius * Math.Sin(angle);

                g.FillEllipse(Brushes.White, (float)x - dotRadius, (float)y - dotRadius, dotRadius * 2, dotRadius * 2);
            }

            // small dots (4 per big)
            var smallDotRadius = 4f;
            for (int i = 0; i < 60; i++)
            {
                var angle = i * 360 / 60 * Math.PI / 180; // convert to radians
                var x = _centerPoint.X + radius * Math.Cos(angle);
                var y = _centerPoint.Y + radius * Math.Sin(angle);

                g.FillEllipse(Brushes.White, (float)x - smallDotRadius, (float)y - smallDotRadius, smallDotRadius * 2, smallDotRadius * 2);
            }

            var hour = _currentTime.Hour % 12;
            var minute = _currentTime.Minute;
            var second = _currentTime.Second;

            // draw seconds
            var secondAngle = second * 360f / 60f;

            var secondMatrix = g.Transform;
            secondMatrix.RotateAt(secondAngle, _centerPoint);
            g.Transform = secondMatrix;
            g.DrawImage(
                secondHandle,
                new RectangleF(
                    _centerPoint.X - secondHandle.Width / 2f,
                    _centerPoint.Y - radius + 20,
                    secondHandle.Width,
                    secondHandle.Height
                ),
                new RectangleF(0, 0, secondHandle.Width, secondHandle.Height),
                GraphicsUnit.Pixel
            );
            g.ResetTransform();


            // draw minute
            var minuteAngle = minute * 360f / 60f;
            var minuteMatrix = g.Transform;
            minuteMatrix.RotateAt(minuteAngle, _centerPoint);
            g.Transform = minuteMatrix;
            g.DrawImage(
                minuteHandle,
                new RectangleF(
                    _centerPoint.X - minuteHandle.Width / 2f,
                    _centerPoint.Y - radius + 40,
                    minuteHandle.Width,
                    minuteHandle.Height
                ),
                new RectangleF(0, 0, minuteHandle.Width, minuteHandle.Height),
                GraphicsUnit.Pixel
            );
            g.ResetTransform();

            // draw hour
            var hourAngle = (hour + minute / 60f) * 360f / 12f;
            var hourMatrix = g.Transform;
            hourMatrix.RotateAt(hourAngle, _centerPoint);
            g.Transform = hourMatrix;
            g.DrawImage(
                hourHandle,
                new RectangleF(
                    _centerPoint.X - hourHandle.Width / 2f,
                    _centerPoint.Y - radius + 20f,
                    hourHandle.Width,
                    hourHandle.Height
                ),
                new RectangleF(0, 0, hourHandle.Width, hourHandle.Height),
                GraphicsUnit.Pixel
            );
            g.ResetTransform();
        }

    }
}

