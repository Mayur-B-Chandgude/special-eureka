#include<stdio.h>
#include<fcntl.h>

int main()
{
	char Arr[] = "Mayur B Chandgude";
	int fd = 0;
	
	fd = open("Demo.txt" , O_WRONLY);
	if(fd == -1)
	{
		printf("Unable to open File..\n");
	}
	else
	{
		printf("File is Successfully open with FD:%d\n",fd);
	}

	write(fd , Arr , 10);
	close(fd);

	return 0;
}
