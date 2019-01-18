# Lab08-LINQInManhattan

This program takes in a data set of location information for properties in Manhattan in JSON format, allows us to make 
queries against that data.



## JSONObjectParser
Class that takes in a file path to a JSON file. Contains one public method, `DeserializeFeatures`, that returns a 
`FeatureCollection` object containing the property data. 


## JSON Object classes
A number of classes are included to instantiate .NET versions of the objects given to us in the JSON file.

### `FeatureCollection`
`IEnumerable` collection, with a single property that holds an array of `Feature` objects.

### `Feature` 
Represents and holds data for an individual piece of property, including the type of property, its geographical location, 
and its characteristics, as properties string `Type`, `Geometry` `Geometry`, and `Properties` `Properties`, respectively.

### `Geometry`
Class that holds coordinates for a piece of property; has properties string `Type` and `List` `Coordinates`.

### `Properties`
Holds address location data for a piece of property. Has string properties `Zip`, `City`, `State`, `Address`, `Borough`, `Neighborhood`, and `County`.





The following queries have been implemented:
 - Output all neighborhoods in the data list
 - Filter out neighborhoods that do not have any names
 - Remove duplicate information
 - Query that performs all of the above functions
 
 
 
