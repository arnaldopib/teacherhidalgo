// vETOR.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int main()
{
	int vetor[10];
	int contador = 0;
	for (contador = 0; contador < 10; contador++) {
		printf("Informe o valor do vetor na posicao"+ contador);
		scanf("%d", &vetor[contador]);
	}

    return 0;
}

