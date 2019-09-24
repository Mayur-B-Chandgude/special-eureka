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
	int i = 2;

	printf("Even Numbers are:\n");
	while(No > 0)
	{
		if((i % 2) == 0)
		{
			printf("%d\t",i);
			No--;
		}
		i++;
	}
}
