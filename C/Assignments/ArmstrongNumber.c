#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Fun(int);

int main()
{
	int value1 = 0;
	BOOL ret;

	printf("Enter Number:");
	scanf("%d",&value1);

	ret = Fun(value1);
	if(ret == TRUE)
	{
		printf("Number is Armstrong\n");
	}
	else
	{
		printf("Number is not Armstrong\n");
	}
			
	return 0;
}

BOOL Fun(int No)
{
	int digit , total , cnt , i = 0;
	int power = 1;

	int temp = No;

	while(temp != 0)
	{
		cnt++;
		temp = temp / 10;
	}

	temp = No;

	while(temp != 0)
	{
		digit = temp % 10;
		for(i = 1 ; i <= cnt ; i++)
		{
			power = power * digit;
		}
		total = total + power;
		power = 1;	
		temp = temp / 10;
	}

	if(total == No)	
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

