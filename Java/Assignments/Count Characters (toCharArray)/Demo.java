import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter String:");
		String str = scan.nextLine();

		System.out.println("Enter Character:");
		char chvalue = scan.next().charAt(0);

		Display obj = new Display();

		int ret = obj.Fun(str , chvalue);
		System.out.println("Count is:" + ret);
	}
}

class Display
{
	public int Fun(String str , char ch)
	{
		int cnt = 0;

		if(str == null)
		{
			return 0;
		}

		char Arr[] = str.toCharArray();

		for(int i = 0 ; i < Arr.length ; i++)
		{
			if(Arr[i] == ch)
			{
				cnt++;
			}
		}
		return cnt;
	}
}

