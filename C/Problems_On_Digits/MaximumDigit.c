#include<stdio.h>

int Display(int);

int main()
{
	int value = 0;
	int ret = 0;
	
	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	printf("Maximum Digit is:%d\n",ret);

	return 0;
}

int Display(int No)
{
	int digit = 0;
	int max = 0;

	while(No != 0)
	{
		digit = No % 10;
		if(digit > max)
		{
			max = digit;
		}

		if(max == 9)
		{
			break;
		}

		No = No / 10;
	}

	return max;
}

