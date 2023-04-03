# [portland local business api](https://github.com/johnedisc/portland_local_businesses_api)

#### by [johnedisc](https://johnedisc.github.io/portfolio/)

#### an excercise in making a simple asp.net webapi in c#

### install tools

first, make sure that you have the [dotnet sdk](https://dotnet.microsoft.com/en-us/download) and dotnet entity framework tool installed.

``` bash
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. Clone this [repository](https://github.com/johnedisc/portland_local_businesses_api.git) to the directory of your choosing.
``` bash
git clone https://github.com/johnedisc/portland_local_businesses_api.git
```
2. Navigate to the PortlandLocalShopsApi directory(folder).
``` bash
cd portland_local_businesses_api/PortlandLocalShopsApi
```
3. create two new files in that directory `appsettings.json` and `appsettings.Development.json`.
``` bash
touch appsettings.json appsettings.Development.json
```
4. in appsettings, add the information below replacing database name, uid, pwd to suit your own situation.
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=NAME_OF_YOUR_CHOOSING;uid=YOUR_USER_NAME;pwd=YOUR_PASSWORD;"
  }
}
```

5. in appsettings.Development.json add the following.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

6. next set up your local database with the following dotnet entity framework command
``` bash
dotnet ef database update
```
7. you are ready to start the api server. this will start the server in production mode. if you are going to develop it further, run the following without the --launch-profile
``` bash
dotnet watch run --launch-profile "PortlandLocalShopsApi-Production"
```
8. use your favorite program to make api calls (eg, [postman](https://www.postman.com/), [curl](https://curl.se/) on the command line, or with swagger). swagger can be found at [http://localhost:5250/swagger](http://localhost:5250/swagger)

```
GET http://localhost:5000/api/animals/
GET http://localhost:5000/api/animals/{id}
POST http://localhost:5000/api/animals/
PUT http://localhost:5000/api/animals/{id}
DELETE http://localhost:5000/api/animals/{id}
```

Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5000/api/animals/` can optionally include query strings to filter or search animals.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| species     | String      | not required | Returns animals with a matching species value |
| name        | String      | not required | Returns animals with a matching name value |
| minimumAge  | Number      | not required | Returns animals that have an age value that is greater than or equal to the specified minimumAge value |

The following query will return all animals with a species value of "Dinosaur":

```
GET http://localhost:5000/api/animals?species=dinosaur
```

The following query will return all animals with the name "Matilda":

```
GET http://localhost:5000/api/animals?name=matilda
```

The following query will return all animals with an age of 10 or older:

```
GET http://localhost:5000/api/animals?minimumAge=10
```

You can include multiple query strings by separating them with an `&`:

```
GET http://localhost:5000/api/animals?species=dinosaur&minimumAge=10
```

#### Additional Requirements for POST Request

When making a POST request to `http://localhost:5000/api/animals/`, you need to include a **body**. Here's an example body in JSON:

```json
{
  "species": "Tyrannosaurus Rex",
  "name": "Elizabeth",
  "age": 8
}
```

#### Additional Requirements for PUT Request

When making a PUT request to `http://localhost:5000/api/animals/{id}`, you need to include a **body** that includes the animal's `animalId` property. Here's an example body in JSON:

```json
{
  "animalId": 1,
  "species": "Tyrannosaurus Rex",
  "name": "Lizzy",
  "age": 9
}
```

And here's the PUT request we would send the previous body to:

```
http://localhost:5000/api/animals/1
```

Notice that the value of `animalId` needs to match the id number in the URL. In this example, they are both 1.

## Available Branches

**1_setup_and_seeding**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/building-an-api/scaffolding-a-net-application-with-dotnet-new
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/exploring-the-dotnet-new-web-api-template
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/adding-a-model-and-database
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/seeding-the-database

**2_crud_functionality**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/building-an-api/api-create-and-read
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/api-update-and-delete

**3_query_strings**: This branch includes the code we added after working through the following lesson:

- https://www.learnhowtoprogram.com/c-and-net/building-an-api/adding-parameters-to-a-get-request-to-support-query-strings

**There are other lessons in this series, but the rest are not implemented in this example repo:**

- https://www.learnhowtoprogram.com/c-and-net/building-an-api/adding-api-model-validation
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/scaffolding-api-controllers
- https://www.learnhowtoprogram.com/c-and-net/building-an-api/further-exploration-with-apis




https://localhost:7263;http://localhost:5250


new Shop { ShopId = 1, Name = "doug fir lounge", StoreType = "music venue", MusicType = "various, singer-songwriter, guitar-bass-drums", PartOfTown = "e, east" }, new Shop { ShopId = 2, Name = "mississippi pizza", StoreType = "pizza restaurant, music venue", MusicType = "various, salsa, timba, singer-songwriter, guitar-bass-drums", PartOfTown = "ne, northeast" }, new Shop { ShopId = 3, Name = "the goodfoot", StoreType = "bar, music venue", MusicType = "various, funk, salsa, guitar-bass-drums", PartOfTown = "ne, northeast" }, new Shop { ShopId = 4, Name = "the 1905", StoreType = "bar, pizza, music venue", MusicType = "jazz", PartOfTown = "ne, northeast" }


-->
