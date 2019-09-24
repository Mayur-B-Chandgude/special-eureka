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
	if(No <= 0)
	{
		return;
	}

	int i , j = 0;

	for(i = 1 ; i < No ; i++)
	{
		printf("%d\t",i);
	}

	
	for(j = No ; j > 0 ; j--)
	{
		printf("%d\t",j);
	}
}
