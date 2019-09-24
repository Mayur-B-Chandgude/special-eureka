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

		System.out.println("Before:" + value1 + " " + value2);
		obj.Fun(value1 , value2);
	}
}

class Display
{
	public void Fun(int No1 , int No2)
	{
		No1 = No1 + No2;
		No2 = No1 - No2;
		No1 = No1 - No2;

		System.out.println("After:" + No1 + " " + No2);
	}
}

