import java.lang.*;
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
		for(int i = 0; i < size ; i++)
		{
			Arr[i] = scan.nextInt();
		}
		
		Display obj = new Display();

		System.out.println("Before:");
		for(int i = 0; i < size ; i++)
		{
			System.out.print("\t" + Arr[i]);
		}
		System.out.println();

		obj.Fun(Arr , size);
	}
}

class Display
{
	public void Fun(int Arr[] , int size)
	{
		int start = 0;
		int end = size-1;

		while(start < end)
		{
			while(((Arr[start] % 2) == 0) && (start < end))
			{
				start++;
			}
			while(((Arr[end] % 2) != 0) && (start < end))
			{
				end--;
			}
		
			if(start < end)
			{
				Arr[start] = Arr[end];
				Arr[end] = Arr[start];
	
				start++;
				end--;
			}
		}

		System.out.println("After:");
		for(int i = 0; i < size ; i++)
		{
			System.out.print("\t" + Arr[i]);
		}
	}
}

