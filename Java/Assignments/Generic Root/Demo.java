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
		int digit = 0;
		int sum = 0;
		
		while(No > 10)
		{
			while(No != 0)
			{
				digit = No % 10;
				sum = sum + digit;
				No = No / 10;
			}
			No = sum;
			sum = 0;
		}
		System.out.println("Generic Root is:" + No);
	}
}

