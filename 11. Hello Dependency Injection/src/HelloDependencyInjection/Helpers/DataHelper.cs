using System;
using System.Collections.Generic;

namespace HelloDependencyInjection.Helpers {

  public class DataHelper : IDataHelper {

    private readonly List<String> _data = new List<String>( );

    public List<String> GetData( ) {
      return _data;
    }

    public void AddData( String data ) {
      _data.Add( data );
    }
  }

}