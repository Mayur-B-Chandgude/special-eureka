#include<stdio.h>
#include<malloc.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int* , int);

int main()
{
	int size = 0;
	int *Arr = NULL;
	int i = 0;	

	BOOL bret;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	Arr = (int*)malloc(size * sizeof(int));
	printf("Enter Data in Array:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&Arr[i]);
	}

	bret = Display(Arr , size);
	if(bret == TRUE)
	{
		printf("Array is Sorted\n");
	}
	else
	{
		printf("Array is not Sorted\n");
	}

	return 0;
}

BOOL Display(int Arr[] , int size)
{
	if(Arr == NULL)
	{
		return FALSE;
	}

	register int i = 0;

	for(i = 1 ; i < size ; i++)	
	{
		if(Arr[i] < Arr[i-1])
		{
			break;
		}
	}

	if(i < size)
	{
		return FALSE;
	}
	else
	{
		return TRUE;
	}
}

