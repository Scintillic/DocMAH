﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocMAH.Data.Sql {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DocMAH.Data.Sql.SqlScripts", typeof(SqlScripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @nextId INT 
        ///SELECT @nextId = ISNULL(MAX(Id), 0) + 1 FROM DocmahBullets
        ///
        ///INSERT INTO [DocmahBullets] (
        ///	Id
        ///	,[PageId]
        ///	,[Number]
        ///	,[Text]
        ///	,[VerticalOffset]
        ///	,[HorizontalOffset]
        ///	,[OffsetElementId]
        ///	,[DocVerticalOffset]
        ///	,[DocHorizontalOffset]
        ///)
        ///VALUES (
        ///	@nextId
        ///	,@pageId
        ///	,@number
        ///	,@text
        ///	,@verticalOffset
        ///	,@horizontalOffset
        ///	,@offsetElementId
        ///	,@docVerticalOffset
        ///	,@docHorizontalOffset
        ///)
        ///
        ///SELECT @nextId.
        /// </summary>
        internal static string Bullet_Create {
            get {
                return ResourceManager.GetString("Bullet_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahBullets] WHERE Id = @id
        ///.
        /// </summary>
        internal static string Bullet_Delete {
            get {
                return ResourceManager.GetString("Bullet_Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahBullets] 
        ///WHERE PageId = @pageId.
        /// </summary>
        internal static string Bullet_DeleteByPageId {
            get {
                return ResourceManager.GetString("Bullet_DeleteByPageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahBullets] WHERE Id NOT IN (@bulletIds).
        /// </summary>
        internal static string Bullet_DeleteExcept {
            get {
                return ResourceManager.GetString("Bullet_DeleteExcept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF( (SELECT COUNT(*) FROM DocmahBullets WHERE Id = @id) = 1)BEGIN
        ///	UPDATE DocmahBullets SET 
        ///		PageId = @pageId,
        ///		Number = @number,
        ///		[Text] = @text,
        ///		VerticalOffset = @verticalOffset,
        ///		HorizontalOffset = @horizontalOffset,
        ///		OffsetElementId = @offsetElementId,
        ///		DocVerticalOffset = @docVerticalOffset,
        ///		DocHorizontalOffset = @docHorizontalOffset 
        ///	WHERE Id = @id
        ///END ELSE BEGIN
        ///	INSERT DocmahBullets(	 Id,  PageId,  Number, [Text], VerticalOffset,  HorizontalOffset,  OffsetElementId,  DocVerti [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Bullet_Import {
            get {
                return ResourceManager.GetString("Bullet_Import", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM DocmahBullets
        ///.
        /// </summary>
        internal static string Bullet_ReadAll {
            get {
                return ResourceManager.GetString("Bullet_ReadAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT *
        ///FROM DocmahBullets
        ///WHERE PageId = @pageId.
        /// </summary>
        internal static string Bullet_ReadByPageId {
            get {
                return ResourceManager.GetString("Bullet_ReadByPageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [DocmahBullets]
        ///   SET [PageId] = @pageId
        ///      ,[Number] = @number
        ///      ,[Text] = @text
        ///      ,[VerticalOffset] = @verticalOffset
        ///      ,[HorizontalOffset] = @horizontalOffset
        ///      ,[OffsetElementId] = @offsetElementId
        ///	  ,[DocVerticalOffset] = @docVerticalOffset
        ///	  ,[DocHorizontalOffset] = @docHorizontalOffset
        /// WHERE Id = @id.
        /// </summary>
        internal static string Bullet_Update {
            get {
                return ResourceManager.GetString("Bullet_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- If the configuration table doesn&apos;t exist, return 0.
        ///IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;[DocmahConfiguration]&apos;) AND type in (N&apos;U&apos;)) BEGIN
        ///	SELECT 0;
        ///END
        ///
        ///SELECT [Value] FROM [DocmahConfiguration] WHERE [Name] = @name;
        ///.
        /// </summary>
        internal static string Configuration_Read {
            get {
                return ResourceManager.GetString("Configuration_Read", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [DocmahConfiguration]
        ///SET [Value] = @value
        ///WHERE [Name] = @name.
        /// </summary>
        internal static string Configuration_Update {
            get {
                return ResourceManager.GetString("Configuration_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///IF (
        ///	EXISTS(
        ///		SELECT name 
        ///		FROM master.dbo.sysdatabases 
        ///		WHERE &apos;[&apos; + name + &apos;]&apos; = &apos;CatalogName&apos;
        ///			OR name = &apos;CatalogName&apos;
        ///	)
        ///) BEGIN
        ///	DROP DATABASE CatalogName
        ///END
        ///
        ///CREATE DATABASE CatalogName
        ///.
        /// </summary>
        internal static string Database_Create {
            get {
                return ResourceManager.GetString("Database_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///IF (
        ///	EXISTS(
        ///		SELECT name 
        ///		FROM master.dbo.sysdatabases 
        ///		WHERE &apos;[&apos; + name + &apos;]&apos; = &apos;CatalogName&apos;
        ///			OR name = &apos;CatalogName&apos;
        ///	)
        ///) BEGIN
        ///	ALTER DATABASE CatalogName SET SINGLE_USER WITH ROLLBACK IMMEDIATE
        ///
        ///	DROP DATABASE CatalogName
        ///END.
        /// </summary>
        internal static string Database_Drop {
            get {
                return ResourceManager.GetString("Database_Drop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET ANSI_NULLS ON
        ///SET QUOTED_IDENTIFIER ON
        ///CREATE TABLE [dbo].[DocmahBullets](
        ///	[Id] [int] NOT NULL,
        ///	[PageId] [int] NOT NULL,
        ///	[Number] [int] NOT NULL,
        ///	[Text] [nvarchar](max) NOT NULL,
        ///	[VerticalOffset] [int] NOT NULL,
        ///	[HorizontalOffset] [int] NOT NULL,
        ///	[OffsetElementId] [nvarchar](50) NOT NULL,
        ///	[DocVerticalOffset] [int] NULL,
        ///	[DocHorizontalOffset] [int] NULL,
        /// CONSTRAINT [PK_DocmahBullets] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF)
        ///)        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Database_Update_01 {
            get {
                return ResourceManager.GetString("Database_Update_01", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE DocmahConfiguration
        ///SET [Name] = &apos;HelpContentVersion&apos;
        ///WHERE [Name] = &apos;DatabaseHelpVersion&apos;
        ///
        ///
        ///-- Update database schema version.
        ///UPDATE [DocmahConfiguration] SET [Value] = 2 WHERE [Name] = &apos;DatabaseSchemaVersion&apos;
        ///.
        /// </summary>
        internal static string Database_Update_02 {
            get {
                return ResourceManager.GetString("Database_Update_02", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Need to fake identity column so that Ids generated when writing documentation
        ///-- are used in production so that installation scripts can update help 
        ///-- without invalidating user settings.
        ///
        ///DECLARE @nextId INT 
        ///SELECT @nextId = ISNULL(MAX(Id), 0) + 1 FROM DocmahPages
        ///
        ///INSERT INTO [DocmahPages] (
        ///	[Id]
        ///	,[PageTypeId]
        ///	,[ParentPageId]
        ///	,[Order]
        ///	,[SourceUrl]
        ///	,[Title]
        ///	,[Content]
        ///	,[VerticalOffset]
        ///	,[HorizontalOffset]
        ///	,[OffsetElementId]
        ///	,[DocImageUrl]
        ///	,[DocVerticalOffset]
        ///	,[DocHori [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Page_Create {
            get {
                return ResourceManager.GetString("Page_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahPages]
        ///WHERE Id = @id.
        /// </summary>
        internal static string Page_Delete {
            get {
                return ResourceManager.GetString("Page_Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahPageUrls] WHERE PageId NOT IN (@pageIds)
        ///DELETE [DocmahPages] WHERE Id NOT IN (@pageIds).
        /// </summary>
        internal static string Page_DeleteExcept {
            get {
                return ResourceManager.GetString("Page_DeleteExcept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF EXISTS (SELECT 1 FROM DocmahPages WHERE Id = @id) BEGIN 
        ///	UPDATE DocmahPages SET 
        ///		PageTypeId = @pageTypeId, 
        ///		ParentPageId = @parentPageId,
        ///		[Order] = @order,
        ///		SourceUrl = @sourceUrl,
        ///		Title = @title,
        ///		Content = @content,
        ///		VerticalOffset = @verticalOffset,
        ///		HorizontalOffset = @horizontalOffset,
        ///		OffsetElementId = @offsetElementId,
        ///		DocImageUrl = @docImageUrl,
        ///		DocVerticalOffset = @docVerticalOffset,
        ///		DocHorizontalOffset = @docHorizontalOffset,
        ///		IsHidden = @isHidden 
        ///	WHERE Id [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Page_Import {
            get {
                return ResourceManager.GetString("Page_Import", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH Pages_CTE
        ///AS (
        ///	SELECT 
        ///		1 AS [Level],
        ///		[Id],
        ///		[ParentPageId],
        ///		[Order]
        ///	FROM [DocmahPages]
        ///	WHERE ParentPageId IS NULL
        ///
        ///	UNION ALL
        ///
        ///	SELECT 
        ///		[Parent].[Level] + 1 AS [Level],
        ///		[Page].[Id],
        ///		[Page].[ParentPageId],
        ///		[Page].[Order]
        ///	FROM [DocmahPages] AS [Page]
        ///		JOIN Pages_CTE AS Parent ON [Page].ParentPageId = Parent.Id
        ///)
        ///SELECT Pages.*
        ///FROM DocmahPages AS Pages
        ///	JOIN Pages_CTE AS Cte ON Pages.Id = Cte.Id
        ///ORDER BY Cte.[Level],Cte.[Order].
        /// </summary>
        internal static string Page_ReadAll {
            get {
                return ResourceManager.GetString("Page_ReadAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT *
        ///FROM [DocmahPages]
        ///WHERE Id = @id.
        /// </summary>
        internal static string Page_ReadById {
            get {
                return ResourceManager.GetString("Page_ReadById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///SELECT *
        ///FROM [DocmahPages]
        ///WHERE ISNULL(@parentId, -1) = ISNULL(ParentPageId, -1)
        ///ORDER BY [Order]
        ///.
        /// </summary>
        internal static string Page_ReadByParentId {
            get {
                return ResourceManager.GetString("Page_ReadByParentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///DECLARE @hitCount INT
        ///
        ///SELECT @hitCount = COUNT(*)
        ///FROM DocmahPageUrls
        ///WHERE @url = Url
        ///
        ///IF @hitCount &gt; 0 BEGIN	
        ///	SELECT P.*
        ///	FROM DocmahPages AS P
        ///		JOIN DocmahPageUrls AS U ON U.PageId = P.Id
        ///	WHERE @url = U.Url
        ///END ELSE BEGIN
        ///	SELECT P.*
        ///	FROM DocmahPages AS P
        ///		JOIN DocmahPageUrls AS U ON U.PageId = P.Id
        ///	WHERE @url LIKE U.Url
        ///END.
        /// </summary>
        internal static string Page_ReadByUrl {
            get {
                return ResourceManager.GetString("Page_ReadByUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WITH Pages_CTE
        ///AS (
        ///	SELECT 
        ///		1 AS [Level],
        ///		[Id],[ParentPageId],[Order],[Title],[IsHidden]
        ///	FROM [DocmahPages]
        ///	WHERE ParentPageId IS NULL
        ///		AND (@includeHidden = 1 OR [IsHidden] = 0)
        ///
        ///	UNION ALL
        ///
        ///	SELECT 
        ///		[Parent].[Level] + 1 AS [Level],
        ///		[Page].[Id],[Page].[ParentPageId],[Page].[Order],[Page].[Title],[Page].[IsHidden]
        ///	FROM [DocmahPages] AS [Page]
        ///		JOIN Pages_CTE AS Parent ON [Page].ParentPageId = Parent.Id
        ///	WHERE @includeHidden = 1 OR [Page].[IsHidden] = 0
        ///)
        ///SELECT [Id],[ParentPa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Page_ReadTableOfContents {
            get {
                return ResourceManager.GetString("Page_ReadTableOfContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [DocmahPages]
        ///   SET [PageTypeId] = @pageTypeId
        ///      ,[ParentPageId] = @parentPageId
        ///      ,[Order] = @order
        ///      ,[SourceUrl] = @sourceUrl
        ///      ,[Title] = @title
        ///      ,[Content] = @content
        ///      ,[VerticalOffset] = @verticalOffset
        ///      ,[HorizontalOffset] = @horizontalOffset
        ///      ,[OffsetElementId] = @offsetElementId
        ///	  ,[DocImageUrl] = @docImageUrl
        ///	  ,[DocVerticalOffset] = @docVerticalOffset
        ///	  ,[DocHorizontalOffset] = @docHorizontalOffset
        ///	  ,[IsHidden] = @isHidden
        /// WHERE Id = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Page_Update {
            get {
                return ResourceManager.GetString("Page_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [DocmahPageUrls] (
        ///	[Url]
        ///	,[PageId]
        ///) VALUES (
        ///	@url
        ///	,@pageId
        ///).
        /// </summary>
        internal static string PageUrl_Create {
            get {
                return ResourceManager.GetString("PageUrl_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE DocmahPageUrls
        ///WHERE PageId = @pageId.
        /// </summary>
        internal static string PageUrl_DeleteByPageId {
            get {
                return ResourceManager.GetString("PageUrl_DeleteByPageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT *
        ///FROM DocmahPageUrls
        ///WHERE PageId = @pageId.
        /// </summary>
        internal static string PageUrl_ReadByPageId {
            get {
                return ResourceManager.GetString("PageUrl_ReadByPageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [DocmahUserPageSettings](
        ///	[UserName]
        ///	,[PageId]
        ///	,[HidePage]
        ///)
        ///OUTPUT Inserted.ID
        ///VALUES (
        ///	 @userName
        ///	,@pageId
        ///	,@hidePage
        ///).
        /// </summary>
        internal static string UserPageSettings_Create {
            get {
                return ResourceManager.GetString("UserPageSettings_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string UserPageSettings_DeleteByPageId {
            get {
                return ResourceManager.GetString("UserPageSettings_DeleteByPageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE [DocmahUserPageSettings] WHERE PageId NOT IN (@pageIds).
        /// </summary>
        internal static string UserPageSettings_DeleteExcept {
            get {
                return ResourceManager.GetString("UserPageSettings_DeleteExcept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT *
        ///FROM DocmahUserPageSettings
        ///WHERE 
        ///	UserName = @userName 
        ///	AND PageId = @pageId.
        /// </summary>
        internal static string UserPageSettings_ReadByUserAndPage {
            get {
                return ResourceManager.GetString("UserPageSettings_ReadByUserAndPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [DocmahUserPageSettings]
        ///   SET [UserName] = @userName
        ///      ,[PageId] = @pageId
        ///      ,[HidePage] = @hidePage
        /// WHERE Id = @id.
        /// </summary>
        internal static string UserPageSettings_Update {
            get {
                return ResourceManager.GetString("UserPageSettings_Update", resourceCulture);
            }
        }
    }
}
