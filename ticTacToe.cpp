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

	int counter = 0;
	int gameLimit = 0;
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

		char& current = currentPlayer;

		std::cout << "It is " << currentPlayer << "'s turn. Where would you like to play?: " << std::endl;
		int input;
		std::cin >> input;

		bool validInput = true; int counter = 0;
		do {
			if (counter == 1) {
				std::cout << "Invalid location, please enter another location:" << std::endl;
				std::cin >> input;
				counter--;
			}
			switch (input) {
			case 1:
				if (functions::isSpaceTaken(board, rows, cols, 0, 0)) {
					board[0][0] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 2:
				if (functions::isSpaceTaken(board, rows, cols, 0, 2)) {
					board[0][2] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 3:
				if (functions::isSpaceTaken(board, rows, cols, 0, 4)) {
					board[0][4] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 4:
				if (functions::isSpaceTaken(board, rows, cols, 2, 0)) {
					board[2][0] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 5:
				if (functions::isSpaceTaken(board, rows, cols, 2, 2)) {
					board[2][2] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 6:
				if (functions::isSpaceTaken(board, rows, cols, 2, 4)) {
					board[2][4] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 7:
				if (functions::isSpaceTaken(board, rows, cols, 4, 0)) {
					board[4][0] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 8:
				if (functions::isSpaceTaken(board, rows, cols, 4, 2)) {
					board[4][2] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			case 9:
				if (functions::isSpaceTaken(board, rows, cols, 4, 4)) {
					board[4][4] = currentPlayer;
					validInput = false;
					break;
				}
				else {
					counter++;
					continue;
				}
			}
		} while (validInput);
		
		gameLimit++;
		if (gameLimit == 9) {
			std::cout << "It is a draw...";
		}

	} while (counter < 100);

};


