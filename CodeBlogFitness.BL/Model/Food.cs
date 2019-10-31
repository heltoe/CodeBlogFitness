using System;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; }
        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; }
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; }
        /// <summary>
        /// Калории продукта.
        /// </summary>
        public double Callories { get; }
        /// <summary>
        /// Калории за 100гр продукта.
        /// </summary>
        private double CalloriesOneGramm { get { return Callories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }
        private double FatsOneGramm { get { return Fats / 100.0; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }
        #endregion

        public Food(string name) : this(name, 0, 0, 0, 0) {}
        public Food(string name, double callories, double proteins, double fats, double carbohydrates)
        {
            // TODO: проверка
            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
