class program
{
    static void Main(string[] ars)
    {
        int patientAdmissionTime = 10;
        int oldWomenInQueue;
        int hours;
        int minutes;

        Console.WriteLine("Введите количество старушек в очереди:");
        oldWomenInQueue = Convert.ToInt32(Console.ReadLine());
        hours = (oldWomenInQueue * patientAdmissionTime) / 60;
        minutes = (oldWomenInQueue * patientAdmissionTime) % 60;
        Console.WriteLine("Вы должны отстоять в очереди {0} часа {1} минут", hours, minutes);
    }
}