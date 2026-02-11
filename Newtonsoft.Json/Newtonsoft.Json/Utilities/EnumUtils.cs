using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000058 RID: 88
	public static class EnumUtils : Object
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x00037690 File Offset: 0x00035890
		// Note: this type is marked as 'beforefieldinit'.
		static EnumUtils()
		{
			Il2CppClassPointerStore<EnumUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "EnumUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr);
			EnumUtils.NativeFieldInfoPtr_EnumSeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "EnumSeparatorChar");
			EnumUtils.NativeFieldInfoPtr_EnumSeparatorString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "EnumSeparatorString");
			EnumUtils.NativeFieldInfoPtr_ValuesAndNamesPerEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "ValuesAndNamesPerEnum");
			EnumUtils.NativeFieldInfoPtr__camelCaseNamingStrategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "_camelCaseNamingStrategy");
			EnumUtils.NativeMethodInfoPtr_InitializeValuesAndNames_Private_Static_EnumInfo_StructMultiKey_2_Type_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664827);
			EnumUtils.NativeMethodInfoPtr_GetFlagsValues_Public_Static_IList_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664828);
			EnumUtils.NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664829);
			EnumUtils.NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_NamingStrategy_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664830);
			EnumUtils.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_EnumInfo_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664831);
			EnumUtils.NativeMethodInfoPtr_GetEnumValuesAndNames_Public_Static_EnumInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664832);
			EnumUtils.NativeMethodInfoPtr_ToUInt64_Private_Static_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664833);
			EnumUtils.NativeMethodInfoPtr_ParseEnum_Public_Static_Object_Type_NamingStrategy_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664834);
			EnumUtils.NativeMethodInfoPtr_MatchName_Private_Static_Nullable_1_Int32_String_Il2CppStringArray_Il2CppStringArray_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664835);
			EnumUtils.NativeMethodInfoPtr_FindIndexByName_Private_Static_Nullable_1_Int32_Il2CppStringArray_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, 100664836);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000377D8 File Offset: 0x000359D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743130, XrefRangeEnd = 743191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_InitializeValuesAndNames_Private_Static_EnumInfo_StructMultiKey_2_Type_NamingStrategy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00037824 File Offset: 0x00035A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743250, RefRangeEnd = 743251, XrefRangeStart = 743191, XrefRangeEnd = 743250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<T> GetFlagsValues<T>(T value) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtils.MethodInfoStoreGeneric_GetFlagsValues_Public_Static_IList_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IList<T>>(intPtr4) : null;
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000378A0 File Offset: 0x00035AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743251, XrefRangeEnd = 743274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryToString(Type enumType, Object value, bool camelCase, out string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref camelCase;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0003791C File Offset: 0x00035B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743290, RefRangeEnd = 743291, XrefRangeStart = 743274, XrefRangeEnd = 743290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryToString(Type enumType, Object value, NamingStrategy namingStrategy, out string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namingStrategy);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_NamingStrategy_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0003799C File Offset: 0x00035B9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 743299, RefRangeEnd = 743301, XrefRangeStart = 743291, XrefRangeEnd = 743299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFlagsFormat(EnumInfo entry, ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_EnumInfo_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000379E8 File Offset: 0x00035BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 743311, RefRangeEnd = 743313, XrefRangeStart = 743301, XrefRangeEnd = 743311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_GetEnumValuesAndNames_Public_Static_EnumInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00037A2C File Offset: 0x00035C2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 743336, RefRangeEnd = 743340, XrefRangeStart = 743313, XrefRangeEnd = 743336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_ToUInt64_Private_Static_UInt64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00037A70 File Offset: 0x00035C70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743416, RefRangeEnd = 743419, XrefRangeStart = 743340, XrefRangeEnd = 743416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namingStrategy);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref disallowNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_ParseEnum_Public_Static_Object_Type_NamingStrategy_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00037AE8 File Offset: 0x00035CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 743427, RefRangeEnd = 743429, XrefRangeStart = 743419, XrefRangeEnd = 743427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> MatchName(string value, Il2CppStringArray enumNames, Il2CppStringArray resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueSubstringLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparison;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_MatchName_Private_Static_Nullable_1_Int32_String_Il2CppStringArray_Il2CppStringArray_Int32_Int32_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00037B74 File Offset: 0x00035D74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743434, RefRangeEnd = 743437, XrefRangeStart = 743429, XrefRangeEnd = 743434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> FindIndexByName(Il2CppStringArray enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueSubstringLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparison;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.NativeMethodInfoPtr_FindIndexByName_Private_Static_Nullable_1_Int32_Il2CppStringArray_String_Int32_Int32_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00004719 File Offset: 0x00002919
		public EnumUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00037BEC File Offset: 0x00035DEC
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00004722 File Offset: 0x00002922
		public unsafe static char EnumSeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(EnumUtils.NativeFieldInfoPtr_EnumSeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtils.NativeFieldInfoPtr_EnumSeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x00037C08 File Offset: 0x00035E08
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00004730 File Offset: 0x00002930
		public unsafe static string EnumSeparatorString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumUtils.NativeFieldInfoPtr_EnumSeparatorString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtils.NativeFieldInfoPtr_EnumSeparatorString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00037C28 File Offset: 0x00035E28
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00004742 File Offset: 0x00002942
		public unsafe static ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumUtils.NativeFieldInfoPtr_ValuesAndNamesPerEnum, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtils.NativeFieldInfoPtr_ValuesAndNamesPerEnum, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00037C50 File Offset: 0x00035E50
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00004754 File Offset: 0x00002954
		public unsafe static CamelCaseNamingStrategy _camelCaseNamingStrategy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumUtils.NativeFieldInfoPtr__camelCaseNamingStrategy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamelCaseNamingStrategy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumUtils.NativeFieldInfoPtr__camelCaseNamingStrategy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_EnumSeparatorChar;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_EnumSeparatorString;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_ValuesAndNamesPerEnum;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr__camelCaseNamingStrategy;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_InitializeValuesAndNames_Private_Static_EnumInfo_StructMultiKey_2_Type_NamingStrategy_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_GetFlagsValues_Public_Static_IList_1_T_T_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_Boolean_byref_String_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_TryToString_Public_Static_Boolean_Type_Object_NamingStrategy_byref_String_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_EnumInfo_UInt64_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValuesAndNames_Public_Static_EnumInfo_Type_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Private_Static_UInt64_Object_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_ParseEnum_Public_Static_Object_Type_NamingStrategy_String_Boolean_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_MatchName_Private_Static_Nullable_1_Int32_String_Il2CppStringArray_Il2CppStringArray_Int32_Int32_StringComparison_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_FindIndexByName_Private_Static_Nullable_1_Int32_Il2CppStringArray_String_Int32_Int32_StringComparison_0;

		// Token: 0x02000191 RID: 401
		[ObfuscatedName("Newtonsoft.Json.Utilities.EnumUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D02 RID: 7426 RVA: 0x00088058 File Offset: 0x00086258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr);
				EnumUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr, "<>9");
				EnumUtils.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr, "<>9__3_0");
				EnumUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr, 100664839);
				EnumUtils.__c.NativeMethodInfoPtr__InitializeValuesAndNames_b__3_0_Internal_String_EnumMemberAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr, 100664840);
			}

			// Token: 0x06001D03 RID: 7427 RVA: 0x000880D4 File Offset: 0x000862D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x00088110 File Offset: 0x00086310
			[CallerCount(0)]
			public unsafe string _InitializeValuesAndNames_b__3_0(EnumMemberAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.__c.NativeMethodInfoPtr__InitializeValuesAndNames_b__3_0_Internal_String_EnumMemberAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001D05 RID: 7429 RVA: 0x0000E4C6 File Offset: 0x0000C6C6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00088158 File Offset: 0x00086358
			// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000E4CF File Offset: 0x0000C6CF
			public unsafe static EnumUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00088180 File Offset: 0x00086380
			// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0000E4E1 File Offset: 0x0000C6E1
			public unsafe static Func<EnumMemberAttribute, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumUtils.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EnumMemberAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumUtils.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeMethodInfoPtr__InitializeValuesAndNames_b__3_0_Internal_String_EnumMemberAttribute_0;
		}

		// Token: 0x02000192 RID: 402
		[ObfuscatedName("Newtonsoft.Json.Utilities.EnumUtils+<>c__4`1")]
		[Serializable]
		public sealed class __c__4<T> : Object where T : new()
		{
			// Token: 0x06001D0A RID: 7434 RVA: 0x000881A8 File Offset: 0x000863A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__4()
			{
				Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumUtils>.NativeClassPtr, "<>c__4`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr);
				EnumUtils.__c__4<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr, "<>9");
				EnumUtils.__c__4<T>.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr, "<>9__4_0");
				EnumUtils.__c__4<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr, 100664842);
				EnumUtils.__c__4<T>.NativeMethodInfoPtr__GetFlagsValues_b__4_0_Internal_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr, 100664843);
			}

			// Token: 0x06001D0B RID: 7435 RVA: 0x00088260 File Offset: 0x00086460
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__4()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumUtils.__c__4<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.__c__4<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x0008829C File Offset: 0x0008649C
			[CallerCount(0)]
			public unsafe bool _GetFlagsValues_b__4_0(ulong v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumUtils.__c__4<T>.NativeMethodInfoPtr__GetFlagsValues_b__4_0_Internal_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D0D RID: 7437 RVA: 0x0000E4F3 File Offset: 0x0000C6F3
			public __c__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000882E8 File Offset: 0x000864E8
			// (set) Token: 0x06001D0F RID: 7439 RVA: 0x0000E4FC File Offset: 0x0000C6FC
			public unsafe static EnumUtils.__c__4<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumUtils.__c__4<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumUtils.__c__4<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumUtils.__c__4<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06001D10 RID: 7440 RVA: 0x00088310 File Offset: 0x00086510
			// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0000E50E File Offset: 0x0000C70E
			public unsafe static Func<ulong, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumUtils.__c__4<T>.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ulong, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumUtils.__c__4<T>.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001573 RID: 5491
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001574 RID: 5492
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001575 RID: 5493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001576 RID: 5494
			private static readonly IntPtr NativeMethodInfoPtr__GetFlagsValues_b__4_0_Internal_Boolean_UInt64_0;
		}

		// Token: 0x02000193 RID: 403
		private sealed class MethodInfoStoreGeneric_GetFlagsValues_Public_Static_IList_1_T_T_0<T>
		{
			// Token: 0x04001577 RID: 5495
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EnumUtils.NativeMethodInfoPtr_GetFlagsValues_Public_Static_IList_1_T_T_0, Il2CppClassPointerStore<EnumUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
