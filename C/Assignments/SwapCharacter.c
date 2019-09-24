#include<stdio.h>

void Fun(char* , char*);

int main()
{
	char chvalue1 , chvalue2;

	printf("Enter First Character:");
	scanf(" %c",&chvalue1);

	printf("Enter Second Number:");
	scanf(" %c",&chvalue2);

	printf("Before Swapping:%c %c\n", chvalue1 , chvalue2);
	Fun(&chvalue1 , &chvalue2);
	printf("After Swapping:%c %c\n", chvalue1 , chvalue2);
			
	return 0;
}

void Fun(char *ch1 , char *ch2)
{
	char temp;

	temp = *ch1;
	*ch1 = *ch2;
	*ch2 = temp;
}

