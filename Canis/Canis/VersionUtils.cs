using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis
{
	// Token: 0x0200002D RID: 45
	public class VersionUtils : Object
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00025CF8 File Offset: 0x00023EF8
		// Note: this type is marked as 'beforefieldinit'.
		static VersionUtils()
		{
			Il2CppClassPointerStore<VersionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "VersionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr);
			VersionUtils.NativeMethodInfoPtr_IsAtLeastMinClient_Public_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr, 100663956);
			VersionUtils.NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr, 100663957);
			VersionUtils.NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr, 100663958);
			VersionUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr, 100663959);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00025D78 File Offset: 0x00023F78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 549457, RefRangeEnd = 549461, XrefRangeStart = 549457, XrefRangeEnd = 549457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAtLeastMinClient(Il2CppStructArray<int> playerVersion, Il2CppStructArray<int> minVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerVersion);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionUtils.NativeMethodInfoPtr_IsAtLeastMinClient_Public_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00025DCC File Offset: 0x00023FCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 549480, RefRangeEnd = 549483, XrefRangeStart = 549461, XrefRangeEnd = 549480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetClientVersion(string version)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionUtils.NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00025E10 File Offset: 0x00024010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549483, XrefRangeEnd = 549491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetClientVersion(Dictionary<string, string> metadata)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionUtils.NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00025E54 File Offset: 0x00024054
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000036B5 File Offset: 0x000018B5
		public VersionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_IsAtLeastMinClient_Public_Static_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetClientVersion_Public_Static_Il2CppStructArray_1_Int32_Dictionary_2_String_String_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
