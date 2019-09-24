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

	printf("Factors are:\n");
	for(i = 1 ; i <= (No / 2) ; i++)
	{
		if((No % i) == 0)
		{
			printf("%d\t",i);
		}
	}
}
