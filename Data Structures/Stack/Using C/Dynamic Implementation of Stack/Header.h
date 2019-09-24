#include<stdio.h>
#include<malloc.h>
#include<stdlib.h>
#include<string.h>

struct Node
{
	int Data;
	struct Node *Next;
};

struct Node *top;

void InitStack();

void Push();
int Pop();

int isEmpty();

void Display();
