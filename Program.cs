namespace Execp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int num3 = num1 / num2; ;
            }
            catch
            {
                Console.WriteLine("lagic error");
            }
            finally
            {
                Console.WriteLine("execption handling");
            }
            //another shape for it .....
            try
            {
                int num1 = 10;
                int num2 = 0;
                int num3 = num1 / num2; ;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("lagic error");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("lagic error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("hello from execption");
            }
            finally
            {
                Console.WriteLine("execption handling");
            }





        }
    }
}
