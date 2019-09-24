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
		No = -No;
	}

	register int i = 0;

	for(i = 1 ; i <= No/2 ; i++)
	{
		if((No % i) == 0)
		{
			if((i % 2) == 0)
			{
				printf("%d\t",i);
			}
		}
	}
}

