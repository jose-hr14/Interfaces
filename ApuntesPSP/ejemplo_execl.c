#include <stdio.h>
#include <unistd.h>

int main(){
	printf("Lanzamos el comando ls con execl \n"); //sin el salto de linea, el execl se carga esta línea también
	execl("/bin/ls", "-l", "NULL"); //sustituye el proceso anterior por el actual
	printf();//no se mostrará en pantalla porque lanza el ls y sustituye el proceso actual por el nuevo
}
