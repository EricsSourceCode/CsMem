// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// See https://ericssourcecode.github.io/
// For guides and information.



using System;



// namespace



public class Uint32Array
{
private MainData mData;
private uint[] uArray;


private Uint32Array()
{
}


internal Uint32Array( MainData useMainData )
{
mData = useMainData;

try
{
uArray = new uint[2];
}
catch( Exception Except )
  {
  freeAll();
  mData.showStatus(
     "Not enough memory for Uint32Array." );
  mData.showStatus( Except.Message );
  // return;
  }


void freeAll()
{
uArray = null;
}



void setSize( int howBig )
{
try
{
uArray = new uint[howBig];
}
catch( Exception Except )
  {
  freeAll();
  mData.showStatus(
     "Not enough memory for Uint32Array." );
  mData.showStatus( Except.Message );
  // return;
  }
}


int getSize()
{
return uArray.Length;
}



uint getVal( int where )
{
RangeT.test( where, 0, uArray.Length - 1,
             "Uint32Array.getVal() range." );

return uArray[where];
}



void setVal( uint where, uint setTo )
{
RangeT.test( where, 0, uArray.Length - 1,
             "Uint32Array.setVal() range." );

uArray[where] = setTo;
}



void copy( Uint32Array toCopy )
{
setSize( toCopy.getSize() );

int max = uArray.Length;
for( int count = 0; count < max; count++ )
  uArray[count] = toCopy.uArray[count];

}




} // Class
