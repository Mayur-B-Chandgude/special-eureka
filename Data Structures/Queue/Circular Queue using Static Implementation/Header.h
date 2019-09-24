#include<stdio.h>
#include<malloc.h>
#include<stdlib.h>

#define SIZE	5

struct Queue
{
	int Data[SIZE];
	int front , rear;	
};

void initq(struct Queue *);

void addq(struct Queue *);

int delq(struct Queue *);

void display(struct Queue *);

int isqempty(struct Queue *);

int isqfull(struct Queue *);

