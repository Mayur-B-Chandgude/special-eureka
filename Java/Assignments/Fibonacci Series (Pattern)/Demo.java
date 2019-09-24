import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter Number of Rows:");
		int value1 = scan.nextInt();

		System.out.println("Enter Number of Columns:");
		int value2 = scan.nextInt();

		Display obj = new Display(value1 , value2);

		obj.Fun();
	}
}

class Display
{
	int row = 0;
	int col = 0;

	Display(int x , int y)
	{
		row = x;
		col = y;
	}

	public void Fun()
	{
		int a = 1;
		int b = 0;
		int c = 0;

	System.out.println("Fibonacci Pattern Like:");
		for(int i = 0 ; i < row ; i++)
		{
			for(int j = 0 ; j < col ; j++)	
			{
				System.out.print("\t" + c);
				c = a + b;
				a = b;
				b = c;
			}
			System.out.println();
		}
	}
}

