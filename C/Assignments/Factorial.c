#include<stdio.h>

int Display(int);

int main()
{
	int value = 0;
	int ret = 0;

	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	printf("%d\n",ret);

	return 0;
}

int Display(int No)
{
	static int fact = 1;

	if(No > 0)
	{
		fact = fact * No;
		No--;
		Display(No);
	}
	return fact;
}
