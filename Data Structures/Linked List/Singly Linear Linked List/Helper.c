#include<stdio.h>
#include "Header.h"

BOOL InsertFirst(PPNODE first)
{
	PNODE newn = NULL;
	int No = 0;

	newn = (PNODE)malloc(sizeof(NODE));
	if(newn == NULL)
	{
		return FALSE;
	}

	printf("Enter Number:");
	scanf("%d",&No);

	newn->data = No;
	newn->next = NULL;

	if(*first == NULL)
	{
		*first = newn;
	}
	else
	{
		newn->next = *first;
		*first = newn;
	}
	
	return TRUE;
}

void Display(PNODE first)
{
	//printf("Linked List Contains:\n");
	while(first != NULL)
	{
		printf("%d\t",first->data);
		first = first->next;
	}
	printf("\n");
}

BOOL InsertLast(PPNODE first)
{
	PNODE newn = NULL;
	PNODE temp = NULL;

	int No = 0;

	newn = (PNODE)malloc(sizeof(NODE));
	if(newn == NULL)
	{
		return FALSE;
	}
	
	printf("Enter Number:");
	scanf("%d",&No);

	newn->data = No;
	newn-> next = NULL;

	if(*first == NULL)
	{
		*first = newn;
	}
	else
	{
		temp = *first;

		while(temp->next != NULL)	
		{
			temp = temp->next;	
		}

		temp->next = newn;
	}
	return TRUE;
}

BOOL InsertAtPos(PPNODE first)
{
	PNODE newn = NULL;

	int cnt = Count(*first);
	int i  = 0;
	PNODE temp = *first;

	int pos , No = 0;

	printf("Enter Position:");
	scanf("%d",&pos);
	
	if(pos <= 0)
	{
		(pos > (cnt + 1));		
		return FALSE;
	}

	if(pos == 1)
	{
		return (InsertFirst(first));
	}
	else if(pos == (cnt + 1))
	{
		return (InsertLast(first));
	}
	else
	{
		newn = (PNODE)malloc(sizeof(NODE));
		if(newn == NULL)
		{
			return FALSE;
		}
		
		printf("Enter Number:");
		scanf("%d",&No);

		newn->data = No;
		newn->next = NULL;

		for(i = 1; i <= (pos - 2); i++)
		{
			temp = temp->next;
		}
	
		newn->next = temp->next;
		temp->next = newn;
	}
	return TRUE;
}

int Count(PNODE first)
{
	int cnt = 0;

	while(first != NULL)
	{
		cnt++;
		first = first->next;
	}
	return cnt;
}

BOOL DeleteFirst(PPNODE first)
{
	PNODE temp = *first;

	if(*first == NULL)
	{
		return FALSE;
	}
	else
	{
		*first = (*first)->next;
		free(temp);
	}
	return TRUE;
}

BOOL DeleteLast(PPNODE first)
{
	PNODE temp = *first;

	if(*first == NULL)
	{
		return FALSE;
	}
	else if((*first)->next == NULL)
	{
		free(*first);
		*first = NULL;
	}
	else
	{
		while(temp->next->next != NULL)
		{
			temp = temp->next;
		}

		free(temp->next);
		temp->next = NULL;
	}
	return TRUE;
}

BOOL DeleteAtPos(PPNODE first)
{
	int cnt = 0 , i = 0 , pos = 0;
	PNODE temp1 = NULL , temp2 = NULL;

	cnt = Count(*first);

	printf("Enter Position:");
	scanf("%d",&pos);

	if((pos < 1) || (pos > cnt))
	{
		return FALSE;
	}

	if(pos == 1)
	{
		return (DeleteFirst(first));
	}
	else if(pos == cnt)
	{
		return (DeleteLast(first));
	}
	else
	{
		temp1 = *first;
	
		for(i = 0; i < (pos - 2); i++)
		{
			temp1 = temp1->next;
		}

		temp2 = temp1->next;
		temp1->next = temp2->next;
		free(temp2);
	}
	return TRUE;
}

