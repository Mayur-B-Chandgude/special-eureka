#include<stdio.h>
#include<malloc.h>

int Display(int* , int , int);

int main()
{
	int i , size = 0;
	int *ptr = NULL;
	int value = 0;
	int ret = 0;

	printf("Enter Number of Elements:\n");
	scanf("%d",&size);

	ptr = (int*)malloc(size * sizeof(int));
	
	printf("Enter data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&ptr[i]);
	}

	printf("Enter Number for search:");
	scanf("%d",&value);

	ret = Display(ptr , size , value);
	if(ret == -1)
	{
		printf("Number not Found\n");
	}
	else
	{
		printf("Number is found at index:%d\n",ret);
	}

	return 0;
}

int Display(int *Arr , int size , int No)
{
	if((Arr == NULL) || (size <= 0))
	{
		return -1;
	}

	register int i = 0;
	int pos = -1;

	for(i = size - 1 ; i >= 0 ; i--)
	{
		if((Arr[i]) == No)
		{
			pos = i + 1;
		}
	}
		
	return pos;
}

