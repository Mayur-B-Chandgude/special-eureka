#include "Header.h"

int main()
{
	int ret , choice = 0;

	InitStack();

	while(1)
	{
		printf("\n********************\n");

		printf("Operations on Dynamic Stack\n\n");
		printf("1. PUSH\n");
		printf("2. POP\n");
		printf("3. DISPLAY\n");
		printf("4. EXIT\n\n");

		printf("\n********************\n");

		printf("Enter Your Choice:-");
		scanf("%d",&choice);

		printf("\n********************\n");

		switch (choice)
		{
			case 1:
				printf("Push Operation..\n");
				Push();
			break;

			case 2:
				if (isEmpty())
				{
					printf("Stack is empty..\n");
				}
				else
				{
					ret = Pop();
					printf("Element popped is:%d\n",ret);
				}
			break;

			case 3:
				if (isEmpty())
				{
					printf("Stack is empty");
				}
				else
				{
					printf("Elements of Stack:\n");
					Display();
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

	return 0;
}

