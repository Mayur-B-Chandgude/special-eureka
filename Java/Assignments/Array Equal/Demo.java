import java.lang.*;
import java.io.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Enter Number of Elements:");
		int size1 = scan.nextInt();

		int Arr[] = new int[size1];

		System.out.println("Enter Data:");
		for(int i = 0 ; i < size1 ; i++)
		{
			Arr[i] = scan.nextInt();
		}
	
		System.out.println("Enter Number of Elements:");
		int size2 = scan.nextInt();

		int Brr[] = new int[size2];

		System.out.println("Enter Data:");
		for(int i = 0 ; i < size2 ; i++)
		{
			Brr[i] = scan.nextInt();
		}

		Display obj = new Display();

		obj.Fun(Arr , Brr , size1 , size2);
	}
}

class Display
{
	public void Fun(int Arr[] , int Brr[] , int size1 , int size2)
	{
		if(size1 != size2)
		{
			return;
		}
		
		int i = 0;

		for(i = 0 ; i < size1 ; i++)
		{
			if(Arr[i] != Brr[i])
			{
				break;
			}
		}

		if(i == size1)
		{
			System.out.println("Array is Equal");
		}
		else
		{
			System.out.println("Array is not Equal");
		}
		
	}
}

