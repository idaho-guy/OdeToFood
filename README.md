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
