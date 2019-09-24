#include<stdio.h>
#include<fcntl.h>
#include<unistd.h>
#include<string.h>

int main()
{
	char str[] = "Mayur B Chandgude";
	char Buffer[1024] = {'\0'};

	int fd[2] = {0};

	char *ptr1 , *ptr2;

	ptr1 = str;
	ptr2 = Buffer;

	while(*ptr1 != '\0')
	{
		*ptr2 = *ptr1;

		ptr1++;
		ptr2++;
	}

	pipe(fd);

	write(fd[1] , Buffer , strlen(Buffer));

	read(fd[0] , Buffer , sizeof(Buffer));

	write(1 , Buffer , strlen(Buffer));

	return 0;

}
