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

	newn->Data = No;
	newn->Next = NULL;
	newn->Prev = NULL;

	if((*first == NULL) && (*last == NULL))
	{
		*first = newn;
		*last = newn;
		(*last)->Next = *first;
		(*first)->Prev = *last;
	}
	else
	{
		newn->Next = *first;
		(*first)->Prev = newn;
		*first = newn;
		(*last)->Next = *first;
		(*first)->Prev = *last;
	}

	return TRUE;
}

BOOL InsertLast(PPNODE first , PPNODE last)
{
	PNODE newn = NULL;
	PNODE temp = NULL;

	int No = 0;

	temp = *first;

	newn = (PNODE)malloc(sizeof(NODE));
	if(newn == NULL)
	{
		return FALSE;
	}

	printf("Enter Number:");
	scanf("%d",&No);

	newn->Data = No;
	newn->Next = NULL;
	newn->Prev = NULL;

	if((*first == NULL) && (*last == NULL))
	{
		*first = newn;
		*last = newn;
		(*last)->Next = *first;
		(*first)->Prev = *last;
	}
	else
	{
		(*last)->Next = newn;
		newn->Prev = *last;
		*last = newn;	
		(*last)->Next = *first;
		(*first)->Prev = *last;	
	}

	return TRUE;
}

BOOL InsertAtPos(PPNODE first , PPNODE last)
{
	PNODE newn = NULL;
	PNODE temp = NULL;

	int cnt , Pos , No = 0;

	cnt = Count(*first , *last);

	printf("Enter Position:");
	scanf("%d",&Pos);

	if((Pos < 1) || (Pos > cnt + 1))
	{
		return FALSE;
	}

	if(Pos == 1)
	{
		return (InsertFirst(first , last));
	}
	else if(Pos == cnt + 1)
	{
		return (InsertLast(first , last));
	}
	else
	{
		temp = *first;

		newn = (PNODE)malloc(sizeof(NODE));
		if(newn == NULL)
		{
			return FALSE;
		}

		printf("Enter Number:");
		scanf("%d",&No);

		newn->Data = No;
		newn->Next = NULL;
		newn->Prev = NULL;

		for(int i = 0; i < (Pos - 2); i++)
		{
			temp = temp->Next;
		}

		newn->Next = temp->Next;
		temp->Next->Prev = newn;
		temp->Next = newn;
		newn->Prev = temp;
	}

	return TRUE;
}

BOOL DeleteFirst(PPNODE first , PPNODE last)
{
	PNODE temp = NULL;

	temp = *first;

	if(*first == NULL)
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
		*first = temp->Next;
		(*last)->Next = *first;
		(*first)->Prev = *last;
		free(temp);
	}

	return TRUE;
}

BOOL DeleteLast(PPNODE first , PPNODE last)
{
	PNODE temp1 = NULL;
	PNODE temp2 = NULL;

	temp1 = *first;
	temp2 = *last;

	if((*first == NULL) && (*last == NULL))
	{
		return FALSE;
	}

	if(*first == *last)
	{
		free(*first);
		(*last)->Next = NULL;
		(*first)->Prev = NULL;
	}
	else
	{
		*last = (*last)->Prev;
		free((*first)->Prev);
		(*last)->Next = *first;
		(*first)->Prev = *last;
	}

	return TRUE;
}

BOOL DeleteAtPos(PPNODE first , PPNODE last)
{
	PNODE temp1 , temp2 = NULL;

	int cnt , Pos = 0;

	cnt =Count(*first , *last);

	printf("Enter position:");
	scanf("%d",&Pos);

	if((Pos < 1) && (Pos > cnt + 1))
	{
		return FALSE;
	}

	if(Pos == 1)
	{
		return (DeleteFirst(first , last));
	}
	else if(Pos == cnt + 1)
	{
		return (DeleteLast(first , last));
	}
	else
	{
		temp1 = *first;
		temp2 = *last;

		for(int i = 0; i < (Pos - 1); i++)
		{
			temp1 = temp1->Next;
		}

		temp1->Prev->Next = temp1->Next;
		temp1->Next->Prev = temp1->Prev;
		free(temp1);
	}

	return TRUE;
}

void DisplayForward(PNODE first , PNODE last)
{
	do
	{
		printf("|%d|",first->Data);
		first = first->Next;
	}while(first != last->Next);
}

int Count(PNODE first , PNODE last)
{
	int cnt = 0;

	do
	{
		cnt++;
		first = first->Next;
	}while(first != last->Next);

	return cnt;
}

int SearchFirstOccurance(PNODE first , PNODE last)
{
	int cnt , No = 0;
	
	printf("Enter Number to Search:");
	scanf("%d",&No);

	do
	{
		cnt++;

		if(first->Data == No)
		{
			return cnt;
		}

		first = first->Next;
	}while(first != last->Next);

	return -1;
}

void DisplayReverse(PNODE first , PNODE last)
{
	PNODE temp = NULL;

	temp = last;

	if(first == NULL)
	{
		return;
	}
	else
	{
		do
		{
			printf("|%d|",temp->Data);
			temp = temp->Prev;
		}while(temp != (first)->Prev);
	}
}

