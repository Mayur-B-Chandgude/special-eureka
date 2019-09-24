#include<stdio.h>

void Display(char* , char , char);

int main()
{
	char Arr[30] = {'\0'};
	char chvalue1 , chvalue2 = '\0';

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	printf("Enter First Character:");
	scanf(" %c",&chvalue1);

	printf("Enter Second Character:");
	scanf(" %c",&chvalue2);

	printf("Before Replace:%s\n",Arr);
	Display(Arr , chvalue1 , chvalue2);
	printf("After Replace:%s\n",Arr);

	return 0;
}

void Display(char str[] , char from , char to)
{
	if(str == NULL)
	{
		return;
	}

	while(*str != 0)
	{
		if(*str == from)
		{
			*str = to;
		}
		str++;
	}
}

