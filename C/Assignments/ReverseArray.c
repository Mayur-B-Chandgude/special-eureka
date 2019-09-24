#include<stdio.h>
#include<malloc.h>

void Display(int* , int);

int main()
{
	int size = 0;
	int *Arr = NULL;
	int i = 0;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	Arr = (int*)malloc(size * sizeof(int));

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
	if((Arr == NULL) && (size <= 0))	
	{
		return;
	}

	int start = 0;
	int end = 0;
	int temp = 0;

	start = 0;
	end = size -1;

	while(start <= end)
	{
		temp = Arr[start];
		Arr[start] = Arr[end];	
		Arr[end] = temp;

		start++;
		end--;
	}
}

