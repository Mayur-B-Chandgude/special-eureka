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
		int temp = No;
		int cnt = 0;

		while(No != 0)
		{
			digit = No % 10;
			cnt = cnt * 10 + digit;
			No = No / 10;
		}

		if(temp == cnt)
		{
			System.out.println("Number is Palindrome");
		}
		else
		{
			System.out.println("Number is not Palindrome");
		}
	}
}

