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

    }


    static void Question(int num)
    {
        Console.WriteLine($"===== Question {num} =====");

    }

}
