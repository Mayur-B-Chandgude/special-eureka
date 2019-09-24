#include<stdio.h>
#include<malloc.h>

void Display(int* , int , int);

int main()
{
	int i , size = 0;
	int *ptr = NULL;
	int value = 0;

	printf("Enter Number of Elements:\n");
	scanf("%d",&size);

	ptr = (int*)malloc(size * sizeof(int));
	
	printf("Enter data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&ptr[i]);
	}

	printf("Enter Number:");
	scanf("%d",&value);

	Display(ptr , size , value);

	return 0;
}

void Display(int *Arr , int size , int No)
{
	if((Arr == NULL) || (size < 0))
	{
		return;
	}

	register int i = 0;

	printf("Factors are:\n");
	for(i = 0 ; i < size ; i++)
	{
		if((No % Arr[i]) == 0)
		{
			printf("%d\t",Arr[i]);
		}
	}
}

