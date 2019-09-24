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

	int i = 0;

	for(i = 1 ; i <= No ; i++)
	{
		printf("*\t");
	}
}
