#### 1. How would you make a web page mobile friendly (i.e responsive)?

One could use media queries with breakpoints to apply specific css styles based on the current screen size.

For example, if you want columns which usually stack a set of elements horizontally on a single to rather stack vertically with each item 
stretching the width of the screen to make them larger and easier to read on a mobile device you could do something similar to the below:

```
@media (max-width: 1000px) 
{ 
  [class*="col-"] { width: 100%;}
}
```

You can use multiple media queries with distinct breakpoints if you want to cater for screen sizes (e.g. phone, tablet and desktop)

Another option is to query the user agent to check if the user is accessing the page using a known mobile device and if so, then taking 
action such as to apply a mobile friendly styles or direct the user to mobile friendly version of the page.

```
if( navigator.userAgent.match(/Android/i) || navigator.userAgent.match(/webOS/i) || navigator.userAgent.match(/iPhone/i))
{
    window.location = "https://m.yourpage.co.za";
}
```

This method does have it's downsides in that you need to specifiy all the mobile browsers you want included in the check. 
For example, the check I wrote above is limitted to detecting Android, WebOS and iPhone devices. Overtime user agent strings might get
changed or new ones are created and you'll need update you check to cater which adds maintanance overhead. 



#### 2. What is the benefit of bundling .js scripts into one file?

This enables clients to retrieve all required javascript in a single request to the server. Having multiple files would require 
making multiple requests to retrieve each file individually which could negatively impact performance, particularly on high volume site. 



#### 3. What needs to be done to ensure the browser understands Sass styling?

The sass .scss style sheet needs to compiled into a css style sheet. This can be done by running a command such as the one below:

```
sass --watch sass.scss stylesheet.css
```

The --watch keyword instructs sass to monitor the .scss file and recompile the css file anytime changes are saved.



#### 4. What should be done to ensure browser compatibility with newer flavours of JavaScript like ES6/7?

You can use feature detection to determine if the browser supports a given feature of a new version of javascript. For example, 
if you want to detect if the browser supports arrow fucntions, you could create a function such as the below:

```
function canSupportArrowFunctions()
{
   var supported;
   try {
      new Function("(y => y)" );
      supported = true;
    }
    catch (err) {
      supported = false;
    }
    
    return supported;
}
```
