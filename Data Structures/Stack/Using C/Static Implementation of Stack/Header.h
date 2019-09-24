#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<malloc.h>

#define SIZE 5

struct Stack
{
	int Data [SIZE];
	int Top;
};

//typedef struct Stack NODE;
typedef struct Stack* PNODE;

typedef int BOOL;

#define TRUE	1
#define FALSE	0

void InitStack(PNODE);

void Push(PNODE);
int Pop(PNODE);

BOOL isEmpty(PNODE);
BOOL isFull(PNODE);

void Display(PNODE);
