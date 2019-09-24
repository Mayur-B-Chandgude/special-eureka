#include "Header.h"

int main()
{
	PNODE root = NULL;

	int ret , choice = 0;

	BOOL bret = TRUE;

	while(1)
	{
		printf("\n********************\n");

		printf("\n Tree Operations:\n");
		printf("1 Insert\n");
		printf("2 Search\n");
		printf("3 Inorder\n");
		printf("4 Preorder\n");
		printf("5 Postorder\n");
		printf("6 Count\n");
		printf("7 CountLeaf\n");
		printf("8 CountParent\n");
		printf("9 Exit\n");

		printf("\n********************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n********************\n");

		switch(choice)
		{
			case 1:
				printf("Insert Element:\n");	
				Insert(&root);
			break;

			case 2:
				printf("Serach Element:\n");
				bret = Search(root);
				if(bret == TRUE)
				{
					printf("Number is Found..\n");
				}
				else
				{
					printf("Number is not Found..\n");
				}
			break;

			case 3:
				printf("Inorder:\n");
				Inorder(root);
			break;

			case 4:
				printf("Preorder:\n");
				Preorder(root);
			break;

			case 5:
				printf("Postorder:\n");
				Postorder(root);
			break;

			case 6:
				ret = Count(root);
				printf("Node Count is:%d\n",ret);
			break;

			case 7:
				ret = CountLeaf(root);
				printf("Leaf Count is:%d\n",ret);
			break;

			case 8:
				ret = CountParent(root);
				printf("Parent Count is:%d\n",ret);
			break;

			case 9:
				printf("Exit From Application..\n");
			break;

			default:
				printf("Wrong Choice : Please Enter Valid Choice:\n");
			break;
		}
	}

	return 0;
}

