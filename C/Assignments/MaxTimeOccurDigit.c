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

	int temp , i , max , maxdigit , digit = 0;
	int Brr[10] = {0};

	for(i = 0 ; i < size ; i++)
	{
		temp = Arr[i];
		while(temp != 0)
		{
			digit = temp % 10;
			Brr[digit]++;
			temp = temp / 10;
		}
	}

	for(i = 0 ; i < 10 ; i++)
	{
		if(Brr[i] > max)
		{
			max = Brr[i];
			maxdigit = i;
		}
	}
	printf("%d occurs %d times:\n", maxdigit , max);
}

