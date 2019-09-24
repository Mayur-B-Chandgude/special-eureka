#include "Header.h"

int main()
{
	PNODE head = NULL;

	BOOL Bret = TRUE;

	int ret , choice = 0;

	while(1)
	{
		printf("\n********************\n");

		printf("1 Insert First:\n");
		printf("2 Insert Last:\n");
		printf("3 Insert At Position:\n");

		printf("4 Delete First:\n");
		printf("5 Delete Last:\n");
		printf("6 Delete At Position:\n");

		printf("7 Display Contains of Doubly Linear Linked List:\n");

		printf("8 Total Count of Nodes in Doubly Linear Linked List:\n");

		printf("9 Search First Occurance:\n");

		printf("0 Exit:");

		printf("\n********************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("********************\n");

		switch(choice)
		{
			case 1:
				printf("Inserting element at FIRST..\n");
				Bret = InsertFirst(&head);
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
				Bret = InsertLast(&head);
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
				Bret = InsertAtPos(&head);
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
				Bret = DeleteFirst(&head);
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
				Bret = DeleteLast(&head);
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
				Bret = DeleteAtPos(&head);
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
				Display(head);
			break;

			case 8:
				ret = Count(head);
				printf("Total Element Count is:%d\n",ret);
			break;

			case 9:
				ret = SearchFirstOccurance(head);
				if(ret == -1)
				{
					printf("Number Not Found..\n");
				}
				else
				{
					printf("First Occurance of Node:%d\n",ret);
				}
			break;

			case 0:
				printf("\n Exit From Application..\n");
			break;
	
			default:
				printf("Wrong Choice : Please try again..\n");
			break;
		}
	}

	return 0;
}
