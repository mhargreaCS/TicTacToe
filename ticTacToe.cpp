#include <iostream>

class functions {
public:
	static void print(char i[][5], int rows, int cols) {
		for (int x = 0; x < rows; x++) {
			for (int y = 0; y < cols; y++) {
				std::cout << i[x][y] << ' ';  
			}
			std::cout << std::endl;
		}
	}
	static bool isSpaceTaken(char i[][5], int rows, int cols, int x, int y) {
		if (i[x][y] != ' ') {
			return false;
		}
		else {
			return true;
		}
	}
};


int main() {
	const int rows = 5;
	const int cols = 5;

	char board[rows][cols] = { { ' ','|', ' ', '|', ' ' },
									          {'-', '-', '-',  '-', '-'},
									          { ' ','|', ' ', '|', ' ' },
									          {'-', '-', '-',  '-', '-'},
									          { ' ','|', ' ', '|', ' ' } };

	functions::print(board, rows, cols);

	int counter = 0;
	do {
		functions::print(board, rows, cols);

		char currentPlayer = ' ';
		if ((counter % 2) == 0) {
			currentPlayer = 'X';
			counter++;
		}
		else {
			currentPlayer = 'O';
			counter++;
		}

		std::cout << "It is " << currentPlayer << "'s turn. Where would you like to play?: " << std::endl;
		int input;
		std::cin >> input;

		switch (input) {
			case 1:
				board[0][0] = currentPlayer;
				break;
			case 2: 
				board[0][2] = currentPlayer;
				break;
			case 3: 
				board[0][4] = currentPlayer;
				break;
		}

	} while (counter < 100);

};
