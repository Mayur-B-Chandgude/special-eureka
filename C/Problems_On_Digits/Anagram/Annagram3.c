/***************************************** Using Single While and Single Array ******************************************/

#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int , int);

int main()
{
	int value1 , value2 = 0;
	BOOL ret = 0;

	printf("Enter First Number:");
	scanf("%d",&value1);

	printf("Enter Second Number:");
	scanf("%d",&value2);

	ret = Display(value1 , value2);
	if(ret == TRUE)
	{
		printf("Numbers are Annagram\n");
	}
	else
	{
		printf("Number are not Annagram\n");
	}
	
	return 0;
}

BOOL Display(int No1 , int No2)
{
	int digit = 0;
	int Arr[10] = {0};
	
	register int i = 0;

	while((No1 != 0) && (No2 != 0))
	{
		digit = No1 % 10;
		Arr[digit]++;
		No1 = No1 / 10;

		digit = No2 % 10;
		Arr[digit]--;
		No2 = No2 / 10;
	}

	for(i = 0 ; i < 10 ; i++)
	{
		if(Arr[i] != 0)
		{
			break;
		}
	}

	if(i == 10)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

