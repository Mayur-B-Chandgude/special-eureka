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
		printf("Number is Prime..\n");
	}
	else
	{
		printf("Number is not Prime..\n");
	}

	return 0;
}

BOOL Display(int No)
{
	register int i = 0;

	for(i = 2 ; i <= No ; i++)
	{
		if((No % i) == 0)
		{
			return FALSE;
		}
		else
		{
			return TRUE;
		}
	}
}

