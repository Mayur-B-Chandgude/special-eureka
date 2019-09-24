#include "Header.h"

void Insert(PPNODE first)
{
	int No = 0;

	PNODE newn = NULL;
	PNODE temp = NULL;

	temp = *first;

	newn = (PNODE)malloc(sizeof(NODE));
	if(newn == NULL)
	{
		return;
	}

	printf("Enter Number:");
	scanf("%d",&No);

	newn->Data = No;
	newn->Lchild = NULL;
	newn->Rchild = NULL;

	if(*first == NULL)
	{
		*first = newn;
	}
	else
	{
		while(1)
		{
			if(temp->Data == No)
			{
				free(newn);
				break;
			}

			if(No < temp->Data)
			{
				if(temp->Lchild == NULL)
				{
					temp->Lchild = newn;
					break;
				}
				temp = temp->Lchild;
			}
			else if(No > temp->Data)
			{
				if(temp->Rchild == NULL)
				{
					temp->Rchild = newn;
					break;
				}
				temp = temp->Rchild;
			}
		}
	}
}

BOOL Search(PNODE first)
{
	int No = 0;

	printf("Enter Number:");	
	scanf("%d",&No);

	while(first != NULL)
	{
		if(first->Data == No)
		{
			break;
		}

		if(No < first->Data)
		{
			first = first->Lchild;
		}
		else if(No > first->Data)
		{
			first = first->Rchild;
		}
	}

	if(first == NULL)
	{
		return FALSE;
	}
	else
	{
		return TRUE;
	}
}

void Inorder(PNODE first)
{
	if(first != NULL)
	{
		Inorder(first->Lchild);
		printf("|%d| ",first->Data);
		Inorder(first->Rchild);
	}
}

void Preorder(PNODE first)
{
	if(first != NULL)
	{
		printf("|%d| ",first->Data);		
		Preorder(first->Lchild);
		Preorder(first->Rchild);
	}
}

void Postorder(PNODE first)
{
	if(first != NULL)
	{
		Postorder(first->Lchild);
		Postorder(first->Rchild);
		printf("|%d| ",first->Data);
	}
}

int Count(PNODE first)
{
	static int cnt = 0;

	if(first != NULL)
	{
		cnt++;
		Count(first->Lchild);
		Count(first->Rchild);
	}
	return cnt;
}

int CountLeaf(PNODE first)
{
	static int cnt = 0;

	if(first != NULL)
	{
		if((first->Lchild == NULL) && (first->Rchild == NULL))
		{
			cnt++;
		}

		CountLeaf(first->Lchild);
		CountLeaf(first->Rchild);
	}

	return cnt;
}

int CountParent(PNODE first)
{
	static int cnt = 0;

	if(first != NULL)
	{
		if((first->Lchild != NULL) || (first->Rchild != NULL))
		{
			cnt++;
		}

		CountParent(first->Lchild);
		CountParent(first->Rchild);
	}

	return cnt;
}

