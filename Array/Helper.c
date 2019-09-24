#include "Header.h"

/*************************************************************** 1D Array *********************************************************/
void One_Dimensional_Array(int *One_Arr)
{
	int size = 0;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	One_Arr = (int *)malloc(size * sizeof(int));
	if(One_Arr == NULL)
	{
		return;
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < size ; i++)
	{
		scanf("%d",&One_Arr[i]);
	}

	printf("Elements from ONE DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < size; i++)
	{
		printf("%d\t",One_Arr[i]);
	}
	printf("\n");

	//Deallocating memory
	free(One_Arr);
}
/*************************************************************** 1D Array *********************************************************/


/*************************************************************** 2D Array *********************************************************/
void Two_Dimensional_Array(int **Two_Arr)
{
	int row , col = 0;

	printf("Enter Number of rows:");
	scanf("%d",&row);

	printf("Enter Number of column:");
	scanf("%d",&col);

	Two_Arr = (int **)malloc(row * sizeof(int*));
	if(Two_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < row ; i++)
	{
		Two_Arr[i] = (int *)malloc(col * sizeof(int));
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < col; j++)
		{
			scanf("%d",&Two_Arr[i][j]);
		}
	}

	printf("Elements from TWO DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < col; j++)
		{
			printf("%d\t",Two_Arr[i][j]);
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < row; i++)
	{
		free(Two_Arr[i]);
	}
	free(Two_Arr);
}
/*************************************************************** 2D Array *********************************************************/


/*************************************************************** 3D Array *********************************************************/
void Three_Dimensional_Array(int ***Three_Arr)
{
	int first , second , third = 0;

	printf("Enter First Dimension:");
	scanf("%d",&first);

	printf("Enter Second Dimension:");
	scanf("%d",&second);

	printf("Enter Third Dimension:");
	scanf("%d",&third);

	Three_Arr = (int ***)malloc(first * sizeof(int**));
	if(Three_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < first ; i++)
	{
		Three_Arr[i] = (int **)malloc(second * sizeof(int*));

		for(int j = 0; j < second; j++)
		{
			Three_Arr[i][j] = (int *)malloc(third * sizeof(int));
		}
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				scanf("%d",&Three_Arr[i][j][k]);
			}
		}
	}

	printf("Elements from THREE DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				printf("%d\t",Three_Arr[i][j][k]);
			}
			printf("\n");
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			free (Three_Arr[i][j]);
		}
		free(Three_Arr[i]);
	}

	free(Three_Arr);
}
/*************************************************************** 3D Array *********************************************************/


/*************************************************************** 4D Array *********************************************************/
void Four_Dimensional_Array(int ****Four_Arr)
{
	int first , second , third , fourth = 0;

	printf("Enter First Dimension:");
	scanf("%d",&first);

	printf("Enter Second Dimension:");
	scanf("%d",&second);

	printf("Enter Third Dimension:");
	scanf("%d",&third);
	
	printf("Enter Fourth Dimension:");
	scanf("%d",&fourth);

	Four_Arr = (int ****)malloc(first * sizeof(int***));
	if(Four_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < first ; i++)
	{
		Four_Arr[i] = (int ***)malloc(second * sizeof(int**));

		for(int j = 0; j < second; j++)
		{
			Four_Arr[i][j] = (int **)malloc(third * sizeof(int*));
			
			for(int k = 0; k < third; k++)
			{
				Four_Arr[i][j][k] = (int*)malloc(fourth * sizeof(int));
			}
		}
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					scanf("%d",&Four_Arr[i][j][k][m]);
				}
			}
		}
	}

	printf("Elements from FOUR DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					printf("%d\t",Four_Arr[i][j][k][m]);
				}
				printf("\n");
			}
			printf("\n");
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				free (Four_Arr[i][j][k]);
			}
		}
		free(Four_Arr[i]);
	}

	free(Four_Arr);
}
/*************************************************************** 4D Array *********************************************************/


/*************************************************************** 5D Array *********************************************************/
void Five_Dimensional_Array(int *****Five_Arr)
{
	int first , second , third , fourth , fifth = 0;

	printf("Enter First Dimension:");
	scanf("%d",&first);

	printf("Enter Second Dimension:");
	scanf("%d",&second);

	printf("Enter Third Dimension:");
	scanf("%d",&third);
	
	printf("Enter Fourth Dimension:");
	scanf("%d",&fourth);
	
	printf("Enter Fifth Dimension:");
	scanf("%d",&fifth);

	Five_Arr = (int *****)malloc(first * sizeof(int****));
	if(Five_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < first ; i++)
	{
		Five_Arr[i] = (int ****)malloc(second * sizeof(int***));

		for(int j = 0; j < second; j++)
		{
			Five_Arr[i][j] = (int ***)malloc(third * sizeof(int**));
			
			for(int k = 0; k < third; k++)
			{
				Five_Arr[i][j][k] = (int **)malloc(fourth * sizeof(int*));
		
				for(int m = 0; m < fifth; m++)
				{
					Five_Arr[i][j][k][m] = (int *)malloc(fifth * sizeof(int));
				}
			}
		}
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						scanf("%d",&Five_Arr[i][j][k][m][n]);
					}
				}
			}
		}
	}

	printf("Elements from FIVE DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						printf("%d\t",Five_Arr[i][j][k][m][n]);
					}
					printf("\n");
				}
				printf("\n");
			}
			printf("\n");
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					free (Five_Arr[i][j][k][m]);
				}
			}
		}
		free(Five_Arr[i]);
	}

	free(Five_Arr);
}
/*************************************************************** 5D Array *********************************************************/


/*************************************************************** 6D Array *********************************************************/
void Six_Dimensional_Array(int ******Six_Arr)
{
	int first , second , third , fourth , fifth , sixth = 0;

	printf("Enter First Dimension:");
	scanf("%d",&first);

	printf("Enter Second Dimension:");
	scanf("%d",&second);

	printf("Enter Third Dimension:");
	scanf("%d",&third);
	
	printf("Enter Fourth Dimension:");
	scanf("%d",&fourth);
	
	printf("Enter Fifth Dimension:");
	scanf("%d",&fifth);
	
	printf("Enter Sixth Dimension:");
	scanf("%d",&sixth);

	Six_Arr = (int ******)malloc(first * sizeof(int*****));
	if(Six_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < first ; i++)
	{
		Six_Arr[i] = (int *****)malloc(second * sizeof(int****));

		for(int j = 0; j < second; j++)
		{
			Six_Arr[i][j] = (int ****)malloc(third * sizeof(int***));
			
			for(int k = 0; k < third; k++)
			{
				Six_Arr[i][j][k] = (int ***)malloc(fourth * sizeof(int**));
		
				for(int m = 0; m < fifth; m++)
				{
					Six_Arr[i][j][k][m] = (int **)malloc(fifth * sizeof(int*));

					for(int n = 0; n < sixth; n++)
					{
						Six_Arr[i][j][k][m][n] = (int *)malloc(sixth * sizeof(int));
					}
				}
			}
		}
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						for(int p = 0; p < sixth; p++)
						{
							scanf("%d",&Six_Arr[i][j][k][m][n][p]);
						}
					}
				}
			}
		}
	}

	printf("Elements from SIX DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						for(int p = 0; p < sixth; p++)
						{
							printf("%d\t",Six_Arr[i][j][k][m][n][p]);
						}
						printf("\n");
					}
					printf("\n");
				}
				printf("\n");
			}
			printf("\n");
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						free (Six_Arr[i][j][k][m][n]);
					}
				}
			}
		}
		free(Six_Arr[i]);
	}

	free(Six_Arr);
}
/*************************************************************** 6D Array *********************************************************/


/*************************************************************** 7D Array *********************************************************/
void Seven_Dimensional_Array(int *******Seven_Arr)
{
	int first , second , third , fourth , fifth , sixth , seventh = 0;

	printf("Enter First Dimension:");
	scanf("%d",&first);

	printf("Enter Second Dimension:");
	scanf("%d",&second);

	printf("Enter Third Dimension:");
	scanf("%d",&third);
	
	printf("Enter Fourth Dimension:");
	scanf("%d",&fourth);
	
	printf("Enter Fifth Dimension:");
	scanf("%d",&fifth);
	
	printf("Enter Sixth Dimension:");
	scanf("%d",&sixth);
	
	printf("Enter Seventh Dimension:");
	scanf("%d",&seventh);

	Seven_Arr = (int *******)malloc(first * sizeof(int******));
	if(Seven_Arr == NULL)
	{
		return;
	}

	for(int i = 0; i < first ; i++)
	{
		Seven_Arr[i] = (int ******)malloc(second * sizeof(int*****));

		for(int j = 0; j < second; j++)
		{
			Seven_Arr[i][j] = (int *****)malloc(third * sizeof(int****));
			
			for(int k = 0; k < third; k++)
			{
				Seven_Arr[i][j][k] = (int ****)malloc(fourth * sizeof(int***));
		
				for(int m = 0; m < fifth; m++)
				{
					Seven_Arr[i][j][k][m] = (int ***)malloc(fifth * sizeof(int**));

					for(int n = 0; n < sixth; n++)
					{
						Seven_Arr[i][j][k][m][n] = (int **)malloc(sixth * sizeof(int*));
		
						for(int p = 0; p < seventh; p++)
						{
							Seven_Arr[i][j][k][m][n][p] = (int *)malloc(seventh * sizeof(int));
						}
					}
				}
			}
		}
	}

	printf("Enter Elements into Array:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						for(int p = 0; p < sixth; p++)
						{
							for(int q = 0; q < seventh; q++)
							{
								scanf("%d",&Seven_Arr[i][j][k][m][n][p][q]);
							}
						}
					}
				}
			}
		}
	}

	printf("Elements from SEVEN DIMENSIONAL ARRAY:\n");
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						for(int p = 0; p < sixth; p++)
						{
							for(int q = 0; q < seventh; q++)
							{
								printf("%d\t",Seven_Arr[i][j][k][m][n][p][q]);
							}
							printf("\n");
						}
						printf("\n");
					}
					printf("\n");
				}
				printf("\n");
			}
			printf("\n");
		}
		printf("\n");
	}
	printf("\n");

	//Deallocating memory
	for(int i = 0; i < first; i++)
	{
		for(int j = 0; j < second; j++)
		{
			for(int k = 0; k < third; k++)
			{
				for(int m = 0; m < fourth; m++)
				{
					for(int n = 0; n < fifth; n++)
					{
						for(int p = 0; p < sixth; p++)
						{
							free (Seven_Arr[i][j][k][m][n][p]);
						}
					}
				}
			}
		}
		free(Seven_Arr[i]);
	}

	free(Seven_Arr);
}
/*************************************************************** 7D Array *********************************************************/

