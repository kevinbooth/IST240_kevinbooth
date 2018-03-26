namespace BootstrapLab.Models
{
    public class QueryOptions
    {
        public string SortField { get; set; }
        public SortOrder SortOrder { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public QueryOptions()
        {
            CurrentPage = 1;
            PageSize = 3;

            SortField = "Id";
            SortOrder = SortOrder.ASC;
        }

        public string Sort
        {
            get
            {
                return string.Format("{0} {1}", SortField, SortOrder.ToString());
            }
        }
    }
}