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

		int Arr[] =new int[size];

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
		if(size <= 0)
		{
			return;
		}

		int max = Arr[0];
		int secondmax = Arr[0];

		for(int i = 0 ; i < size ; i++)
		{
			if(Arr[i] > max)
			{
				max = Arr[i];
			}
		}

		for(int i = 0 ; i < size ; i++)
		{
			if((secondmax < Arr[i]) && (max > Arr[i]))
			{
				secondmax = Arr[i];
			}
		}

		//System.out.println("max number is:" + max);
		System.out.println("second maximum is:" + secondmax);
	}
}

