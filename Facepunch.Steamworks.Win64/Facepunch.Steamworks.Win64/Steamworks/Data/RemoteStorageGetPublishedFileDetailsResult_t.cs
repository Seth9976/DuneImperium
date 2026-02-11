using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200012D RID: 301
	public sealed class RemoteStorageGetPublishedFileDetailsResult_t : ValueType
	{
		// Token: 0x060010C6 RID: 4294 RVA: 0x00060E30 File Offset: 0x0005F030
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageGetPublishedFileDetailsResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemoteStorageGetPublishedFileDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Result");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "PublishedFileId");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_CreatorAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "CreatorAppID");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_ConsumerAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "ConsumerAppID");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Title");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Description");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_File = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "File");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "PreviewFile");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_SteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "SteamIDOwner");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "TimeCreated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "TimeUpdated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Visibility");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Banned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Banned");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "Tags");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TagsTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "TagsTruncated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PchFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "PchFileName");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "FileSize");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "PreviewFileSize");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "URL");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "FileType");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_AcceptedForUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "AcceptedForUse");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "_datasize");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_TitleUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666966);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666967);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_TagsUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666968);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666969);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666970);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666971);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100666972);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000610A4 File Offset: 0x0005F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950461, XrefRangeEnd = 950465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TitleUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_TitleUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000610E0 File Offset: 0x0005F2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950465, XrefRangeEnd = 950469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DescriptionUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0006111C File Offset: 0x0005F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950469, XrefRangeEnd = 950473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TagsUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_TagsUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00061158 File Offset: 0x0005F358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950473, XrefRangeEnd = 950477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PchFileNameUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00061194 File Offset: 0x0005F394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950477, XrefRangeEnd = 950481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string URLUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_URLUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x000611D0 File Offset: 0x0005F3D0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950481, XrefRangeEnd = 950485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x00061214 File Offset: 0x0005F414
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00004C8D File Offset: 0x00002E8D
		public RemoteStorageGetPublishedFileDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00004C96 File Offset: 0x00002E96
		public RemoteStorageGetPublishedFileDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00061258 File Offset: 0x0005F458
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00004CA8 File Offset: 0x00002EA8
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00061280 File Offset: 0x0005F480
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00004CC3 File Offset: 0x00002EC3
		public unsafe PublishedFileId PublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PublishedFileId)) = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x000612A8 File Offset: 0x0005F4A8
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x00004CDE File Offset: 0x00002EDE
		public unsafe AppId CreatorAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_CreatorAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_CreatorAppID)) = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x000612D0 File Offset: 0x0005F4D0
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00004CF9 File Offset: 0x00002EF9
		public unsafe AppId ConsumerAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_ConsumerAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_ConsumerAppID)) = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x000612F8 File Offset: 0x0005F4F8
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe Il2CppStructArray<byte> Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00061328 File Offset: 0x0005F528
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00004D33 File Offset: 0x00002F33
		public unsafe Il2CppStructArray<byte> Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00061358 File Offset: 0x0005F558
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00004D52 File Offset: 0x00002F52
		public unsafe ulong File
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_File);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_File)) = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00061380 File Offset: 0x0005F580
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00004D6D File Offset: 0x00002F6D
		public unsafe ulong PreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFile)) = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000613A8 File Offset: 0x0005F5A8
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x00004D88 File Offset: 0x00002F88
		public unsafe ulong SteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_SteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_SteamIDOwner)) = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000613D0 File Offset: 0x0005F5D0
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00004DA3 File Offset: 0x00002FA3
		public unsafe uint TimeCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeCreated)) = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000613F8 File Offset: 0x0005F5F8
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00004DBE File Offset: 0x00002FBE
		public unsafe uint TimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TimeUpdated)) = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00061420 File Offset: 0x0005F620
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00004DD9 File Offset: 0x00002FD9
		public unsafe RemoteStoragePublishedFileVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00061448 File Offset: 0x0005F648
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public unsafe bool Banned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Banned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Banned)) = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00061470 File Offset: 0x0005F670
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x00004E0F File Offset: 0x0000300F
		public unsafe Il2CppStructArray<byte> Tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x000614A0 File Offset: 0x0005F6A0
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00004E2E File Offset: 0x0000302E
		public unsafe bool TagsTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TagsTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_TagsTruncated)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x000614C8 File Offset: 0x0005F6C8
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00004E49 File Offset: 0x00003049
		public unsafe Il2CppStructArray<byte> PchFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PchFileName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PchFileName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x000614F8 File Offset: 0x0005F6F8
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00004E68 File Offset: 0x00003068
		public unsafe int FileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileSize)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00061520 File Offset: 0x0005F720
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00004E83 File Offset: 0x00003083
		public unsafe int PreviewFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_PreviewFileSize)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00061548 File Offset: 0x0005F748
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00004E9E File Offset: 0x0000309E
		public unsafe Il2CppStructArray<byte> URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_URL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_URL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00061578 File Offset: 0x0005F778
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x00004EBD File Offset: 0x000030BD
		public unsafe WorkshopFileType FileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_FileType)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x000615A0 File Offset: 0x0005F7A0
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x00004ED8 File Offset: 0x000030D8
		public unsafe bool AcceptedForUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_AcceptedForUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_AcceptedForUse)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x000615C8 File Offset: 0x0005F7C8
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x00004EF3 File Offset: 0x000030F3
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_PublishedFileId;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_CreatorAppID;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_ConsumerAppID;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_File;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_PreviewFile;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDOwner;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_TimeCreated;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_TimeUpdated;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_Banned;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_Tags;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_TagsTruncated;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_PchFileName;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr_FileSize;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr_PreviewFileSize;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr_FileType;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedForUse;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_TitleUTF8_Internal_String_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_DescriptionUTF8_Internal_String_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_TagsUTF8_Internal_String_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_PchFileNameUTF8_Internal_String_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_URLUTF8_Internal_String_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
