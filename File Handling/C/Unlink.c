#include<stdio.h>
#include<fcntl.h>

int main()
{
	char Arr[50];	
	int fd = 0;
	
	printf("Enter File Name:\n");
	scanf(" %['\n']s",Arr);

	fd = open(Arr , O_RDONLY);

	read(fd , Arr , 0);

	unlink(fd);

	return 0;
}
