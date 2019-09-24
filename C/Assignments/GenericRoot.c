#include<stdio.h>

int Display(int);

int main()
{
	int value = 0;
	int ret = 0;

	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	printf("Generic Root is:%d\n",ret);

	return 0;
}

int Display(int No)
{
	int digit = 0;
	int sum = 0;

	while(No >= 10)
	{
		while(No != 0)
		{
			digit = No % 10;
			sum = sum + digit;
			No = No / 10;
		}

		No = sum;
		sum = 0;
	}

	return No;
}
