
public class Program
{
    /// <summary>
    /// Método principal
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        
        foreach (float i in args)
        {
            float [][] A = new float [1] [1] {i};
            float [][] A = new float [1] [2] {i++};
            float [][] A = new float [2] [1] {i++};
            float [][] A = new float [2] [2] {i++};
            float [][] b = new float [1] [1] {i++};
            float [][] b = new float [2] [1] {i++};
            Console.WriteLine(A);
        }
    }
}
