#include "Header.h"

int main()
{
	PNODE head = NULL;
	PNODE tail = NULL;

	BOOL Bret = TRUE;

	int ret = 0;

	char choice = '\0';

	while(1)
	{
		printf("\n********************\n");

		printf("A Insert First:\n");
		printf("B Insert Last:\n");
		printf("C Insert At Position:\n");

		printf("D Delete First:\n");
		printf("E Delete Last:\n");
		printf("F Delete At Position:\n");

		printf("G Display Contains of Doubly Circular Linked List(Forward):\n");

		printf("H Total Count of Nodes in Doubly Circular Linked List:\n");

		printf("I Search First Occurance:\n");

		printf("J Display Contains of Doubly Circular Linked List(Backward):\n");

		printf("K Exit:");

		printf("\n********************\n");

		printf("Enter Your Choice:");
		scanf(" %c",&choice);

		printf("********************\n");

		switch(choice)
		{
			case 'A':
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

			case 'B':
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

			case 'C':
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

			case 'D':
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

			case 'E':
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

			case 'F':
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

			case 'G':
				printf("Elements of Linked List in Forward Direction..\n");
				DisplayForward(head , tail);
			break;

			case 'H':
				ret = Count(head , tail);
				printf("Total Element Count is:%d\n",ret);
			break;

			case 'I':
				ret = SearchFirstOccurance(head , tail);
				if(ret == -1)
				{
					printf("Number Not Found..\n");
				}
				else
				{
					printf("First Occurance of Node at:%d\n",ret);
				}
			break;

			case 'J':
				printf("Elements of Linked List in Backward Direction..\n");
				DisplayReverse(head , tail);
			break;

			case 'K':
				printf("\n Exit From Application..\n");
			break;
	
			default:
				printf("Wrong Choice : Please try again..\n");
			break;
		}
	}

	return 0;
}
