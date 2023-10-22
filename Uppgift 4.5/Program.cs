using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett heltal");
        string heltal = Console.ReadLine();
        string talet = "";
        for (int i = 0; i < heltal.Length; i++)
        {
            string tecken = heltal[i].ToString();
            int ental = Convert.ToInt32((tecken));
            ental++;
            if (ental == 9)
            {
                ental = 0;
            }

            talet += ental;

        }
        Console.WriteLine(talet);

    }
}
