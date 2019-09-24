#include<stdio.h>

void Display(int);

int main()
{
	int value1 = 0;
	
	printf("Enter Number:");
	scanf("%d",&value1);

	Display(value1);
	
	return 0;
}

void Display(int No)
{
	register int i = 0;

	for(i = 1 ; i <= No ; i++)
	{
		if((i % 2) == 0)
		{
			printf("%d\t",i);
		}
	}
}
