namespace SchoolProjectAPI.DTOs
{
    class LiteWidgetDTO : SharedEntitiesDTO
    {
        public string Title { get; set; }
    }
    class WidgetDTO : LiteWidgetDTO
    {

    }
    class DetailedWidgetDTO : WidgetDTO
    {

    }
}
