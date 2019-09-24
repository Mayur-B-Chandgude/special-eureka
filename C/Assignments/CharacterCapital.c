#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(char);

int main()
{
	char value;
	BOOL bret;

	printf("Enter Character:");
	scanf(" %c",&value);

	bret = Display(value);
	if(bret == TRUE)
	{
		printf("Character is Capital..\n");
	}
	else
	{
		printf("Character is not Capital..\n");
	}

	return 0;
}

BOOL Display(char ch)
{
	if((ch >= 'A') && (ch <= 'Z'))
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

