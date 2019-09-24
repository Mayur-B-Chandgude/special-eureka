#include<stdio.h>

void Display(char);

int main()
{
	char chvalue;
	
	printf("Enter Character:");
	scanf(" %c",&chvalue);

	Display(chvalue);

	return 0;
}

void Display(char ch)
{
	switch(ch)
	{
		case 'A':
		case 'a':
			printf("9-a.m.\n");
			break;

		case 'B':
		case 'b':
			printf("10-a.m.\n");
			break;

		case 'C':
		case 'c':
			printf("11-a.m.\n");
			break;

		case 'D':
		case 'd':
			printf("12-p.m.\n");
			break;

		default:
			printf("Wrong Division\n");
	}
}

