using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.Unity.DWD
{
	// Token: 0x0200009F RID: 159
	public static class DWDPlayerPrefs : Object
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x0003C838 File Offset: 0x0003AA38
		// Note: this type is marked as 'beforefieldinit'.
		static DWDPlayerPrefs()
		{
			Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.Unity.DWD", "DWDPlayerPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr);
			DWDPlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664797);
			DWDPlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664798);
			DWDPlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664799);
			DWDPlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664800);
			DWDPlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664801);
			DWDPlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664802);
			DWDPlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664803);
			DWDPlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664804);
			DWDPlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664805);
			DWDPlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664806);
			DWDPlayerPrefs.NativeMethodInfoPtr_CheckInitialization_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDPlayerPrefs>.NativeClassPtr, 100664807);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003C944 File Offset: 0x0003AB44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 863128, RefRangeEnd = 863131, XrefRangeStart = 863126, XrefRangeEnd = 863128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003C96C File Offset: 0x0003AB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863131, XrefRangeEnd = 863132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003C9A4 File Offset: 0x0003ABA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863132, XrefRangeEnd = 863133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key, float defaultValue = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 863134, RefRangeEnd = 863136, XrefRangeStart = 863133, XrefRangeEnd = 863134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key, int defaultValue = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003CA44 File Offset: 0x0003AC44
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 863137, RefRangeEnd = 863156, XrefRangeStart = 863136, XrefRangeEnd = 863137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key, string defaultValue = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0003CA94 File Offset: 0x0003AC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863157, RefRangeEnd = 863158, XrefRangeStart = 863156, XrefRangeEnd = 863157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 863159, RefRangeEnd = 863162, XrefRangeStart = 863158, XrefRangeEnd = 863159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003CB00 File Offset: 0x0003AD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863162, XrefRangeEnd = 863163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003CB44 File Offset: 0x0003AD44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 863164, RefRangeEnd = 863167, XrefRangeStart = 863163, XrefRangeEnd = 863164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003CB88 File Offset: 0x0003AD88
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 863168, RefRangeEnd = 863177, XrefRangeStart = 863167, XrefRangeEnd = 863168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckInitialization()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDPlayerPrefs.NativeMethodInfoPtr_CheckInitialization_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00005D1B File Offset: 0x00003F1B
		public DWDPlayerPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_CheckInitialization_Private_Static_Void_0;
	}
}
