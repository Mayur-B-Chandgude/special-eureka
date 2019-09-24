#include "Header.h"

int main()
{
	int pos = 0;
	int choice = 0;
	
	int *Arr = NULL;

	while(1)
	{
		printf("\n************************************************\n");

		printf("\n Searching..\n");
		printf("1 Binary Search\n");
		printf("2 Linear Unsorted Search\n");
		printf("3 Exit\n");

		printf("\n************************************************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n************************************************\n");

		switch(choice)
		{
			case 1:
				printf("BINARY SEARCH\n");
				pos = Binary_Search(Arr);
				printf("Element is found at position : %d",pos);
			break;

			case 2:
				printf("LINEAR UNSORTED SEARCH\n");
				pos = Linear_Unsorted_Search(Arr);
				printf("Element is found at position : %d",pos);
			break;

			case 3:
				printf("Exit from Application..\n");
			break;

			default:
				printf("Wrong Choice..\n");
			break;
		}
	}

	return 0;
}

