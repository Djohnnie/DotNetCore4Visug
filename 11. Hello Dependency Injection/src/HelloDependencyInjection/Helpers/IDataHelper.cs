using System;
using System.Collections.Generic;

namespace HelloDependencyInjection.Helpers {

  public interface IDataHelper {

    List<String> GetData( );

    void AddData( String data );

  }

}