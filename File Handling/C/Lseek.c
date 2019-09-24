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
	int fd , ret = 0;
	char Arr[50];

	fd = open("Demo.txt" , O_RDONLY);
	if(fd == -1)
	{
		printf("File is not Found..\n");
		return;
	}

	lseek(fd , 0 , 0);
	ret = read(fd , Arr , 5);
	
	write(1 , Arr , 5);

	close(fd);
}
