import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter Number:");
		int value = scan.nextInt();

		Display obj = new Display();

		obj.Fun(value);
	}
}

class Display
{
	public void Fun(int No)
	{
		if(No > 0)
		{
			System.out.print("*\t");
			No--;
			Fun(No);
		}
	}
}

