#include<stdio.h>

void Display(int);

int main()
{
	int value = 0;

	printf("Enter Number:");
	scanf("%d",&value);

	Display(value);

	return 0;
}

void Display(int No)
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
