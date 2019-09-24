import java.lang.*;
import java.io.*;
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
	public void Fun(int No)
	{
		int a = 1;
		int b = 0;
		int c = 0;

		while(No != 0)
		{
			c = a + b;
			
			System.out.println("\t" + c);
	
			a = b;
			b = c;
		
			No--;
		}
	}
}

