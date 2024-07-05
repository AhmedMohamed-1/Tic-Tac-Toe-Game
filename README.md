# Tic Tac Toe Game

This project is a simple Tic Tac Toe game implemented using C# and WinForms. The game allows two players to play Tic Tac Toe with a graphical user interface, where players can click on the PictureBoxes to make their moves. The game detects wins, losses, and draws and updates the UI accordingly.

![Screenshot (189)](https://github.com/AhmedMohamed-1/Tic-Tac-Toe-Game/assets/140642488/30b372b6-2c6a-4e3b-bf21-e5b45c7291b1)

## Features

- Two-player Tic Tac Toe game.
- Visual representation of the game board using PictureBoxes.
- Detection of wins, losses, and draws.
- Reset functionality to start a new game.
- Links to the developer's GitHub and LinkedIn profiles.

## Note
- **Not Responsive**: This application is not responsive to different sizes.
  
## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/tic-tac-toe-game.git
   ```

2. Open the solution file (`Tic_Tac_Toe_Game.sln`) in Visual Studio.

3. Build and run the project.

## Usage

1. Run the application.
2. Players take turns clicking on the PictureBoxes to make their moves.
3. The game will highlight the winning combination and display the winner or indicate a draw if there are no more moves left.
4. Click the "Start Again" button to reset the game board and play another game.
5. Use the "Exit" button to close the application.
6. Click the GitHub or LinkedIn buttons to visit the developer's profiles.

## Code Overview

### MainForm.cs

This file contains the main logic for the game:

- `MainForm` class: Initializes the form and contains the game logic.
- `IsDraw()`: Checks if the game is a draw.
- `Return_Picture_Box_Properties()`: Resets the PictureBox properties for a new game.
- `Disable_Enable_Picture_boxes()`: Enables or disables the PictureBoxes.
- `PictureBox_Click()`: Handles the click events for the PictureBoxes and updates the game state.
- `GameLogic()`: Checks for winning combinations or a draw.
- `IsWinningCombination()`: Checks if a set of three PictureBoxes contains a winning combination.
- `Draw_Lines()`: Draws the grid lines on the game board.
- `bt_Exit_Click()`: Closes the application.
- `bt_Start_Again_Click()`: Resets the game board to start a new game.
- `Github_button_Click()`: Opens the developer's GitHub profile.
- `Linkedin_button_Click()`: Opens the developer's LinkedIn profile.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

- GitHub: [AhmedMohamed-1](https://github.com/AhmedMohamed-1)
- LinkedIn: [Ahmed Mohamed](https://www.linkedin.com/in/ahmed-mohamed-0a6086285)
