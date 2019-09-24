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
	printf("count is:%d\n",ret);

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
			cnt++;
		}
		str++;
	}
	return cnt;
}

