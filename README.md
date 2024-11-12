Readme.md Version# 2023.05.30 (INEW-2330 and INEW-2332 Version)

![A logo showing a pine tree and a pair of mountains on a black circle](/Icons/iconSmall.png "Summit Stash Logo")

# Summit Stash
A hybrid point of sale and marketplace application. Created for businesses to track and manage their product inventory and to provide a complete shopping experience to customers. The application was designed specifically with alpine sports gear and other similar equipment in mind, but is capable of adapting to whatever products your business requires an inventory of. Core functionality includes sales insights for management, inventory control for employees, and browsing and ordering for consumers. The application itself offers versatile customization of the inventory database allowing for easy installation and maintenance throughout its use.

## Detailed Description

Summit Stash is an inventory application that aims to provide businesses with all the tools they need to track their current product inventory, monitor stock levels, and update and revise the wares they sell. Additionally, the same application provides functionality for customers of the business to create an account and credentials with which they can purchase products in an easy and intuitive way. 

Summit Stash stores the inventory information in an external database that can be accessed by multiple devices running the application with different credentials simultaneously, thus protecting the information while making it as accessible as possible. Summit Stash includes templates for tracking a snow sports inventory that can also be easily customized by accounts with administrative privileges. Different products will require different fields for their relevant attributes, and Summit Stash helps you design your inventory database in a way that can track relevant information optimally. The business front of the application interfaces with the marketplace front in order to provide sales reports that help the business assess popular products, high-demand items, and customer activity across different times.

On the customer front, Summit Stash offers browsing capabilities by categories defined according the structure of the inventory database. Customer credentials are saved in the database, and this helps make checkout faster once personal details have been saved.

### Inventory and Inventory Control

Summit Stash will be able to inventory a variety of equiment used in snow sports.
* Skis and Snowboards
* Ski and Snowboard Boots and Bindings (and other snow footwear)
* Snow Gear (Helmets, Goggles, Gloves, etc.)
* Snow Clothes (Waterproof Jackets and Overalls)
* Miscellaneous Gear (Cameras, Poles, Stomp Pads, etc.)

Inventories will not be unlimited: Summit Stash enforces a limit on the stock available dependent on the item category (quantity is verified before query is sent to database server).

#### Inventory Example Data
Field | Data
------|------
Item Name | Never Summer Proto FR
Item Description|Aggressive all mountain snowboard. Triple camber profile.
Category|Snowboards
Retail Price|699.99
Cost|400
Quantity|36
Restock Threshold|10
Image|[Image binary (Don't need to update for this example]
Discontinued|false

### Project Introduction

#### Functionality
Summit Stash is a desktop application that asks the user for their credentials (or helps them create new ones) in order to retrieve the inventory data that is visible to them from the external Microsoft SQL Server database. This data is formatted and displayed by the application so that a customer can select what items they will purchase or an employee can see what entries need to be edited. Any purchase or modification is processed by the application and results in an appropriate Transact-SQL query that is sent to the server to update the database in real time. Purchase details are stored in the database as well and can be used to generate reports of customizable time frames to aid the business in determining which products should be restocked and when.

#### Notable Features
* By combining both the employee interface and the customer interface in one application, Summit Stash aims to be as versatile as possible in the hands of your business.
  * Inventory testing and viewing of the customer storefront is instant and can be done within the same desktop device.
  * Desktop devices can be purposed for both employee use and customer use depending on necessity without extra configuration.
  * Employee and manager administrative actions are available from any device running the application regardless of location.
* By retaining and providing reports of customer sales, business administrators can evaluate the success of individual products.
  * Reports can indicate what yearly time frames have higher activity and require more stock than usual.
  * Reports show which items are of highest demand so that they can be prioritized and lower demand items discontinued.

#### Accessibility
Summit Stash is extremely user friendly. Installation is fast and easy with only a few clicks. Configuration of the application is not needed. An integrated help system is included to explain the application functions to new users. Dependencies are kept to a minimum to get your inventory system up and running as fast as possible.

#### Development Status
Summit Stash is currently in development and prerelease is not yet available.

### Development Plan - Time Table
#### Below is the development time table and planned benchmarks/milestones to accomplish this project by the due date.
Date | Items | Description
-----|-------------|--------------
11/11/24 | Project Proposal submitted | Proposal for consideration.
11/18/24 | Logon View | Complete login functionality (validate credentials from database, present appropriate interface).
11/25/24 | Customer View | Complete shopping functionality (browse inventory catalog, create an order, check out, etc.).
12/2/24 | Manager View | Complete administrative inventory functionality (add/remove products, retrieve sales reports).
12/9/24 | Polish/Final Submission | Debug faulty functionality, refine UI elements, QOL, and ensure ease of use.

### Development Environment

Type | Description
-----|-------------
Language | C#
Development Environment | Visual Studio 2022 Community Edition
SQL Server Type/Dialect | Microsoft SQL (TSTC Server)
Target Environment | Windows 10 or Windows 11 <br>Desktop Application
Target Business/Industry | Winter Sports
Help System | Context Sensitive PDF Help Files
Report Methods | HTML Reports
Project Version Control | Git and Course assigned GitHub Repository

### Getting Started and Dependencies
Download the latest release from the releases section. Unzip the folder. Run setup.exe to install necessary components to local computer.

Currently, Summit Stash requires the latest [.NET SDK](https://dotnet.microsoft.com/en-us/download) to be installed on the computer. We are looking into
removing this dependency and making Summit Stash a completely self-contained application.

### Videos [Must Update your video entries below and add a URL for the specific topic that goes to the Google Drive video file]
- Project Proposal [Must Update with URL at each Pull Request approval]
- Logon View [Must Update with URL at each Pull Request approval]
- Customer View [Must Update with URL at each Pull Request approval]
- Manager View [Must Update with URL at each Pull Request approval]
- Video Resume [Must Update with URL at each Pull Request approval]
- Final Client Demonstration Video [Must Update with URL at each Pull Request approval]
- URL for any other specific videos for this product [Must Update with URL at each Pull Request approval, if applicable]

### Contact

Contact | Information
--------|------
Name | Benjamin Flores
Email | bflores133514@mymail.tstc.edu

### [License](/LICENSE)

GNU General Public License v3.0

Permissions of this strong copyleft license are conditioned on making available complete source code of licensed works and modifications, which include larger works using a licensed work, under the same license. Copyright and license notices must be preserved. Contributors provide an express grant of patent rights.
