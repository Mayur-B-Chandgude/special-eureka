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

void Display(int No1)
{
	register int i = 0;
	register int cnt = 0;

	for(i = 1 ; i < No1 ; i++)
	{
		for(cnt = 1 ; cnt < i ; cnt++)
		{
			if((cnt % 2) == 0)
			{
				printf("%d\t",cnt);
			}
		}
	}
}

