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

		System.out.println("Enter Number:");
		int value = scan.nextInt();

		Display obj = new Display();

		int ret = obj.Fun(Arr , size , value);
		System.out.println("Location is:" + ret);
	}
}

class Display
{
	public int Fun(int Arr[] , int size , int No)
	{
		if(size <= 0)
		{
			return 0;
		}

		int i , cnt = 0;
		int pos = -1;
	
		for(i = 0 ; i < size ; i++)
		{
			if(Arr[i] == No)
			{
				pos = i + 1;
			}
		}
		return pos;
	}
}

