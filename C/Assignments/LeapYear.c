#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int);

int main()
{
	int value = 0;
	BOOL bret;

	printf("Enter Year:");
	scanf("%d",&value);

	bret = Display(value);
	if(bret == TRUE)
	{
		printf("Year is Leap..\n");
	}
	else
	{
		printf("Year not Leap..\n");
	}

	return 0;
}

BOOL Display(int year)
{
	if((year % 4) == 0)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}
