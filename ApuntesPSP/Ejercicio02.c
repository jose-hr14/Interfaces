#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>

int main(){
	printf("Ejercicio 02 \n");
	int i;
	pid_t id = fork();
	if(id == 0)
	{
		printf("Soy el proceso hijo \n");
		for(i = 10; i > 0; i--)
		{
			printf("%d \n", i);
		}
	}
	else
	{
		printf("Soy el proceso padre \n");
		for(i = 1; i <= 10; i++)
		{
			printf("%d \n", i);
		}		
	}
	for(i = 0; i <= 10; i++)
	{
		
	}
}
