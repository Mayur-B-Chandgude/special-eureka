#include<stdio.h>
#include<malloc.h>

void Display(int* , int);

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

	printf("Perfect Numbers are:\n");
	for(i = 0 ; i < size ; i++)
	{	
		ans = 0;
	
		for(cnt = 1 ; cnt < Arr[i] ; cnt++)
		{
			if((Arr[i] % cnt) == 0)
			{
				ans = ans + cnt;
			}
		}

		if(ans == Arr[i])
		{
			printf("%d\t",Arr[i]);
		}
	}
}

