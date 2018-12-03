using System;
					
public class Program
{
	public static void Main()
	{
		int rows = 3, cols = 3;
            Console.WriteLine("Enter the values for 3 X 3 matrix");
            int[,] matA = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {                                     
                        Console.WriteLine("Enter the values");
                        matA[i, j] = Convert.ToInt32(Console.ReadLine());                
                }
            }
            
                
                int row1 = ((matA[1, 1] * matA[2, 2]) - (matA[2, 1] * matA[1, 2]));
                int row2 = -1 * ((matA[1, 0] * matA[2, 2]) - (matA[2, 0] * matA[1, 2]));
                int row3 = ((matA[1, 0] * matA[2, 1]) - (matA[2, 0] * matA[1, 1]));
                int row4 = -1 * ((matA[0, 1] * matA[2, 2]) - (matA[2, 1] * matA[0, 2]));
                int row5 = ((matA[0, 0] * matA[2, 2]) - (matA[2, 0] * matA[0, 2]));
                int row6 = -1 * ((matA[0, 0] * matA[2, 1]) - (matA[2, 0] * matA[0, 1]));
                int row7 = ((matA[0, 1] * matA[1, 2]) - (matA[1, 1] * matA[0, 2]));
                int row8 = -1 * ((matA[0, 0] * matA[1, 2]) - (matA[1, 0] * matA[0, 2]));
                int row9 = ((matA[0, 0] * matA[1, 1]) - (matA[1, 0] * matA[0, 1]));
               
                Console.WriteLine("The adjoint of 3 x 3 matrix is :");
                Console.WriteLine("    |{0} {1} {2}|", row1, row2, row3);
                Console.WriteLine("Adj=|{0} {1} {2}|", row4, row5, row6);
                Console.WriteLine("    |{0} {1} {2}|", row7, row8, row9);
	}
}
