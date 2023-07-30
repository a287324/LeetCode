#include <iostream>
// Factorial
int F(int n) {
	int ans = 1;
	for(int i = 1; i <= n; ++i) {
		ans *= i;
	}
	return ans;
}
// Combination
int C(int n, int r) { 
	return F(n)/(F(n-r)*F(r));
}
// Pascal's Triangle
void PascalTriangle(int n) {
	for(int i = 0; i < n; ++i) {
		for(int j = 0; j <= i; ++j) {
			printf("%d ", C(i, j));
		}
		printf("\n");
	}
}
// main function
int main(void) {
	PascalTriangle(10);
	return 0;
}