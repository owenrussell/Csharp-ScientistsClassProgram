using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKpart1students
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // creating an array for the students

            Student[] students = new Student[20];

            // creating and adding students

            students[0] = new Student("Albert Einstein", 1, 76);

            students[1] = new Student("Isaac Newton", 2, 84);

            students[2] = new Student("Marie Curie", 3, 66);

            students[3] = new Student("Nikola Tesla", 4, 86);

            students[4] = new Student("Leonardo da vinci", 5, 67);

            students[5] = new Student("John Dalton", 6, 77);

            students[6] = new Student("Aristotle", 7, 62);

            students[7] = new Student("Dmitri Mendeleev", 8, 72);

            students[8] = new Student("Richard Feynman", 9, 69);

            students[9] = new Student("Ada Lovelace", 10, 36);

            students[10] = new Student("Archimedes", 11, 75);

            students[11] = new Student("Micheal Faraday", 12, 75);

            students[12] = new Student("Charles Darwin", 13, 73);

            students[13] = new Student("Galileo Galilei", 14, 77);

            students[14] = new Student("Alan Turing", 15, 41);

            students[15] = new Student("Johannes Vermeer", 16, 43);

            students[16] = new Student("Claude Monet", 17, 86);

            students[17] = new Student("Michelangelo", 18, 88);

            students[18] = new Student("Rembrandt", 19, 63);

            students[19] = new Student("Caravaggio", 20, 38);

            // display the info of the students using info function in a loop

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(students[i].GetInfo());
            }

            Console.ReadKey();
        }
    }
}
