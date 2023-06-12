namespace ClassLibrary1
{
    public class MedicalBot
    {

        public const string BotName = "Bob";

        public static string GetBotName()
        {
            return BotName;
        }

        public string PrescribeMedication(Patient p)
        {
            string symptom = p.GetSymptomCode();

            if (symptom.Equals("Headache"))
            {
                p.SetPrescription("ibuprofen");
            }
            else if (symptom.Equals("Skin rashes"))
            {
                p.SetPrescription("diphenhydramine");
            }
            else if (symptom.Equals("Dizziness"))
            {
                if (p.GetMedicalHistory().Equals("diabetes"))
                {
                    p.SetPrescription("metformin");
                }
                else
                {
                    p.SetPrescription("dimenhydrinat");
                }

            }

            return GetDosage(p.GetPrescription());

            string GetDosage(string medicineName)
            {
                if (medicineName.Equals("diphenhydramine") && p.GetAge() < 18)
                {
                    if (p.GetAge() >= 18)
                    {
                        return "300 mg";
                    }
                    return "50 mg";
                }

                if (medicineName.Equals("ibuprofen") && p.GetAge() < 18)
                {
                    if (p.GetAge() >= 18)
                    {
                        return "800 mg";
                    }
                    return "400 mg";
                }

                if (medicineName.Equals("metformin"))
                {
                    return "500 mg";
                }
                return null;
            }

        }

        public MedicalBot()
        {
        }
    }
    public class Patient
    {

        private string name;

        private int age;

        private string gender;

        private string medicalHistory;

        private string symptomCode;

        private string prescription;

        public Patient()
        {
        }
        public string GetName()
        {
            return name;
        }

        public bool SetName(string name, out string errorMessage)
        {
            if (!string.IsNullOrEmpty(name) && name.Length >= 2)
            {
                this.name = name;
                errorMessage = "";
                return true;
            }
            errorMessage = "name not valid";
            return false;
        }

        public int GetAge()
        {
            return age;
        }

        public bool SetAge(int age, out string errorMessage)
        {

            if (age >= 0 && age <= 100)
            {
                this.age = age;
                errorMessage = "";
                return true;
            }
            errorMessage = "age not valid";
            return false;
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }

        public void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }

        public string GetGender()
        {
            return gender;
        }

        public bool SetGender(string gender, out string errorMessage)
        {
            switch (gender)
            {
                case "Male":
                case "Female":
                case "Other":
                    errorMessage = "";
                    this.gender = gender;
                    return true;
                default:
                    errorMessage = "Gender not valid";
                    return false;
            }
        }

        public string GetSymptomCode()
        {
            if (symptomCode.Equals("S1"))
            {
                symptomCode = "Headache";
            }
            else if (symptomCode.Equals("S2"))
            {
                symptomCode = "Skin rashes";
            }
            else if (symptomCode.Equals("S3"))
            {
                symptomCode = "Dizziness";
            }
            else
            {
                symptomCode = "Unknown";
            }
            return symptomCode;
        }

        public void SetSymptomCode(string symptomCode)
        {

            if (symptomCode.Equals("S1") || symptomCode.Equals("S2") || symptomCode.Equals("S3"))
            {
                this.symptomCode = symptomCode;
            }
        }
        public string GetPrescription()
        {
            return prescription;
        }

        public void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
    }
}
