#include<stdio.h>
#include<malloc.h>

void Display(int* , int);

int main()
{
	int i , size = 0;
	int *ptr = NULL;

	printf("Enter Number of Elements:\n");
	scanf("%d",&size);

	ptr = (int*)malloc(size * sizeof(int));
	
	printf("Enter data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&ptr[i]);
	}

	Display(ptr , size);
	
	return 0;
}

void Display(int *Arr , int size)
{
	if((Arr == NULL) || (size <= 0))
	{
		return;
	}

	register int i , cnt = 0;
	int ans = 0;

	printf("Numbers are:\n");
	for(i = 2 ; i < size ; i = i + 2)
	{
		if((Arr[i] % 2) == 0)
		{	
			printf("%d\t",Arr[i]);
		}
	}
}

