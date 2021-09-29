#include <stdio.h>
#include <unistd.h>

int main(){
	printf("Lanzamos un nuevo proceso \n");
	pid_t pid = fork();
	if(pid == 0){
		printf("Soy el proceso hijo \n");
	}
	else{
		printf("Soy el proceso padre \n");
	}		
}
