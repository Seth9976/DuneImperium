using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x020000AB RID: 171
	public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage>
	{
		// Token: 0x06000A45 RID: 2629 RVA: 0x0004A018 File Offset: 0x00048218
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemoteStorage()
		{
			Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamRemoteStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr);
			SteamRemoteStorage.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemoteStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665822);
			SteamRemoteStorage.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665823);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665824);
			SteamRemoteStorage.NativeMethodInfoPtr_FileRead_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665825);
			SteamRemoteStorage.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665826);
			SteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665827);
			SteamRemoteStorage.NativeMethodInfoPtr_FileTime_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665828);
			SteamRemoteStorage.NativeMethodInfoPtr_FileSize_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665829);
			SteamRemoteStorage.NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665830);
			SteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665831);
			SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaBytes_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665832);
			SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaUsedBytes_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665833);
			SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaRemainingBytes_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665834);
			SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665835);
			SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabledForAccount_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665836);
			SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabledForApp_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665837);
			SteamRemoteStorage.NativeMethodInfoPtr_set_IsCloudEnabledForApp_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665838);
			SteamRemoteStorage.NativeMethodInfoPtr_get_FileCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665839);
			SteamRemoteStorage.NativeMethodInfoPtr_get_Files_Public_Static_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665840);
			SteamRemoteStorage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100665841);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0004A1D8 File Offset: 0x000483D8
		public unsafe static ISteamRemoteStorage Internal
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 942062, RefRangeEnd = 942082, XrefRangeStart = 942059, XrefRangeEnd = 942062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemoteStorage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamRemoteStorage>(intPtr3) : null;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0004A20C File Offset: 0x0004840C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942082, XrefRangeEnd = 942086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamRemoteStorage.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0004A258 File Offset: 0x00048458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942086, XrefRangeEnd = 942092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileWrite(string filename, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0004A2AC File Offset: 0x000484AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942092, XrefRangeEnd = 942101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FileRead(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileRead_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0004A2F0 File Offset: 0x000484F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942101, XrefRangeEnd = 942104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileExists(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0004A334 File Offset: 0x00048534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942104, XrefRangeEnd = 942107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilePersisted(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0004A378 File Offset: 0x00048578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942107, XrefRangeEnd = 942117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FileTime(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileTime_Public_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0004A3BC File Offset: 0x000485BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942117, XrefRangeEnd = 942120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FileSize(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileSize_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0004A400 File Offset: 0x00048600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942120, XrefRangeEnd = 942123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileForget(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0004A444 File Offset: 0x00048644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942123, XrefRangeEnd = 942126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileDelete(string filename)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0004A488 File Offset: 0x00048688
		public unsafe static ulong QuotaBytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942126, XrefRangeEnd = 942128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaBytes_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0004A4B8 File Offset: 0x000486B8
		public unsafe static ulong QuotaUsedBytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942128, XrefRangeEnd = 942130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaUsedBytes_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0004A4E8 File Offset: 0x000486E8
		public unsafe static ulong QuotaRemainingBytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942130, XrefRangeEnd = 942132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_QuotaRemainingBytes_Public_Static_get_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0004A518 File Offset: 0x00048718
		public unsafe static bool IsCloudEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942132, XrefRangeEnd = 942134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0004A548 File Offset: 0x00048748
		public unsafe static bool IsCloudEnabledForAccount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942134, XrefRangeEnd = 942137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabledForAccount_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0004A578 File Offset: 0x00048778
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x0004A5A8 File Offset: 0x000487A8
		public unsafe static bool IsCloudEnabledForApp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942137, XrefRangeEnd = 942140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_IsCloudEnabledForApp_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942140, XrefRangeEnd = 942143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_set_IsCloudEnabledForApp_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0004A5DC File Offset: 0x000487DC
		public unsafe static int FileCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942143, XrefRangeEnd = 942146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_FileCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0004A60C File Offset: 0x0004880C
		public unsafe static IEnumerable<string> Files
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942146, XrefRangeEnd = 942151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_get_Files_Public_Static_get_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0004A640 File Offset: 0x00048840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942151, XrefRangeEnd = 942154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamRemoteStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002AE4 File Offset: 0x00000CE4
		public SteamRemoteStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamRemoteStorage_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_FileRead_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_FileTime_Public_Static_DateTime_String_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_FileSize_Public_Static_Int32_String_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_get_QuotaBytes_Public_Static_get_UInt64_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_get_QuotaUsedBytes_Public_Static_get_UInt64_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_get_QuotaRemainingBytes_Public_Static_get_UInt64_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCloudEnabled_Public_Static_get_Boolean_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCloudEnabledForAccount_Public_Static_get_Boolean_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCloudEnabledForApp_Public_Static_get_Boolean_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCloudEnabledForApp_Public_Static_set_Void_Boolean_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_get_FileCount_Public_Static_get_Int32_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_get_Files_Public_Static_get_IEnumerable_1_String_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000250 RID: 592
		[ObfuscatedName("Steamworks.SteamRemoteStorage+<get_Files>d__27")]
		public sealed class _get_Files_d__27 : Object
		{
			// Token: 0x06001DD5 RID: 7637 RVA: 0x00088584 File Offset: 0x00086784
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Files_d__27()
			{
				Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, "<get_Files>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr);
				SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, "<>1__state");
				SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, "<>2__current");
				SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, "<>l__initialThreadId");
				SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr____5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, "<_>5__2");
				SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, "<i>5__3");
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665842);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665843);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665844);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665845);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665846);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665847);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665848);
				SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr, 100665849);
			}

			// Token: 0x06001DD6 RID: 7638 RVA: 0x000886B4 File Offset: 0x000868B4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Files_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRemoteStorage._get_Files_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x000886FC File Offset: 0x000868FC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DD8 RID: 7640 RVA: 0x00088730 File Offset: 0x00086930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942027, XrefRangeEnd = 942033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0008876C File Offset: 0x0008696C
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001DDA RID: 7642 RVA: 0x000887A4 File Offset: 0x000869A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942033, XrefRangeEnd = 942057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001DDB RID: 7643 RVA: 0x000887D8 File Offset: 0x000869D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001DDC RID: 7644 RVA: 0x00088818 File Offset: 0x00086A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942057, XrefRangeEnd = 942059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06001DDD RID: 7645 RVA: 0x00088858 File Offset: 0x00086A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage._get_Files_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001DDE RID: 7646 RVA: 0x0000A9F2 File Offset: 0x00008BF2
			public _get_Files_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00088898 File Offset: 0x00086A98
			// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0000A9FB File Offset: 0x00008BFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x000888C0 File Offset: 0x00086AC0
			// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0000AA16 File Offset: 0x00008C16
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x000888E8 File Offset: 0x00086AE8
			// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000AA35 File Offset: 0x00008C35
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00088910 File Offset: 0x00086B10
			// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000AA50 File Offset: 0x00008C50
			public unsafe int ___5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr____5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr____5__2)) = value;
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00088938 File Offset: 0x00086B38
			// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000AA6B File Offset: 0x00008C6B
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRemoteStorage._get_Files_d__27.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04002164 RID: 8548
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002165 RID: 8549
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002166 RID: 8550
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002167 RID: 8551
			private static readonly IntPtr NativeFieldInfoPtr____5__2;

			// Token: 0x04002168 RID: 8552
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04002169 RID: 8553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400216A RID: 8554
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400216B RID: 8555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400216C RID: 8556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x0400216D RID: 8557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400216E RID: 8558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400216F RID: 8559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x04002170 RID: 8560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
