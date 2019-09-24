#include<stdio.h>

template<class T>
void Display(T *ch1 , T *ch2)
{
	T temp;

	temp = *ch1;
	*ch1 = *ch2;
	*ch2 = temp;
}

int main()
{
	char chvalue1 , chvalue2;
	
	printf("Enter First Character:");
	scanf(" %c",&chvalue1);
	
	printf("Enter Second Character:");
	scanf(" %c",&chvalue2);
	
	printf("Before Swap:%c %c\n",chvalue1 , chvalue2);
	Display(chvalue1 , chvalue2);
	printf("After After:%c %c\n",chvalue1 , chvalue2);
	
	return 0;
}
