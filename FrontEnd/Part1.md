#### 1. What will the colour of both div elements be?

"firstDiv" would be red   (Style for ".red-card" class selector applied)  
secondDiv would be orange (Style for "#secondDiv" id selector applied) 

If code executed as is, only orange secondDiv will be visible as the positioning defined class under element type selector 'Div'will apply
to both elements. secondDiv is declares last, so is place at the front.  

#### 2. How would you dynamically target firstDiv and make it's colour pink? (provide the code snippet)

```
JS: document.getElementById("firstDiv").style["background"] = "Pink";
JQuery: $("#firstDiv").css({"background": "Pink"});
```

#### 3. How would you dynamically target secondDiv and add the yellow-card class to its class list? (provide the code snippet)

```
JS: document.getElementById("firstDiv").className += " yellow-card";
JQuery: $("#firstDiv").addClass("yellow-card");
```
