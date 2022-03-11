class program
{
    static void Main(string[] ars)
    {
        int patientAdmissionTime = 10;
        int oldWomenInQueue;
        int hoursInQueue;
        int minutesInQueue;
        int minutesPerOneHour = 60;

        Console.WriteLine("Введите количество старушек в очереди:");
        oldWomenInQueue = Convert.ToInt32(Console.ReadLine());
        hoursInQueue = (oldWomenInQueue * patientAdmissionTime) / minutesPerOneHour;
        minutesInQueue = (oldWomenInQueue * patientAdmissionTime) % minutesPerOneHour;
        Console.WriteLine("Вы должны отстоять в очереди {0} часа {1} минут", hoursInQueue, minutesInQueue);
    }
}