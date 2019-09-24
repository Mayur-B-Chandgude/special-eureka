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

		System.out.println("Enter Number:");
		int value = scan.nextInt();

		Display obj = new Display();

		obj.Fun(Arr , value);
	}
}

class Display
{
	public void Fun(int Arr[] , int No)
	{
		int i = 0;
		int diff = 0;
		int nearNum = 0;
		int cnt = 0;

		nearNum = Arr[0];
		
		diff = No - Arr[0];
		if(diff < 0)
		{
			diff = -diff;
		}
	
		for(i = 0 ; i < Arr.length ; i++)
		{
			cnt = No - Arr[i];
			if(cnt < 0)
			{
				cnt = -cnt;
			}
		
			if(cnt < diff)
			{
				diff = cnt;
				nearNum = Arr[i];
			}

			if(diff == 0)
			{
				break;
			}
		}

		System.out.println("Nearest Number is:" + nearNum);
		System.out.println("Difference is:" + diff);
	}
}

