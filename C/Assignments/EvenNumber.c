#include<stdio.h>

void Fun(int);

int main()
{
	int value = 0;

	printf("Enter Number:");
	scanf("%d",&value);

	Fun(value);
		
	return 0;
}

void Fun(int No)
{
	if(No <= 0)
	{
		return;
	}

	int i = 1; 

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

