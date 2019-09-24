#include "Header.h"

void main()
{
	int choice , ret = 0;

	for(int i = 0; i < SIZE; i++)
	{
		b[i].key = -1;
		b[i].chain = -1;
	}

		while(1)
		{
			printf("\n********************\n");

			printf("Hash Table Operations:\n");
			printf("1 Insert\n");
			printf("2 Search\n");
			printf("3 Display\n");
			printf("4 Delete\n");
			printf("5 Exit\n");

			printf("\n********************\n");

			printf("Enter Your Choice:");	
			scanf("%d",&choice);

			printf("\n********************\n");

			switch(choice)
			{
				case 1:
					if(cnt == SIZE)
					{
						printf("Hash Table is Full\n");
					}
					else
					{
						printf("Inserting elements in Hash Table\n");
						Insert();
					}
				break;

				case 2:
					if(cnt == 0)
					{
						printf("Hash Table is Empty\n");	
					}				
					else
					{
						ret = Search();
						if(ret == -1)
						{
							printf("Number not Found\n");
						}
						else
						{
							printf("Number Found at:%d\n",ret);
						}
					}
				break;

				case 3:
					if(cnt == 0)
					{
						printf("Hash Table is Empty\n");	
					}
					else
					{
						printf("Data of Hash Table:\n");
						Display();
					}
				break;
	
				case 4:
					if(cnt == 0)
					{
						printf("Hash Table is Empty\n");
					}
					else
					{
						ret = Search();
						if(ret == -1)
						{
							printf("Number not Found in Hash Table\n");
						}
						else
						{
							Delete();
							printf("Number Deleted successfully from Hash Table:%d\n",ret);
						}
					}
				break;

				case 5:
					printf("Exit from Application\n");
			}
		}
}

