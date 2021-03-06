# AnimalSource

This is an ASP.NET Core (3.1), Blazor Server web application (MVC design pattern). The purpose of this project is to get familiar with all of the current technologies in the ASP.NET web framework.

AnimalSource is a basic site displaying information and dummy data about a few different animals. 
A notable implemented feature is the ability to rate the "danger level" of an animal by clicking on 
a star in the modal of any respective animal, which dynamically updates the database. All of the data displayed 
about the animals is read from the database.

_Note: This site has no production server, and can be demo'd via localhost_

* **Front-end:** All of the UI is hosted on the server-side and built with Razor components (C#, HTML, CSS)
* **Back-end:** Written in C#/.NET. There is a basic REST API to `GET` the animal data from the database at route `/animals`
* **Database:** JSON file consisting of an array of objects for each animal

_Example snippet of the Animal database_
```
[
  {
    "id": 0,
    "type": "Reptile",
    "species": "Lizard",
    "size": "Small",
    "age": 1,
    "endangered": false,
    "dangerLevels": [1, 2, 9, 10, 7, 6, 8, 10],
    "url": "https://some.url.of.wiki.documentation.of.animal",
    "img": "https://some.url.to.an.image.of.animal"
  },
  .
  .
  .
]
```

_Screenshot of the index page with a visible modal_
![AnimalSource screenshot](./AnimalSource.png)
