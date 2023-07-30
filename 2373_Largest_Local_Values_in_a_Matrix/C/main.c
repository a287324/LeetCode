#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// sub-function
int** largestLocal(int** matrix, int matrixSize, int* matrixColSize, int* returnSize, int** returnColumnSizes){
	// parameter
    *returnSize = matrixSize - 2;
    *returnColumnSizes = (int*)malloc(sizeof(int) * (*returnSize));
    for (int i = 0; i < *returnSize; i++) {
        (*returnColumnSizes)[i] = *matrixColSize - 2;
    }
	// res
    int** res = (int**)malloc(sizeof(int*) * (*returnSize));
    for (int i = 0; i < *returnSize; i++) {
        res[i] = (int*)malloc(sizeof(int) * (*matrixColSize - 2));
        memset(res[i], 0, sizeof(int) * (*matrixColSize - 2));
    }
	// largestLocal
	for(int i = 1; i < matrixSize-1; ++i) {
		for(int j = 1; j < matrixSize-1; ++j) {
			int max = 0;
			for(int k = -1; k <= 1; ++k) {
				for(int m = -1; m <= 1; ++m) {
					if(max < matrix[i+k][j+m]) {
						max = matrix[i+k][j+m];
					}
				}
			}
			res[i-1][j-1] = max;
		}
	}
	return res;
}


// main function
int main(void) {
	int arr[4][4] = {{9,9,8,1},{5,6,2,6},{8,2,6,4},{6,2,2,2}};
	int **matrix;
	int matrixSize = 4;
	int matrixColSize[4] = {4,4,4,4};
	int returnSize;
	int *returnColumnSizes;
	int **ans;

	// matrix initialize
	matrix = (int**)malloc(sizeof(int*)*4);
	matrix[0] = (int*)malloc(sizeof(int)*16);
	for(int i = 1; i < 4; ++i) {
		matrix[i] = matrix[i-1] + i;
	}
	for(int i = 0; i < 4; ++i) {
		for(int j = 0; j < 4; ++j) {
			matrix[i][j] = arr[i][j];
		}
	}
	// 
	returnColumnSizes = (int*)malloc(sizeof(int)*4);

	// largestLocal
	ans = largestLocal(matrix, matrixSize, matrixColSize, &returnSize, &returnColumnSizes);
	
	// display result
	for(int i = 0; i < returnSize; ++i) {
		for(int j = 0; j < returnSize; ++j) {
			printf("%5d", ans[i][j]);
		}
		printf("\n");
	}
	return 0;
}
