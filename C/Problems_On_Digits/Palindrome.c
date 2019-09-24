#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int);

int main()
{
	int value = 0;
	BOOL ret = 0;

	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	if(ret == TRUE)
	{
		printf("Number is Palindrome\n");
	}
	else
	{
		printf("Number is not Palindrome\n");
	}
	
	return 0;
}

BOOL Display(int No)
{
	int digit = 0;
	int cnt = 0;
	int temp = No;

	while(No != 0)
	{
		digit = No % 10;
		cnt = cnt * 10 + digit;
		No = No / 10;
	}

	if(temp == cnt)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

