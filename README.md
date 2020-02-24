* Make model available to [page](https://github.com/idaho-guy/OdeToFood/commit/9076c7ab30b873f6a5c2f3beebafceaad9a05d67)
* Access configuration in [model](https://github.com/idaho-guy/OdeToFood/commit/2086170a5d38472f74941ac9f06b43b2892b1bc2)
* Populate a list of restaurants and make available on [page](https://github.com/idaho-guy/OdeToFood/commit/e8e4992ad9173d025f96274302b525fba5dcb931)
* Add [Search](https://github.com/idaho-guy/OdeToFood/commit/a1472844ba78825e6a9d9b511ba8bdaa6c327f93) form to page
* Persist searchTerm with [asp-for](https://github.com/idaho-guy/OdeToFood/commit/f0e486158db02eed4bded3fbf589aa88fe325a7c)
* Link to details page using query string  [asp-page and asp-route-restaurantId](https://github.com/idaho-guy/OdeToFood/commit/72990af7c42da0939accd45b110b818c0b05ab03)
* Access details page using path info with only [1 change](https://github.com/idaho-guy/OdeToFood/commit/8d8b11466494245ca0f469fad891f69da6a43f2e)
* Update logic around details page to return [error page](https://github.com/idaho-guy/OdeToFood/commit/c8bb00d550944f3f61119192840859b45ced2d22) if no restaurant exists
* Added EditForm [logic](https://github.com/idaho-guy/OdeToFood/commit/33d6aec1de25cb9aad62c82b8e4ace1dfffe51c3)
  * Using `BindProperty` attribiute for POST and added validations to the Restaurant Model
* [Validation](https://github.com/idaho-guy/OdeToFood/commit/77bfb1692b68ee40f78a81126e458b707b325eb2) in model and page display
* [Redirect](https://github.com/idaho-guy/OdeToFood/commit/8a812fb356c0006ff0f019d35e57eb1c838f9cdd) after POST so refreshing browser won't initiate a new form submission
* Make [restaurantId](https://github.com/idaho-guy/OdeToFood/commit/646d3a2188f5ef6ba5e7fcc4ae903f1d5a0998e3) nullable so we can use the Edit page to create new Restaurants
* Service [updates](https://github.com/idaho-guy/OdeToFood/commit/bad80e3d77dfdcd707bdf55c4b050ded586d4126) to add new Restaurant
* Update [Post](https://github.com/idaho-guy/OdeToFood/commit/ae0bc1a7967b995a8308165dd3598fb0cbf4b66d) method so it handles add and create
* [TempData](https://github.com/idaho-guy/OdeToFood/commit/e588bc2b1bbdb0bdfcd7728d523fd7e95e19167e) example usage
* Update to work with [EntityFramework](https://github.com/idaho-guy/OdeToFood/commit/796f39eea5d7d835172d35ab8a7a0204c97e49dc); also extend from [DBContext](https://github.com/idaho-guy/OdeToFood/commit/b95f37b05e9ef2c4ad3c905802725f7dffde3160)
* Add a [logger](https://github.com/idaho-guy/OdeToFood/commit/43cfe65abd759504e0981fb24594fe9e71db6735)
* [Migrate](https://github.com/idaho-guy/OdeToFood/wiki/prod-db-migration) DB

### Install dotnet ef tool
```
dotnet tool install --global dotnet-ef --version 3.1.0
```

### Db info
```
Mark-Sage's-MacBook-Pro:OdeToFood.Data marksage$ dotnet ef dbcontext info -s ../OdeToFood/OdeToFood.csproj 
Build started...
Build succeeded.
The EF Core tools version '3.1.1' is older than that of the runtime '3.1.2'. Update the tools for the latest features and bug fixes.
Provider name: Pomelo.EntityFrameworkCore.MySql
Database name: OdeToFood
Data source: localhost
Options: MaxPoolSize=128
Mark-Sage's-MacBook-Pro:OdeToFood.Data marksage$ 
```
### Add migration
```
Mark-Sage's-MacBook-Pro:OdeToFood.Data marksage$ dotnet ef migrations add initialcreate -s ../OdeToFood/OdeToFood.csproj 
Build started...
Build succeeded.
The EF Core tools version '3.1.1' is older than that of the runtime '3.1.2'. Update the tools for the latest features and bug fixes.
Done. To undo this action, use 'ef migrations remove'
```
### Create database
```
Mark-Sage's-MacBook-Pro:OdeToFood.Data marksage$ dotnet ef database update -s ../OdeToFood/OdeToFood.csproj 
Build started...
Build succeeded.
The EF Core tools version '3.1.1' is older than that of the runtime '3.1.2'. Update the tools for the latest features and bug fixes.
Done.
```

[Implement Entity Framework in MySQL](https://github.com/idaho-guy/OdeToFood/commit/6e09a7b1d8beaf2f99f59da8920c33fae5c5f81b)

### Layout
You can add sections in the _Layout.cshtml in the following manner
```
<footer>
  @RenderSection("footer", required: false)
</footer>
```
Pages that choose to implement would do the following:
```
@section footer {
  <div>@Model.Message</div>
}
```

* Delete logic using a custom [Layout](https://github.com/idaho-guy/OdeToFood/commit/87ae246cb40b75496d3dfba8c1ca8f9fdc621ca7)
* Default Layout is contained in the [_ViewStart.cshtml](https://github.com/idaho-guy/OdeToFood/blob/master/OdeToFood/Pages/_ViewStart.cshtml) file
* [_ViewImports.cshtml](https://github.com/idaho-guy/OdeToFood/blob/master/OdeToFood/Pages/_ViewImports.cshtml) contains using statments and other utilities
* [Partial view sample](https://github.com/idaho-guy/OdeToFood/commit/193f76486cad3845c4ebf19ba0aeafd16a2cc912)
* Add [ViewComponent](https://github.com/idaho-guy/OdeToFood/commit/f85e3998adc2dae4dac17b0bd4e1e7bff6dd29ec) to _Layout.cshtml

### Configuration on start-up
[Defaults](https://github.com/dotnet/aspnetcore/blob/1480b998660d2f77d0605376eefab6a83474ce07/src/DefaultBuilder/src/WebHost.cs#L155) set in WebHost

### DB Migration
[DB Migration](generate-db-migration)
