namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Barsik = new Cat("Барсик");
            Tiger Grizsha = new Tiger("Гриша");

            Barsik.Meow();
            Barsik.Meowing(3);

            Console.WriteLine("Мяуканий Барсика: " + Barsik.MeowCount());

            IMeowkee[] meowkees = {Barsik, Grizsha };
            EveryoneMustMeowMeow(meowkees);

            Console.WriteLine($"Барсик мяукнул {Barsik.MeowCount()} раз.");


            //////////////////////////////////////////////////////////////////////////////////////


            Fraction D1 = new Fraction(1, 2);
            Fraction D2 = new Fraction(3, 4);
            Fraction D3 = new Fraction(7, -8);
            Fraction D4 = new Fraction(7, 8);
            Fraction D5 = new Fraction(7, 8);

            Console.WriteLine($"\n{D1} + {D2} =  {D1 + D2}");
            Console.WriteLine($"{D1} + 2 =  {D1 + 2}");
            Console.WriteLine($"2 + {D2} =  {2 + D2}");

            Console.WriteLine($"\n{D1} - {D2} =  {D1 - D2}");
            Console.WriteLine($"{D1} - 2 =  {D1 - 2}");
            Console.WriteLine($"2 - {D2} =  {2 - D2}");
            

            Console.WriteLine($"\n{D1} * {D2} = {D1 * D2}");
            Console.WriteLine($"{D1} * 2 = {D1 * 2}");
            Console.WriteLine($"2 * {D2} = {2 * D2}");

            Console.WriteLine($"\n{D1} / {D2} =  {D1 / D2}");
            Console.WriteLine($"{D1} / 2 =  {D1 / 2}");
            Console.WriteLine($"2 / {D2} =  {2 / D2}");

            Console.WriteLine($"\n{D1} + {D2} / {D3} - 5 = {D1 + D2 / D3 - 5}");

            Console.WriteLine($"\nПроверка равенства дробей {D4} и {D5}: {D4 == D5}");
            Console.WriteLine($"Проверка равенства дробей {D3} и {D5}: {D3 == D5}");

            Fraction cloneD5 = (Fraction)D5.Clone();
            Console.WriteLine($"\nОригинальная дробь: {D5}, клонированная дробь: {cloneD5}");
            Console.WriteLine($"Проверка равенства дробей {cloneD5} и {D5}: {cloneD5 == D5}");

            FractionCache cache = new FractionCache(D5);
            Console.WriteLine($"Вещественное значение {D5}: {cache.GetCachedDecimalValue()}");

            D5.SetDenominator(2);
            cache.InvalidateCache();
            Console.WriteLine($"Новое вещ. значение: {cache.GetCachedDecimalValue()}");

            Fraction clone2_D5 = (Fraction)D5.Clone();
            Console.WriteLine($"\nОригинальная дробь: {D5}, клонированная дробь: {clone2_D5}");
            Console.WriteLine($"Проверка равенства дробей {clone2_D5} и {D5}: {clone2_D5 == D5}");

            D5.SetNumerator(2);
            cache.InvalidateCache();
            Console.WriteLine($"Новое вещ. значение: {cache.GetCachedDecimalValue()}");

            Fraction clone3_D5 = (Fraction)D5.Clone();
            Console.WriteLine($"\nОригинальная дробь: {D5}, клонированная дробь: {clone3_D5}");
            Console.WriteLine($"Проверка равенства дробей {clone3_D5} и {D5}: {clone3_D5 == D5}");

        }


        static void EveryoneMustMeowMeow(IMeowkee[] objects)
        {
            foreach (var obj in objects)
            {
                obj.Meow();
            }
        }
    }
}
