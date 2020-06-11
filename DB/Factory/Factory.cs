
using DBschemaTool.Repository;
using DBschemaTool.Repository.Common.Helper;
using System.Collections.Generic;

namespace DBschemaTool.Factory
{
    public class DBFactory
    {
        public FugoRepository FugoRepository;
        public MSSQLRepository MSSQLRepository;
        public MlecRepository MlecRepository;

        public DBFactory( string connect) {
            FugoRepository = new FugoRepository(new DbConnectionHelper(connect));
            MSSQLRepository = new MSSQLRepository(new DbConnectionHelper(connect));
            MlecRepository = new MlecRepository(new DbConnectionHelper(connect));
        }

      
    }
}
