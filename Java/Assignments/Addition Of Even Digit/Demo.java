import java.lang.*;
import java.io.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Enter Number:");
		int value = scan.nextInt();

		Display obj = new Display();

		obj.Fun(value);
	}
}

class Display
{
	public void Fun(int No)
	{
		int digit = 0; 
		int sum = 0;

		while(No != 0)
		{
			digit = No % 10;
			if((digit % 2) == 0)
			{
				sum = sum + digit;
			}
			No = No / 10;
		}
		System.out.println("Addition is:" + sum);
	}
}

