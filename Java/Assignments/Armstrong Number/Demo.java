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
		int i = 0;
		int temp = No;
		int sum = 0;
		int cnt = 0;
		int power = 1;

		while(temp != 0)		
		{
			cnt++;
			temp = temp / 10;
		}

		temp = No;
		while(temp != 0)
		{
			digit = temp % 10;
			for(i = 1 ; i <= cnt ; i++)
			{
				power = power * digit;
			}
		
			sum = sum + power;
			power = 1;
			temp = temp / 10;
		}

		if(sum == No)
		{
			System.out.println("Number is Armstrong Number");
		}	
		else
		{
			System.out.println("Number is not Armstrong Number");
		}
	}
}

