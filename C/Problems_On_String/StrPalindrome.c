#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	BOOL bret;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	bret = Display(Arr);
	if(bret == TRUE)
	{
		printf("String is Palindrome\n");
	}
	else
	{
		printf("String is not Palindrome\n");
	}
	
	return 0;
}

BOOL Display(char str[])
{
	if(str == NULL)
	{
		return FALSE;
	}

	char *temp = str;

	while(*temp != '\0')
	{
		temp++;
	}
	temp--;

	while(str < temp)
	{
		if(*str != *temp)
		{
			break;
		}
		str++;
		temp--;
	}

	if(str < temp)
	{
		return FALSE;
	}
	else
	{
		return TRUE;
	}
}

