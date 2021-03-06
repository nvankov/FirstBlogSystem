﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("CSCB766BlogDBModel", "FK_Comments_Posts", "Post", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Blog.Data.Post), "Comments", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Blog.Data.Comment), true)]

#endregion

namespace Blog.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CSCB766BlogDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CSCB766BlogDBEntities object using the connection string found in the 'CSCB766BlogDBEntities' section of the application configuration file.
        /// </summary>
        public CSCB766BlogDBEntities() : base("name=CSCB766BlogDBEntities", "CSCB766BlogDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CSCB766BlogDBEntities object.
        /// </summary>
        public CSCB766BlogDBEntities(string connectionString) : base(connectionString, "CSCB766BlogDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CSCB766BlogDBEntities object.
        /// </summary>
        public CSCB766BlogDBEntities(EntityConnection connection) : base(connection, "CSCB766BlogDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<aspnet_Users> aspnet_Users
        {
            get
            {
                if ((_aspnet_Users == null))
                {
                    _aspnet_Users = base.CreateObjectSet<aspnet_Users>("aspnet_Users");
                }
                return _aspnet_Users;
            }
        }
        private ObjectSet<aspnet_Users> _aspnet_Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Post> Posts
        {
            get
            {
                if ((_Posts == null))
                {
                    _Posts = base.CreateObjectSet<Post>("Posts");
                }
                return _Posts;
            }
        }
        private ObjectSet<Post> _Posts;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Comment> Comments
        {
            get
            {
                if ((_Comments == null))
                {
                    _Comments = base.CreateObjectSet<Comment>("Comments");
                }
                return _Comments;
            }
        }
        private ObjectSet<Comment> _Comments;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the aspnet_Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToaspnet_Users(aspnet_Users aspnet_Users)
        {
            base.AddObject("aspnet_Users", aspnet_Users);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Posts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPosts(Post post)
        {
            base.AddObject("Posts", post);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Comments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToComments(Comment comment)
        {
            base.AddObject("Comments", comment);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CSCB766BlogDBModel", Name="aspnet_Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class aspnet_Users : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new aspnet_Users object.
        /// </summary>
        /// <param name="applicationId">Initial value of the ApplicationId property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="loweredUserName">Initial value of the LoweredUserName property.</param>
        /// <param name="isAnonymous">Initial value of the IsAnonymous property.</param>
        /// <param name="lastActivityDate">Initial value of the LastActivityDate property.</param>
        public static aspnet_Users Createaspnet_Users(global::System.Guid applicationId, global::System.Guid userId, global::System.String userName, global::System.String loweredUserName, global::System.Boolean isAnonymous, global::System.DateTime lastActivityDate)
        {
            aspnet_Users aspnet_Users = new aspnet_Users();
            aspnet_Users.ApplicationId = applicationId;
            aspnet_Users.UserId = userId;
            aspnet_Users.UserName = userName;
            aspnet_Users.LoweredUserName = loweredUserName;
            aspnet_Users.IsAnonymous = isAnonymous;
            aspnet_Users.LastActivityDate = lastActivityDate;
            return aspnet_Users;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                OnApplicationIdChanging(value);
                ReportPropertyChanging("ApplicationId");
                _ApplicationId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationId");
                OnApplicationIdChanged();
            }
        }
        private global::System.Guid _ApplicationId;
        partial void OnApplicationIdChanging(global::System.Guid value);
        partial void OnApplicationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoweredUserName
        {
            get
            {
                return _LoweredUserName;
            }
            set
            {
                OnLoweredUserNameChanging(value);
                ReportPropertyChanging("LoweredUserName");
                _LoweredUserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoweredUserName");
                OnLoweredUserNameChanged();
            }
        }
        private global::System.String _LoweredUserName;
        partial void OnLoweredUserNameChanging(global::System.String value);
        partial void OnLoweredUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MobileAlias
        {
            get
            {
                return _MobileAlias;
            }
            set
            {
                OnMobileAliasChanging(value);
                ReportPropertyChanging("MobileAlias");
                _MobileAlias = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MobileAlias");
                OnMobileAliasChanged();
            }
        }
        private global::System.String _MobileAlias;
        partial void OnMobileAliasChanging(global::System.String value);
        partial void OnMobileAliasChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAnonymous
        {
            get
            {
                return _IsAnonymous;
            }
            set
            {
                OnIsAnonymousChanging(value);
                ReportPropertyChanging("IsAnonymous");
                _IsAnonymous = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAnonymous");
                OnIsAnonymousChanged();
            }
        }
        private global::System.Boolean _IsAnonymous;
        partial void OnIsAnonymousChanging(global::System.Boolean value);
        partial void OnIsAnonymousChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastActivityDate
        {
            get
            {
                return _LastActivityDate;
            }
            set
            {
                OnLastActivityDateChanging(value);
                ReportPropertyChanging("LastActivityDate");
                _LastActivityDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastActivityDate");
                OnLastActivityDateChanged();
            }
        }
        private global::System.DateTime _LastActivityDate;
        partial void OnLastActivityDateChanging(global::System.DateTime value);
        partial void OnLastActivityDateChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CSCB766BlogDBModel", Name="Comment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Comment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Comment object.
        /// </summary>
        /// <param name="commentID">Initial value of the CommentID property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="commentText">Initial value of the CommentText property.</param>
        /// <param name="postID">Initial value of the PostID property.</param>
        public static Comment CreateComment(global::System.Int32 commentID, global::System.String author, global::System.String commentText, global::System.Int32 postID)
        {
            Comment comment = new Comment();
            comment.CommentID = commentID;
            comment.Author = author;
            comment.CommentText = commentText;
            comment.PostID = postID;
            return comment;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CommentID
        {
            get
            {
                return _CommentID;
            }
            set
            {
                if (_CommentID != value)
                {
                    OnCommentIDChanging(value);
                    ReportPropertyChanging("CommentID");
                    _CommentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CommentID");
                    OnCommentIDChanged();
                }
            }
        }
        private global::System.Int32 _CommentID;
        partial void OnCommentIDChanging(global::System.Int32 value);
        partial void OnCommentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CommentText
        {
            get
            {
                return _CommentText;
            }
            set
            {
                OnCommentTextChanging(value);
                ReportPropertyChanging("CommentText");
                _CommentText = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CommentText");
                OnCommentTextChanged();
            }
        }
        private global::System.String _CommentText;
        partial void OnCommentTextChanging(global::System.String value);
        partial void OnCommentTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PostID
        {
            get
            {
                return _PostID;
            }
            set
            {
                OnPostIDChanging(value);
                ReportPropertyChanging("PostID");
                _PostID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PostID");
                OnPostIDChanged();
            }
        }
        private global::System.Int32 _PostID;
        partial void OnPostIDChanging(global::System.Int32 value);
        partial void OnPostIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CSCB766BlogDBModel", "FK_Comments_Posts", "Post")]
        public Post Posts
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("CSCB766BlogDBModel.FK_Comments_Posts", "Post").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("CSCB766BlogDBModel.FK_Comments_Posts", "Post").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Post> PostsReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Post>("CSCB766BlogDBModel.FK_Comments_Posts", "Post");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Post>("CSCB766BlogDBModel.FK_Comments_Posts", "Post", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CSCB766BlogDBModel", Name="Post")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Post : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Post object.
        /// </summary>
        /// <param name="postID">Initial value of the PostID property.</param>
        /// <param name="postContent">Initial value of the PostContent property.</param>
        /// <param name="postTitle">Initial value of the PostTitle property.</param>
        public static Post CreatePost(global::System.Int32 postID, global::System.String postContent, global::System.String postTitle)
        {
            Post post = new Post();
            post.PostID = postID;
            post.PostContent = postContent;
            post.PostTitle = postTitle;
            return post;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PostID
        {
            get
            {
                return _PostID;
            }
            set
            {
                if (_PostID != value)
                {
                    OnPostIDChanging(value);
                    ReportPropertyChanging("PostID");
                    _PostID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PostID");
                    OnPostIDChanged();
                }
            }
        }
        private global::System.Int32 _PostID;
        partial void OnPostIDChanging(global::System.Int32 value);
        partial void OnPostIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PostContent
        {
            get
            {
                return _PostContent;
            }
            set
            {
                OnPostContentChanging(value);
                ReportPropertyChanging("PostContent");
                _PostContent = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PostContent");
                OnPostContentChanged();
            }
        }
        private global::System.String _PostContent;
        partial void OnPostContentChanging(global::System.String value);
        partial void OnPostContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PostTitle
        {
            get
            {
                return _PostTitle;
            }
            set
            {
                OnPostTitleChanging(value);
                ReportPropertyChanging("PostTitle");
                _PostTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PostTitle");
                OnPostTitleChanged();
            }
        }
        private global::System.String _PostTitle;
        partial void OnPostTitleChanging(global::System.String value);
        partial void OnPostTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PostDate
        {
            get
            {
                return _PostDate;
            }
            set
            {
                OnPostDateChanging(value);
                ReportPropertyChanging("PostDate");
                _PostDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PostDate");
                OnPostDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _PostDate;
        partial void OnPostDateChanging(Nullable<global::System.DateTime> value);
        partial void OnPostDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("CSCB766BlogDBModel", "FK_Comments_Posts", "Comments")]
        public EntityCollection<Comment> Comments
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Comment>("CSCB766BlogDBModel.FK_Comments_Posts", "Comments");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Comment>("CSCB766BlogDBModel.FK_Comments_Posts", "Comments", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
