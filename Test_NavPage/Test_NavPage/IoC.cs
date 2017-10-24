using System;
using System.Collections.Generic;
using System.Text;


namespace Test_NavPage
{
    class IoC
    {
      static readonly Dictionary<Type, object> registeredItems = new Dictionary<Type, object>();
      public static TToCreate Resolve<TToCreate>() where TToCreate : class, new()
      {
        var targetType = typeof(TToCreate);
        if (!registeredItems.ContainsKey(targetType))
        {
          registeredItems.Add(targetType, new TToCreate());
        }
        return registeredItems[targetType] as TToCreate;

      }

  }
}
