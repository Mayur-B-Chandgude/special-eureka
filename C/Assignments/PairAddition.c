#include<stdio.h>
#include<malloc.h>

void Display(int * , int);

int main()
{
	int * Arr = NULL;
	int size , i = 0;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	Arr = (int *) malloc(size * sizeof(int));
	
	printf("Enter Data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&Arr[i]);
	}

	Display(Arr , size);

	return 0;
}

void Display(int Arr[] , int size)
{
	if((Arr == NULL) || (size <= 0))
	{
		return;
	}

	register int i , j = 0;
	
	for(i = 0 ; i < size - 1 ; i++)
	{
		for(j = i + 1 ; j < size ; j++)
		{
			if((Arr[i] + Arr[j]) == 100)
			{
				printf("%d %d\t" , Arr[i] , Arr[j]);
			}
		}
	}
}

