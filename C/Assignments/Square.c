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
	No = No * No;
	
	printf("%d\n",No);
}
