import java.lang.*;
import java.io.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter First Number:");
		int value1 = scan.nextInt();

		System.out.println("Enter Second Number:");
		int value2 = scan.nextInt();

		Display obj = new Display();

		obj.Fun(value1 , value2);
	}
}

class Display
{
	public void Fun(int No1 , int No2)
	{
		int digit = 0;
		int i = 0;
		
		int Arr[] = new int[10];

		while((No1 != 0) && (No2 != 0))
		{
			digit = No1 % 10;
			Arr[digit]++;
			No1 = No1 / 10;

			digit = No2 % 10;
			Arr[digit]--;
			No2 = No2 / 10;
		}

		for(i = 0 ; i < 10 ; i++)
		{
			if(Arr[i] != 0)
			{
				break;
			}
		}

		if(i == 10)
		{
			System.out.println("Numbers are Annagram");
		}
		else
		{
			System.out.println("Numbers are not Annagram");
		}
	}
}

