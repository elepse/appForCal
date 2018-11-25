using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fMain());
        }
    }
    public class Person {
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }

        [MaxLength(255), NotNull]
        public string Name { get; set; }

        [NotNull]
        public int sex { get; set; }

        [NotNull]
        public int age { get; set; }

        [NotNull]
        public int height { get; set; }

        [NotNull]
        public int mass { get; set; }

        [NotNull]
        public int activeIndex { get; set; }

        [NotNull]
        public int target { get; set; }

        [NotNull]
        public int wantDoTarget { get; set; }

        public int waist { get; set; }

        public int neck { get; set; }

        public int hips { get; set; }

        public override string ToString()
        {
            return string.Format(
                "id:{0} name:{1} sex:{2} age:{3} height:{4} mass:{5} activeIndex:{6} target:{7} wantDoTarget:{8} waist:{9} neck:{10} hips:{11}",
                Id,
                Name,
                sex,
                age,
                height,
                mass,
                activeIndex,
                target,
                wantDoTarget,
                waist,
                neck,
                hips
            );
        }
    }

    public class Product
    {
        //Колонки
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }

        [MaxLength(255), NotNull]
        public string Name { get; set; }

        [NotNull]
        public int proteins { get; set; }

        [NotNull]
        public int fats { get; set; }

        [NotNull]
        public int carbohydrates { get; set; }

        [NotNull]
        public int calories { get; set; }

        public override string ToString()
        {
            return string.Format(
                "id:{0} name:{1} proteins:{2} fats:{3} carbohydrates:{4} calories:{5}",
                Id,
                Name,
                proteins,
                fats,
                carbohydrates,
                calories
            );
        }
    }
}
