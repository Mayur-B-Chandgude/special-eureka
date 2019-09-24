import java.lang.*;
import java.io.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Enter Number of Elements:");
		int size = scan.nextInt();

		int Arr[] = new int[size];

		System.out.println("Enter Data:");
		for(int i = 0 ; i < size ; i++)
		{
			Arr[i] = scan.nextInt();
		}
	
		Display obj = new Display();

		obj.Fun(Arr , size);
	}
}

class Display
{
	public void Fun(int Arr[] , int size)
	{
		int digit = 0;
		int sum = 0;

		for(int i = 0 ; i < size ; i++)		
		{
			while(Arr[i] != 0)
			{
				digit = Arr[i] % 10;
				sum = sum + digit;
				Arr[i] = Arr[i] / 10;
			}
			System.out.println("\t" + sum);
			sum = 0;
		}
	}
}

