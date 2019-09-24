#include<string.h>
#include<stdio.h>
#include<stdlib.h>
#include<malloc.h>

struct node
{
	int Data;
	struct node *Next , *Prev;
};

typedef struct node NODE;
typedef struct node* PNODE;
typedef struct node** PPNODE;

typedef int BOOL;

#define TRUE	1
#define FALSE	0

BOOL InsertFirst(PPNODE);
BOOL InsertLast(PPNODE);
BOOL InsertAtPos(PPNODE);

BOOL DeleteFirst(PPNODE);
BOOL DeleteLast(PPNODE);
BOOL DeleteAtPos(PPNODE);

int SearchFirstOccurance(PNODE);

void Display(PNODE);

int Count(PNODE);
