namespace DioExercise03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hour = 3600, minute = 60;
            int timeInSeconds = int.Parse(Console.ReadLine());

            //TODO: Implementar a formula para calcular as horas.
            int hours = timeInSeconds / hour;
            timeInSeconds = timeInSeconds % (hour);

            //TODO: Implementar a formula para calcular as horas.
            int minutes = timeInSeconds / minute;
            int seconds = timeInSeconds % minute;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}