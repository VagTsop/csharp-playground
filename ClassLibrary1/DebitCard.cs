using System;

public class DebitCard
{
    private string _pin;

    public string Pin
    {
        set
        {
            if (value.Length < 4 || value.Length > 6)
                Console.WriteLine(value + " is invalid"); 

            if ((value.Length == 4) || (value.Length == 6))
            {
                if (!ContainsLetter(value))
                {
                    Console.WriteLine(value + " is valid");
                    this._pin = value;
                }
                if (ContainsLetter(value))
                {
                    Console.WriteLine(value + " is invalid");
                }
            }
        }

        get
        {
            return _pin;
        }
    }


    public bool ContainsLetter(string pin)
    {
        foreach (char c in pin)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
        }
        return false;
    }
}