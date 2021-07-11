namespace PurpleYam_POS.Model
{
    interface IUserRole
    {
        bool Create { get; set; }
        bool Delete { get; set; }
        string Module { get; set; }
        bool Update { get; set; }
    }
}