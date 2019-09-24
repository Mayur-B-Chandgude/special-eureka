#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int);

int main()
{
	int value = 0;
	BOOL bret;

	printf("Enter Number:");
	scanf("%d",&value);

	bret = Display(value);
	if(bret == TRUE)
	{
		printf("Number is Perfect..\n");
	}
	else
	{
		printf("Number is not Perfect..\n");
	}

	return 0;
}

BOOL Display(int No)
{
	register int i = 0;
	int sum = 0;

	for(i = 1 ; i < No ; i++)
	{
		if((No % i) == 0)
		{
			sum = sum + i;
		}
	}
	
	if(sum == No)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

