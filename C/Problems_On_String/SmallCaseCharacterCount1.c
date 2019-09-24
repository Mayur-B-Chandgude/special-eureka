/*************************************** Using For Loop and Array *********************************************/

#include<stdio.h>

int Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	int ret = 0;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	ret = Display(Arr);
	printf("count is:%d\n",ret);

	return 0;
}

int Display(char str[])
{
	if(str == NULL)
	{
		return 0;
	}

	int cnt = 0;
	int i = 0;
	
	for( ; str[i] != '\0' ; i++)
	{	
		if((str[i] >= 'a') && (str[i] <= 'z'))
		{
			cnt++;
		}
	}
	return cnt;
}

