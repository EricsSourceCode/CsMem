// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class Uint32Array
{
private uint[] uArray;


internal Uint32Array()
{
try
{
uArray = new uint[2];
}
catch( Exception ) //  Except )
  {
  string showS = "Uint32Array: not" +
     " enough memory.";
     //   + Except.Message;

  throw new Exception( showS );
  }
}


void freeAll()
{
uArray = null;
}



void setSize( int howBig )
{
try
{
if( howBig == uArray.Length )
  return;

uArray = new uint[howBig];
}
catch( Exception ) // Except )
  {
  string showS = "Uint32Array: not" +
     " enough memory.";

  throw new Exception( showS );
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



void setVal( int where, uint setTo )
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
