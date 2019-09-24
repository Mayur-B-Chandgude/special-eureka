int printf(char *,...);
#include<fcntl.h>
#include<unistd.h>

int main(int cnt , char *Arr[])
{
	int fd = 0;
	char LocalBuffer[256] = "Mayur";

	if(cnt <= 1)
	{
		printf("ERROR: Insufficient Arguments..\n");
		return -1;
	}

	fd = open(Arr[1] , O_WRONLY);
	if(fd == -1)
	{
		printf("ERROR: Unable to open..\n");
		return -1;
	}
	else
	{
		printf("File is Successfully open with FD:%d\n",fd);
	}

	write(fd , LocalBuffer , sizeof(LocalBuffer));

	lseek(fd , 1024 , 1);

	write(fd , LocalBuffer , 5);

	close(fd);

	return 0;
}
