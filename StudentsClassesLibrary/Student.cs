using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsClassesLibrary
{
    public enum eFormStep
    {       
        internally=0,//ochno
        absentia  //zaoch
    }
    public enum eSex
    {
        Man,
        Girl
    }

    public struct Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public int AvgMark { get; set; }
        public int IncomeFamilyMember { get; set; }
        public eSex Sex { get; set; }
        public eFormStep FormStep { get; set; } 
        public static  List<Student>  SortList(List<Student> listSours)
        {
            List<Student> list = new List<Student>(listSours);
            if (list.Count < 2) return listSours;
            for(int i = 0; i < list.Count-1; i++)
            {
                for(int j = i; j < list.Count; j++)
                {
                    if (list[i].AvgMark < list[j].AvgMark)
                    {
                        Student buf = list[i];                        
                        list[i] = list[j];
                        list[j] = buf;
                    }
                }
            }
            return list;
        }
    }
}
