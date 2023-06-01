
using System;


namespace ConsoleAppExercise
{
    internal class Question
    {

        public string questionText;

        public string optionA;

        public string optionB;

        public string optionC;

        public string optionD;

        public char correctAnswerLetter;

        private static char defaultCorrectAnswerLetter = 'X';

        public Question()
        {
            questionText = null;
            optionA = null;
            optionB = null;
            optionC = null;
            optionD = null;
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText)
        {
            this.questionText = questionText;
            this.optionA = null;
            this.optionB = null;
            this.optionC = null;
            this.optionD = null;
            correctAnswerLetter = defaultCorrectAnswerLetter;
        }

        public Question(string questionText, string optionA , string optionB, string optionC, string optionD, char correctAnswerLetter)
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            this.correctAnswerLetter = correctAnswerLetter;
        }

        public bool AreOptionsValid()
        {
            //TO DO: Return true, if at least two options are not null

            if (
                optionA != null && optionB != null ||
                optionA != null && optionC != null ||
                optionA != null && optionD != null ||
                optionA != null && optionC != null && optionD != null ||
                optionA != null && optionB != null && optionD != null ||
                optionA != null && optionB != null && optionC != null ||
                optionA != null && optionB != null && optionC != null && optionD != null ||
                optionC != null && optionD != null)
                
            {
                return true;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            /*
           You have the following values to convert:

            byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
            int b = 10; //Convert this value into "short" type (assign into another short type of variable)
            string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
            decimal d; //Convert this value into "string" type (assign into another string type of variable)
            And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.

            You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

            Implicit Casting

            Explicit Casting

            Parse or TryParse (as suggested above)

            Conversion Methods
           */

            // Values to Convert

            byte a = 10;
            int b = 10;
            string c = "10.34";
            decimal d = 11.56M;

            short xa = a;
            short xb = (short)b;
            double xc = double.Parse(c);
            decimal.TryParse(c, out decimal m);
            string xe = Convert.ToString(d);

            Console.WriteLine(xa);
            Console.WriteLine(xb);
            Console.WriteLine(xc);
            Console.WriteLine(m);
            Console.WriteLine(xe);
            Console.ReadKey();


            Question question = new Question();
            Question question2 = new Question("which is the Capital of New York ?");
            Question question3 = new Question("which is the Capital of Greece ?", "Athens", "Thessaloniki", "Patra", "Kastoria", 'A');
            Question question4 = new Question() { questionText = ""};
 
        }
    }
}
