# Book-Forms

## Overview
- A C# Windows Forms application designed for library management.
- Includes multiple forms for different user roles and functionalities.
- Connects to a SQL Server database for data storage and retrieval.

## Forms and Features
- **Form1**:
  - Displays a list of books in the library.
  - Uses a `DataGridView` to show book details such as book ID, name, author, translator, publisher, publication date, section, and borrow ID.
  - Retrieves data from the `book` table in the SQL Server database.

- **Form2**:
  - Handles user login.
  - Verifies credentials against the `member` and `library_staff` tables.
  - Directs members to `Form3` and library staff to `Form5` upon successful login.

- **Form3**:
  - Displays member details, penalties, and borrowed books.
  - Retrieves data from the `member`, `penalty`, and `borrow` tables.
  - Allows members to search for books and navigate to `Form4` for book borrowing or reservation.

- **Form4**:
  - Allows members to search for books by author or title.
  - Displays search results with options to borrow or reserve books.
  - Handles book borrowing and reservation transactions.

- **Form5**:
  - Displays library staff details and member management options.
  - Allows library staff to accept or reject book borrowing requests.
  - Provides options to remove members and add new members.

## Database
- **Connection String**: `Data Source=DANIAL\\SQLEXPRESS;Initial Catalog=libraryTemp;Integrated Security=SSPI`
- **Tables**:
  - `book`: Stores book details.
  - `member`: Stores member details.
  - `library_staff`: Stores library staff details.
  - `borrow`: Stores borrowing transactions.
  - `penalty`: Stores penalty details.

## Main Functionalities
- **Data Retrieval and Display**: Uses SQL queries to fetch data from the database and display it in `DataGridView` controls.
- **User Authentication**: Validates user credentials and directs them to appropriate forms based on their roles.
- **Book Borrowing and Reservation**: Allows members to borrow or reserve books based on availability.
- **Member Management**: Enables library staff to manage member details, borrowing requests, and penalties.
