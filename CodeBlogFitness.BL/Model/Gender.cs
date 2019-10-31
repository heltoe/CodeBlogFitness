using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Gender.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///  Create new gender
        /// </summary>
        /// <param name="name">Name gender.</param>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
