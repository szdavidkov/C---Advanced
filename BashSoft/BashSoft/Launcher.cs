using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            StudentsRepository.InitializedData();
            StudentsRepository.GetStudentScoreFromCourse("Ivan", "Unity");
        }
    }
}
