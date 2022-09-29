using System;

namespace WiangtaiMemberApp.Model;

public class MasterAccount
{
    public long idMasterAccount { get; set; }
    public string strEmail { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string strAccountRef { get; set; }
    public byte intRefType { get; set; }
    public string strAccountName { get; set; }
    public DateTime dtAccountCreate { get; set; }
    public Nullable<byte> intBillingCycle { get; set; }
    public string strMobileNo { get; set; }
    public Nullable<DateTime> dtBirthDate { get; set; }
    public Nullable<byte> intGender { get; set; }
    public Nullable<Guid> idJobTitle { get; set; }
    public Nullable<Guid> idEducation { get; set; }
    public Nullable<Guid> idIncome { get; set; }
    public string strBusPhone { get; set; }
    public string strHousePhone { get; set; }
    public string strMobilePhone { get; set; }
    public string strFax { get; set; }
    public Nullable<byte> intEmailConsent { get; set; }
    public Nullable<byte> intSMSConsent { get; set; }
    public Nullable<byte> intContactMethod { get; set; }
    public string strHomeAddress1 { get; set; }
    public string strHomeAddress2 { get; set; }
    public string strHomeAddress3 { get; set; }
    public Nullable<Guid> idHomeCity { get; set; }
    public string strHomePostCd { get; set; }
    public Nullable<Guid> idHomeState { get; set; }
    public Nullable<Guid> idHomeCountry { get; set; }
    public string strDeliverAddress1 { get; set; }
    public string strDeliverAddress2 { get; set; }
    public string strDeliverAddress3 { get; set; }
    public Nullable<Guid> idDeliverCity { get; set; }
    public string strDeliverPostCd { get; set; }
    public Nullable<Guid> idDeliverState { get; set; }
    public Nullable<Guid> idDeliverCountry { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid ModifiedBy { get; set; }
    public string strHomeCity { get; set; }
    public string strDeliverCity { get; set; }
    public Nullable<Guid> idRace { get; set; }
    public Nullable<Guid> idNationality { get; set; }
    public Nullable<Guid> idReligion { get; set; }
    public Nullable<byte> intMaritalStatus { get; set; }
    public string strFirstName { get; set; }
    public string strLastName { get; set; }
    public Nullable<bool> intStatus { get; set; }
    public Nullable<bool> IMXInstall { get; set; }
    public string strRemarks { get; set; }
    public Nullable<byte> intCustomerType { get; set; }
    public bool bitEStatement { get; set; }
    public Nullable<System.DateTime> dtEStatementSubscribe { get; set; }


    public virtual Education Education { get; set; }
    public virtual JobTitle JobTitle { get; set; }
    public virtual Region Region { get; set; }
    public virtual Region Region1 { get; set; }
    public virtual Region Region2 { get; set; }
    public virtual Region Region3 { get; set; }
    public virtual SalaryRange SalaryRange { get; set; }
}