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
