# labview-offline-maps
Just example illustrates how the offline geographical maps capabilities can be added to Labview (using .Net control)

![alt text](/img/main.png)

Demo https://www.youtube.com/watch?v=vc_ed1tQreE

## description
Example of the geographical map with data (pins, path, labels and callounts) displaying implementation in Labview.

1. Maps are stored on a local disk in the form of images (tiles). They can be downloaded for any part of the earth’s surface with the required detail.
2. To display the map and data in Labview, the OfflineMap.Control is used. It is a .Net Control and is supplied as a dll file. 
Control uses Telerik Win Forms RadMap control (https://www.telerik.com/products/winforms/map.aspx)
To add to the Front Panel, the .NET Container component from the .NET & ActiveX page is used. 
You can get already compilated dlls from \labview-offline-maps\labview\dll\
3. The file tracks\track.json acts as a source of test data in with some parameters of. 
In the test program, you can set the temperature threshold level above which the mark on the map and the path will be displayed in red.

## to completely recompile you will need 
1. NI Labview 2017 or newer
2. Microsoft Visual Studio 2017 or newer 
3. Telerik UI for WinForms (trial) https://www.telerik.com/products/winforms.aspx

## maps
before test unarchive \maps\map.7z and \maps\sat.7z (map based on sattelite images)

## Telerik replacement 
I think using the same principle https://github.com/radioman/greatmaps can be used instead Telerik controls.


