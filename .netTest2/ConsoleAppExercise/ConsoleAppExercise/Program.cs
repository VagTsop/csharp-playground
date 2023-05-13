
using ClassLibrary1;
using System;


namespace ConsoleAppExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string errorMessage;

            Patient patient = new Patient();
            MedicalBot bot = new MedicalBot();

            Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + " I'm here to help you in your medication.");
            Console.WriteLine("Enter your(patient) details:");
            Console.WriteLine("Enter Patient Name");

            patient.SetName(Console.ReadLine(), out errorMessage);
            Console.WriteLine(errorMessage);

            Console.WriteLine("Enter Patient Age:");
            patient.SetAge(int.Parse(Console.ReadLine()), out errorMessage);
            Console.WriteLine(errorMessage);

            Console.WriteLine("Enter Patient Gender:");
            patient.SetGender(Console.ReadLine(), out errorMessage);
            Console.WriteLine(errorMessage);

            Console.WriteLine("Enter Patient Medical History:");
            patient.SetMedicalHistory(Console.ReadLine());

            Console.WriteLine("Welcome, " + patient.GetName() + ", " + patient.GetAge() + ".");

            Console.WriteLine("Which of the following symptoms do you have:");
            Console.WriteLine("S1.Headache");
            Console.WriteLine("S2.Skin rashes");
            Console.WriteLine("S3.Dizziness");

            Console.WriteLine("Enter the symptom code from above list(S1, S2 or S3):");
            patient.SetSymptomCode(Console.ReadLine());

            Console.WriteLine("Your prescription based on your age, symptoms and medical history");

            string dose = bot.PrescribeMedication(patient);

            Console.WriteLine(patient.GetPrescription() + " " + dose);

            Console.WriteLine("Thank you for coming.");
            Console.ReadKey();
        }
    }
}
