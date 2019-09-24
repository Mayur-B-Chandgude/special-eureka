#include<stdio.h>

int Fun(int);

int main()
{
	int value1 = 0;
	int ret = 0;

	printf("Enter Number:");
	scanf("%d",&value1);

	ret = Fun(value1);
	printf("Factorial is:%d\n",ret);
			
	return 0;
}

int Fun(int No)
{
	int fact = 1;

	while(No != 0)
	{
		fact = fact * No;
		No--;
	}
	return fact;
}

