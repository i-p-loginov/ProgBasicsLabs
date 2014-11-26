using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace v9lab6
{
    public class StorableActionInfo
    {
        private TurtleActionInfo _actionInfo = null;

        public StorableActionInfo(TurtleActionInfo actionInfo)
        {
            if (actionInfo == null)
                throw new ArgumentNullException();

            this._actionInfo = actionInfo;

            this.ActionName = actionInfo.Name;

            ReadOnlyCollection<string> args;

            //выполняем проверку на то, что за тип действия получили и создаём соответствующий экземпляр
            if (actionInfo is MovementInfo)
            {
                var movement = actionInfo as MovementInfo;
                
                args = new ReadOnlyCollection<string>(new[] { 
                    movement.NewLocation.X.ToString(), 
                    movement.NewLocation.Y.ToString(),
                    movement.NewLocation.Angle.ToString()
                });
            }
            else if (actionInfo is PenColorChangingInfo)
            {
                throw new NotImplementedException("");
            }
            else if (actionInfo is PenStateChangingInfo)
            {
                throw new NotImplementedException("");
            }

            if (actionInfo == null)
            {
                throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Название действия.
        /// </summary>
        public string ActionName
        {
            get;
            private set;
        }

        /// <summary>
        /// Аргументы действия.
        /// </summary>
        public IEnumerable<string> Arguments
        {
            get;
            private set;
        }

        public TurtleActionInfo ActionInfo
        {
            get
            {
                return this._actionInfo;
            }
        }

        public override string ToString()
        {
            //предлагаю, например, такой формат:
            //commandName(arg1,arg2,arg3);
            return this.ActionName + "(" + string.Join(", ", this.Arguments) + ");";
        }

        /// <summary>
        /// Выполняет разбор строки, содержащей информацию об одном действии.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Экземпляр, содержащий информацию о выполняемом действии.</returns>
        public static StorableActionInfo Parse(string str)
        {
            throw new NotImplementedException("");
        }

        /// <summary>
        /// Метод получает тип-наследник, который по имени создаёт экзмпляр соответствующего ActionInfo
        /// На самом деле, можно в Parse просто сравнивать строки и вручную создавать экземпляры классов-наследников TurtleActionInfo
        /// </summary>
        /// <returns></returns>
        //private static TurtleActionInfo ToActionInfo(string actionName)
        //{
        //    var actionTypes = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
        //                                                                       .Where(t => t.IsSubclassOf(typeof(TurtleActionInfo)))
        //                                                                       .ToArray();

        //    var typeToInstance = actionTypes.SingleOrDefault(t => actionName == t.Name.Substring(0, t.Name.IndexOf("Info")));

        //    if (typeToInstance == null)
        //    {
        //        throw new InvalidOperationException("Type with required name not found.");
        //    }

        //    return Activator.CreateInstance(typeToInstance) as TurtleActionInfo;
        //}

    }
}
