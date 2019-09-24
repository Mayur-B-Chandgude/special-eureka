#include<stdio.h>

#define TRUE	0
#define FALSE	1

typedef int BOOL;

BOOL Display(int);

int main()
{
	BOOL bret;
	int value = 0;
	
	printf("Enter Number:");
	scanf("%d",&value);

	bret = Display(value);
	if(bret == TRUE)
	{
		printf("Number is Even\n");
	}
	else
	{
		printf("Number is Odd\n");
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

