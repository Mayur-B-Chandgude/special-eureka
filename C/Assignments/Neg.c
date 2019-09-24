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
		
	register int i = 0;

	for(i = 1 ; i < size - 1 ; i++)
	{
		if(((Arr[i] % 2) != 0) && ((Arr[i - 1] % 2) == 0) && ((Arr[i + 1] % 2) == 0))
		{
			printf("%d %d %d\t" , Arr[i - 1] , Arr[i] , Arr[i + 1]);
		}
	}
}

