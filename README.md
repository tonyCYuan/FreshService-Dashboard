# FreshService Dashboard

A WPF desktop application that provides a convenient dashboard to view and search Freshservice tickets.

## Features

- **Current Tickets Dashboard**: View all open tickets assigned to you
- **Ticket History**: Access and review closed/resolved tickets
- **Search Functionality**: Search through tickets by keyword
- **Ticket Details View**: View comprehensive ticket information

## Requirements

- Windows 10 or later
- .NET 9.0 or later
- Freshservice account with API access

## Setup Instructions

1. **Clone or download the repository**

2. **Configure your Freshservice API credentials**
   - Open `App.config` file
   - Update the `FreshserviceApiKey` value with your Freshservice API key
   - Update the `FreshserviceDomain` value with your Freshservice domain

3. **Build and run the application**
   - Open the solution in Visual Studio
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5)

## Configuration

The application uses the `App.config` file to store configuration values.

## Usage

1. **Dashboard**: The application opens to the dashboard showing your current tickets.
2. **Ticket History**: Click the "Ticket History" tab to view closed tickets.
3. **Search**: Click the "Search" tab, enter a keyword, and click "Search" to find tickets.
4. **Ticket Details**: Click on any ticket in the list to view its details in the right panel.