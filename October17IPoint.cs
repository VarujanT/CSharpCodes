public interface IPoint
    {
        int GetPoints();//public abstract functon
        int Points{ get; }//public abstract property
        int this [int i] { get; }//public abstract indexer
    }