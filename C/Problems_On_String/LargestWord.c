#include<stdio.h>

int Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	int ret = 0;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);
	
	ret = Display(Arr);
	printf("Largest Word length is:%d\n",ret);
	
	return 0;
}

int Display(char str[])
{
	if(str == NULL)
	{
		return 0;
	}

	int cnt , max = 0; 
	char *temp = NULL;

	while(*str != '\0')
	{
		if(*str == ' ')
		{
			while((*str == ' ') && (*str != '\0'))
			{
				str++;
			}
		}
		else
		{
			cnt = 0;
			while((*str != ' ') && (*str != '\0'))
			{
					str++;
					cnt++;
			}
			if(cnt > max)
			{
				max = cnt;
				temp = str - max;
			}
		}
	}
	
	while((*temp != ' ') && (*temp != '\0'))	
	{
		printf("%c",*temp);
		temp++;
	}
	return max;
}

