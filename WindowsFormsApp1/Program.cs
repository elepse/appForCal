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
    public class Person{
        [PrimaryKey, AutoIncrement, Unique]
        public int Id { get; set; }

        [MaxLength(255), NotNull]
        public string Name{ get; set; }

        [NotNull]
        public int sex { get; set; }

        [NotNull]
        public int age{ get; set; }

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

        public int neck{ get; set; }

        public int hips { get; set; }

        public override string ToString()
        {
            return string.Format(
                "{0}: {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}",
                Id,
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
}
