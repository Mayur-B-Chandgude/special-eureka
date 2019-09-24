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

	printf("Prime Numbers are:\n");
	for(i = 0 ; i < size ; i++)
	{		
		for(cnt = 2 ; cnt < Arr[i] ; cnt++)
		{
			if((Arr[i] % cnt) == 0)
			{
				ans++;
				break;
			}
		}

		if(ans == 0)
		{
			printf("%d\t",Arr[i]);
		}
	}
}

