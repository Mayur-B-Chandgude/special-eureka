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
		printf("Number is Even..\n");
	}
	else
	{
		printf("Number is Odd..\n");
	}

	return 0;
}

BOOL Display(int No)
{
	if((No % 2) == 0)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}
