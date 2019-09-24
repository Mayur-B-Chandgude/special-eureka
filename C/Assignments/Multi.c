#include<stdio.h>

int Fun(int);

int main()
{
	int value1 = 0;
	int ret = 0;

	printf("Enter Number:");
	scanf("%d",&value1);

	ret = Fun(value1);
	printf("Multiplication is:%d\n",ret);
			
	return 0;
}

int Fun(int No)
{
	int digit = 0;
	int sum = 1;

	while(No != 0)
	{
		digit = No % 10;
		if(digit != 0)
		{
			sum = sum * digit;
		}
		No = No / 10;
	}
	return sum;
}

