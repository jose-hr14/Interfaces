#include <stdio.h>
#include <unistd.h>

int main(){
	printf("Lanzamos un nuevo proceso \n");
	pid_t pid = fork();
	if(pid == 0){
		//Codigo ejecutado por el proceso hijo
		printf("Soy el proceso hijo \n");
		pid_t id = getpid();
		printf("H: Mi identificador es %d \n", id);
		pid_t idParent = getppid();
		printf("H: El identificador de mi padre es %d \n", idParent);
	}
	else{
		//Codigo ejecutado por el proceso padre
		printf("Soy el proceso padre \n");
		pid_t id = getpid();
		printf("P: Mi identificador es %d \n", id);
		pid_t idParent = getppid();
		printf("P: El identificador de mi padre es %d \n", idParent);
	}		
}
