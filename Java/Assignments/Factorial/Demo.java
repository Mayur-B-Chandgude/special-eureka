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
		int fact = 1;
		
		while(No > 0)
		{
			fact = fact * No;
			No--;
		}

		System.out.println("\t" + fact);
	}
}

