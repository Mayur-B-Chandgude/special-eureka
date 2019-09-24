#include<stdio.h>

void Display(int , char);

int main()
{
	int value = 0;
	char ch;

	printf("Enter Number:");
	scanf("%d",&value);

	printf("Enter Symbol:");
	scanf(" %c",&ch);

	Display(value , ch);
	
	return 0;
}

void Display(int No , char ch)
{
	if(No <= 0)
	{
		return;
	}

	int i = 0;

	for(i = 1 ; i <= No ; i++)
	{
		printf(" %c\t",ch);
	}
}
