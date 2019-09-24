#include<stdio.h>

#define SIZE	10

struct Hash
{
	int key , chain;
};

struct Hash b[SIZE];
int cnt;

void Insert();
void Delete();

void Display();

int Search();
