using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex02
{
    public class Squad : IUnit
    {
        // Variável privada de classe do tipo ICollection<IUnit>, na qual podem ser
        // guardados vários tipos de coleções que permitam usar funcionalidades
        // necessárias
        private ICollection<IUnit> untCol;

        // Propriedade pública read-only do tipo IEnumerable<IUnit>que permite
        // a código externo aceder à informação de untCol do Squad, mas 
        // não alterá-la
        public IEnumerable<IUnit> UntCol => untCol;

        // Propriedade pública read-only, que permite a código externo aceder
        // ao nome do Squad, mas não alterá-lo
        public string UnitName => $"Group of {untCol.Count} units";

        // Propriedade pública read-only, que permite a código externo aceder
        // à posição do Squad, mas não alterá-la
        public Vector2 Position
        {
            // Getter que, usando duas variáveis locais, calcula a média das
            // posições (X e Y) de todas as IUnit no Squad e devolve a mesma
            get
            {
                float xCalc = 0;
                float yCalc = 0;
                foreach (IUnit u in untCol) xCalc += u.Position.X;
                foreach (IUnit u in untCol) yCalc += u.Position.Y;
                return new Vector2(xCalc / untCol.Count, yCalc / untCol.Count);
            }
        }

        // Propriedade pública read-only, que permite a código externo aceder
        // à vida do Squad, mas não alterá-la
        public float Health
        {
            get
            {
                float totalHealth = 0;
                foreach (IUnit u in untCol) totalHealth += u.Health;
                return totalHealth / untCol.Count;
            }
        }

        // Método público que permite a código externo adicionar uma IUnit a
        // untCol
        public void AddUnit(IUnit u)
        {
            if(u != null)
            {
                untCol.Add(u);
            }
        }

        // Método público que permite a código externo remover uma IUnit de
        // untCol
        public void RemoveUnit(IUnit u)
        {
            untCol.Remove(u);
        }

        // Método público, que permite a código externo alterar a posição
        // do Squad, e subsequentemente dos seus elementos
        // Para este efeito, cria uma variável local do tipo Vector2, na qual
        // guarda o vetor do movimento, calculado ao subtrair X e Y da posição
        // atual do X e Y da posição alvo, chamando após isto o método Move()
        // dos vários elementos IUnit do Squad num ciclo foreach, dando ao 
        // mesmo como parâmetro um novo Vector2 cujos valores para X e Y 
        // resultam de um cálculo de adição do X e Y do vetor de movimento ao 
        // X e Y da posição atual do IUnit em questão em dada iteração do ciclo
        public void Move(Vector2 targetPos)
        {
            Vector2 movVec = new Vector2(targetPos.X - Position.X,
                targetPos.Y - Position.Y);
            foreach (IUnit u in untCol)
                u.Move(new Vector2(u.Position.X + movVec.X, 
                    u.Position.Y + movVec.Y));
        }

        // Construtor do Squad, no qual a variável untCol, do tipo 
        // ICollection<IUnit> é inicializada, guardando uma lista List<IUnit>
        // na mesma e guardando na mesma o IEnumerable dado como parâmetro
        public Squad(IEnumerable<IUnit> units)
        {
            untCol = new List<IUnit>(units);
        }

        // Método ToString(), que devolve uma string com uma descrição curta
        // do Squad
        public override string ToString() => $"{UnitName} at ({Position.X:f1}" +
            $", {Position.Y:f1}) with {Health:f1} HP";
    }
}
