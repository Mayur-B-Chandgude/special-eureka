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
	if(No > 0)
	{
		printf("%d\t",No);
		No--;
		Display(No);
	}
}
