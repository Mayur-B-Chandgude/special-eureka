#include "Header.h"

void InitStack()
{
	top = NULL;
}

void Push()
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

	if(top == NULL)
	{
		newn->Next = NULL;
		top = newn;
	}	
	else
	{
		newn->Next = top;
		top = newn;
	}
}

int Pop()
{
	int No = 0;

	struct Node *temp;

	No = top->Data;
	temp = top;
	top = top->Next;

	free(temp);

	return No;
}

int isEmpty()
{
	if(top == NULL)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}

void Display()
{
	struct Node *temp;

	for (temp = top; temp != NULL; temp = temp->Next)
	{
		printf("%d\n",temp->Data);
	}
		
}

