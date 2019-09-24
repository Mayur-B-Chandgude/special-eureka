#include<stdio.h>
#include<malloc.h>

struct Node
{
	int Data;
	struct Node *Next , *Prev;
};

typedef struct Node NODE;
typedef struct Node* PNODE;
typedef struct Node** PPNODE;

typedef int BOOL;

#define TRUE	1
#define FALSE	0

BOOL InsertFirst(PPNODE , PPNODE);
BOOL InsertLast(PPNODE , PPNODE);
BOOL InsertAtPos(PPNODE , PPNODE);

BOOL DeleteFirst(PPNODE , PPNODE);
BOOL DeleteLast(PPNODE , PPNODE);
BOOL DeleteAtPos(PPNODE , PPNODE);

void DisplayForward(PNODE , PNODE);

void DisplayReverse(PNODE , PNODE);

int SearchFirstOccurance(PNODE , PNODE);

int Count(PNODE , PNODE);
