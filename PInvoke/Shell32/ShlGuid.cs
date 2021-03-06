using System;

namespace Vanara.PInvoke
{
	public static partial class Shell32
	{
		/// <summary>Service ID to find common dialog browser.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SCommDlgBrowser = new Guid(0x80f30233, 0xb7df, 0x11d2, 0xa3, 0x3b, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SGetViewFromViewDual = new Guid(0x889A935D, 0x971E, 0x4B12, 0xB9, 0x0C, 0x24, 0xDF, 0xC9, 0xE1, 0xE5, 0xE8);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_ShellFolderViewCB = typeof(IShellFolderViewCB).GUID;

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SInPlaceBrowser = new Guid(0x1D2AE02B, 0x3655, 0x46CC, 0xB6, 0x3A, 0x28, 0x59, 0x88, 0x15, 0x3B, 0xCA);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SInternetExplorer = new Guid("0002DF05-0000-0000-C000-000000000046");

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandBKContextMenu = new Guid(0x164bbd86, 0x1d0d, 0x4de0, 0x9a, 0x3b, 0xd9, 0x72, 0x96, 0x47, 0xc2, 0xb8);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandBottom = new Guid(0x743ca664, 0xdeb, 0x11d1, 0x98, 0x25, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandBottomSelected = new Guid(0x165ebaf4, 0x6d51, 0x11d2, 0x83, 0xad, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandChild = new Guid(0xed9cc020, 0x8b9, 0x11d1, 0x98, 0x23, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandContextMenuModifier = new Guid(0x39545874, 0x7162, 0x465e, 0xb7, 0x83, 0x2a, 0xa1, 0x87, 0x4f, 0xef, 0x81);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandParent = new Guid(0x8c278eec, 0x3eab, 0x11d1, 0x8c, 0xb0, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuBandTop = new Guid(0x9493a810, 0xec38, 0x11d0, 0xbc, 0x46, 0x0, 0xaa, 0x0, 0x6c, 0xe2, 0xf5);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SMenuPopup = new Guid(0xD1E7AFEB, 0x6A2E, 0x11d0, 0x8C, 0x78, 0x0, 0xC0, 0x4F, 0xD9, 0x18, 0xB4);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SProgressUI = new Guid(0xf8383852, 0xfcd3, 0x11d1, 0xa6, 0xb9, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SSearchBoxInfo = new Guid(0x142daa61, 0x516b, 0x4713, 0xb4, 0x9c, 0xfb, 0x98, 0x5e, 0xf8, 0x29, 0x98);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SShellBrowser = typeof(IShellBrowser).GUID;

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SShellDesktop = new Guid("00021400-0000-0000-C000-000000000046");

		/// <summary>Service ID to find top-level browser.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_STopLevelBrowser = new Guid(0x4C96BE40, 0x915C, 0x11CF, 0x99, 0xD3, 0x00, 0xAA, 0x00, 0x4A, 0xE8, 0x37);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_STopWindow = new Guid(0x49e1b500, 0x4636, 0x11d3, 0x97, 0xf7, 0x0, 0xc0, 0x4f, 0x45, 0xd0, 0xb3);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SUrlHistory = new Guid(0x3C374A40, 0xBAE4, 0x11CF, 0xBF, 0x7D, 0x00, 0xAA, 0x00, 0x69, 0x46, 0xEE);

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");

		/// <summary>Undocumented.</summary>
		[PInvokeData("shlguid.h")]
		public static readonly Guid SID_SWebBrowserEventsService = new Guid("54A8F188-9EBD-4795-AD16-9B4945119636");

		/// <summary>Reference to a GUID that specifies which handler will be created.</summary>
		[PInvokeData("shlguid.h")]
		public enum BHID
		{
			/// <summary>Restricts usage to BindToObject.</summary>
			[Associate("{3981e224-f559-11d3-8e3a-00c04f6837d5}")]
			BHID_SFObject = 1,

			/// <summary>Restricts usage to GetUIObjectOf.</summary>
			[Associate("{3981e225-f559-11d3-8e3a-00c04f6837d5}")]
			BHID_SFUIObject,

			/// <summary>Restricts usage to CreateViewObject.</summary>
			[Associate("{3981e226-f559-11d3-8e3a-00c04f6837d5}")]
			BHID_SFViewObject,

			/// <summary>Attempts to retrieve the storage RIID, but defaults to Shell implementation on failure.</summary>
			[Associate("{3981e227-f559-11d3-8e3a-00c04f6837d5}")]
			BHID_Storage,

			/// <summary>Restricts usage to IStream.</summary>
			[Associate("{1CEBB3AB-7C10-499a-A417-92CA16C4CB83}")]
			BHID_Stream,

			/// <summary>Introduced in Windows 8: Gets an IRandomAccessStream object for the item.</summary>
			[Associate("{f16fc93b-77ae-4cfe-bda7-a866eea6878d}")]
			BHID_RandomAccessStream,

			/// <summary>
			/// CLSID_ShellItem is initialized with the target of this item (can only be SFGAO_LINK). See GetAttributesOf for a description
			/// of SFGAO_LINK.
			/// </summary>
			[Associate("{3981e228-f559-11d3-8e3a-00c04f6837d5}")]
			BHID_LinkTargetItem,

			/// <summary>If the item is a folder, gets an IEnumShellItems object with which to enumerate the storage contents.</summary>
			[Associate("{4621A4E3-F0D6-4773-8A9C-46E77B174840}")]
			BHID_StorageEnum,

			/// <summary>Introduced in Windows Vista: If the item is a folder, gets an ITransferSource or ITransferDestination object.</summary>
			[Associate("{5D080304-FE2C-48fc-84CE-CF620B0F3C53}")]
			BHID_Transfer,

			/// <summary>Introduced in Windows Vista: Restricts usage to IPropertyStore or IPropertyStoreFactory.</summary>
			[Associate("{0384e1a4-1523-439c-a4c8-ab911052f586}")]
			BHID_PropertyStore,

			/// <summary>Introduced in Windows Vista: Restricts usage to IExtractImage or IThumbnailProvider.</summary>
			[Associate("{7b2e650a-8e20-4f4a-b09e-6597afc72fb0}")]
			BHID_ThumbnailHandler,

			/// <summary>
			/// Introduced in Windows Vista: If the item is a folder, gets an IEnumShellItems object that enumerates all items in the folder.
			/// This includes folders, nonfolders, and hidden items.
			/// </summary>
			[Associate("{94f60519-2850-4924-aa5a-d15e84868039}")]
			BHID_EnumItems,

			/// <summary>Introduced in Windows Vista: Gets an IDataObject object for use with an item or an array of items.</summary>
			[Associate("{B8C0BD9F-ED24-455c-83E6-D5390C4FE8C4}")]
			BHID_DataObject,

			/// <summary>Introduced in Windows Vista: Gets an IQueryAssociations object for use with an item or an array of items.</summary>
			[Associate("{bea9ef17-82f1-4f60-9284-4f8db75c3be9}")]
			BHID_AssociationArray,

			/// <summary>Introduced in Windows Vista: Restricts usage to IFilter.</summary>
			[Associate("{38d08778-f557-4690-9ebf-ba54706ad8f7}")]
			BHID_Filter,

			/// <summary>
			/// Introduced in Windows 7: Gets an IEnumAssocHandlers object used to enumerate the recommended association handlers for the
			/// given item.
			/// </summary>
			[Associate("{b8ab0b9c-c2ec-4f7a-918d-314900e6280a}")]
			BHID_EnumAssocHandlers,

			/// <summary>Introduced in Windows 8.1: Gets an object used to provide placeholder file functionality.</summary>
			[Associate("{8677DCEB-AAE0-4005-8D3D-547FA852F825}")]
			BHID_FilePlaceholder,
		}

		/// <summary>The FOLDERTYPEID values represent a view template applied to a folder, usually based on its intended use and contents.</summary>
		[PInvokeData("Shlguid.h")]
		public enum FOLDERTYPEID
		{
			/// <summary>Introduced in Windows 8. The folder contains the image files used with the current user's account.</summary>
			[Associate("{db2a5d8f-06e6-4007-aba6-af877d526ea6}")]
			FOLDERTYPEID_AccountPictures,

			/// <summary>
			/// Introduced in Windows 7. A folder that contains communication-related files such as emails, calendar information, and contact information.
			/// </summary>
			[Associate("{91475fe5-586b-4eba-8d75-d17434b8cdf6}")]
			FOLDERTYPEID_Communications,

			/// <summary>The folder is a compressed archive, such as a compressed file with a .zip file name extension.</summary>
			[Associate("{80213e82-bcfd-4c4f-8817-bb27601267a9}")]
			FOLDERTYPEID_CompressedFolder,

			/// <summary>A folder that contains email contact information.</summary>
			[Associate("{de2b70ec-9bf7-4a93-bd3d-243f7881d492}")]
			FOLDERTYPEID_Contacts,

			/// <summary>The Control Panel in category view. This is a virtual folder.</summary>
			[Associate("A folder that contains email contact information.")]
			FOLDERTYPEID_ControlPanelCategory,

			/// <summary>The Control Panel in classic view. This is a virtual folder.</summary>
			[Associate("{0c3794f3-b545-43aa-a329-c37430c58d2a}")]
			FOLDERTYPEID_ControlPanelClassic,

			/// <summary>The folder contains document files. These can be of mixed format�.doc, .txt, and others.</summary>
			[Associate("{7d49d726-3c21-4f05-99aa-fdc2c9474656}")]
			FOLDERTYPEID_Documents,

			/// <summary>The folder is the Games folder found in the Start menu.</summary>
			[Associate("{b689b0d0-76d3-4cbb-87f7-585d0e0ce070}")]
			FOLDERTYPEID_Games,

			/// <summary>Introduced in Windows 7. The folder does not fall under one of the other FOLDERTYPEID categories.</summary>
			[Associate("{5c4f28b5-f869-4e84-8e60-f11db97c5cc7}")]
			FOLDERTYPEID_Generic,

			/// <summary>Introduced in Windows 7. The folder is a library, but of no specified type.</summary>
			[Associate("{5f4eab9a-6833-4f61-899d-31cf46979d49}")]
			FOLDERTYPEID_GenericLibrary,

			/// <summary>Introduced in Windows 7. The folder contains search results, but they are of mixed or no specific type.</summary>
			[Associate("{7fde1a1e-8b31-49a5-93b8-6be14cfa4943}")]
			FOLDERTYPEID_GenericSearchResults,

			/// <summary>
			/// The folder is invalid. There are several things that can cause this judgement: hard disk errors, file system errors, and
			/// compression errors among them.
			/// </summary>
			[Associate("{57807898-8c4f-4462-bb63-71042380b109}")]
			FOLDERTYPEID_Invalid,

			/// <summary>Introduced in Windows 7. The folder contains audio files, such as .mp3 and .wma files.</summary>
			[Associate("{94d6ddcc-4a68-4175-a374-bd584a510b78}")]
			FOLDERTYPEID_Music,

			/// <summary>The Network Explorer folder.</summary>
			[Associate("{25CC242B-9A7C-4f51-80E0-7A2928FEBE42}")]
			FOLDERTYPEID_NetworkExplorer,

			/// <summary>Introduced in Windows 7. The folder contains federated search OpenSearch results.</summary>
			[Associate("{8faf9629-1980-46ff-8023-9dceab9c3ee3}")]
			FOLDERTYPEID_OpenSearch,

			/// <summary>Introduced in Windows 7.</summary>
			[Associate("{B337FD00-9DD5-4635-A6D4-DA33FD102B7A}")]
			FOLDERTYPEID_OtherUsers,

			/// <summary>Image files, such as .jpg, .tif, or .png files.</summary>
			[Associate("{b3690e58-e961-423b-b687-386ebfd83239}")]
			FOLDERTYPEID_Pictures,

			/// <summary>Printers that have been added to the system. This is a virtual folder.</summary>
			[Associate("{2c7bbec6-c844-4a0a-91fa-cef6f59cfda1}")]
			FOLDERTYPEID_Printers,

			/// <summary>Introduced in Windows 7. A homegroup user's libraries.</summary>
			[Associate("{7F2F5B96-FF74-41da-AFD8-1C78A5F3AEA2}")]
			FOLDERTYPEID_PublishedItems,

			/// <summary>Introduced in Windows 7. The folder contains recorded television broadcasts.</summary>
			[Associate("{5557a28f-5da6-4f83-8809-c2c98a11a6fa}")]
			FOLDERTYPEID_RecordedTV,

			/// <summary>The Recycle Bin. This is a virtual folder.</summary>
			[Associate("{d6d9e004-cd87-442b-9d57-5e0aeb4f6f72}")]
			FOLDERTYPEID_RecycleBin,

			/// <summary>Introduced in Windows 7. The folder contains saved game states.</summary>
			[Associate("{d0363307-28cb-4106-9f23-2956e3e5e0e7}")]
			FOLDERTYPEID_SavedGames,

			/// <summary>Introduced in Windows 7.</summary>
			[Associate("{982725ee-6f47-479e-b447-812bfa7d2e8f}")]
			FOLDERTYPEID_SearchConnector,

			/// <summary>Introduced in Windows 7.</summary>
			[Associate("{834d8a44-0974-4ed6-866e-f203d80b3810}")]
			FOLDERTYPEID_SearchHome,

			/// <summary>Introduced in Windows 7. A user's Searches folder, normally found at C:\Users\username\Searches.</summary>
			[Associate("{0b0ba2e3-405f-415e-a6ee-cad625207853}")]
			FOLDERTYPEID_Searches,

			/// <summary>The software explorer window used by the Add or Remove Programs control panel icon.</summary>
			[Associate("{d674391b-52d9-4e07-834e-67c98610f39d}")]
			FOLDERTYPEID_SoftwareExplorer,

			/// <summary>Introduced in Windows 7. A user's Start Menu folder, normally found at C:\Users\username\Start Menu.</summary>
			[Associate("{ef87b4cb-f2ce-4785-8658-4ca6c63e38c6}")]
			FOLDERTYPEID_StartMenu,

			/// <summary>
			/// Introduced in Windows 8.1. The folder is a MSFT_StorageProvider folder and contains document files. These can be of mixed
			/// format�.doc, .txt, and others.
			/// </summary>
			[Associate("{DD61BD66-70E8-48dd-9655-65C5E1AAC2D1}")]
			FOLDERTYPEID_StorageProviderDocuments,

			/// <summary>
			/// Introduced in Windows 8.1. The folder is a MSFT_StorageProvider folder and does not fall under one of the other FOLDERTYPEID categories.
			/// </summary>
			[Associate("{4F01EBC5-2385-41f2-A28E-2C5C91FB56E0}")]
			FOLDERTYPEID_StorageProviderGeneric,

			/// <summary>
			/// Introduced in Windows 8.1. The folder is a MSFT_StorageProvider folder and contains audio files, such as .mp3 and .wma files.
			/// </summary>
			[Associate("{672ECD7E-AF04-4399-875C-0290845B6247}")]
			FOLDERTYPEID_StorageProviderMusic,

			/// <summary>
			/// Introduced in Windows 8.1. The folder is a MSFT_StorageProvider folder and contains image files, such as .jpg, .tif, or .png files.
			/// </summary>
			[Associate("{71D642A9-F2B1-42cd-AD92-EB9300C7CC0A}")]
			FOLDERTYPEID_StorageProviderPictures,

			/// <summary>
			/// Introduced in Windows 8.1. The folder is a MSFT_StorageProvider folder and contains video files. These can be of mixed
			/// format�.wmv, .mov, and others.
			/// </summary>
			[Associate("{51294DA1-D7B1-485b-9E9A-17CFFE33E187}")]
			FOLDERTYPEID_StorageProviderVideos,

			/// <summary>The folder is the FOLDERID_UsersFiles folder.</summary>
			[Associate("{CD0FC69B-71E2-46e5-9690-5BCD9F57AAB3}")]
			FOLDERTYPEID_UserFiles,

			/// <summary>Introduced in Windows 7. The view shown when the user clicks the Windows Explorer button on the taskbar.</summary>
			[Associate("{5fa96407-7e77-483c-ac93-691d05850de8}")]
			FOLDERTYPEID_UsersLibraries,

			/// <summary>Introduced in Windows 7. The folder contains video files. These can be of mixed format�.wmv, .mov, and others.</summary>
			[Associate("{C4D98F09-6124-4fe0-9942-826416082DA9}")]
			FOLDERTYPEID_Videos,
		}
	}
}