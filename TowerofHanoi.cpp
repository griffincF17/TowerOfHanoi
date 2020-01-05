//Programmer: Cody Griffin
//Date: 1/5/2020
//Program: Tower of Hanoi

#include <iostream>

//Tower function to print the steps needed to solve the Tower of Hanoi
void Tower(int sz, int start, int tmp, int end){
    //Base case: if size is 1, move peg from start to end
    if(sz == 1) {
        std::cout << start << "-->" << end << '\n';
    }
    
    //Recursive case: if size is greater than 1, calls Tower until sz is 1.
    //Then, it prints the step needed to move a peg from start to end for the size passed in
    //Finally, calls Tower again to take care of any pegs in tmp
    else {
        Tower(sz - 1, start, end, tmp);
        std::cout << start << "-->" << end << '\n';
        Tower(sz - 1, tmp, start, end);
    }
}//end Tower

int main() {
    //Variable for the tower's size
    int size;
    
    //Asks user to enter the tower's size
    std::cout << "Enter the tower size: ";
    std::cin >> size;
    std::cout << '\n';
    
    //Prints each step to solving the Tower of Hanoi
    std::cout << "Solving the Tower of Hanoi..." << '\n';
    Tower(size, 1, 2, 3);
    return 0;
}//end main
    
