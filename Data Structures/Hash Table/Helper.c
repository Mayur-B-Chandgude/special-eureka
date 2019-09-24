#include "Header.h"

void Insert()
{
	int No = 0;

	int k , m = -1;

	printf("Enter Number:");
	scanf("%d",&No);

	k = No % SIZE;

	while(1)
	{
		if(b[k].key == -1)
		{
			b[k].key = No;
			cnt++;
		
			if(m != -1)
			{
				b[m].chain = k;
			}

			break;
		}
		else
		{
			if(m == -1)
			{
				m = k;
			}

			k = (k + 1) % SIZE;

			if(b[m].chain == k)
			{
				m = k;
			}
		}
	}
}

void Display()
{
	printf("Pos\tKey\tChain\n");
	for(int i = 0; i < SIZE; i++)
	{
		printf("%d\t%d\t%d\n" , i , b[i].key , b[i].chain);
	}
}

int Search()
{
	int Pos = -1 , k;
	int No = 0;

	printf("Enter Number:");
	scanf("%d",&No);

	printf("Enter Position:");
	scanf("%d",&Pos);

	k = No % SIZE;

	while(1)
	{
		if(b[k].key == No)
		{
			Pos = k;
			break;
		}

		if(b[k].chain != -1)
		{
			k = b[k].chain;
		}
		else
		{
			break;
		}
	}

	return Pos;
}

void Delete()
{
	int k , m;
	int Pos = -1;

	printf("Enter Position:");
	scanf("%d",&Pos);

	if(b[Pos].chain == -1)
	{
		b[Pos].key = -1;
	}
	else
	{
		m = Pos;
	
		while(b[m].chain != -1)
		{
			k = b[m].chain;
			b[m].key = b[k].key;

			if(b[k].chain == -1)
			{
				b[m].chain = -1;
			}

			m = k;
		}

		b[k].key = -1;
	}

	cnt--;
}

