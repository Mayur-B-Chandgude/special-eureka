#include<stdio.h>

void Display(int);

int main()
{
	int value = 0;
	
	printf("Enter Number:");
	scanf("%d",&value);

	Display(value);
	
	return 0;
}

void Display(int No)
{
	register int i = 0;	
	char ch = 'A';

	printf("Characters are:\n");
	for(i = 1 ; i <= No ; i++ , ch++)
	{
		printf("%c\t",ch);
	}
}
