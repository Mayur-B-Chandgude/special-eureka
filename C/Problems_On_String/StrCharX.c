#include<stdio.h>

int Display(char* , char);

int main()
{
	char Arr[30] = {'\0'};
	int ret = 0;
	char chvalue = '\0';

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	printf("Enter Character:");
	scanf(" %c",&chvalue);

	ret = Display(Arr , chvalue);
	if(ret == -1)
	{
		printf("Character not found\n");
	}
	else	
	{
		printf("Character found at location:%d\n",ret);
	}

	return 0;
}

int Display(char str[] , char ch)
{
	if(str == NULL)
	{
		return 0;
	}

	int cnt = 0;
	
	while(*str != '\0')
	{
		if(*str == ch)
		{
			break;
		}
		cnt++;
		str++;
	}
	
	if(*str == '\0')
	{
		return -1;
	}
	else
	{
		return cnt;
	}
}

