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
	register int i = 0;

	printf("Number in Reverse order:\n");
	for(i = No ; i >= 0 ; i--)
	{
		printf("%d\t",i);
	}
}
