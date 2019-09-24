#include "Header.h"

BOOL InsertFirst(PPNODE first , PPNODE last)
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

	if((*first == NULL) && (*last == NULL))
	{
		*first = newn;
		*last = newn;
		(*last)->next = *first;
	}
	else
	{
		newn->next = *first;
		*first = newn;
		(*last)->next = *first;
	}
	return TRUE;
}

BOOL InsertLast(PPNODE first , PPNODE last)
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

	if((*first == NULL) && (*last == NULL))	
	{
		*first = newn;
		*last = newn;
		(*last)->next = *first;
	}
	else
	{
		(*last)->next = newn;
		*last = newn;
		(*last)->next = *first;
	}
	return TRUE;
}

void Display(PNODE first , PNODE last)
{
	if((first == NULL) && (last == NULL))
	{
		return;
	}

	do	
	{
		printf("%d\t",first->data);
		first = first->next;
	}while(first != last->next);
}

int Count(PNODE first , PNODE last)
{
	int cnt = 0;

	if((first == NULL) && (last == NULL))
	{
		return cnt;
	}

	do
	{
		cnt++;
		first = first->next;
	}while(first != last->next);

	return cnt;
}

BOOL InsertAtPos(PPNODE first , PPNODE last)
{
	PNODE newn = NULL , temp = NULL;

	int pos , cnt , No = 0;

	cnt = Count(*first , *last);

	printf("Enter Position:");	
	scanf("%d",&pos);

	if((pos < 1) || (pos > cnt + 1))
	{
		return FALSE;
	}
	
	if(pos == 1)
	{
		return(InsertFirst(first , last));
	}
	else if(pos == cnt + 1)
	{
		return (InsertLast(first , last));
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

		temp = *first;

		for(int i = 0; i < (pos - 2); i++)
		{
			temp = temp->next;
		}

		newn->next = temp->next;
		temp->next = newn;
	}
	return TRUE;
}

BOOL DeleteFirst(PPNODE first , PPNODE last)
{
	if((*first == NULL) && (*last == NULL))
	{
		return FALSE;
	}

	if(*first == *last)
	{
		free(*first);
		*first = NULL;
		*last = NULL;
	}
	else
	{
		*first = (*first)->next;
		free((*last)->next);
		(*last)->next = *first;
	}
	return TRUE;
}

BOOL DeleteLast(PPNODE first , PPNODE last)
{
	PNODE temp = NULL;

	if((*first == NULL) && (*last == NULL))
	{
		return FALSE;
	}

	if(*first == *last)
	{
		free(*last);
		*first = NULL;
		*last = NULL;
	}
	else
	{
		temp = *first;
		
		while(temp->next != *last)
		{
			temp = temp->next;
		}

		free(*last);
		*last = temp;
		(*last)->next = *first;
	}
	return TRUE;
}

BOOL DeleteAtPos(PPNODE first , PPNODE last)
{
	PNODE temp1 = NULL , temp2 = NULL;

	int cnt , pos = 0;

	cnt = Count(*first , *last);

	printf("Enter Position:");
	scanf("%d",&pos);

	if((pos < 1) || (pos > cnt))
	{
		return FALSE;	
	}

	if(pos == 1)
	{
		return (DeleteFirst(first , last));
	}
	else if(pos == cnt)
	{
		return (DeleteLast(first , last));
	}
	else
	{
		temp1 = *first;

		for(int i = 0; i < (pos - 2); i++)
		{
			temp1 = temp1->next;
		}

		temp2 = temp1->next;
		temp1->next = temp2->next;
		free(temp2);
	}
	return TRUE;
}

