using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsClassesLibrary;

namespace StudentRaitingInHostel
{
    class Program
    {
        static void Main(string[] args)
        {
            int minMoneyFamilyMember = 60000;
            Console.WriteLine("Mинимальный доход на чела семьи: " +minMoneyFamilyMember+"$");
            Console.WriteLine();
        List<Student> list = new List<Student>();

            list.Add(new Student()
            {
                FullName = "Temirbulat Anuar",
                Group = "SDP-172",
                AvgMark = 12,
                IncomeFamilyMember = 700000,
                Sex = eSex.Man,
                FormStep = eFormStep.internally
            });
            list.Add(new Student()
            {
                FullName = "Aleksandr Sergeevich Zapov",
                Group = "SEP-173",
                AvgMark = 11,
                IncomeFamilyMember = 80000,
                Sex = eSex.Man,
                FormStep = eFormStep.internally
            });
            list.Add(new Student()
            {
                FullName = "Arturovich Artur Artemov",
                Group = "PEN-140",
                AvgMark = 10,
                IncomeFamilyMember = 90000,
                Sex = eSex.Man,
                FormStep = eFormStep.internally
            });
            list.Add(new Student()
            {
                FullName = "Pasha Pashkeevich Pashov",
                Group = "ASD-145",
                AvgMark = 8,
                IncomeFamilyMember = 100000,
                Sex = eSex.Man,
                FormStep = eFormStep.absentia
            });
            list.Add(new Student()
            {
                FullName = "Maria Marievna Marieva",
                Group = "WER-128",
                AvgMark = 9,
                IncomeFamilyMember = 50000,
                Sex = eSex.Girl,
                FormStep = eFormStep.internally
            });
            list.Add(new Student()
            {
                FullName = "Alina Alievna Alieva",
                Group = "SSD-109",
                AvgMark = 7,
                IncomeFamilyMember = 10000,
                Sex = eSex.Girl,
                FormStep = eFormStep.internally
            });

            List<Student> listLittleMoney = new List<Student>();
            List<Student> listNormMoney = new List<Student>();
            foreach (Student p in list)
            {
                if (p.IncomeFamilyMember <= minMoneyFamilyMember)
                    listLittleMoney.Add(p);
                else listNormMoney.Add(p);
            }
            //Console.WriteLine("Студенты у которых мало денег: ");
            List<Student> listrSortLittleMoney=  Student.SortList(listLittleMoney);
            foreach(Student p in listrSortLittleMoney)
            {
                Console.WriteLine(p.FullName+" ,  "+p.AvgMark + " ball,   " + "  "+p.IncomeFamilyMember+"$");
            }
            Console.WriteLine();
            List<Student> listrSortNormMoney = Student.SortList(listNormMoney);
            foreach (Student p in listrSortNormMoney)
            {
                Console.WriteLine(p.FullName + " ,  " + p.AvgMark + " ball,   " + p.IncomeFamilyMember + "$");
            }
            Console.WriteLine();
        }
    }
}
