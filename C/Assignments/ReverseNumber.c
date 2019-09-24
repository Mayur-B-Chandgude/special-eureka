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
	int digit = 0;
	int rev = 0;

	while(No != 0)
	{
		digit = No % 10;
		rev = rev * 10 + digit;
		No = No / 10;
	}
	printf("Reverse Number is:%d\n",rev);
}
