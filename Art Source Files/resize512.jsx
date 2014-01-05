var savedRuler= app.preferences.rulerUnits;
app.preferences.rulerUnits = Units.PIXELS;
var w = app.activeDocument.width;
var h = app.activeDocument.height;
if(w>h) app.activeDocument.resizeCanvas (h, h, AnchorPosition.MIDDLECENTER);
if(w<h) app.activeDocument.resizeCanvas (w, w, AnchorPosition.MIDDLECENTER);
//if w==h already square
app.activeDocument.resizeImage(512, 512,null,ResampleMethod.BICUBIC);

app.preferences.rulerUnits = savedRuler;