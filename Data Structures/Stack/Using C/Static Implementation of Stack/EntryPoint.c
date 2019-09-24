#include "Header.h"

int main()
{
	PNODE head = NULL;

	int ret , choice = 0;
	
	InitStack(&head);

	while(1)
	{
		printf("\n******************** \n");

		printf("\n Operations On Static Stack:- \n");
		printf("1 PUSH\n");
		printf("2 POP\n");
		printf("3 DISPLAY\n");
		printf("4 EXIT\n");

		printf("\n******************** \n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n******************** \n");

		switch(choice)
		{
			case 1:
				if(isFull(&head))
				{
					printf("Stack is FULL..\n");
				}
				else
				{
					printf("PUSH Operation:\n");
					Push(&head);
				}
			break;

			case 2:
				if(isEmpty(&head))
				{
					printf("Stack is EMPTY..\n");
				}
				else
				{
					ret = Pop(&head);
					printf("Pop Element is:%d\n",ret);
				}
			break;

			case 3:
				if(isEmpty(&head))
				{
					printf("Stack is EMPTY..\n");
				}
				else
				{
					printf("Stack contains:\n");
					Display(&head);
				}
			break;

			case 4:
				printf("EXIT from Application..\n");
			break;

			default:
				printf("Wrong Choice : Please enter Valid Choice..\n");
			break;
		}
	}
	
	return 0;
}

