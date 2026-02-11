using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000025 RID: 37
	public static class ProfilerUnsafeUtility : global::Il2CppSystem.Object
	{
		// Token: 0x06000128 RID: 296 RVA: 0x0001987C File Offset: 0x00017A7C
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerUnsafeUtility()
		{
			Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663408);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663409);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663410);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663411);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663412);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663413);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663414);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663415);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663416);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663417);
			ProfilerUnsafeUtility.CreateCategoryDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategoryDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory");
			ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Unsafe");
			ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe");
			ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe");
			ProfilerUnsafeUtility.GetMarkerDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetMarkerDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetMarker");
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata");
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe");
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata");
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata");
			ProfilerUnsafeUtility.CreateCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue");
			ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe");
			ProfilerUnsafeUtility.FlushCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlushCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue");
			ProfilerUnsafeUtility.CreateFlowDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateFlowDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow");
			ProfilerUnsafeUtility.FlowEventDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlowEventDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent");
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject");
			ProfilerUnsafeUtility.Internal_GetNameDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_GetNameDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName");
			ProfilerUnsafeUtility.get_TimestampDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.get_TimestampDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp");
			ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryColor_Injected");
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00019A84 File Offset: 0x00017C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643274, XrefRangeEnd = 643276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00019ADC File Offset: 0x00017CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643276, XrefRangeEnd = 643278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00019B1C File Offset: 0x00017D1C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 643280, RefRangeEnd = 643307, XrefRangeStart = 643278, XrefRangeEnd = 643280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00019B88 File Offset: 0x00017D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643307, XrefRangeEnd = 643309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00019BFC File Offset: 0x00017DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643309, XrefRangeEnd = 643311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markerPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00019C74 File Offset: 0x00017E74
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 643313, RefRangeEnd = 643335, XrefRangeStart = 643311, XrefRangeEnd = 643313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(IntPtr markerPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markerPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00019CA8 File Offset: 0x00017EA8
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 643337, RefRangeEnd = 643399, XrefRangeStart = 643335, XrefRangeEnd = 643337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample(IntPtr markerPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref markerPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00019CDC File Offset: 0x00017EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643399, XrefRangeEnd = 643401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &counterPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataUnit;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counterOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00019D80 File Offset: 0x00017F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643401, XrefRangeEnd = 643410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00019DC8 File Offset: 0x00017FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 643410, XrefRangeEnd = 643412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref categoryId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000028DE File Offset: 0x00000ADE
		public ProfilerUnsafeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000028E7 File Offset: 0x00000AE7
		public static ushort CreateCategory(string name, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategoryDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), colorIndex);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00019E08 File Offset: 0x00018008
		public unsafe static ushort CreateCategory(char* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategory_Unsafe(name, nameLen, colorIndex);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000028FA File Offset: 0x00000AFA
		public unsafe static ushort CreateCategory_Unsafe(char* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField(name, nameLen, colorIndex);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00019E24 File Offset: 0x00018024
		public unsafe static ushort GetCategoryByName(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_Unsafe(name, nameLen);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002909 File Offset: 0x00000B09
		public unsafe static ushort GetCategoryByName_Unsafe(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField(name, nameLen);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00019E40 File Offset: 0x00018040
		public static global::UnityEngine.Color32 GetCategoryColor(ProfilerCategoryColor colorIndex)
		{
			global::UnityEngine.Color32 color;
			ProfilerUnsafeUtility.GetCategoryColor_Injected(colorIndex, out color);
			return color;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00019E58 File Offset: 0x00018058
		public unsafe static IntPtr CreateMarker(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_Unsafe(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002917 File Offset: 0x00000B17
		public unsafe static IntPtr CreateMarker_Unsafe(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002929 File Offset: 0x00000B29
		public static IntPtr GetMarker(string name)
		{
			return ProfilerUnsafeUtility.GetMarkerDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000293B File Offset: 0x00000B3B
		public static void SetMarkerMetadata(IntPtr markerPtr, int index, string name, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField(markerPtr, index, IL2CPP.ManagedStringToIl2Cpp(name), type, unit);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002952 File Offset: 0x00000B52
		public unsafe static void SetMarkerMetadata(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_Unsafe(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002963 File Offset: 0x00000B63
		public unsafe static void SetMarkerMetadata_Unsafe(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002977 File Offset: 0x00000B77
		public unsafe static void BeginSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002986 File Offset: 0x00000B86
		public unsafe static void SingleSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00019E78 File Offset: 0x00018078
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, string name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValueDelegateField(out counterPtr, IL2CPP.ManagedStringToIl2Cpp(name), categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00019EA0 File Offset: 0x000180A0
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_Unsafe(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00019EC8 File Offset: 0x000180C8
		public unsafe static void* CreateCounterValue_Unsafe(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002995 File Offset: 0x00000B95
		public unsafe static void FlushCounterValue(void* counterValuePtr)
		{
			ProfilerUnsafeUtility.FlushCounterValueDelegateField(counterValuePtr);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000029A2 File Offset: 0x00000BA2
		public static uint CreateFlow(ushort categoryId)
		{
			return ProfilerUnsafeUtility.CreateFlowDelegateField(categoryId);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000029AF File Offset: 0x00000BAF
		public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType)
		{
			ProfilerUnsafeUtility.FlowEventDelegateField(flowId, flowEventType);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000029BD File Offset: 0x00000BBD
		public static void Internal_BeginWithObject(IntPtr markerPtr, global::UnityEngine.Object contextUnityObject)
		{
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField(markerPtr, IL2CPP.Il2CppObjectBaseToPtr(contextUnityObject));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00019EF0 File Offset: 0x000180F0
		public static string Internal_GetName(IntPtr markerPtr)
		{
			IntPtr intPtr = ProfilerUnsafeUtility.Internal_GetNameDelegateField(markerPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000029D0 File Offset: 0x00000BD0
		public static long Timestamp
		{
			get
			{
				return ProfilerUnsafeUtility.get_TimestampDelegateField();
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000029DC File Offset: 0x00000BDC
		public static void GetCategoryColor_Injected(ProfilerCategoryColor colorIndex, out global::UnityEngine.Color32 ret)
		{
			ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField(colorIndex, out ret);
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0;

		// Token: 0x0400010B RID: 267
		public const ushort CategoryRender = 0;

		// Token: 0x0400010C RID: 268
		public const ushort CategoryScripts = 1;

		// Token: 0x0400010D RID: 269
		public const ushort CategoryGUI = 4;

		// Token: 0x0400010E RID: 270
		public const ushort CategoryPhysics = 5;

		// Token: 0x0400010F RID: 271
		public const ushort CategoryAnimation = 6;

		// Token: 0x04000110 RID: 272
		public const ushort CategoryAi = 7;

		// Token: 0x04000111 RID: 273
		public const ushort CategoryAudio = 8;

		// Token: 0x04000112 RID: 274
		public const ushort CategoryVideo = 11;

		// Token: 0x04000113 RID: 275
		public const ushort CategoryParticles = 12;

		// Token: 0x04000114 RID: 276
		public const ushort CategoryLighting = 13;

		// Token: 0x04000115 RID: 277
		public const ushort CategoryLightning = 13;

		// Token: 0x04000116 RID: 278
		public const ushort CategoryNetwork = 14;

		// Token: 0x04000117 RID: 279
		public const ushort CategoryLoading = 15;

		// Token: 0x04000118 RID: 280
		public const ushort CategoryOther = 16;

		// Token: 0x04000119 RID: 281
		public const ushort CategoryVr = 22;

		// Token: 0x0400011A RID: 282
		public const ushort CategoryAllocation = 23;

		// Token: 0x0400011B RID: 283
		public const ushort CategoryInternal = 24;

		// Token: 0x0400011C RID: 284
		public const ushort CategoryFileIO = 25;

		// Token: 0x0400011D RID: 285
		public const ushort CategoryInput = 30;

		// Token: 0x0400011E RID: 286
		public const ushort CategoryVirtualTexturing = 31;

		// Token: 0x0400011F RID: 287
		public const ushort CategoryGPU = 32;

		// Token: 0x04000120 RID: 288
		public const ushort CategoryPhysics2D = 33;

		// Token: 0x04000121 RID: 289
		public const ushort CategoryAny = 65535;

		// Token: 0x04000122 RID: 290
		private static readonly ProfilerUnsafeUtility.CreateCategoryDelegate CreateCategoryDelegateField;

		// Token: 0x04000123 RID: 291
		private static readonly ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate CreateCategory_UnsafeDelegateField;

		// Token: 0x04000124 RID: 292
		private static readonly ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate GetCategoryByName_UnsafeDelegateField;

		// Token: 0x04000125 RID: 293
		private static readonly ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate CreateMarker_UnsafeDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly ProfilerUnsafeUtility.GetMarkerDelegate GetMarkerDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadataDelegate SetMarkerMetadataDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate SetMarkerMetadata_UnsafeDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate BeginSampleWithMetadataDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate SingleSampleWithMetadataDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly ProfilerUnsafeUtility.CreateCounterValueDelegate CreateCounterValueDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate CreateCounterValue_UnsafeDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly ProfilerUnsafeUtility.FlushCounterValueDelegate FlushCounterValueDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly ProfilerUnsafeUtility.CreateFlowDelegate CreateFlowDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly ProfilerUnsafeUtility.FlowEventDelegate FlowEventDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate Internal_BeginWithObjectDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly ProfilerUnsafeUtility.Internal_GetNameDelegate Internal_GetNameDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly ProfilerUnsafeUtility.get_TimestampDelegate get_TimestampDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate GetCategoryColor_InjectedDelegateField;

		// Token: 0x020003A6 RID: 934
		// (Invoke) Token: 0x06003027 RID: 12327
		private delegate ushort CreateCategoryDelegate(IntPtr name, ProfilerCategoryColor colorIndex);

		// Token: 0x020003A7 RID: 935
		// (Invoke) Token: 0x06003029 RID: 12329
		private delegate ushort CreateCategory_UnsafeDelegate(IntPtr name, int nameLen, ProfilerCategoryColor colorIndex);

		// Token: 0x020003A8 RID: 936
		// (Invoke) Token: 0x0600302B RID: 12331
		private delegate ushort GetCategoryByName_UnsafeDelegate(IntPtr name, int nameLen);

		// Token: 0x020003A9 RID: 937
		// (Invoke) Token: 0x0600302D RID: 12333
		private delegate IntPtr CreateMarker_UnsafeDelegate(IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);

		// Token: 0x020003AA RID: 938
		// (Invoke) Token: 0x0600302F RID: 12335
		private delegate IntPtr GetMarkerDelegate(IntPtr name);

		// Token: 0x020003AB RID: 939
		// (Invoke) Token: 0x06003031 RID: 12337
		private delegate void SetMarkerMetadataDelegate(IntPtr markerPtr, int index, IntPtr name, byte type, byte unit);

		// Token: 0x020003AC RID: 940
		// (Invoke) Token: 0x06003033 RID: 12339
		private delegate void SetMarkerMetadata_UnsafeDelegate(IntPtr markerPtr, int index, IntPtr name, int nameLen, byte type, byte unit);

		// Token: 0x020003AD RID: 941
		// (Invoke) Token: 0x06003035 RID: 12341
		private delegate void BeginSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020003AE RID: 942
		// (Invoke) Token: 0x06003037 RID: 12343
		private delegate void SingleSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020003AF RID: 943
		// (Invoke) Token: 0x06003039 RID: 12345
		private delegate IntPtr CreateCounterValueDelegate([Out] IntPtr counterPtr, IntPtr name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020003B0 RID: 944
		// (Invoke) Token: 0x0600303B RID: 12347
		private delegate IntPtr CreateCounterValue_UnsafeDelegate([Out] IntPtr counterPtr, IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020003B1 RID: 945
		// (Invoke) Token: 0x0600303D RID: 12349
		private delegate void FlushCounterValueDelegate(IntPtr counterValuePtr);

		// Token: 0x020003B2 RID: 946
		// (Invoke) Token: 0x0600303F RID: 12351
		private delegate uint CreateFlowDelegate(ushort categoryId);

		// Token: 0x020003B3 RID: 947
		// (Invoke) Token: 0x06003041 RID: 12353
		private delegate void FlowEventDelegate(uint flowId, ProfilerFlowEventType flowEventType);

		// Token: 0x020003B4 RID: 948
		// (Invoke) Token: 0x06003043 RID: 12355
		private delegate void Internal_BeginWithObjectDelegate(IntPtr markerPtr, IntPtr contextUnityObject);

		// Token: 0x020003B5 RID: 949
		// (Invoke) Token: 0x06003045 RID: 12357
		private delegate IntPtr Internal_GetNameDelegate(IntPtr markerPtr);

		// Token: 0x020003B6 RID: 950
		// (Invoke) Token: 0x06003047 RID: 12359
		private delegate long get_TimestampDelegate();

		// Token: 0x020003B7 RID: 951
		// (Invoke) Token: 0x06003049 RID: 12361
		private delegate void GetCategoryColor_InjectedDelegate(ProfilerCategoryColor colorIndex, [Out] IntPtr ret);
	}
}
