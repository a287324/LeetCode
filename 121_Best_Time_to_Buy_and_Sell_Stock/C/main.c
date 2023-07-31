#include <stdio.h>
#include <stdlib.h>

int maxProfit(int* prices, int pricesSize){
	int buy = prices[0];
	int profit = 0, varProfit = 0;
	for(int i = 1; i < pricesSize; ++i) {
		if(buy > prices[i]) {
			buy = prices[i];
		} else {
			varProfit = prices[i] - buy;
		}
		if(varProfit > profit) {
			profit = varProfit;
		}
	}
	return profit;
}

int main () {
	int prices[] = {7,1,5,3,6,4};
	// int prices[] = {7,6,4,3,1};
	// int prices[] = {2,4,1};
	int pricesSize = sizeof(prices) / sizeof(int);

	printf("%d\n", maxProfit(prices, pricesSize));

	return 0;
}