#include "Header.h"

int main()
{
	int *One_Arr = NULL;
	
	int **Two_Arr = NULL;	

	int ***Three_Arr = NULL;

	int ****Four_Arr = NULL;

	int *****Five_Arr = NULL;
	
	int ******Six_Arr = NULL;

	int *******Seven_Arr = NULL;

	int choice = 0;

	while(1)
	{
		printf("\n************************************************\n");

		printf("\n*****ARRAY*****\n");
		printf("1 ONE DIMENSIONAL ARRAY\n");
		printf("2 TWO DIMENSIONAL ARRAY\n");
		printf("3 THREE DIMENSIONAL ARRAY\n");
		printf("4 FOUR DIMENSIONAL ARRAY\n");
		printf("5 FIVE DIMENSIONAL ARRAY\n");
		printf("6 SIX DIMENSIONAL ARRAY\n");
		printf("7 SEVEN DIMENSIONAL ARRAY\n");								
		printf("8 EXIT\n");

		printf("\n************************************************\n");

		printf("Enter Your Choice:");
		scanf("%d",&choice);

		printf("\n************************************************\n");

		switch(choice)
		{
			case 1:
				printf("ONE DIMENSIONAL ARRAY..\n");
				One_Dimensional_Array(One_Arr);
			break;

			case 2:
				printf("TWO DIMENSIONAL ARRAY..\n");
				Two_Dimensional_Array(Two_Arr);
			break;

			case 3:
				printf("THREE DIMENSIONAL ARRAY..\n");
				Three_Dimensional_Array(Three_Arr);
			break;

			case 4:
				printf("FOUR DIMENSIONAL ARRAY..\n");
				Four_Dimensional_Array(Four_Arr);
			break;
				
			case 5:
				printf("FIVE DIMENSIONAL ARRAY..\n");
				Five_Dimensional_Array(Five_Arr);
			break;

			case 6:
				printf("SIX DIMENSIONAL ARRAY..\n");
				Six_Dimensional_Array(Six_Arr);
			break;

			case 7:
				printf("SEVEN DIMENSIONAL ARRAY..\n");
				Seven_Dimensional_Array(Seven_Arr);
			break;

			case 8:
				printf("Exit From Application..\n");
			break;

			default:
				printf("Wrong Choice..\n");
			break;
		}
	}

	return 0;
}

