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
	
		System.out.println("Before:");
		for(int i = 0 ; i < size ; i++)
		{
			System.out.print("\t" + Arr[i]);
		}

		Display obj = new Display();

		obj.Fun(Arr , size);
	}
}

class Display
{
	public void Fun(int Arr[] , int size)
	{
		int temp = 0;

		int start = 0;
		int end = size-1;

		while(start <= end)
		{
			temp = Arr[start];
			Arr[start] = Arr[end];
			Arr[end] = temp;

			start++;
			end--;
		}

		System.out.println("After:");
		for(int i = 0 ; i < size ; i++)
		{
			System.out.print("\t" + Arr[i]);
		}
	}
}

