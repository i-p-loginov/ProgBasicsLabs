using System;

namespace v9lab6
{
    public struct Location
    {
        private readonly int _x, _y, _angle;

        public Location(int x, int y, int angle)
        {
            if (angle > 360 || angle < 0)
                throw new ArgumentOutOfRangeException("angle");
            
            _x = x;
            _y = y;
            _angle = angle;
        }

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public int Angle
        {
            get
            {
                return _angle;
            }
        }
    }
}
