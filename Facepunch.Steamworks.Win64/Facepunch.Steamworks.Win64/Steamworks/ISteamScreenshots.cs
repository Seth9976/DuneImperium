using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200002A RID: 42
	public class ISteamScreenshots : SteamInterface
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x0003485C File Offset: 0x00032A5C
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamScreenshots()
		{
			Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamScreenshots");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr);
			ISteamScreenshots.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664778);
			ISteamScreenshots.NativeMethodInfoPtr_SteamAPI_SteamScreenshots_v003_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664779);
			ISteamScreenshots.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664780);
			ISteamScreenshots.NativeMethodInfoPtr__WriteScreenshot_Private_Static_ScreenshotHandle_IntPtr_IntPtr_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664781);
			ISteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Internal_ScreenshotHandle_IntPtr_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664782);
			ISteamScreenshots.NativeMethodInfoPtr__AddScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664783);
			ISteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Internal_ScreenshotHandle_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664784);
			ISteamScreenshots.NativeMethodInfoPtr__TriggerScreenshot_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664785);
			ISteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664786);
			ISteamScreenshots.NativeMethodInfoPtr__HookScreenshots_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664787);
			ISteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664788);
			ISteamScreenshots.NativeMethodInfoPtr__SetLocation_Private_Static_Boolean_IntPtr_ScreenshotHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664789);
			ISteamScreenshots.NativeMethodInfoPtr_SetLocation_Internal_Boolean_ScreenshotHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664790);
			ISteamScreenshots.NativeMethodInfoPtr__TagUser_Private_Static_Boolean_IntPtr_ScreenshotHandle_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664791);
			ISteamScreenshots.NativeMethodInfoPtr_TagUser_Internal_Boolean_ScreenshotHandle_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664792);
			ISteamScreenshots.NativeMethodInfoPtr__TagPublishedFile_Private_Static_Boolean_IntPtr_ScreenshotHandle_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664793);
			ISteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Internal_Boolean_ScreenshotHandle_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664794);
			ISteamScreenshots.NativeMethodInfoPtr__IsScreenshotsHooked_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664795);
			ISteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664796);
			ISteamScreenshots.NativeMethodInfoPtr__AddVRScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_VRScreenshotType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664797);
			ISteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Internal_ScreenshotHandle_VRScreenshotType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr, 100664798);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00034A30 File Offset: 0x00032C30
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamScreenshots(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamScreenshots>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00034A78 File Offset: 0x00032C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935067, XrefRangeEnd = 935069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamScreenshots_v003()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_SteamAPI_SteamScreenshots_v003_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00034AA8 File Offset: 0x00032CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamScreenshots.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00034AF0 File Offset: 0x00032CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935069, XrefRangeEnd = 935071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle _WriteScreenshot(IntPtr self, IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pubRGB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubRGB;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__WriteScreenshot_Private_Static_ScreenshotHandle_IntPtr_IntPtr_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00034B68 File Offset: 0x00032D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935073, RefRangeEnd = 935074, XrefRangeStart = 935071, XrefRangeEnd = 935073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenshotHandle WriteScreenshot(IntPtr pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pubRGB;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubRGB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_WriteScreenshot_Internal_ScreenshotHandle_IntPtr_UInt32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00034BDC File Offset: 0x00032DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935074, XrefRangeEnd = 935079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle _AddScreenshotToLibrary(IntPtr self, string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchThumbnailFilename);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__AddScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00034C5C File Offset: 0x00032E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935084, RefRangeEnd = 935085, XrefRangeStart = 935079, XrefRangeEnd = 935084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchThumbnailFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_AddScreenshotToLibrary_Internal_ScreenshotHandle_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00034CD8 File Offset: 0x00032ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935085, XrefRangeEnd = 935087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _TriggerScreenshot(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__TriggerScreenshot_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00034D0C File Offset: 0x00032F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935089, RefRangeEnd = 935090, XrefRangeStart = 935087, XrefRangeEnd = 935089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_TriggerScreenshot_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00034D40 File Offset: 0x00032F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935090, XrefRangeEnd = 935092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _HookScreenshots(IntPtr self, bool bHook)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHook;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__HookScreenshots_Private_Static_Void_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00034D80 File Offset: 0x00032F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935094, RefRangeEnd = 935095, XrefRangeStart = 935092, XrefRangeEnd = 935094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HookScreenshots(bool bHook)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bHook;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_HookScreenshots_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00034DC0 File Offset: 0x00032FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935095, XrefRangeEnd = 935098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetLocation(IntPtr self, ScreenshotHandle hScreenshot, string pchLocation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hScreenshot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__SetLocation_Private_Static_Boolean_IntPtr_ScreenshotHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00034E20 File Offset: 0x00033020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935101, RefRangeEnd = 935102, XrefRangeStart = 935098, XrefRangeEnd = 935101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_SetLocation_Internal_Boolean_ScreenshotHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00034E7C File Offset: 0x0003307C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935102, XrefRangeEnd = 935104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _TagUser(IntPtr self, ScreenshotHandle hScreenshot, SteamId steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hScreenshot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__TagUser_Private_Static_Boolean_IntPtr_ScreenshotHandle_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00034ED8 File Offset: 0x000330D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935106, RefRangeEnd = 935107, XrefRangeStart = 935104, XrefRangeEnd = 935106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TagUser(ScreenshotHandle hScreenshot, SteamId steamID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_TagUser_Internal_Boolean_ScreenshotHandle_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00034F30 File Offset: 0x00033130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935107, XrefRangeEnd = 935109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _TagPublishedFile(IntPtr self, ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hScreenshot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__TagPublishedFile_Private_Static_Boolean_IntPtr_ScreenshotHandle_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00034F8C File Offset: 0x0003318C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935111, RefRangeEnd = 935112, XrefRangeStart = 935109, XrefRangeEnd = 935111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId unPublishedFileID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hScreenshot;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_TagPublishedFile_Internal_Boolean_ScreenshotHandle_PublishedFileId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00034FE4 File Offset: 0x000331E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935112, XrefRangeEnd = 935114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsScreenshotsHooked(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__IsScreenshotsHooked_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00035024 File Offset: 0x00033224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 935116, RefRangeEnd = 935117, XrefRangeStart = 935114, XrefRangeEnd = 935116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScreenshotsHooked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_IsScreenshotsHooked_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00035060 File Offset: 0x00033260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935117, XrefRangeEnd = 935122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenshotHandle _AddVRScreenshotToLibrary(IntPtr self, VRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVRFilename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr__AddVRScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_VRScreenshotType_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000350D0 File Offset: 0x000332D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935122, XrefRangeEnd = 935127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenshotHandle AddVRScreenshotToLibrary(VRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFilename);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVRFilename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamScreenshots.NativeMethodInfoPtr_AddVRScreenshotToLibrary_Internal_ScreenshotHandle_VRScreenshotType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000023D8 File Offset: 0x000005D8
		public ISteamScreenshots(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamScreenshots_v003_Internal_Static_IntPtr_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr__WriteScreenshot_Private_Static_ScreenshotHandle_IntPtr_IntPtr_UInt32_Int32_Int32_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenshot_Internal_ScreenshotHandle_IntPtr_UInt32_Int32_Int32_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr__AddScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_String_String_Int32_Int32_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_AddScreenshotToLibrary_Internal_ScreenshotHandle_String_String_Int32_Int32_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr__TriggerScreenshot_Private_Static_Void_IntPtr_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_TriggerScreenshot_Internal_Void_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr__HookScreenshots_Private_Static_Void_IntPtr_Boolean_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_HookScreenshots_Internal_Void_Boolean_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr__SetLocation_Private_Static_Boolean_IntPtr_ScreenshotHandle_String_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_SetLocation_Internal_Boolean_ScreenshotHandle_String_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr__TagUser_Private_Static_Boolean_IntPtr_ScreenshotHandle_SteamId_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_TagUser_Internal_Boolean_ScreenshotHandle_SteamId_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr__TagPublishedFile_Private_Static_Boolean_IntPtr_ScreenshotHandle_PublishedFileId_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_TagPublishedFile_Internal_Boolean_ScreenshotHandle_PublishedFileId_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr__IsScreenshotsHooked_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_IsScreenshotsHooked_Internal_Boolean_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr__AddVRScreenshotToLibrary_Private_Static_ScreenshotHandle_IntPtr_VRScreenshotType_String_String_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_AddVRScreenshotToLibrary_Internal_ScreenshotHandle_VRScreenshotType_String_String_0;
	}
}
