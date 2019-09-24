#include<stdio.h>

void Display(char*);

int main()
{
	char Arr[30] = {'\0'};
	
	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	printf("Before:%s\n",Arr);
	Display(Arr);
	printf("After:%s\n",Arr);
	
	return 0;
}

void Display(char str[])
{
	if(str == NULL)
	{
		return;
	}

	char *start = NULL;
	char *end = NULL;

	char temp; 

	start = str;
	end = str;
	
	while(*end != '\0')	
	{
		end++;
	}
	end--;

	while(start < end)
	{
		temp = *start;
		*start = *end;
		*end = temp;
		
		start++;
		end--;
	}
}

