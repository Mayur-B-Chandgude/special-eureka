#include "Header.h"

int main()
{
	int choice = 0 , No = 0;

	int Arr[SIZE];

	while(1)
	{
		printf("\n*************************************************************\n");

		printf("Sorting..\n");
		printf("1 Merge Sort\n");
		printf("2 Quick Sort\n");
		printf("3 Exit\n");

		printf("\n*************************************************************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n*************************************************************\n");

		switch(choice)
		{
			case 1:
				printf("MERGE SORT:\n");

				printf("Enter Number of Elements:");
				scanf("%d",&No);

				printf("Enter Elements:\n");
				for(int i = 0; i < No; i++)
				{
					scanf("%d",&Arr[i]);
				}

				Partition(Arr , 0 , No - 1);

				printf("Sorted Array is:\n");
				for(int i = 0; i < No; i++)
				{
					printf("%d\t",Arr[i]);
				}
				printf("\n");
			break;

			case 2:
				printf("QUICK SORT:\n");

				printf("Enter Number of Elements:");
				scanf("%d",&No);

				printf("Enter Elements:\n");
				for(int i = 0; i < No; i++)
				{
					scanf("%d",&Arr[i]);
				}

				Partition(Arr , 0 , No - 1);

				printf("Sorted Array is:\n");
				for(int i = 0; i < No; i++)
				{
					printf("%d\t",Arr[i]);
				}
				printf("\n");
			break;

			case 3:
				printf("Exit From Application..\n");
			break;

			default:
				printf("Wrong Choice:\n");
			break;
		}
	}

	return 0;
}

