import java.lang.*;
import java.io.*;

public class RW_ByteOrientedIO
{
	public static void main(String arg[])
	{
		FileInputStream fi;
		FileOutputStream fo;

		try
		{
			System.out.println("Write the data into File..");
			fo = new FileOutputStream("Demo.txt");

			String str = "Mayur Chandgude";
			byte Arr[] = str.getBytes();

			fo.write(Arr);
			fo.close();

			System.out.println("Read the data from File..");
			fi = new FileInputStream("Demo.txt");
		
			int No = 0;
			while((No = fi.read()) != -1)
			{
				System.out.print((char)No);
			}

			fi.close();
		}
		
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
}

