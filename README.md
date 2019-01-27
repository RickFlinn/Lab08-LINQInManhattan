# Lab08-LINQInManhattan

This program takes in a data set of location information for properties in Manhattan in JSON format, converts it into .NET objects using NewtonSoft's JSON.NET library, and then makes several queries against that data. 



## JSON Object classes
A number of classes are included to instantiate .NET versions of the objects given to us in the JSON file.

### `RootObject`
Corresponds to the root JSON object. Contains properties for a string Type and a  List of `Feature` objects.

### `Feature` 
Represents and holds data for an individual piece of property, including the type of property, its geographical location, 
and its characteristics, as properties string `Type`, `Geometry` `Geometry`, and `Properties` `Properties`, respectively.

### `Geometry`
Class that holds coordinates for a piece of property; has properties string `Type` and `List` `Coordinates`.

### `Properties`
Holds address location data for a piece of property. Has string properties `Zip`, `City`, `State`, `Address`, `Borough`, `Neighborhood`, and `County`.


## Queries and Output

The following queries have been implemented, printing to Console:
 - Output all neighborhoods in the data list
 - Filter out neighborhoods that do not have any names
 - Remove duplicate information
 - Query that performs all of the above functions
 

 ```
 ************************************************

All neighborhood values:
Chelsea
Lower East Side
Gramercy Park
Financial District
Civic Center
Financial District
Tribeca

East Village
Gramercy Park
Chelsea
Greenwich Village, SoHo
SoHo, Tribeca
Greenwich Village
Kips Bay, Murray Hill
Midtown East
Garment District
Midtown West
Diamond District, Midtown
Upper East Side
Midtown East
Upper West Side
Upper West Side
Manhattan Valley
Harlem
Morningside Heights, Harlem
Upper East Side
Spanish Harlem
Harlem
Sugar Hill, Upper Manhattan
Washington Heights
Hudson Heights
Inwood
East Harlem
Hell's Kitchen
Harlem
Civic Center
Upper Manhattan
Hudson Heights
Financial District
Financial District
Roosevelt Island
Financial District
Midtown
Midtown
Hunter College, Rockefeller University
Upper West Side
Upper East Side
Battery Park City
Financial District
Midtown
Financial District


Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Hell's Kitchen
Midtown
Midtown
Midtown

Chelsea
Manhattanville
Chelsea
Chelsea
Murray Hill
Garment District
Garment District
Garment District
Garment District
Garment District
Midtown
Upper West Side
Midtown
Carnegie Hill
Midtown
Yorkville
Lenox Hill
Upper West Side
Upper West Side
Chelsea
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Chelsea
Murray Hill
Kips Bay
Kips Bay
Financial District
Upper East Side
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Murray Hill
Midtown
Midtown
Midtown East
Murray Hill
Midtown
Midtown
Garment District
Financial District
East Village
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Gramercy Park
Financial District
Financial District
Financial District
South Cove
Battery Park City
Battery Park City
Battery Park City
Battery Park City
Battery Park City
************************************************

All named neighborhoods:
Chelsea
Lower East Side
Gramercy Park
Financial District
Civic Center
Financial District
Tribeca
East Village
Gramercy Park
Chelsea
Greenwich Village, SoHo
SoHo, Tribeca
Greenwich Village
Kips Bay, Murray Hill
Midtown East
Garment District
Midtown West
Diamond District, Midtown
Upper East Side
Midtown East
Upper West Side
Upper West Side
Manhattan Valley
Harlem
Morningside Heights, Harlem
Upper East Side
Spanish Harlem
Harlem
Sugar Hill, Upper Manhattan
Washington Heights
Hudson Heights
Inwood
East Harlem
Hell's Kitchen
Harlem
Civic Center
Upper Manhattan
Hudson Heights
Financial District
Financial District
Roosevelt Island
Financial District
Midtown
Midtown
Hunter College, Rockefeller University
Upper West Side
Upper East Side
Battery Park City
Financial District
Midtown
Financial District
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Hell's Kitchen
Midtown
Midtown
Midtown
Chelsea
Manhattanville
Chelsea
Chelsea
Murray Hill
Garment District
Garment District
Garment District
Garment District
Garment District
Midtown
Upper West Side
Midtown
Carnegie Hill
Midtown
Yorkville
Lenox Hill
Upper West Side
Upper West Side
Chelsea
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Chelsea
Murray Hill
Kips Bay
Kips Bay
Financial District
Upper East Side
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Midtown
Murray Hill
Midtown
Midtown
Midtown East
Murray Hill
Midtown
Midtown
Garment District
Financial District
East Village
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Financial District
Gramercy Park
Financial District
Financial District
Financial District
South Cove
Battery Park City
Battery Park City
Battery Park City
Battery Park City
Battery Park City
************************************************

Non-duplicate neighborhoods
Chelsea
Lower East Side
Gramercy Park
Financial District
Civic Center
Tribeca

East Village
Greenwich Village, SoHo
SoHo, Tribeca
Greenwich Village
Kips Bay, Murray Hill
Midtown East
Garment District
Midtown West
Diamond District, Midtown
Upper East Side
Upper West Side
Manhattan Valley
Harlem
Morningside Heights, Harlem
Spanish Harlem
Sugar Hill, Upper Manhattan
Washington Heights
Hudson Heights
Inwood
East Harlem
Hell's Kitchen
Upper Manhattan
Roosevelt Island
Midtown
Hunter College, Rockefeller University
Battery Park City
Manhattanville
Murray Hill
Carnegie Hill
Yorkville
Lenox Hill
Kips Bay
South Cove
************************************************

Unique, named neighborhoods
Chelsea
Lower East Side
Gramercy Park
Financial District
Civic Center
Tribeca
East Village
Greenwich Village, SoHo
SoHo, Tribeca
Greenwich Village
Kips Bay, Murray Hill
Midtown East
Garment District
Midtown West
Diamond District, Midtown
Upper East Side
Upper West Side
Manhattan Valley
Harlem
Morningside Heights, Harlem
Spanish Harlem
Sugar Hill, Upper Manhattan
Washington Heights
Hudson Heights
Inwood
East Harlem
Hell's Kitchen
Upper Manhattan
Roosevelt Island
Midtown
Hunter College, Rockefeller University
Battery Park City
Manhattanville
Murray Hill
Carnegie Hill
Yorkville
Lenox Hill
Kips Bay
South Cove
 ```
