using System;

namespace TryCatchPractices
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Сработало моё исключение");
        }

        public MyException(string message)
            : base(message)
        { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyException myexception = new MyException();
            ArgumentOutOfRangeException argumentOutOfRangeException = new ArgumentOutOfRangeException();
            RankException rankException = new RankException();
            DivideByZeroException divideByZeroException = new DivideByZeroException();
            OverflowException overflowException = new OverflowException();

            Exception[] except = new Exception[] { myexception, argumentOutOfRangeException, rankException, divideByZeroException, overflowException };

            for (int i = 0; i < except.Length; i++)
            {
                try
                {
                    throw except[i];
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Сработало исключение {i + 1} ArgumentOutOfRangeException");
                    Console.WriteLine(ex.Message);
                }

                catch (MyException ex)
                {
                    Console.WriteLine($"Сработало исключение {i + 1} MyException");
                    Console.WriteLine(ex.Message);
                }
                catch (RankException ex)
                {
                    Console.WriteLine($"Сработало исключение {i + 1} RankException");
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Сработало исключение {i + 1} DivideByZeroException");
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Сработало исключение {i + 1} OverflowException");
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("finally");
                }

            }
            

        }
    }
}
