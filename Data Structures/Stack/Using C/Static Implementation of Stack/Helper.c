#include "Header.h"

void InitStack(PNODE first)
{
	(first)->Top = -1;
}

void Push(PNODE first)
{
	int No = 0;

	printf("Enter Node:");
	scanf("%d",&No);

	(first)->Top++;
	first->Data[first->Top] = No;
}

int Pop(PNODE first)
{
	int cnt = 0;

	cnt = first->Data[first->Top];
	first->Top--;

	return cnt;
}

BOOL isFull(PNODE first)
{
	if(first->Top == SIZE - 1)
	{	
		return TRUE;
	}	
	else
	{
		return FALSE;
	}	
}

BOOL isEmpty(PNODE first)
{
	if(first->Top == -1)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

void Display(PNODE first)
{
	int temp = 0;

	for (temp = first->Top; temp != -1; temp--)
	{
		printf("%d\n",first->Data[temp]);
	}
}

