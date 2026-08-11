### TEAM MEMBER NAMES:
* MORONI ALANIS NAVARRO


# BookTracker

BookTracker is a .NET Blazor Web application designed to help users
organize and track their personal book collections.

Users can create an account, add books to their personal library,
track reading progress, manage reading status, add notes, and rate 
their books.

---

## Project Overview

BookTracker was developed as a Blazor Web Application using ASP.NET Core 
and C#.

The application is designed for readers who want a simple way to organize their books and keep track of their reading progress in one place.

Each user has a personal library where they can manage their own books
after creating an account ang logging in.

## Application Structure

The application is organized into several main areas:
## Components

Contains the Blazor pages and user interface components used by the application.

Example include:

- Home
- Login 
- Register
- Library
- Add book
- Edit Book

## User Guide

### 1. Creating an Account

1. Open BookTracker.
2. Select **Register** from the navigation menu.
3. Enter your Full Name, email and password.
4. Select the **Register** button.
5. After registration, you'll be redirected to the Login page.

### 2. Logging In

1. Enter your email and password.
2. Select the **Login** button.
3. After successful authentication, you'll be redirected to the Home page.

### 3. Adding a Book

1. Open **Library**.
2. Select **Add Book**.
3. Enter the book information.
4. Select the **Add Book** button.
5. The book will be displayed in your personal library.

### 4. Managing Books

In the Library, users can:

- Create books.
- Edit book information.
- Delete books.
- Update reading progress.
- Change the reading status.
- Add or edit notes.
- Rate books from 1 to 5 stars.

### 5. Reading progress

Users can update their current page using the progress control on the book card. BookTracker automatically calculates the percentage of the book that has been completed.

### 6. Rating Books

Users can rate a book directly from its card.

Hover over the stars to preview a rating and click a star to save the selected rating.

### 7. Logging Out

Select **Logout** from the navigation menu to end the current session.