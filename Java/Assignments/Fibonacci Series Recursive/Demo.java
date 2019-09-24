import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter Number:");
		int value1 = scan.nextInt();

		Display obj = new Display();

		obj.Fun(value1);
	}
}

class Display
{	
	public static void Fun(int No)
	{
		static int a = 1 , b = 0 , c = 0;

		if(No > 0)
		{
			System.out.print("\t" + c);
			c = a + b;
			a = b;
			b = c;
			No--;
			Fun(No);
		}
	}
}

