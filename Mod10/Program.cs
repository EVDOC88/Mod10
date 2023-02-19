namespace Mod10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Logger = new Logger();
            var sum = new SumAB(Logger);
            sum.Sum();
            Console.ReadLine();

        }
    }

    public interface ILogger
    {
        void Event(string mes);

        void Error(string mes);

    }
    public class Logger : ILogger
    {
        public void Event(string mes)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(mes);     
        }
        public void Error(string mes)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(mes);
        }
    }


    public interface ISum
    {
        public void Sum()
        {

        }

    }

    public class SumAB : ISum
    {
        ILogger logger { get; }

        public SumAB(ILogger log)
        {
            logger = log;
        }


        public void Sum()
        {
            logger.Event("Посчитаем сумму A и Б");

            try
            {
                logger.Event("Введите число A");
                double A = double.Parse(Console.ReadLine());
                logger.Event("Введите число Б");
                double B = double.Parse(Console.ReadLine());
                logger.Event($"Сумма чисел A и Б = {A + B}");

            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }


        }

    }

}