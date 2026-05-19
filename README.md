# Tic-Tac-Chess

TicTacChess (TTC) is a 2-player strategy game played on a 3×3 board.  
Each player has **three chess pieces**: **Queen, Rook, and Knight**. The pieces move like standard chess.

**Goal:** be the first to get **all three of your pieces in a row** (horizontal, vertical, or diagonal).

---

## About

TicTacChess is a custom 2-player strategy game inspired by tic-tac-toe and chess, built in C# WinForms.

The project includes a custom steampunk-themed interface with chess-inspired pieces and a 3×3 tactical board.

---

## Game Rules

- The board is **3×3**
- **2 players**
- Each player controls:
  - **Queen**
  - **Rook**
  - **Knight**
- Players take turns and **move exactly one piece per turn**
- A player wins when their **three pieces form a straight line**
  - Horizontal / Vertical / Diagonal

---

## Starting Setup

- **White** pieces start in the **bottom row**
- **Black** pieces start in the **top row**
- The order of pieces in each row is decided by a player  
  (the order can be different for white and black)
- **Important rule:** the starting positions **can never already be a winning line**

---

## How Pieces Move

- **Queen:** any number of squares horizontally or vertically (within the 3×3 board)
- **Rook:** any number of squares horizontally or vertically (within the 3×3 board)
- **Knight:** L-shape move (like chess)

> Note: Movement is restricted by the 3×3 board boundaries.

---

## Technologies Used

- Language: **C#**
- Project type: **WinForms**

---

## Robot Integration

This project was also integrated with a physical Arduino-powered robot system developed during college.

The robot was capable of:

- detecting moves made in the game
- and recreating those moves on a physical board automatically

Before using the robot, it must first be calibrated/reset using the:

`Zero Robot`

button found in the application interface.

Robot functionality can also be enabled or disabled directly in code using:

private bool useRobot = false;

false → robot disabled

true → robot active

---

## Roadmap (Planned)

- Add clear UI / board display
- Move validation
- Win detection
- Restart / new game option
- Cleaner architecture (GameManager, Board, Pieces)

---

## License

This project is for learning / school purposes.
