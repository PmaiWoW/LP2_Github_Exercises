using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex02
{
    public class Squad : IUnit
    {
        public List<IUnit> UntLst { get; private set; }

        public string UnitName
        {
            get => $"Group of {UntLst.Count} units";
            private set
            {
                UnitName = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                float xCalc = 0;
                float yCalc = 0;
                foreach (IUnit u in UntLst) xCalc += u.Position.X;
                foreach (IUnit u in UntLst) yCalc += u.Position.Y;
                return new Vector2(xCalc / UntLst.Count, yCalc / UntLst.Count);
            }
            private set
            {
                Position = value;
            }
        }

        public float Health
        {
            get
            {
                float totalHealth = 0;
                foreach (IUnit u in UntLst) totalHealth += u.Health;
                return totalHealth / UntLst.Count;
            }
            private set
            {
                Health = value;
            }
        }

        public void Move(Vector2 targetPos)
        {
            Vector2 movVec = new Vector2(targetPos.X - Position.X,
                targetPos.Y - Position.Y);
            foreach (IUnit u in UntLst)
                u.Move(new Vector2(u.Position.X + movVec.X, 
                    u.Position.Y + movVec.Y));
        }

        public Squad(List<IUnit> lst)
        {
            UntLst = new List<IUnit>();
            foreach (IUnit u in lst) UntLst.Add(u);
        }

        public Squad(params IUnit[] units)
        {
            UntLst = new List<IUnit>();
            foreach (IUnit u in units) UntLst.Add(u);
        }

        public override string ToString() => $"{UnitName} at " +
            $"({Position.X:f1}, {Position.Y:f1}) with {Health:f1} HP";
    }
}
