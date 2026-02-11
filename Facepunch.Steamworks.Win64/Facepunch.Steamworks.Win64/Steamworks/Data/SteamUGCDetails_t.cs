using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C3 RID: 451
	public sealed class SteamUGCDetails_t : ValueType
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x00070350 File Offset: 0x0006E550
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCDetails_t()
		{
			Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamUGCDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr);
			SteamUGCDetails_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "PublishedFileId");
			SteamUGCDetails_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Result");
			SteamUGCDetails_t.NativeFieldInfoPtr_FileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "FileType");
			SteamUGCDetails_t.NativeFieldInfoPtr_CreatorAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "CreatorAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_ConsumerAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "ConsumerAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Title");
			SteamUGCDetails_t.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Description");
			SteamUGCDetails_t.NativeFieldInfoPtr_SteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "SteamIDOwner");
			SteamUGCDetails_t.NativeFieldInfoPtr_TimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "TimeCreated");
			SteamUGCDetails_t.NativeFieldInfoPtr_TimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "TimeUpdated");
			SteamUGCDetails_t.NativeFieldInfoPtr_TimeAddedToUserList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "TimeAddedToUserList");
			SteamUGCDetails_t.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Visibility");
			SteamUGCDetails_t.NativeFieldInfoPtr_Banned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Banned");
			SteamUGCDetails_t.NativeFieldInfoPtr_AcceptedForUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "AcceptedForUse");
			SteamUGCDetails_t.NativeFieldInfoPtr_TagsTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "TagsTruncated");
			SteamUGCDetails_t.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Tags");
			SteamUGCDetails_t.NativeFieldInfoPtr_File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "File");
			SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "PreviewFile");
			SteamUGCDetails_t.NativeFieldInfoPtr_PchFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "PchFileName");
			SteamUGCDetails_t.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "FileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "PreviewFileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "URL");
			SteamUGCDetails_t.NativeFieldInfoPtr_VotesUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "VotesUp");
			SteamUGCDetails_t.NativeFieldInfoPtr_VotesDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "VotesDown");
			SteamUGCDetails_t.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "Score");
			SteamUGCDetails_t.NativeFieldInfoPtr_NumChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "NumChildren");
			SteamUGCDetails_t.NativeMethodInfoPtr_TitleUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100667479);
			SteamUGCDetails_t.NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100667480);
			SteamUGCDetails_t.NativeMethodInfoPtr_TagsUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100667481);
			SteamUGCDetails_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100667482);
			SteamUGCDetails_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100667483);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x000705EC File Offset: 0x0006E7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951395, RefRangeEnd = 951396, XrefRangeStart = 951391, XrefRangeEnd = 951395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TitleUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_TitleUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00070628 File Offset: 0x0006E828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951400, RefRangeEnd = 951401, XrefRangeStart = 951396, XrefRangeEnd = 951400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DescriptionUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00070664 File Offset: 0x0006E864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951405, RefRangeEnd = 951406, XrefRangeStart = 951401, XrefRangeEnd = 951405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TagsUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_TagsUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000706A0 File Offset: 0x0006E8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951406, XrefRangeEnd = 951410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PchFileNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000706DC File Offset: 0x0006E8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951410, XrefRangeEnd = 951414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string URLUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000077C6 File Offset: 0x000059C6
		public SteamUGCDetails_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000077CF File Offset: 0x000059CF
		public SteamUGCDetails_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr))
		{
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00070718 File Offset: 0x0006E918
		// (set) Token: 0x060016B2 RID: 5810 RVA: 0x000077E1 File Offset: 0x000059E1
		public unsafe PublishedFileId PublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PublishedFileId)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x00070740 File Offset: 0x0006E940
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x000077FC File Offset: 0x000059FC
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00070768 File Offset: 0x0006E968
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x00007817 File Offset: 0x00005A17
		public unsafe WorkshopFileType FileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_FileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_FileType)) = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x00070790 File Offset: 0x0006E990
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00007832 File Offset: 0x00005A32
		public unsafe AppId CreatorAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_CreatorAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_CreatorAppID)) = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000707B8 File Offset: 0x0006E9B8
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x0000784D File Offset: 0x00005A4D
		public unsafe AppId ConsumerAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_ConsumerAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_ConsumerAppID)) = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000707E0 File Offset: 0x0006E9E0
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00007868 File Offset: 0x00005A68
		public unsafe Il2CppStructArray<byte> Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00070810 File Offset: 0x0006EA10
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00007887 File Offset: 0x00005A87
		public unsafe Il2CppStructArray<byte> Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00070840 File Offset: 0x0006EA40
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x000078A6 File Offset: 0x00005AA6
		public unsafe ulong SteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_SteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_SteamIDOwner)) = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00070868 File Offset: 0x0006EA68
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x000078C1 File Offset: 0x00005AC1
		public unsafe uint TimeCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeCreated)) = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00070890 File Offset: 0x0006EA90
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x000078DC File Offset: 0x00005ADC
		public unsafe uint TimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeUpdated)) = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x000708B8 File Offset: 0x0006EAB8
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x000078F7 File Offset: 0x00005AF7
		public unsafe uint TimeAddedToUserList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeAddedToUserList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TimeAddedToUserList)) = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x000708E0 File Offset: 0x0006EAE0
		// (set) Token: 0x060016C8 RID: 5832 RVA: 0x00007912 File Offset: 0x00005B12
		public unsafe RemoteStoragePublishedFileVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060016C9 RID: 5833 RVA: 0x00070908 File Offset: 0x0006EB08
		// (set) Token: 0x060016CA RID: 5834 RVA: 0x0000792D File Offset: 0x00005B2D
		public unsafe bool Banned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Banned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Banned)) = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x00070930 File Offset: 0x0006EB30
		// (set) Token: 0x060016CC RID: 5836 RVA: 0x00007948 File Offset: 0x00005B48
		public unsafe bool AcceptedForUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_AcceptedForUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_AcceptedForUse)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00070958 File Offset: 0x0006EB58
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00007963 File Offset: 0x00005B63
		public unsafe bool TagsTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TagsTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_TagsTruncated)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00070980 File Offset: 0x0006EB80
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000797E File Offset: 0x00005B7E
		public unsafe Il2CppStructArray<byte> Tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x000709B0 File Offset: 0x0006EBB0
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x0000799D File Offset: 0x00005B9D
		public unsafe ulong File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_File);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_File)) = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x000709D8 File Offset: 0x0006EBD8
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe ulong PreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFile)) = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00070A00 File Offset: 0x0006EC00
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x000079D3 File Offset: 0x00005BD3
		public unsafe Il2CppStructArray<byte> PchFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PchFileName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PchFileName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00070A30 File Offset: 0x0006EC30
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x000079F2 File Offset: 0x00005BF2
		public unsafe int FileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_FileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_FileSize)) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00070A58 File Offset: 0x0006EC58
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00007A0D File Offset: 0x00005C0D
		public unsafe int PreviewFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_PreviewFileSize)) = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00070A80 File Offset: 0x0006EC80
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x00007A28 File Offset: 0x00005C28
		public unsafe Il2CppStructArray<byte> URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_URL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_URL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00070AB0 File Offset: 0x0006ECB0
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x00007A47 File Offset: 0x00005C47
		public unsafe uint VotesUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_VotesUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_VotesUp)) = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x00070AD8 File Offset: 0x0006ECD8
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00007A62 File Offset: 0x00005C62
		public unsafe uint VotesDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_VotesDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_VotesDown)) = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00070B00 File Offset: 0x0006ED00
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x00007A7D File Offset: 0x00005C7D
		public unsafe float Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00070B28 File Offset: 0x0006ED28
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x00007A98 File Offset: 0x00005C98
		public unsafe uint NumChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_NumChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_NumChildren)) = value;
			}
		}

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_FileType;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr_CreatorAppID;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_ConsumerAppID;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDOwner;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_TimeCreated;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_TimeUpdated;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_TimeAddedToUserList;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr_Banned;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedForUse;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_TagsTruncated;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_Tags;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeFieldInfoPtr_File;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeFieldInfoPtr_PreviewFile;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_PchFileName;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeFieldInfoPtr_FileSize;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_PreviewFileSize;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_VotesUp;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr_VotesDown;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeFieldInfoPtr_NumChildren;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_TitleUTF8_Internal_String_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_TagsUTF8_Internal_String_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_URLUTF8_Internal_String_0;
	}
}
