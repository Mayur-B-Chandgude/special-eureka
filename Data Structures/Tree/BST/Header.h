#include<stdio.h>
#include<malloc.h>
#include<stdlib.h>

struct Node
{
	struct Node *Lchild;
	int Data;
	struct Node *Rchild;
};

typedef struct Node NODE;
typedef struct Node* PNODE;
typedef struct Node** PPNODE;

#define TRUE	1
#define FALSE	0

typedef int BOOL;

void Insert(PPNODE);

BOOL Search(PNODE);

void Inorder(PNODE);
void Postorder(PNODE);
void Preorder(PNODE);

int Count(PNODE);
int CountLeaf(PNODE);
int CountParent(PNODE);
