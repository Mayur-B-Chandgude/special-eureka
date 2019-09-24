#include "Header.h"

/************************************************ BUBBLE SORT ******************************************************/
/*****Best Case Complexity:- O(n)*****/

void Bubble_Sort(int *Arr)
{
	int temp = 0 , size = 0, swapped = 1;

	printf("Enter Size:");
	scanf("%d",&size);

	Arr = (int*)malloc(size*sizeof(int));
	if(Arr == NULL)
	{
		return;
	}

	printf("Enter Elements:\n");
	for(int i = 0; i < size; i++)
	{
		scanf("%d",&Arr[i]);
	}

	for(int pass = size - 1; pass >= 0 && swapped; pass--)
	{
		swapped = 0;
	
		for(int i = 0; i <= pass - 1; i++)
		{
			if(Arr[i] > Arr[i + 1])
			{
				temp = Arr[i];
				Arr[i] = Arr[i + 1];
				Arr[i + 1] = temp;

				swapped = 1;
			}
		}
	}

	printf("After Sort:\n");
	for(int i = 0; i < size; i++)
	{
		printf("|%d|\t",Arr[i]);
	}
	printf("\n");
}

/************************************************ BUBBLE SORT ******************************************************/


/************************************************ SELECTION SORT ******************************************************/
/*****Best Case Complexity:- O(n Square)*****/

void Selection_Sort(int *Arr)
{
	int min = 0 , size = 0 , temp = 0;

	printf("Enter Size:");
	scanf("%d",&size);

	Arr = (int*)malloc(size * sizeof(int));
	if(Arr == NULL)
	{
		return;
	}

	printf("Enter Elements:\n");
	for(int i = 0; i < size; i++)
	{
		scanf("%d",&Arr[i]);
	}

	for(int i = 0; i < size - 1; i++)
	{
		min = i;
		
		for(int j = i + 1; j < size; j++)
		{
			if(Arr[j] < Arr[min])
			{
				min = j;
			}
		}

		temp = Arr[min];
		Arr[min] = Arr[i];
		Arr[i] = temp;
	}

	printf("After Sort:\n");
	for(int i = 0; i < size; i++)
	{
		printf("|%d|\t",Arr[i]);
	}
	printf("\n");
}

/************************************************ SELECTION SORT ******************************************************/


/************************************************ INSERTION SORT ******************************************************/
/*****Best Case Complexity:- Theta(n)*****/

void Insertion_Sort(int *Arr)
{
	int size = 0 , j = 0 , v = 0;

	printf("Enter Size:");
	scanf("%d",&size);

	Arr = (int*)malloc(size*sizeof(int));
	if(Arr == NULL)
	{
		return;
	}

	printf("Enter Elements:\n");
	for(int i = 0; i < size; i++)
	{
		scanf("%d",&Arr[i]);
	}

	for(int i = 1; i <= size - 1; i++)
	{
		v = Arr[i];
		j = i;
		
		while((Arr[j - 1] > v) && (j >= 1))
		{
			Arr[j] = Arr[j - 1];	
			j--;
		}

		Arr[j] = v;
	}

	printf("After Sort:\n");
	for(int i = 0; i < size; i++)
	{
		printf("|%d|\t",Arr[i]);
	}
}

/************************************************ INSERTION SORT ******************************************************/

