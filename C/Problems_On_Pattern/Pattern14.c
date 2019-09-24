#include<stdio.h>

void Display(int , int);

int main()
{
	int value1 , value2 = 0;

	printf("Enter Number of Rows:");
	scanf("%d",&value1);

	printf("Enter Number of Columns:");
	scanf("%d",&value2);

	Display(value1 , value2);
	
	return 0;
}

void Display(int row , int col)
{
	if((row < 1) || (col < 1) || (row != col))
	{
		return;
	}

	int i , j = 0;
	char ch = 'A';

	for(i = 1 ; i <= row ; i++ , ch++)
	{
		for(j = 1 ; j <= col ; j++)
		{
			printf("%c\t",ch);
		}
		printf("\n");
	}
}
