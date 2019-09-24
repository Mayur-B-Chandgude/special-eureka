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
		
		System.out.println("Enter Number:");
		int value = scan.nextInt();

		Display obj = new Display();

		obj.Fun(Arr , size , value);
	}
}

class Display
{
	public void Fun(int Arr[] , int size , int No)
	{
		if(size <= 0)
		{
			return;
		}
		
		for(int i = 0 ; i < size ; i++)
		{
			if(Arr[i] == No)
			{
				Arr[i] = No;
			}
		}
	
		for(int i = 0 ; i < size ; i++)
		{
			System.out.println("\t" + Arr[i]);
		}
	}
}

