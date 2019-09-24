#include<stdio.h>
#include<malloc.h>

int Display(int* , int);

int main()
{
	int i , size = 0;
	int *ptr = NULL;
	int ret = 0;

	printf("Enter Number of Elements:\n");
	scanf("%d",&size);

	ptr = (int*)malloc(size * sizeof(int));
	
	printf("Enter data:\n");
	for(i = 0 ; i < size ; i++)
	{
		scanf("%d",&ptr[i]);
	}

	ret = Display(ptr , size);
	printf("Second Maxmium is:%d\n",ret);
	
	return 0;
}

int Display(int *Arr , int size)
{
	if((Arr == NULL) || (size < 3))
	{
		return 0;
	}

	register int i = 0;
	
	int max = Arr[0];
	int Smax = Arr[0];

	for(i = 0 ; i < size ; i++)	
	{
		if(Arr[i] > max)
		{
			max = Arr[i];
		}
	}
	
	for(i = 0 ; i < size ; i++)	
	{
		if((Smax < Arr[i]) && (max > Arr[i]))
		{
			Smax = Arr[i];
		}
	}

	printf("Maximum Number is:%d\n",max);

	return Smax;
}

