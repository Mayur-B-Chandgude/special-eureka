#include<stdio.h>

void Fun(int);

int main()
{
	int value1 = 0;

	printf("Enter Number:");
	scanf("%d",&value1);

	Fun(value1);
			
	return 0;
}

void Fun(int No)
{
	int a = 1 , b = 0 , c = 0;

	while(No != 0)
	{
		c = a + b;

		printf("%d\t",c);

		a = b;
		b = c;

		No--;
	}
}

