#include "Header.h"

int main()
{
	int *Arr = NULL;
	int choice = 0;

	while(1)
	{
		printf("\n *********************************** SORTING *********************************** \n");

		printf("1 BUBBLE SORT\n");
		printf("2 SELECTION SORT\n");
		printf("3 INSERTION SORT\n");
		printf("4 EXIT\n");

		printf("\n *********************************** SORTING *********************************** \n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n *********************************** SORTING *********************************** \n");

		switch(choice)
		{
			case 1:
				printf("Bubble Sort:\n");
				Bubble_Sort(Arr);
			break;

			case 2:
				printf("Selection Sort:\n");
				Selection_Sort(Arr);
			break;

			case 3:
				printf("Selection Sort:\n");
				Insertion_Sort(Arr);
			break;

			case 4:
				printf("Exit From Application:\n");
			break;

			default:
				printf("Wrong Choice..Try Again..\n");
			break;
		}
	}

	return 0;
}

