using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	[StructLayout(2)]
	public struct Cache
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00021A38 File Offset: 0x0001FC38
		// Note: this type is marked as 'beforefieldinit'.
		static Cache()
		{
			Il2CppClassPointerStore<Cache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cache>.NativeClassPtr);
			Cache.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cache>.NativeClassPtr, "m_Handle");
			Cache.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663697);
			Cache.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663698);
			Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663699);
			Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663700);
			Cache.NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663701);
			Cache.NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663702);
			Cache.NativeMethodInfoPtr_get_path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663703);
			Cache.NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663704);
			Cache.NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663705);
			Cache.NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663706);
			Cache.NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663707);
			Cache.NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663708);
			Cache.Cache_IsReadyDelegateField = IL2CPP.ResolveICall<Cache.Cache_IsReadyDelegate>("UnityEngine.Cache::Cache_IsReady");
			Cache.Cache_IsReadonlyDelegateField = IL2CPP.ResolveICall<Cache.Cache_IsReadonlyDelegate>("UnityEngine.Cache::Cache_IsReadonly");
			Cache.Cache_GetIndexDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetIndexDelegate>("UnityEngine.Cache::Cache_GetIndex");
			Cache.Cache_GetSpaceFreeDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetSpaceFreeDelegate>("UnityEngine.Cache::Cache_GetSpaceFree");
			Cache.Cache_GetMaximumDiskSpaceAvailableDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetMaximumDiskSpaceAvailableDelegate>("UnityEngine.Cache::Cache_GetMaximumDiskSpaceAvailable");
			Cache.Cache_GetCachingDiskSpaceUsedDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetCachingDiskSpaceUsedDelegate>("UnityEngine.Cache::Cache_GetCachingDiskSpaceUsed");
			Cache.Cache_GetExpirationDelayDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetExpirationDelayDelegate>("UnityEngine.Cache::Cache_GetExpirationDelay");
			Cache.Cache_ClearCacheDelegateField = IL2CPP.ResolveICall<Cache.Cache_ClearCacheDelegate>("UnityEngine.Cache::Cache_ClearCache");
			Cache.Cache_ClearCache_ExpirationDelegateField = IL2CPP.ResolveICall<Cache.Cache_ClearCache_ExpirationDelegate>("UnityEngine.Cache::Cache_ClearCache_Expiration");
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		public unsafe int handle
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00021C24 File Offset: 0x0001FE24
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00021C54 File Offset: 0x0001FE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645168, XrefRangeEnd = 645171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00021C98 File Offset: 0x0001FE98
		[CallerCount(0)]
		public unsafe bool Equals(Cache other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00021CD8 File Offset: 0x0001FED8
		public unsafe bool valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645173, RefRangeEnd = 645175, XrefRangeStart = 645171, XrefRangeEnd = 645173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00021D08 File Offset: 0x0001FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645175, XrefRangeEnd = 645177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Cache_IsValid(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00021D48 File Offset: 0x0001FF48
		public unsafe string path
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 645179, RefRangeEnd = 645182, XrefRangeStart = 645177, XrefRangeEnd = 645179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_path_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00021D74 File Offset: 0x0001FF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645182, XrefRangeEnd = 645184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Cache_GetPath(int handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00021F60 File Offset: 0x00020160
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00021DAC File Offset: 0x0001FFAC
		public unsafe long maximumAvailableStorageSpace
		{
			get
			{
				return Cache.Cache_GetMaximumDiskSpaceAvailable(this.m_Handle);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645186, RefRangeEnd = 645188, XrefRangeStart = 645184, XrefRangeEnd = 645186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645188, XrefRangeEnd = 645190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cache_SetMaximumDiskSpaceAvailable(int handle, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00021FA0 File Offset: 0x000201A0
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00021E20 File Offset: 0x00020020
		public unsafe int expirationDelay
		{
			get
			{
				return Cache.Cache_GetExpirationDelay(this.m_Handle);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645192, RefRangeEnd = 645194, XrefRangeStart = 645190, XrefRangeEnd = 645192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00021E54 File Offset: 0x00020054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645194, XrefRangeEnd = 645196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cache_SetExpirationDelay(int handle, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00003FE6 File Offset: 0x000021E6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cache>.NativeClassPtr, ref this));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00021E94 File Offset: 0x00020094
		public static bool operator ==(Cache lhs, Cache rhs)
		{
			return lhs.handle == rhs.handle;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00021EB8 File Offset: 0x000200B8
		public static bool operator !=(Cache lhs, Cache rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00021EE0 File Offset: 0x000200E0
		public bool ready
		{
			get
			{
				return Cache.Cache_IsReady(this.m_Handle);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003FF8 File Offset: 0x000021F8
		public static bool Cache_IsReady(int handle)
		{
			return Cache.Cache_IsReadyDelegateField(handle);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00021F00 File Offset: 0x00020100
		public bool readOnly
		{
			get
			{
				return Cache.Cache_IsReadonly(this.m_Handle);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00004005 File Offset: 0x00002205
		public static bool Cache_IsReadonly(int handle)
		{
			return Cache.Cache_IsReadonlyDelegateField(handle);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00021F20 File Offset: 0x00020120
		public int index
		{
			get
			{
				return Cache.Cache_GetIndex(this.m_Handle);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00004012 File Offset: 0x00002212
		public static int Cache_GetIndex(int handle)
		{
			return Cache.Cache_GetIndexDelegateField(handle);
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00021F40 File Offset: 0x00020140
		public long spaceFree
		{
			get
			{
				return Cache.Cache_GetSpaceFree(this.m_Handle);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000401F File Offset: 0x0000221F
		public static long Cache_GetSpaceFree(int handle)
		{
			return Cache.Cache_GetSpaceFreeDelegateField(handle);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000402C File Offset: 0x0000222C
		public static long Cache_GetMaximumDiskSpaceAvailable(int handle)
		{
			return Cache.Cache_GetMaximumDiskSpaceAvailableDelegateField(handle);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00021F80 File Offset: 0x00020180
		public long spaceOccupied
		{
			get
			{
				return Cache.Cache_GetCachingDiskSpaceUsed(this.m_Handle);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004039 File Offset: 0x00002239
		public static long Cache_GetCachingDiskSpaceUsed(int handle)
		{
			return Cache.Cache_GetCachingDiskSpaceUsedDelegateField(handle);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00004046 File Offset: 0x00002246
		public static int Cache_GetExpirationDelay(int handle)
		{
			return Cache.Cache_GetExpirationDelayDelegateField(handle);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00021FC0 File Offset: 0x000201C0
		public bool ClearCache()
		{
			return Cache.Cache_ClearCache(this.m_Handle);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004053 File Offset: 0x00002253
		public static bool Cache_ClearCache(int handle)
		{
			return Cache.Cache_ClearCacheDelegateField(handle);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00021FE0 File Offset: 0x000201E0
		public bool ClearCache(int expiration)
		{
			return Cache.Cache_ClearCache_Expiration(this.m_Handle, expiration);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00004060 File Offset: 0x00002260
		public static bool Cache_ClearCache_Expiration(int handle, int expiration)
		{
			return Cache.Cache_ClearCache_ExpirationDelegateField(handle, expiration);
		}

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Internal_get_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_get_path_Public_get_String_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x0400039F RID: 927
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x040003A0 RID: 928
		private static readonly Cache.Cache_IsReadyDelegate Cache_IsReadyDelegateField;

		// Token: 0x040003A1 RID: 929
		private static readonly Cache.Cache_IsReadonlyDelegate Cache_IsReadonlyDelegateField;

		// Token: 0x040003A2 RID: 930
		private static readonly Cache.Cache_GetIndexDelegate Cache_GetIndexDelegateField;

		// Token: 0x040003A3 RID: 931
		private static readonly Cache.Cache_GetSpaceFreeDelegate Cache_GetSpaceFreeDelegateField;

		// Token: 0x040003A4 RID: 932
		private static readonly Cache.Cache_GetMaximumDiskSpaceAvailableDelegate Cache_GetMaximumDiskSpaceAvailableDelegateField;

		// Token: 0x040003A5 RID: 933
		private static readonly Cache.Cache_GetCachingDiskSpaceUsedDelegate Cache_GetCachingDiskSpaceUsedDelegateField;

		// Token: 0x040003A6 RID: 934
		private static readonly Cache.Cache_GetExpirationDelayDelegate Cache_GetExpirationDelayDelegateField;

		// Token: 0x040003A7 RID: 935
		private static readonly Cache.Cache_ClearCacheDelegate Cache_ClearCacheDelegateField;

		// Token: 0x040003A8 RID: 936
		private static readonly Cache.Cache_ClearCache_ExpirationDelegate Cache_ClearCache_ExpirationDelegateField;

		// Token: 0x02000430 RID: 1072
		// (Invoke) Token: 0x0600315B RID: 12635
		private delegate bool Cache_IsReadyDelegate(int handle);

		// Token: 0x02000431 RID: 1073
		// (Invoke) Token: 0x0600315D RID: 12637
		private delegate bool Cache_IsReadonlyDelegate(int handle);

		// Token: 0x02000432 RID: 1074
		// (Invoke) Token: 0x0600315F RID: 12639
		private delegate int Cache_GetIndexDelegate(int handle);

		// Token: 0x02000433 RID: 1075
		// (Invoke) Token: 0x06003161 RID: 12641
		private delegate long Cache_GetSpaceFreeDelegate(int handle);

		// Token: 0x02000434 RID: 1076
		// (Invoke) Token: 0x06003163 RID: 12643
		private delegate long Cache_GetMaximumDiskSpaceAvailableDelegate(int handle);

		// Token: 0x02000435 RID: 1077
		// (Invoke) Token: 0x06003165 RID: 12645
		private delegate long Cache_GetCachingDiskSpaceUsedDelegate(int handle);

		// Token: 0x02000436 RID: 1078
		// (Invoke) Token: 0x06003167 RID: 12647
		private delegate int Cache_GetExpirationDelayDelegate(int handle);

		// Token: 0x02000437 RID: 1079
		// (Invoke) Token: 0x06003169 RID: 12649
		private delegate bool Cache_ClearCacheDelegate(int handle);

		// Token: 0x02000438 RID: 1080
		// (Invoke) Token: 0x0600316B RID: 12651
		private delegate bool Cache_ClearCache_ExpirationDelegate(int handle, int expiration);
	}
}
