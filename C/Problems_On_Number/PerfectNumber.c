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
		printf("Number is Perfect\n");
	}
	else
	{
		printf("Number is not Perfect\n");
	}
	
	return 0;
}

BOOL Display(int No1)
{
	register int i = 0;
	int add = 0;
	
	//int temp = No1;

	for(i = 1 ; i <= No1/2 ; i++)
	{
		if((No1 % i) == 0)
		{
			add = add + i;
		}
	}

	if(No1 == add)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

