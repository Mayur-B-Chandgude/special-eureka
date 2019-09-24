#include<stdio.h>
#include<fcntl.h>

void Display();

int main()
{
	Display();

	return 0;
}

void Display()
{
	FILE *fp = NULL;

	fp = fopen("Demo.txt" , "r");
	if(fp == NULL)
	{
		printf("Unable to open File..\n");
		return;
	}

	fclose(fp);
}
