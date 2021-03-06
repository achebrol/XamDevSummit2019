// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // UserProfile
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class UserProfile
    {
        public int UserProfileId { get; set; } // UserProfileId (Primary key)
        public string AspNetUsersId { get; set; } // AspNetUsersId (length: 128)
        public System.DateTime? BirthDate { get; set; } // BirthDate
        public string FirstName { get; set; } // FirstName (length: 255)
        public string LastName { get; set; } // LastName (length: 255)
        public int? GenderTypeId { get; set; } // GenderTypeId
        public System.DateTime LastLogin { get; set; } // LastLogin
        public int PreferredLanguageId { get; set; } // PreferredLanguageId
        public string Biography { get; set; } // Biography (length: 4000)
        public System.Guid? PhotoBlobFileId { get; set; } // PhotoBlobFileId
        public string AvatarUrl { get; set; } // AvatarUrl (length: 1000)
        public string CompanyName { get; set; } // CompanyName (length: 1000)
        public string JobTitle { get; set; } // JobTitle (length: 1000)
        public string CompanyWebsiteUrl { get; set; } // CompanyWebsiteUrl (length: 1000)
        public string BlogUrl { get; set; } // BlogUrl (length: 1000)
        public string TwitterUrl { get; set; } // TwitterUrl (length: 1000)
        public string LinkedInUrl { get; set; } // LinkedInUrl (length: 1000)
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child Feedbacks where [Feedback].[UserProfileId] point to this entity (FK_Feedback_UserProfile)
        /// </summary>
        public System.Collections.Generic.ICollection<Feedback> Feedbacks { get; set; } // Feedback.FK_Feedback_UserProfile
        /// <summary>
        /// Child SessionLikes where [Session_Like].[UserProfileId] point to this entity (FK_Session_Like_UserProfile)
        /// </summary>
        public System.Collections.Generic.ICollection<SessionLike> SessionLikes { get; set; } // Session_Like.FK_Session_Like_UserProfile
        /// <summary>
        /// Child SessionSpeakers where [Session_Speaker].[UserProfileId] point to this entity (FK_Session_Speaker_UserProfile)
        /// </summary>
        public System.Collections.Generic.ICollection<SessionSpeaker> SessionSpeakers { get; set; } // Session_Speaker.FK_Session_Speaker_UserProfile

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [UserProfile].([AspNetUsersId]) (FK_UserProfile_AspNetUsers)
        /// </summary>
        public AspNetUser AspNetUser { get; set; } // FK_UserProfile_AspNetUsers

        /// <summary>
        /// Parent BlobFile pointed by [UserProfile].([PhotoBlobFileId]) (FK_UserProfile_BlobFile)
        /// </summary>
        public BlobFile BlobFile { get; set; } // FK_UserProfile_BlobFile

        /// <summary>
        /// Parent GenderType pointed by [UserProfile].([GenderTypeId]) (FK_UserProfile_GenderType_GenderTypeId)
        /// </summary>
        public GenderType GenderType { get; set; } // FK_UserProfile_GenderType_GenderTypeId

        /// <summary>
        /// Parent LanguageType pointed by [UserProfile].([PreferredLanguageId]) (FK_UserProfile_LanguageType)
        /// </summary>
        public LanguageType LanguageType { get; set; } // FK_UserProfile_LanguageType

        public UserProfile()
        {
            PreferredLanguageId = 1;
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            Feedbacks = new System.Collections.Generic.List<Feedback>();
            SessionLikes = new System.Collections.Generic.List<SessionLike>();
            SessionSpeakers = new System.Collections.Generic.List<SessionSpeaker>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
