using System;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double punkte = 0;
            double possiblePoints = 0;
            double percentage = 0;

            Console.Write("Hast den ersten Test gemacht? (j für ja/ n für nein): ");
            char jaNein = Convert.ToChar(Console.ReadLine()!);
            
            if (jaNein == 'j')
            {
                Console.Write("Wie viele Punkte erreicht? (max 20) ");
                punkte += Convert.ToInt32(Console.ReadLine()!);
                possiblePoints += 20;
            }

            Console.Write("Hast du den zweiten Test gemacht? (j für ja/ n for nein): ");
            jaNein = Convert.ToChar(Console.ReadLine()!);

            if (jaNein == 'j')
            {
                Console.Write("Wie viele Punte erreicht? (max 20) ");
                punkte += Convert.ToDouble(Console.ReadLine()!);
                possiblePoints += 20;
            }

            Console.WriteLine("Wie viele Punkte hast du bei der Hausübung erreicht? (max 20)");
          double punkteHü =Convert.ToDouble(Console.ReadLine()!);
            possiblePoints += 20;
            
            Console.WriteLine();

            Console.WriteLine("Hast du eine mündliche Überprüfung gemacht? (j für ja / n für nein) ");
            jaNein= Convert.ToChar(Console.ReadLine()!);

            if (jaNein == 'j')
            {
                Console.WriteLine("Wie viele Punkte hast du erreicht)");
               punkte+= Convert.ToInt32(Console.ReadLine()!);
                possiblePoints += 20;
            }

            percentage = (punkte+punkteHü)/possiblePoints * 100.0;

            double percentage2 = (punkte + 20) / possiblePoints * 100.0;
            
            int grade = 0;

            if (percentage < 50)
            {
                grade = 5;
            }
            else if (percentage >= 50 && percentage < 63)
            {
                grade = 4;
            }
            else if (percentage >= 63 && percentage < 76)
            {
                grade = 3;
            }
            else if (percentage >= 76 && percentage < 89)
            {
                grade = 2;
            }
            else if(percentage >= 89)
            {
                grade = 1;
            }


            if (percentage2 < 50)
            {
                grade = 5;
            }
            else if (percentage2 >= 50 && percentage2 < 63)
            {
                grade = 4;
            }
            else if (percentage2 >= 63 && percentage2 < 76)
            {
                grade = 3;
            }
            else if (percentage2 >= 76 && percentage2 < 89)
            {
                grade = 2;
            }
            else if (percentage2 >= 89)
            {
                grade = 1;
            }

            Console.WriteLine($"Da du {percentage}% erreicht hast, bekommst eine {grade} im Zeugnis");


            if(percentage2 > percentage)
            {
                Console.WriteLine($"Hättest du alle Punkte bei der Hausübung dann hättest du {percentage2} und hättest somit eine bessere Note ");
            }
        }
    }
}
