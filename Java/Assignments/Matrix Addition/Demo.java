import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Scanner scan = new Scanner(System.in);

		System.out.println("Enter Number of Rows:");
		int value1 = scan.nextInt();

		System.out.println("Enter Number of Columns:");
		int value2 = scan.nextInt();

		Matrix obj1 = new Matrix(value1 , value2);
		Matrix obj2 = new Matrix(value1 , value2);

		obj1.Accept();
		obj2.Accept();

		System.out.println("First Matrix Elements are:");
		obj1.Display();
	
		System.out.println("Second Matrix Elements are:");
		obj2.Display();

		Op obj = new Op();

		Matrix result = obj.Add(obj1 , obj2);

		System.out.println("Addition of Matrix is:");
		result.Display();
	}
}

class Matrix
{
	public int row = 0;
	public int col = 0;
	public int Arr[][];

	public Matrix(int x , int y)
	{
		row = x;
		col = y;
		Arr = new int[row][col];
	}

	public void Accept()
	{
		Scanner sobj = new Scanner(System.in);

		System.out.println("Enter Elements:");
		for(int i = 0 ; i < row ; i++)
		{
			for(int j = 0 ; j < col ; j++)
			{
				Arr[i][j] = sobj.nextInt();
			}
		}
	}

	public void Display()
	{
		for(int i = 0 ; i < row ; i++)
		{
			for(int j = 0 ; j < col ; j++)
			{
				System.out.print("\t" + Arr[i][j]);
			}
			System.out.println();
		}
	}
}

class Op
{
	public Matrix Add(Matrix op1 , Matrix op2)
	{
		if((op1.row != op2.row) || (op1.col != op2.col))
		{
			return null;
		}

		Matrix temp = new Matrix(op1.row , op2.col);

		for(int i = 0 ; i < op1.row ; i++)
		{
			for(int j = 0 ; j < op1.col ; j++)
			{	
				temp.Arr[i][j] = op1.Arr[i][j] + op2.Arr[i][j];
			}
		}
		return temp;
	}
}

