namespace AutofacInterceptionWithCache
{
    public class DefaultMyQuery : IMyQuery
    {
        private readonly IMySecondQuery _mySecondQuery;

        public DefaultMyQuery(IMySecondQuery mySecondQuery)
        {
            _mySecondQuery = mySecondQuery;
        }

        public string GetName()
        {
            return _mySecondQuery.GetSecondName();
        }
    }
}