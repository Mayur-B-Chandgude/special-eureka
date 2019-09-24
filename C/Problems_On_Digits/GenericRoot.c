#include<stdio.h>

int Display(int);

int main()
{
	int value1 = 0;
	int ret = 0;

	printf("Enter Number:");
	scanf("%d",&value1);

	ret = Display(value1);
	printf("Generic Root is:%d\n",ret);
	
	return 0;
}

int Display(int No1)
{
	int digit = 0;
	int sum = 0;

	while(No1 >= 10)
	{
		while(No1 != 0)
		{
			digit = No1 % 10;
			sum = sum + digit;
			No1 = No1 / 10;
		}
		No1 = sum;
		sum = 0;
	}
	return No1;
}

