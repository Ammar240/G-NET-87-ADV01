namespace CS_Advanced_S01_Generics;

internal class Program
{
    static void Main(string[] args)
    {
        #region question 1
        Question(1);
        // Q1: What is a generic class? Why use generics?
        // class with a specified type (the type determined when creating instance of this class)
        // use it to
        // 1.reduce code duplication
        // 2.avoid (boxing / unboxing) -> better preformace
        // 3.type safty
        #endregion

        #region question 2
        Question(2);
        Container<int> intContainer = new Container<int>();
        intContainer.Add(1);
        Console.WriteLine(intContainer.Get());
        #endregion
        #region question 3
        Question(3);
        //class can take any number of parameters T
        Pair<int, string> pair = new Pair<int, string>()
        {
            Key = 1,
            Value = "Ammar"
        };
        Console.WriteLine($"{pair.Key} - {pair.Value}");
        #endregion

        #region question 4
        Question(4);
        // generic method -> is a method with any type(place holder T) (determined when calling the method)
        double a = 10.5;
        double b = 20.3;
        Console.WriteLine($"a = {a}, b = {b}"); // compiler inferes the type from argument passed to the method
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}");

        #endregion

    }

    #region question 4
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    #endregion

    static void Question(int num)
    {
        Console.WriteLine($"===== Question {num} =====");

    }

}
