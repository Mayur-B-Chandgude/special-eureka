#include<stdio.h>

int Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	int ret = 0;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	ret = Display(Arr);
	printf("String Length is:%d\n",ret);

	return 0;
}

int Display(char str[])
{
	if(str == NULL)
	{
		return 0;
	}

	int cnt = 0;
	
	while(*str != '\0')
	{
		cnt++;
		str++;
	}

	return cnt;
}
