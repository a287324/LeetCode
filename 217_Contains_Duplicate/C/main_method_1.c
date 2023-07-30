#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

// sub-function
int comp (const void * a, const void * b) {
   return ( *(int*)a - *(int*)b );
}

bool containsDuplicate(int* nums, int numsSize) {
    qsort(nums, numsSize, sizeof(int), comp);
    for (int i = 0; i < numsSize - 1; i++) {
        if (nums[i] == nums[i+1]) return true;
    }
    return false;
}
// main function
int main(void) {
	// int nums[] = {1,2,3,1};
	int nums[] = {1,2,3,4};
	// int nums[] = {1,1,1,3,3,4,3,2,4,2};
	int numsSize = sizeof(nums) / sizeof(int);

	if(containsDuplicate(nums, numsSize)) {
		printf("True\n");
	} else {
		printf("False\n");
	}
	return 0;
}
