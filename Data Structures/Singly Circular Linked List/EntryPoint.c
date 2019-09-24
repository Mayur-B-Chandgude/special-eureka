#include "Header.h"

int main()
{
	PNODE head = NULL;
	PNODE tail = NULL;

	BOOL Bret = TRUE;

	int ret = 0 , choice = 0;

	while(TRUE)
	{
		printf("\n********************\n");

		printf("1 Insert First:\n");
		printf("2 Insert Last:\n");
		printf("3 Insert At Position:\n");

		printf("4 Delete First:\n");
		printf("5 Delete Last:\n");
		printf("6 Delete At Position:\n");

		printf("7 Display Contains of Singly Circular Linked List:\n");

		printf("8 Total Count of Nodes in Singly Circular Linked List:\n");

		printf("9 Exit:");

		printf("\n********************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("********************\n");

		switch(choice)
		{
			case 1:
				printf("Inserting element at FIRST..\n");
				Bret = InsertFirst(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Inserted Successfully..\n");
				}
				else
				{
					printf("\n Insertion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 2:
				printf("Inserting element at LAST..\n");
				Bret = InsertLast(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Inserted Successfully..\n");
				}
				else
				{
					printf("\n Insertion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 3:
				printf("Inserting element at POSITION..\n");
				Bret = InsertAtPos(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Inserted Successfully..\n");
				}
				else
				{
					printf("\n Insertion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 4:
				printf("Deleting element at FIRST..\n");
				Bret = DeleteFirst(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Deleted Successfully..\n");
				}
				else
				{
					printf("\n Deletion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 5:
				printf("Deleting element at LAST..\n");
				Bret = DeleteLast(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Deleted Successfully..\n");
				}
				else
				{
					printf("\n Deletion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 6:
				printf("Deleting element at POSITION..\n");
				Bret = DeleteAtPos(&head , &tail);
				if(Bret == TRUE)
				{		
					printf("\n Element Deleted Successfully..\n");
				}
				else
				{
					printf("\n Deletion of element is FAIL : Due to some Reason..\n");
				}
			break;

			case 7:
				printf("Elements of Linked List..\n");
				Display(head , tail);
			break;

			case 8:
				ret = Count(head , tail);
				printf("Total Element Count is:%d\n",ret);
			break;

			case 9:
				printf("\n Exit From The Application..\n");
			break;
	
			default:
				printf("Wrong Choice : Please try again..\n");
			break;
		}

		if(Bret == FALSE)
		{
			break;
		}
	}

	return 0;
}

