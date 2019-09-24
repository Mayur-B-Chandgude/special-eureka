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
	
	printf("Your Name is:%s\n",Arr);
}
