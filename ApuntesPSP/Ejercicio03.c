#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>

int main(){
	printf("Ejercicio 03 \n");
	pid_t id = fork();
	pid_t id02;
	
	if(id == 0)//hijo
	{
		id02 = fork();
		if(id == 0)
		{
			
		}
	}
}
