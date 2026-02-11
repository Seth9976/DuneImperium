using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000023 RID: 35
	[StructLayout(2)]
	public struct ProfilerRecorderHandle
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00019450 File Offset: 0x00017650
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderHandle()
		{
			Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr);
			ProfilerRecorderHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, "handle");
			ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663401);
			ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663402);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663403);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663404);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663405);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663406);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663407);
			ProfilerRecorderHandle.GetAvailableDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetAvailableDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetAvailable");
			ProfilerRecorderHandle.GetByName_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Injected");
			ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Unsafe_Injected");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00019550 File Offset: 0x00017750
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorderHandle(ulong handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00019584 File Offset: 0x00017784
		public unsafe bool Valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 643260, RefRangeEnd = 643262, XrefRangeStart = 643260, XrefRangeEnd = 643260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000195B4 File Offset: 0x000177B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 643264, RefRangeEnd = 643266, XrefRangeStart = 643262, XrefRangeEnd = 643264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000195F4 File Offset: 0x000177F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643266, XrefRangeEnd = 643268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001964C File Offset: 0x0001784C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643268, XrefRangeEnd = 643270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001968C File Offset: 0x0001788C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643270, XrefRangeEnd = 643272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &category;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000196E8 File Offset: 0x000178E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643272, XrefRangeEnd = 643274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002871 File Offset: 0x00000A71
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00019728 File Offset: 0x00017928
		public static ProfilerRecorderHandle Get(ProfilerMarker marker)
		{
			return new ProfilerRecorderHandle((ulong)marker.Handle.ToInt64());
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00019750 File Offset: 0x00017950
		public static ProfilerRecorderHandle Get(ProfilerCategory category, string statName)
		{
			bool flag = String.IsNullOrEmpty(statName);
			if (flag)
			{
				throw new ArgumentException("String must be not null or empty", "statName");
			}
			return ProfilerRecorderHandle.GetByName(category, statName);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002883 File Offset: 0x00000A83
		public static void GetAvailable(List<ProfilerRecorderHandle> outRecorderHandleList)
		{
			ProfilerRecorderHandle.GetAvailableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(outRecorderHandleList));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00019784 File Offset: 0x00017984
		public static ProfilerRecorderHandle GetByName(ProfilerCategory category, string name)
		{
			ProfilerRecorderHandle profilerRecorderHandle;
			ProfilerRecorderHandle.GetByName_Injected(ref category, name, out profilerRecorderHandle);
			return profilerRecorderHandle;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0001979C File Offset: 0x0001799C
		public unsafe static ProfilerRecorderHandle GetByName(ProfilerCategory category, char* name, int nameLen)
		{
			return ProfilerRecorderHandle.GetByName_Unsafe(category, name, nameLen);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000197B8 File Offset: 0x000179B8
		public unsafe static ProfilerRecorderHandle GetByName_Unsafe(ProfilerCategory category, char* name, int nameLen)
		{
			ProfilerRecorderHandle profilerRecorderHandle;
			ProfilerRecorderHandle.GetByName_Unsafe_Injected(ref category, name, nameLen, out profilerRecorderHandle);
			return profilerRecorderHandle;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002895 File Offset: 0x00000A95
		public static void GetByName_Injected(ref ProfilerCategory category, string name, out ProfilerRecorderHandle ret)
		{
			ProfilerRecorderHandle.GetByName_InjectedDelegateField(ref category, IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe static void GetByName_Unsafe_Injected(ref ProfilerCategory category, char* name, int nameLen, out ProfilerRecorderHandle ret)
		{
			ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField(ref category, name, nameLen, out ret);
		}

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(0)]
		public readonly ulong handle;

		// Token: 0x040000F1 RID: 241
		public const ulong k_InvalidHandle = 18446744073709551615UL;

		// Token: 0x040000F2 RID: 242
		private static readonly ProfilerRecorderHandle.GetAvailableDelegate GetAvailableDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly ProfilerRecorderHandle.GetByName_InjectedDelegate GetByName_InjectedDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate GetByName_Unsafe_InjectedDelegateField;

		// Token: 0x020003A3 RID: 931
		// (Invoke) Token: 0x06003021 RID: 12321
		private delegate void GetAvailableDelegate(IntPtr outRecorderHandleList);

		// Token: 0x020003A4 RID: 932
		// (Invoke) Token: 0x06003023 RID: 12323
		private delegate void GetByName_InjectedDelegate(IntPtr category, IntPtr name, [Out] IntPtr ret);

		// Token: 0x020003A5 RID: 933
		// (Invoke) Token: 0x06003025 RID: 12325
		private delegate void GetByName_Unsafe_InjectedDelegate(IntPtr category, IntPtr name, int nameLen, [Out] IntPtr ret);
	}
}
