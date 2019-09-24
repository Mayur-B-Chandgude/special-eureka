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
	int fd = 0;

	fd = creat("Hello.txt" , 0x777);
	if(fd == -1)
	{
		printf("Unable to create new File..\n");
		return;
	}
	else
	{
		printf("New File is created with FD:%d\n",fd);
		return;
	}
}
