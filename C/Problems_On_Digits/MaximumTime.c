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
	int cnt = 0;
	register int i = 0;
	int max = 0;
	int Arr[10] = {0};

	while(No != 0)
	{
		digit = No % 10;
		Arr[digit]++;
		No = No / 10;
	}

	for(i = 0 ; i < 10 ; i++)
	{
		if(Arr[i] > max)
		{
			max = Arr[i];
			cnt = i;
		}
	}

	printf("%d Occurs %d Times\n", max , cnt);
}

