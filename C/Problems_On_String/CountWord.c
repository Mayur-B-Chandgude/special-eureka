#include<stdio.h>

int Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	int ret = 0;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);
	
	ret = Display(Arr);
	printf("Total words are:%d\n",ret);
	
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
		if(*str == ' ')
		{
			while((*str == ' ') && (*str != '\0'))
			{
				str++;
			}
		}
		else
		{
			cnt++;
			while((*str != ' ') && (*str != '\0'))
			{
					str++;
			}
		}
	}
	return cnt;
}

