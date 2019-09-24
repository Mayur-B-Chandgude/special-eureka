#include<stdio.h>

void Display(char* , char*);

int main()
{
	char Arr[30] = {'\0'};
	char Brr[30] = {'\0'};
	int ret = 0;

	printf("Enter String:");
	scanf("%[^'\n']s",Arr);

	printf("Before:%s\n",Arr);
	Display(Arr , Brr);
	printf("After:%s\n",Brr);
	
	return 0;
}

void Display(char str1[] , char str2[])
{
	if((str1 == NULL) || (str2 == NULL))
	{
		return;
	}

	while(*str1 != '\0')
	{
		*str2 = *str1;

		str1++;
		str2++;
	}
	*str2 = '\0';
}
