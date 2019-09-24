#include "Header.h"

void main()
{
	int choice = 0;

	initq();

	while (1)
	{
		printf("\n********************\n");

		printf("Operations on Dynamic Queue\n\n");
		printf("1. ADD TO QUEUE\n");
		printf("2. DELETE FROM QUEUE\n");
		printf("3. DISPLAY QUEUE\n");
		printf("4. EXIT\n");

		printf("\n********************\n");

		printf("Enter your choice:-");
		scanf("%d",&choice);

		printf("\n********************\n");

		switch (choice)
		{
			case 1:
				printf("Add Element to Queue:\n");
				addq();
			break;

			case 2:
				if (isqempty())
				{
					printf("Queue is empty..\n");
				}
				else
				{
					printf("Element deleted is:%d\n",delq());
				}
			break;

			case 3:
				if (isqempty())
				{
					printf("Queue is empty..\n");
				}
				else
				{
					printf("Elements of Queue:\n");
					displayq();
				}
			break;

			case 4:
				printf("Exit From Application..\n");
			break;

			default:
				printf("Wrong Choice : Please Enter Valid Choice..\n");
			break;
		}
	}
}
