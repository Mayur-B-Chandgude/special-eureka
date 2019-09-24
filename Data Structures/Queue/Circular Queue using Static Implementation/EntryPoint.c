#include "Header.h"

void main()
{
	struct Queue q;

	int choice, ret = 0;

	initq(&q);

	while (1)
	{
		printf("\n********************\n");

		printf("Operations on Circular Queue\n\n");

		printf("1. Add to Queue\n");
		printf("2. Delete from Queue\n");
		printf("3. Display Queue\n");
		printf("4. Exit\n");

		printf("\n********************\n");

		printf("Enter Your Choice:-");
		scanf("%d",&choice);

		printf("\n********************\n");

		switch (choice)
		{
			case 1:
				if (isqfull(&q))
				{
					printf("Queue is full..\n");
				}
				else
				{
					printf("Element add to Queue:\n");
					addq(&q);
				}
			break;

			case 2:
				if (isqempty(&q))
				{
					printf("Queue is Empty..\n");
				}
				else
				{
					printf("Element deleted is:%d\n",delq(&q));
				}
			break;

			case 3:
				if (isqempty(&q))
				{
					printf("Queue is Empty..\n");
				}
				else
				{
					printf("Elements of Queue..\n");
					display(&q);
				}
			break;

			case 4:
				printf("Exit from Application..\n");
			break;

			default:
				printf("Wrong Choice : Please Enter Valid Choice..\n");
			break;
		}
	}
}

