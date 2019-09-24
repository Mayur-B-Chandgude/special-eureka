import java.lang.*;
import java.io.*;

public class RW_CharacterOriented
{
	public static void main(String arg[])
	{
		FileReader fr;
		FileWriter fw;

		try
		{
			System.out.println("Write the data into File..");
			fw = new FileWriter("Hello.txt");

			String str = "Mayur B Chandgude";
			//byte Arr[] = str.getBytes();

			fw.write(str);
			fw.close();

			System.out.println("Read the data from File..");
			fr = new FileReader("Hello.txt");
		
			int No = 0;
			while((No = fr.read()) != -1)
			{
				System.out.print((char)No);
			}

			fr.close();
		}
		
		catch(Exception e)
		{
			System.out.println(e);
		}
	}
}

