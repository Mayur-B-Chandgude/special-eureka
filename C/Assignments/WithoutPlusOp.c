#include<stdio.h>

void Display(int , int);

int main()
{
	int value1 , value2 = 0;

	printf("Enter First Number:");
	scanf("%d",&value1);

	printf("Enter Second Number:");
	scanf("%d",&value2);

	Display(value1 , value2);
	
	return 0;
}

void Display(int No1 , int No2)
{
	while(No1 > 0)
	{	
		No1--;
		No2++;
	}

	printf("%d\n",No2);
}
