#include<stdio.h>
#include<malloc.h>

struct Node
{
	int data;
	struct Node *next;
};

typedef struct Node NODE;
typedef struct Node* PNODE;
typedef struct Node** PPNODE;

typedef int BOOL;

#define TRUE	1
#define FALSE	0

BOOL InsertFirst(PPNODE);
BOOL InsertLast(PPNODE);
BOOL InsertAtPos(PPNODE);

BOOL DeleteFirst(PPNODE);
BOOL DeleteLast(PPNODE);
BOOL DeleteAtPos(PPNODE);

void Display(PNODE);

int Count(PNODE);
