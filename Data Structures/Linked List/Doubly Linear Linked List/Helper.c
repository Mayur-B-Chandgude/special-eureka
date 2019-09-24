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

	newn->Data = No;
	newn->Next = NULL;
	newn->Prev = NULL;

	if(*first == NULL)
	{
		*first = newn;
	}
	else
	{
		newn->Next = *first;
		(*first)->Prev = newn;
		*first = newn;
	}

	return TRUE;
}

BOOL InsertLast(PPNODE first)
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

	if(*first == NULL)
	{
		*first = newn;
	}
	else
	{
		while(temp->Next != NULL)
		{
			temp = temp->Next;
		}
		
		temp->Next = newn;
		newn->Prev = temp;
	}
	
	return TRUE;
}

BOOL InsertAtPos(PPNODE first)
{
	PNODE newn = NULL;
	PNODE temp = NULL;

	int No , Pos , cnt = 0;
	int i = 1;

	cnt = Count(*first);

	printf("Enter Position:");
	scanf("%d",&Pos);

	if((Pos < 1) && (Pos > cnt + 1))
	{
		return FALSE;
	}

	if(Pos == 1)
	{
		return (InsertFirst(first));
	}
	else if(Pos == cnt + 1)
	{
		return (InsertLast(first));
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

		for(i = 0; i < (Pos - 2); i++)
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

BOOL DeleteFirst(PPNODE first)
{
	PNODE temp = NULL;

	temp = *first;

	if(*first == NULL)
	{
		return FALSE;
	}
	else
	{
		*first = temp->Next;
		(*first)->Prev = NULL;	
		free(temp);
	}

	return TRUE;
}

BOOL DeleteLast(PPNODE first)
{
	PNODE temp1 , temp2 = NULL;

	temp1 = temp2 = *first;

	if(*first == NULL)
	{
		return FALSE;
	}
	else
	{
		while(temp1->Next != NULL)
		{
			temp2 = temp2->Next;
			temp1 = temp2->Next;
		}

		temp2->Next = NULL;
		free(temp1);
	}

	return TRUE;
}

BOOL DeleteAtPos(PPNODE first)
{
	PNODE temp = NULL;

	int cnt , Pos = 0;

	cnt = Count(*first);

	printf("Enter Position:");
	scanf("%d",&Pos);

	if((Pos < 1) || (Pos > cnt + 1))
	{
		return FALSE;
	}

	if(Pos == 1)
	{
		return (DeleteFirst(first));
	}
	else if(Pos == cnt + 1)
	{
		return (DeleteLast(first));
	}
	else
	{
		temp = *first;

		for(int i = 0; i < (Pos - 1); i++)
		{
			temp = temp->Next;
		}

		temp->Prev->Next = temp->Next;
		temp->Next->Prev = temp->Prev;

		free(temp);
	}

	return TRUE;
}

void Display(PNODE first)
{
	while(NULL != first)
	{
		printf("|%d|->",first->Data);
		first = first->Next;
	}
}

int Count(PNODE first)
{
	int cnt = 0;

	while(NULL != first)
	{
		cnt++;
		first = first->Next;
	}

	return cnt;
}

int SearchFirstOccurance(PNODE first)
{
	int cnt , No = 0;

	printf("Enter Number to Search:");
	scanf("%d",&No);

	while(first != NULL)
	{
		cnt++;

		if(first->Data == No)
		{
			return cnt;			
		}
	
		first = first->Next;
	}

	return -1;
}

