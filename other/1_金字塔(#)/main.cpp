#include <iostream>

using namespace std;

int main(void) {
    for(int i = 1 ; i <= 7; ++i) {
        for(int j = 7-i; j > 0; --j) {
            printf(" ");
        }
        for(int j = i; j > 0; --j) {
            printf("#");
        }
        printf("  ");
        for(int j = i; j > 0; --j) {
            printf("#");
        }
        printf("\n");
    }
}