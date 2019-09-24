#include<stdio.h>
#include<malloc.h>
#include<stdlib.h>

struct Node
{
	int Data;
	struct Node *Next;
};

struct Node *front , *rear;

void addq();

int delq();

void displayq();

int isqempty();

void initq();
