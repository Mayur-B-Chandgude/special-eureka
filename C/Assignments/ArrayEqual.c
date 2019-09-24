#include<stdio.h>
#include<malloc.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int* , int* , int , int);

int main()
{
	int size1 , size2 = 0;
	int *Arr = NULL;
	int *Brr = NULL;
	int i = 0;	

	BOOL bret;

	printf("Enter Number of Elements:");
	scanf("%d",&size1);

	Arr = (int*)malloc(size1 * sizeof(int));
	printf("Enter Data in first Array:\n");
	for(i = 0 ; i < size1 ; i++)
	{
		scanf("%d",&Arr[i]);
	}

	printf("Enter Number of Elements:");
	scanf("%d",&size2);

	Brr = (int*)malloc(size2 * sizeof(int));
	printf("Enter Data in second Array:\n");
	for(i = 0 ; i < size2 ; i++)
	{
		scanf("%d",&Brr[i]);
	}

	bret = Display(Arr , Brr , size1 , size2);
	if(bret == TRUE)
	{
		printf("Both Arrays are Equal\n");
	}
	else
	{
		printf("Both Arrays are not Equal\n");
	}

	return 0;
}

BOOL Display(int Arr[] , int Brr[] , int size1 , int size2)
{
	if((Arr == NULL) || (Brr == NULL))
	{
		return FALSE;
	}

	if(size1 != size2)
	{
		return FALSE;
	}

	int i = 0;

	for(i = 0 ; i < size1 ; i++)
	{
		if(Arr[i] != Brr[i])
		{
			break;
		}
	}

	if(i < size1)
	{
		return FALSE;
	}
	else
	{
		return TRUE;
	}
}

