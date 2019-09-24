#include<stdio.h>
#include<fcntl.h>

void Display(char*);

int main()
{
	char Arr[20];

	Display(Arr);

	return 0;
}

void Display(char Arr[])
{
	int fd = 0;

	fd = open("Demo.txt" , O_RDONLY);
	if(fd == -1)
	{
		printf("Unable to open File..\n");
		return;
	}

	read(fd , Arr , 5);
	printf("Data From file is:%s\n",Arr);

	close(fd);
}
