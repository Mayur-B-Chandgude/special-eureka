#include<stdio.h>

int Display(int);

int main()
{
	int value = 0;
	int ret = 0;
	
	printf("Enter Number:");
	scanf("%d",&value);

	ret = Display(value);
	printf("Addition is:%d\n",ret);
	
	return 0;
}

int Display(int No)
{
	register int i = 0;
	int add = 0;

	for(i = 1 ; i <= No/2 ; i++)
	{
		if((No % i) == 0)
		{
			add = add + i;
		}
	}
	
	return add;
}

