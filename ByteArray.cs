// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html




using System;



// namespace



public class ByteArray
{
private byte[] bArray;


internal ByteArray()
{
try
{
bArray = new byte[2];
}
catch( Exception ) //  Except )
  {
  string showS = "ByteArray: not" +
     " enough memory.";
     //   + Except.Message;

  throw new Exception( showS );
  }
}



internal void setSize( int howBig )
{
try
{
if( howBig == bArray.Length )
  return;

bArray = new byte[howBig];
}
catch( Exception ) // Except )
  {
  string showS = "ByteArray: not" +
     " enough memory.";

  throw new Exception( showS );
  }
}


internal int getSize()
{
return bArray.Length;
}



internal byte getVal( int where )
{
RangeT.test( where, 0, bArray.Length - 1,
             "ByteArray.getVal() range." );

return bArray[where];
}



internal void setVal( int where, byte setTo )
{
RangeT.test( where, 0, bArray.Length - 1,
             "ByteArray.setVal() range." );

bArray[where] = setTo;
}



internal void copy( ByteArray toCopy )
{
int max = toCopy.getSize();

if( getSize() < max )
  setSize( max );

for( int count = 0; count < max; count++ )
  bArray[count] = toCopy.bArray[count];

}



internal void increaseSize( int toAdd )
{
int arraySize = bArray.Length;
int newSize = arraySize + toAdd;

try
{
Array.Resize( ref bArray, newSize );
}
catch( Exception ) // Except )
  {
  string showS =
           "ByteArray. Not enough memory.";

  throw new Exception( showS );
  }
}




} // Class
