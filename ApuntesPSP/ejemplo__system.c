#include <stdio.h>
#include <stdlib.h>

int main(){
	printf("Enlazamos el programa ls \n");
	int error = system("ls");
	printf("El código de error devuelto es: %d", error);
}
