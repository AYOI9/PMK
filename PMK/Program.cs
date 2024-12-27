
class Program
{
    static void Main()
    {
        // Ввод данных
        Console.WriteLine("Введите название учебного заведения:");
        string institutionName = Console.ReadLine();

        Console.WriteLine("Введите количество студентов, зачисленных на 1-й курс:");
        int enrolledStudents = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество выпускников:");
        int graduates = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите процент выпускников, которые работают по специальности:");
        double percentageEmployed = double.Parse(Console.ReadLine());

        // Расчеты
        double q = (double)graduates / enrolledStudents;
        double qp = percentageEmployed * q;

        // Вывод результатов
        Console.WriteLine($"Учебное заведение: {institutionName}");
        Console.WriteLine($"Количество зачисленных студентов: {enrolledStudents}");
        Console.WriteLine($"Количество выпускников: {graduates}");
        Console.WriteLine($"Q (количество выпускников / количество зачисленных): {q:F2}");
        Console.WriteLine($"Qp (процент выпускников, работающих по специальности * Q): {qp:F2}");
    }
}
