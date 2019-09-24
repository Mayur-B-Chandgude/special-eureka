#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int);

int main()
{
	int value1 = 0;
	BOOL ret;
	
	printf("Enter Number:");
	scanf("%d",&value1);

	ret = Display(value1);
	if(ret == TRUE)
	{
		printf("Number is Prime\n");
	}
	else
	{
		printf("Number is not Prime\n");
	}
	
	return 0;
}

BOOL Display(int No1)
{
	register int i = 0;

	for(i = 2 ; i < No1 ; i++)
	{
		if((No1 % i) == 0)
		{
			return FALSE;
		}
	}
	return TRUE;
}

