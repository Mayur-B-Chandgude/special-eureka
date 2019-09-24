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

		int add = 0;
		int i = 0;
	
		for(i = 0 ; i < size ; i++)
		{
			add = 0;

			for(int cnt = 1 ; cnt < Arr[i] ; cnt++)
			{
				if((Arr[i] % cnt) == 0)
				{
					add = add + cnt;
				}
			}
			if(add == Arr[i])
			{
				System.out.print(" " + Arr[i]);
			}
		}
	}
}

