#include "Header.h"

void addq()
{
	int No = 0;

	struct Node *newn;

	newn = (struct Node*)malloc(sizeof(struct Node));
	if(newn == NULL)
	{
		return;
	}

	printf("Enter Number:");
	scanf("%d",&No);
		
	newn->Data = No;
	newn->Next = NULL;

	if(front == NULL)	
	{
		front = newn;
		rear = newn;
	}
	else
	{
		rear->Next = newn;
		rear = newn;
	}
}

int delq()
{
	int No = 0;

	struct Node *temp;

	No = front->Data;
	temp = front;
	front = front->Next;
	if (front == NULL)
	{
		rear = NULL;
	}

	free(temp);

	return No;
}

void displayq()
{
	struct Node *temp = NULL;

	temp = front;

	while(temp != NULL)
	{
		printf("|%d|\t",temp->Data);
		temp = temp->Next;
	}	
}

int isqempty()
{
	if (front == NULL)
	{
		return 1;
	}

	return 0;
}

void initq()
{
	front = rear = NULL;
}

