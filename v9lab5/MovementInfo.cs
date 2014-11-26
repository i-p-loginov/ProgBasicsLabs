using System;

namespace v9lab5
{
    public sealed class MovementInfo : TurtleActionInfo
    {
        public MovementInfo(Location newLocation)
        {
            //throw new NotImplementedException("");
        }

        /// <summary>
        /// Новое положение черепашки на плоскости.
        /// </summary>
        public Location NewLocation
        {
            get;
            private set;
        }

        public override string ToString()
        {
            throw new NotImplementedException("");
        }
    }
}
