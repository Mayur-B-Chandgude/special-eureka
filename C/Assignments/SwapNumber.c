#include<stdio.h>

void Fun(int* , int*);

int main()
{
	int value1 , value2 = 0;

	printf("Enter First Number:");
	scanf("%d",&value1);

	printf("Enter Second Number:");
	scanf("%d",&value2);

	printf("Before Swapping:%d %d\n", value1 , value2);
	Fun(&value1 , &value2);
	printf("After Swapping:%d %d\n", value1 , value2);
			
	return 0;
}

void Fun(int *No1 , int *No2)
{
	*No1 = *No1 + *No2;
	*No2 = *No1 - *No2;
	*No1 = *No1 - *No2;
}

