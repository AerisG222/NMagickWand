#0.4.1 (05/21/2016)
- updates to reference rc2 dependencies

#0.4.0 (05/10/2016)
- first updates to support rc2 / netcore

#0.3.7 (05/01/2016)
- breakfix

#0.3.6 (04/25/2016)
- correct/improve accessing some properties on MagickWandEnvironment (like QuantumDepth, QuantumRange, Version, etc)
- reorganize files so it is a bit easier to reason about (moving enums and structs into like namespaces)
- added tests, and more attempts to find a good approach to preparing images based on characteristics of the images - will see how good this is after testing a larger sample!

#0.3.5 (03/07/2016)
- add properties on pixelwand to make it easy to get html color values

#0.3.4 (03/07/2016)
- fix issue when iterating over pixels

#0.3.3 (03/06/2016)
- support writing to streams

#0.3.2 (03/04/2016)
- update the dllimport name to align with system library name.  previously, this used a dll map in my mono config i had forgotten about

#0.3.1 (03/03/2016)
- ensure all wrapper methods expect width then height in that order
- add convenience overload of MagickWand constructor to accept an image file to read
- wrapper now adds memory pressure for wrapper when reading or cloning image
- more wrapper tests

#0.3.0 (03/01/2016)
- initial attempt to provide friendly wrappers

#0.2.0 (02/04/2016)
- improve native and managed type mappings
- additional tests to illustrate more complex calls

#0.1.0 (02/01/2016)
- initial release
