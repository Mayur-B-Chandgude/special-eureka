#include "Header.h"

void initq(struct Queue *q)
{
	q->front = q->rear = -1;
}

void addq(struct Queue *q)
{
	int No = 0;
	
	printf("Enter Number:");
	scanf("%d",&No);

	q->rear = (q->rear + 1) % SIZE;
	q->Data[q->rear] = No;
	if(q->front == -1)
	{
		q->front = 0;
	}
}

int delq(struct Queue *q)
{
	int No = 0;

	No = q->Data[q->front];
	q->front = (q->front + 1) % SIZE;

	if(q->front == (q->rear + 1) % SIZE)
	{
		q->front = -1;
		q->rear = -1;
	}
	
	return No;
}

void display(struct Queue *q)
{
	int temp = q->front;

	while (1)
	{
		printf("|%d| ",q->Data[temp]);
		temp = (temp + 1) % SIZE;
		if (temp == (q->rear + 1) % SIZE)
		{
			break;
		}
	}
}

int isqfull(struct Queue *q)
{
	if (q->front == (q->rear + 1) % SIZE)
	{
		return 1;
	}

	return 0;
}

int isqempty(struct Queue *q)
{
	if (q->front == -1)
	{
		return 1;
	}

	return 0;
}

