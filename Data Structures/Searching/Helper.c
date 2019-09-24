#include "Header.h"

int Binary_Search(int arr[])
{
	int size = 0 , data = 0;
	int low = 0 , mid = 0 , high = 0;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	arr = (int*)malloc(size * sizeof(int));
	if(arr == NULL)
	{
		return 0;
	}

	printf("Enter Elements:\n");
	for(int i = 0; i < size; i++)
	{
		scanf("%d",&arr[i]);
	}

	printf("Enter elements to search:");
	scanf("%d",&data);

	high = size - 1;

	while(low <= high)
	{
		mid = low + (high - low)/2;
		
		if(arr[mid] == data)
		{
			return mid;
		}

		else if(arr[mid] < data)
		{
			low = mid +1;
		}

		else
		{
			high = mid -1;
		}
	}

	return -1;
}


int Linear_Unsorted_Search(int arr[])
{
	int size = 0 , data = 0;

	printf("Enter Number of elements:");
	scanf("%d",&size);

	arr = (int*)malloc(size * sizeof(int*));
	if(arr == NULL)
	{
		return 0;
	}

	printf("Enter Elements:\n");
	for(int i = 0; i < size; i++)
	{
		scanf("%d",&arr[i]);
	}

	printf("Enter Number to Search:");
	scanf("%d",&data);

	for(int i = 0; i < size; i++)
	{
		if(arr[i] == data)
		{
			return i;	
		}
	}

	return -1;
}

