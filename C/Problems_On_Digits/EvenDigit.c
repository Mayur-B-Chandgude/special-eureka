#include<stdio.h>

int Display(int);

int main()
{
	int value = 0;
	int ret = 0;
	
	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	printf("Even Digits are:%d\n",ret);

	return 0;
}

int Display(int No)
{
	int digit = 0;
	int cnt = 0;

	while(No != 0)
	{
		digit = No % 10;
		if((digit % 2) == 0)
		{
			cnt++;
		}
		No = No / 10;
	}

	return cnt;
}
