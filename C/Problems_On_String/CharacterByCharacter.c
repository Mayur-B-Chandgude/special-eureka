#include<stdio.h>

void Display(char*);

int main()
{
	char Arr[30] = {'\0'};

	printf("Enter Name:");
	scanf("%[^'\n']s",Arr);

	Display(Arr);

	return 0;
}

void Display(char Arr[])
{
	if(Arr == NULL)
	{
		return;
	}
	
	while(*Arr != '\0')
	{
		printf("%c\n",*Arr);
		Arr++;
	}
}
