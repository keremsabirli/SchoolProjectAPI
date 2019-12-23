namespace SchoolProjectAPI.DTOs
{
    public class LiteWidgetDTO : SharedEntitiesDTO
    {
        public string Title { get; set; }
    }
    public class WidgetDTO : LiteWidgetDTO
    {

    }
    public class DetailedWidgetDTO : WidgetDTO
    {

    }
}
