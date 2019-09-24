#include<stdio.h>
#include<malloc.h>

int Display(int * , int);

int main()
{
	int * Arr = NULL;
	int size , i , ret = 0;

	printf("Enter Number of Elements:");
	scanf("%d",&size);

	Arr = (int *) malloc(size * sizeof(int));
	
	printf("Enter Data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&Arr[i]);
	}

	ret = Display(Arr , size);
	printf("Second Maximum Number is:%d\n",ret);

	return 0;
}

int Display(int Arr[] , int size)
{
	if((Arr == NULL) || (size <= 0))
	{
		return 0;
	}

	register int i = 0;
	int max = 0;
	int secondmax = 0;

	for(i = 0 ; i < size ; i++)
	{
		if(Arr[i] > max)
		{
			secondmax = max;
			max = Arr[i];
			
		}
		else if((Arr[i] > secondmax) && (max != Arr[i]))
		{
			secondmax = Arr[i];
		}
	}

	return secondmax;
}





















