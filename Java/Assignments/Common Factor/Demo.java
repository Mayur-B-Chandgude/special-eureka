import java.lang.*;
import java.io.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Enter First Number:");
		int value1 = scan.nextInt();

		System.out.println("Enter Second Number:");
		int value2 = scan.nextInt();

		Display obj = new Display();

		obj.Fun(value1 , value2);
	}
}

class Display
{
	public void Fun(int No1 , int No2)
	{
		int i = 1 ;

		System.out.println("Common Factors are:");
		while((i <= No1/2) && (i <= No2/2))
		{
			if(((No1 % i) == 0) && ((No2 % i) == 0))
			{
				System.out.println("\t" + i);
			}
			i++;
		}
	}
}

