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
		int sum = 0;
		int cnt = 1;
		int temp = No;

		while(No != 0)
		{
			digit = No % 10;
			while(digit != 0)
			{
				cnt = cnt * digit;
				digit--;
			}
			sum = sum + cnt;
			cnt = 1;
			No = No / 10;
		}

		if(temp == sum)
		{
			System.out.println("Number is Strong");
		}
		else
		{
			System.out.println("Number is not Strong");
		}
	}
}

