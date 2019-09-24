#include<stdio.h>

void Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	
	printf("Enter String:");
	scanf("%[^'\n']s",Arr);
	
	printf("Before Toggle:%s\n",Arr);
	Display(Arr);
	printf("After Toggle:%s\n",Arr);
	
	return 0;
}

void Display(char str[])
{
	if(str == NULL)
	{
		return;
	}

	while(*str != '\0')
	{
		if((*str >= 'A') && (*str <= 'Z'))
		{
			*str = *str + 32;
		}
		else if((*str >= 'a') && (*str <= 'z'))
		{
			*str = *str - 32;
		}
		str++;
	}
}

