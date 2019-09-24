/*********************************** Using While Loop ********************************************/

#include<stdio.h>
#include<malloc.h>

#define TRUE	1
#define FALSE	0

typedef int BOOL;

BOOL Display(int* , int);

int main()
{
	int i , size = 0;
	int *ptr = NULL;
	BOOL bret;

	printf("Enter Number of Elements:\n");
	scanf("%d",&size);

	ptr = (int*)malloc(size * sizeof(int));
	
	printf("Enter data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&ptr[i]);
	}

	bret = Display(ptr , size);
	if(bret == TRUE)
	{
		printf("Array is Palindrome\n");
	}
	else
	{
		printf("Array is not Palindrome\n");
	}
	
	return 0;
}

BOOL Display(int *Arr , int size)
{
	if((Arr == NULL) || (size <= 0))
	{
		return FALSE;
	}

	int start = 0;	
	int end = 0;

	start = 0;
	end = size - 1;

	while(start <= end)
	{
		if(Arr[start] != Arr[end])
		{
			break;
		}

		start++;
		end--;
	}

	if(start < end)
	{
		return FALSE;
	}
	else
	{
		return TRUE;
	}
}

