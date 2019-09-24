import java.lang.*;
import java.util.*;

public class Demo
{
	public static void main(String args[])
	{
		Emp eobj1 = new Emp();
		Emp eobj2 = new Emp();

		eobj1.AcceptEmp();
		eobj1.AcceptEmpTime();

		eobj2.AcceptEmp();
		eobj2.AcceptEmpTime();

		Time ret = Time.AddTime(eobj1.tobj , eobj2.tobj);

		System.out.println(ret.hr);
		System.out.println(ret.min);
		System.out.println(ret.sec);

		int estimate = Company.CalculateEstimate(ret);
		System.out.println("Your Estimate Amount is:" + estimate);
	}
}

class Time
{
	public int hr , min , sec;

	public Time(int No1 , int No2 , int No3)
	{
		hr = No1;
		min = No2;
		sec = No3;
	}

	public static Time AddTime(Time op1 , Time op2)
	{
		Time result = new Time(0 , 0 , 0);

		result.hr = op1.hr + op2.hr;
		result.min = op1.min + op2.min;
		result.sec = op1.sec + op2.sec;

		result.min = result.min + (result.sec / 60);
		result.sec = result.sec % 60;

		result.hr = result.hr + (result.min / 60);
		result.min = result.min % 60;

		return result;
	}
}

class Emp
{
	public String name;
	public int id;
	Time tobj;

	{
		tobj = new Time(0 , 0 , 0);
	}

	public void AcceptEmp()
	{
		Scanner sobj = new Scanner(System.in);

		System.out.println("Enter Name:");
		name = sobj.nextLine();

		System.out.println("Enter id:");
		id = sobj.nextInt();
	}

	public void AcceptEmpTime()
	{
		Scanner sobj = new Scanner(System.in);

		System.out.println("Enter Hour:");
		tobj.hr = sobj.nextInt();

		System.out.println("Enter minute:");
		tobj.min = sobj.nextInt();

		System.out.println("Enter Second:");
		tobj.sec = sobj.nextInt();
	}
}

class Company
{
	public static int CalculateEstimate(Time obj)
	{
		int Amount = (obj.hr * 350) + (obj.min * 5);
		
		return Amount;
	}
}

