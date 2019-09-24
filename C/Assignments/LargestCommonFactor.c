#include<stdio.h>

void Fun(int , int);

int main()
{
	int value1 , value2 = 0;
	int ret = 0;

	printf("Enter First Number:");
	scanf("%d",&value1);

	printf("Enter Second Number:");
	scanf("%d",&value2);

	Fun(value1 , value2);
			
	return 0;
}

void Fun(int No1 , int No2)
{
	if((No1 <= 0) || (No2 <= 0))
	{
		return;
	}

	int i = 1;
	int ans = 0;

	while((i <= No1/2) && (i <= No2/2))
	{
		if(((No1 % i) == 0) && (No2 % i) == 0)
		{
			ans = i;
		}
		i++;
	}
	printf("%d\n",ans);	
}

