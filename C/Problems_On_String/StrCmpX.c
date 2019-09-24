#include<stdio.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(char* , char*);

int main()
{
	char Arr[30] = {'\0'};
	char Brr[30] = {'\0'};

	BOOL ret = 0;
	
	printf("Enter First String:");
	scanf("%[^'\n']s",Arr);
	
	printf("Enter Second String:");
	scanf(" %[^'\n']s",Brr);

	ret = Display(Arr , Brr);
	if(ret == TRUE)
	{
		printf("Strings are Equal\n");
	}
	else	
	{
		printf("Strings are not Equal\n");
	}

	return 0;
}

BOOL Display(char str1[] , char str2[])
{
	if((str1 == NULL) || (str2 == NULL))
	{
		return FALSE;
	}

	while((*str1 != '\0') && (*str2 != '\0'))
	{
		if(*str1 != *str2)
		{
			break;
		}
		str1++;
		str2++;
	}

	if((*str1 == '\0') && (*str2 == '\0')) 
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

