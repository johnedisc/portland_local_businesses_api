# [portland local business api](https://github.com/johnedisc/portland_local_businesses_api)

#### by [johnedisc](https://johnedisc.github.io/portfolio/)

#### an excercise in making a simple asp.net webapi in c#

### install tools

first, make sure that you have the [dotnet sdk](https://dotnet.microsoft.com/en-us/download) and dotnet entity framework tool installed.

``` bash
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. clone this [repository](https://github.com/johnedisc/portland_local_businesses_api.git) to the directory of your choosing.
``` bash
git clone https://github.com/johnedisc/portland_local_businesses_api.git
```
2. navigate to the PortlandLocalShopsApi directory(folder).
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

```bash
GET http://localhost:5250/portlandlocalshopsapi/
GET http://localhost:5250/portlandlocalshopsapi/{id}
POST http://localhost:5250/portlandlocalshopsapi/
PUT http://localhost:5250/portlandlocalshopsapi/{id}
DELETE http://localhost:5250/portlandlocalshopsapi/{id}
```

Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.

#### Optional Query String Parameters for GET Request

GET requests to `http://localhost:5250/portlandlocalshops/` can optionally include query strings to filter shops.

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| storeType   | String      | not required | Returns shops with a given type |
| name        | String      | not required | Returns shops with a given name |
| MusicType   | String      | not required | Returns shops that have a given music type |
| partOfTown  | String      | not required | Returns shops that are located in a given part of town |

The following query will return all shops that have "jazz" music:

```bash
GET http://localhost:5250/portlandlocalshopsapi?musictype=jazz
```

The following query will return all shops that are in ne:

```bash
GET http://localhost:5250/portlandlocalshopsapi?partoftown=ne
```

You can include multiple query strings by separating them with an `&`:

```bash
GET http://localhost:5250/portlandlocalshopsapi?partoftown=ne&musictype=salsa
```

#### for a POST request, you have to supply an entire unique object

a body is required for the post to be successful

```json
{ 
    "ShopId": 1,
    "Name": "doug fir lounge",
    "StoreType": "music venue",
    "MusicType": "various, singer-songwriter, guitar-bass-drums",
    "PartOfTown": "e, east" 
}
```

#### PUT request

when making a put request, you must provide the whole object, not just the value that is changing. thus:

```json
{ 
    "ShopId": 1,
    "Name": "doug fir lounge",
    "StoreType": "music venue",
    "MusicType": "rock",
    "PartOfTown": "e, east" 
}
```
becomes
```json
{ 
    "ShopId": 1,
    "Name": "doug fir lounge",
    "StoreType": "music venue",
    "MusicType": "various, singer-songwriter, guitar-bass-drums",
    "PartOfTown": "e, east" 
}
```

#### pagination

requests made to `GET http://localhost:5250/portlandlocalshopsapi/` will return only 20 results at a time. this is called [keyset-pagination](https://learn.microsoft.com/en-us/ef/core/querying/pagination#keyset-pagination) and can referenced in the MSDOCS for a deeper dive. the basic idea here is that if there are hundreds or thousands of entries in this api, the client does not benefit from getting them all at once. what they will get instead is just 20 per page. 

this method does not allow for random access of the database entries. thus, the client cannot skip from page 4 or results to page 8. they instead have to advance one page at a time. the benefit to this method is performance. instead of needing to calculate an offset and pass over potentially thousands of entries per request. the api will instead pass the client the id of the last entry passed. with that, when the next page is accessed, all that is needed to go directly to that list element.

the `lastIdNumber` is passed first to the api from the client when the next page is desired:
```bash
http://localhost:5250/portlandlocalshopsapi?lastIdNumber=21&partoftown=ne&musictype=salsa
```
a header with the name `X-Pagination` is returned to the client. it contains information about the previous query and can be used to make the next paging request.


## license

feel free to get in touch at [christopher(dot)johnedis(at)gmail(dot)com](christopher.johnedis@gmail.com)

MIT License

Copyright (c) [2023] [christopher johnedis]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

