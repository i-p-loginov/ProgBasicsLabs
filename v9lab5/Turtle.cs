using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace v9lab5
{
    public class Turtle
    {
        private readonly List<TurtleActionInfo> _executedActions = new List<TurtleActionInfo>();

        public Turtle()
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Текущее положение черепашки на плоскости.
        /// </summary>
        public Location Position
        {
            get;
            private set;
        }

        /// <summary>
        /// Текущее состояние пера.
        /// </summary>
        public PenState PenState
        {
            get;
            private set;
        }

        /// <summary>
        /// Текущий цвет пера.
        /// </summary>
        public PenColors PenColor
        {
            get;
            private set;
        }

        /// <summary>
        /// Коллекция выполненных черепашкой команд, в порядке их поступления.
        /// </summary>
        public IEnumerable<TurtleActionInfo> ExecutedCommands
        {
            get
            {
                return new ReadOnlyCollection<TurtleActionInfo>(this._executedActions.ToArray());
            }
        }

        /// <summary>
        /// Перемещает черепашку в точку newLocation.
        /// </summary>
        /// <param name="newLocation"></param>
        public void Move(Location newLocation)
        {
            throw new NotImplementedException("");

            //check for intersection with line to detect new figure, and rise event
            //if (this.IntersectedLine != null)
            //this.IntersectedWithLine();
        }

        /// <summary>
        /// Поднимает перо.
        /// </summary>
        public void PutPenUp()
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Опускает перо.
        /// </summary>
        public void PutPenDown()
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Меняет цвет пера.
        /// </summary>
        /// <param name="newColor"></param>
        public void ChangeColor(PenColors newColor)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Поворачивает черепашку на определённое количество градусов.
        /// </summary>
        /// <param name="degrees"></param>
        public void RotateOn(int degrees)
        {
            throw new NotImplementedException("");
        }

        public void ExecuteActionSet(IEnumerable<TurtleActionInfo> actions)
        {
            foreach (var action in actions)
            {
                if (action is MovementInfo)
                {
                    this.Move((action as MovementInfo).NewLocation);
                }
                else if (action is PenColorChangingInfo)
                {
                    this.ChangeColor((action as PenColorChangingInfo).NewColor);
                }
                else if (action is PenStateChangingInfo)
                {
                    var penState = action as PenStateChangingInfo;

                    if (penState.PenState == PenState.Up)
                    {
                        this.PutPenUp();
                    }
                    else
                    {
                        this.PutPenDown();
                    }
                }
                else
                {
                    throw new InvalidOperationException("Wrong command: " + action.Name);
                }
            }
        }
    }
}
