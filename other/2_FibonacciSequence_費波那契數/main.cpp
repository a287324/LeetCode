#include <iostream>
void FibonacciSequence(int n) {
	int t1 = 0, t2 = 1, nextTerm;
	for(int i = 0; i < n; ++i) {
		if(i == 0) {
			printf("%d, ", t1);
			continue;
		}
		if(i == 1) {
			printf("%d, ", t2);
			continue;
		}
		nextTerm = t1 + t2;
		t1 = t2;
		t2 = nextTerm;
		printf("%d, ", nextTerm);
	}
}
int main(void) {
	FibonacciSequence(10);
}