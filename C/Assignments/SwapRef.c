#include<stdio.h>

void Display(char* , char*);

int main()
{
	char chvalue1 , chvalue2;
	
	printf("Enter First Character:");
	scanf(" %c",&chvalue1);
	
	printf("Enter Second Character:");
	scanf(" %c",&chvalue2);
	
	printf("Before Swap:%c %c\n",chvalue1 , chvalue2);
	Display(&chvalue1 , &chvalue2);
	printf("After After:%c %c\n",chvalue1 , chvalue2);
	
	return 0;
}

void Display(char &ch1 , char &ch2)
{
	char temp;

	temp = ch1;
	ch1 = ch2;
	ch2 = temp;
}

