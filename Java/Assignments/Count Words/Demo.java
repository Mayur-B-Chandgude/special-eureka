import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter String:");
		String str = scan.nextLine();

		Display obj = new Display();

		obj.Fun(str);
	}
}

class Display
{
	public void Fun(String str)
	{
		int cnt = 0;

		if(str == null)
		{
			return;
		}

		String Arr[] = str.split("\\s");
	
		for(String ptr : Arr)
		{
			System.out.println(ptr);
		}
		System.out.println("Number of Words are:" + Arr.length);
	}
}

