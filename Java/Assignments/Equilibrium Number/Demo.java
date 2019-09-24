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
		for(int i = 0 ; i < size ; i++)
		{
			Arr[i] = scan.nextInt();
		}

		Display obj = new Display();

		obj.Fun(Arr);
	}
}

class Display
{
	public void Fun(int Arr[])
	{
		int leftSum = 0;
		int rightSum = 0;
		int i = 0;

		for(i = 0 ; i < Arr.length ; i++)
		{
			leftSum = 0;
			rightSum = 0;

			for(int j = 0 ; j < i ; j++)
			{
				leftSum = leftSum + Arr[j];
			}

			for(int k = i+1 ; k < Arr.length ; k++)
			{
				rightSum = rightSum + Arr[k];
			}

			if(leftSum == rightSum)
			{
				break;
			}
		}

		if(i == Arr.length)
		{
			System.out.println("No Equilibrian index");
		}
		else
		{
			System.out.println("Equilibrian index is:" + i);
		}
	}
}

