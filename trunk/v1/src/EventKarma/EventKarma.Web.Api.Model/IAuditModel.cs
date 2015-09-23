namespace EventKarma.Web.Api.Model
{
    public interface IAuditModel
    {
        int CreatedBy { get; set; }
        long CreatedOn { get; set; }
        long? UpdatedOn { get; set; }
        bool? IsDeleted { get; set; }
        int? UpdatedBy { get; set; }
    }
}
