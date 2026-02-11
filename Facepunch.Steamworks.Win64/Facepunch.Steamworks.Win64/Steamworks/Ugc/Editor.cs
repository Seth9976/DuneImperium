using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	// Token: 0x020000D1 RID: 209
	public sealed class Editor : ValueType
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x00054D08 File Offset: 0x00052F08
		// Note: this type is marked as 'beforefieldinit'.
		static Editor()
		{
			Il2CppClassPointerStore<Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Ugc", "Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Editor>.NativeClassPtr);
			Editor.NativeFieldInfoPtr_fileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "fileId");
			Editor.NativeFieldInfoPtr_creatingNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "creatingNew");
			Editor.NativeFieldInfoPtr_creatingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "creatingType");
			Editor.NativeFieldInfoPtr_consumerAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "consumerAppId");
			Editor.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "Title");
			Editor.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "Description");
			Editor.NativeFieldInfoPtr_MetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "MetaData");
			Editor.NativeFieldInfoPtr_ChangeLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "ChangeLog");
			Editor.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "Language");
			Editor.NativeFieldInfoPtr_PreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "PreviewFile");
			Editor.NativeFieldInfoPtr_ContentFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "ContentFolder");
			Editor.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "Visibility");
			Editor.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "Tags");
			Editor.NativeFieldInfoPtr_KeyValueTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "KeyValueTags");
			Editor.NativeFieldInfoPtr_KeyValueTagsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor>.NativeClassPtr, "KeyValueTagsToRemove");
			Editor.NativeMethodInfoPtr__ctor_Internal_Void_WorkshopFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666466);
			Editor.NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666467);
			Editor.NativeMethodInfoPtr_get_NewCommunityFile_Public_Static_get_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666468);
			Editor.NativeMethodInfoPtr_get_NewCollection_Public_Static_get_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666469);
			Editor.NativeMethodInfoPtr_get_NewMicrotransactionFile_Public_Static_get_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666470);
			Editor.NativeMethodInfoPtr_get_NewGameManagedFile_Public_Static_get_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666471);
			Editor.NativeMethodInfoPtr_ForAppId_Public_Editor_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666472);
			Editor.NativeMethodInfoPtr_WithTitle_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666473);
			Editor.NativeMethodInfoPtr_WithDescription_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666474);
			Editor.NativeMethodInfoPtr_WithMetaData_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666475);
			Editor.NativeMethodInfoPtr_WithChangeLog_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666476);
			Editor.NativeMethodInfoPtr_InLanguage_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666477);
			Editor.NativeMethodInfoPtr_WithPreviewFile_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666478);
			Editor.NativeMethodInfoPtr_WithContent_Public_Editor_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666479);
			Editor.NativeMethodInfoPtr_WithContent_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666480);
			Editor.NativeMethodInfoPtr_WithPublicVisibility_Public_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666481);
			Editor.NativeMethodInfoPtr_WithFriendsOnlyVisibility_Public_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666482);
			Editor.NativeMethodInfoPtr_WithPrivateVisibility_Public_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666483);
			Editor.NativeMethodInfoPtr_WithTag_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666484);
			Editor.NativeMethodInfoPtr_AddKeyValueTag_Public_Editor_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666485);
			Editor.NativeMethodInfoPtr_RemoveKeyValueTags_Public_Editor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666486);
			Editor.NativeMethodInfoPtr_SubmitAsync_Public_Task_1_PublishResult_IProgress_1_Single_Action_1_PublishResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor>.NativeClassPtr, 100666487);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0005501C File Offset: 0x0005321C
		[CallerCount(0)]
		public unsafe Editor(WorkshopFileType filetype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref filetype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr__ctor_Internal_Void_WorkshopFileType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00055068 File Offset: 0x00053268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 948665, RefRangeEnd = 948666, XrefRangeStart = 948665, XrefRangeEnd = 948665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor(PublishedFileId fileId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000550B4 File Offset: 0x000532B4
		public unsafe static Editor NewCommunityFile
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_get_NewCommunityFile_Public_Static_get_Editor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x000550E0 File Offset: 0x000532E0
		public unsafe static Editor NewCollection
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_get_NewCollection_Public_Static_get_Editor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0005510C File Offset: 0x0005330C
		public unsafe static Editor NewMicrotransactionFile
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_get_NewMicrotransactionFile_Public_Static_get_Editor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00055138 File Offset: 0x00053338
		public unsafe static Editor NewGameManagedFile
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_get_NewGameManagedFile_Public_Static_get_Editor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00055164 File Offset: 0x00053364
		[CallerCount(0)]
		public unsafe Editor ForAppId(AppId id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_ForAppId_Public_Editor_AppId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000551B0 File Offset: 0x000533B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948666, XrefRangeEnd = 948667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithTitle(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithTitle_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00055200 File Offset: 0x00053400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948667, XrefRangeEnd = 948668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithDescription(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithDescription_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00055250 File Offset: 0x00053450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948668, XrefRangeEnd = 948669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithMetaData(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithMetaData_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000552A0 File Offset: 0x000534A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948669, XrefRangeEnd = 948670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithChangeLog(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithChangeLog_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000552F0 File Offset: 0x000534F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948670, XrefRangeEnd = 948671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor InLanguage(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_InLanguage_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00055340 File Offset: 0x00053540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948671, XrefRangeEnd = 948672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithPreviewFile(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithPreviewFile_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00055390 File Offset: 0x00053590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948672, XrefRangeEnd = 948673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithContent(DirectoryInfo t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithContent_Public_Editor_DirectoryInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000553E0 File Offset: 0x000535E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948673, XrefRangeEnd = 948678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithContent(string folderName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folderName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithContent_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00055430 File Offset: 0x00053630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948678, XrefRangeEnd = 948681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithPublicVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithPublicVisibility_Public_Editor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Editor(intPtr);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0005546C File Offset: 0x0005366C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948681, XrefRangeEnd = 948684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithFriendsOnlyVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithFriendsOnlyVisibility_Public_Editor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Editor(intPtr);
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000554A8 File Offset: 0x000536A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948684, XrefRangeEnd = 948687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithPrivateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithPrivateVisibility_Public_Editor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Editor(intPtr);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000554E4 File Offset: 0x000536E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948687, XrefRangeEnd = 948699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor WithTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_WithTag_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00055534 File Offset: 0x00053734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948699, XrefRangeEnd = 948726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor AddKeyValueTag(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_AddKeyValueTag_Public_Editor_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Editor(intPtr);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00055594 File Offset: 0x00053794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948726, XrefRangeEnd = 948736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Editor RemoveKeyValueTags(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_RemoveKeyValueTags_Public_Editor_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Editor(intPtr);
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000555E4 File Offset: 0x000537E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948736, XrefRangeEnd = 948753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<PublishResult> SubmitAsync(IProgress<float> progress = null, Action<PublishResult> onItemCreated = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(progress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onItemCreated);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor.NativeMethodInfoPtr_SubmitAsync_Public_Task_1_PublishResult_IProgress_1_Single_Action_1_PublishResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<PublishResult>>(intPtr3) : null;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000034B2 File Offset: 0x000016B2
		public Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000034BB File Offset: 0x000016BB
		public Editor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Editor>.NativeClassPtr))
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0005564C File Offset: 0x0005384C
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000034CD File Offset: 0x000016CD
		public unsafe PublishedFileId fileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_fileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_fileId)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00055674 File Offset: 0x00053874
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000034E8 File Offset: 0x000016E8
		public unsafe bool creatingNew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_creatingNew);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_creatingNew)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x0005569C File Offset: 0x0005389C
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00003503 File Offset: 0x00001703
		public unsafe WorkshopFileType creatingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_creatingType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_creatingType)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000556C4 File Offset: 0x000538C4
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0000351E File Offset: 0x0000171E
		public unsafe AppId consumerAppId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_consumerAppId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_consumerAppId)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000556EC File Offset: 0x000538EC
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00003539 File Offset: 0x00001739
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x00055714 File Offset: 0x00053914
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00003558 File Offset: 0x00001758
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0005573C File Offset: 0x0005393C
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00003577 File Offset: 0x00001777
		public unsafe string MetaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_MetaData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_MetaData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00055764 File Offset: 0x00053964
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00003596 File Offset: 0x00001796
		public unsafe string ChangeLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_ChangeLog);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_ChangeLog), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0005578C File Offset: 0x0005398C
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x000035B5 File Offset: 0x000017B5
		public unsafe string Language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000557B4 File Offset: 0x000539B4
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x000035D4 File Offset: 0x000017D4
		public unsafe string PreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_PreviewFile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_PreviewFile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000557DC File Offset: 0x000539DC
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x000035F3 File Offset: 0x000017F3
		public unsafe DirectoryInfo ContentFolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_ContentFolder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_ContentFolder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0005580C File Offset: 0x00053A0C
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00003612 File Offset: 0x00001812
		public Nullable<RemoteStoragePublishedFileVisibility> Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Visibility);
				return new Nullable<RemoteStoragePublishedFileVisibility>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RemoteStoragePublishedFileVisibility>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Visibility), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RemoteStoragePublishedFileVisibility>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0005583C File Offset: 0x00053A3C
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00003640 File Offset: 0x00001840
		public unsafe List<string> Tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_Tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0005586C File Offset: 0x00053A6C
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x0000365F File Offset: 0x0000185F
		public unsafe Dictionary<string, List<string>> KeyValueTags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_KeyValueTags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_KeyValueTags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0005589C File Offset: 0x00053A9C
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x0000367E File Offset: 0x0000187E
		public unsafe HashSet<string> KeyValueTagsToRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_KeyValueTagsToRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor.NativeFieldInfoPtr_KeyValueTagsToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeFieldInfoPtr_fileId;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeFieldInfoPtr_creatingNew;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeFieldInfoPtr_creatingType;

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeFieldInfoPtr_consumerAppId;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr_MetaData;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr_ChangeLog;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_Language;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_PreviewFile;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_ContentFolder;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_Tags;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_KeyValueTags;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_KeyValueTagsToRemove;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WorkshopFileType_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PublishedFileId_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_get_NewCommunityFile_Public_Static_get_Editor_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_get_NewCollection_Public_Static_get_Editor_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_get_NewMicrotransactionFile_Public_Static_get_Editor_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_get_NewGameManagedFile_Public_Static_get_Editor_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_ForAppId_Public_Editor_AppId_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_WithTitle_Public_Editor_String_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_WithDescription_Public_Editor_String_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_WithMetaData_Public_Editor_String_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_WithChangeLog_Public_Editor_String_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_InLanguage_Public_Editor_String_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_WithPreviewFile_Public_Editor_String_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_WithContent_Public_Editor_DirectoryInfo_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_WithContent_Public_Editor_String_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_WithPublicVisibility_Public_Editor_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_WithFriendsOnlyVisibility_Public_Editor_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_WithPrivateVisibility_Public_Editor_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_WithTag_Public_Editor_String_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyValueTag_Public_Editor_String_String_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyValueTags_Public_Editor_String_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_SubmitAsync_Public_Task_1_PublishResult_IProgress_1_Single_Action_1_PublishResult_0;

		// Token: 0x0200028C RID: 652
		[ObfuscatedName("Steamworks.Ugc.Editor+<SubmitAsync>d__40")]
		public sealed class _SubmitAsync_d__40 : ValueType
		{
			// Token: 0x060020FF RID: 8447 RVA: 0x000904F0 File Offset: 0x0008E6F0
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitAsync_d__40()
			{
				Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Editor>.NativeClassPtr, "<SubmitAsync>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr);
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<>1__state");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<>t__builder");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "progress");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<>4__this");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr_onItemCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "onItemCreated");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr__result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<result>5__2");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<>u__1");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr__handle_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<handle>5__3");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr__updating_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<updating>5__4");
				Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, "<>u__2");
				Editor._SubmitAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, 100666488);
				Editor._SubmitAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr, 100666489);
			}

			// Token: 0x06002100 RID: 8448 RVA: 0x0009060C File Offset: 0x0008E80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948473, XrefRangeEnd = 948659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor._SubmitAsync_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002101 RID: 8449 RVA: 0x00090644 File Offset: 0x0008E844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948659, XrefRangeEnd = 948665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Editor._SubmitAsync_d__40.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002102 RID: 8450 RVA: 0x0000CCC1 File Offset: 0x0000AEC1
			public _SubmitAsync_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002103 RID: 8451 RVA: 0x0000CCCA File Offset: 0x0000AECA
			public _SubmitAsync_d__40()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Editor._SubmitAsync_d__40>.NativeClassPtr))
			{
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06002104 RID: 8452 RVA: 0x0009068C File Offset: 0x0008E88C
			// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000CCDC File Offset: 0x0000AEDC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06002106 RID: 8454 RVA: 0x000906B4 File Offset: 0x0008E8B4
			// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000CCF7 File Offset: 0x0000AEF7
			public AsyncTaskMethodBuilder<PublishResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<PublishResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<PublishResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<PublishResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06002108 RID: 8456 RVA: 0x000906E4 File Offset: 0x0008E8E4
			// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000CD25 File Offset: 0x0000AF25
			public unsafe IProgress<float> progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IProgress<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x0600210A RID: 8458 RVA: 0x00090714 File Offset: 0x0008E914
			// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000CD44 File Offset: 0x0000AF44
			public Editor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___4__this);
					return new Editor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Editor>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Editor>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x0600210C RID: 8460 RVA: 0x00090744 File Offset: 0x0008E944
			// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000CD72 File Offset: 0x0000AF72
			public unsafe Action<PublishResult> onItemCreated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr_onItemCreated);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PublishResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr_onItemCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x00090774 File Offset: 0x0008E974
			// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000CD91 File Offset: 0x0000AF91
			public unsafe PublishResult _result_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__result_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__result_5__2)) = value;
				}
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06002110 RID: 8464 RVA: 0x0009079C File Offset: 0x0008E99C
			// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000CDAC File Offset: 0x0000AFAC
			public CallResult<CreateItemResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__1);
					return new CallResult<CreateItemResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<CreateItemResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<CreateItemResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06002112 RID: 8466 RVA: 0x000907CC File Offset: 0x0008E9CC
			// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000CDDA File Offset: 0x0000AFDA
			public unsafe UGCUpdateHandle_t _handle_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__handle_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__handle_5__3)) = value;
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06002114 RID: 8468 RVA: 0x000907F4 File Offset: 0x0008E9F4
			// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000CDF5 File Offset: 0x0000AFF5
			public CallResult<SubmitItemUpdateResult_t> _updating_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__updating_5__4);
					return new CallResult<SubmitItemUpdateResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<SubmitItemUpdateResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr__updating_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<SubmitItemUpdateResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06002116 RID: 8470 RVA: 0x00090824 File Offset: 0x0008EA24
			// (set) Token: 0x06002117 RID: 8471 RVA: 0x0000CE23 File Offset: 0x0000B023
			public TaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Editor._SubmitAsync_d__40.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002312 RID: 8978
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002313 RID: 8979
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002314 RID: 8980
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x04002315 RID: 8981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002316 RID: 8982
			private static readonly IntPtr NativeFieldInfoPtr_onItemCreated;

			// Token: 0x04002317 RID: 8983
			private static readonly IntPtr NativeFieldInfoPtr__result_5__2;

			// Token: 0x04002318 RID: 8984
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002319 RID: 8985
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__3;

			// Token: 0x0400231A RID: 8986
			private static readonly IntPtr NativeFieldInfoPtr__updating_5__4;

			// Token: 0x0400231B RID: 8987
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400231C RID: 8988
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400231D RID: 8989
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
