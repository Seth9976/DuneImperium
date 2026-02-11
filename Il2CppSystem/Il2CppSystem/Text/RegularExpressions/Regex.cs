using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200007C RID: 124
	public class Regex : Object
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x0003AB8C File Offset: 0x00038D8C
		// Note: this type is marked as 'beforefieldinit'.
		static Regex()
		{
			Il2CppClassPointerStore<Regex>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Regex");
			Regex.NativeFieldInfoPtr_CacheDictionarySwitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CacheDictionarySwitchLimit");
			Regex.NativeFieldInfoPtr_s_cacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheSize");
			Regex.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cache");
			Regex.NativeFieldInfoPtr_s_cacheCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheCount");
			Regex.NativeFieldInfoPtr_s_cacheFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheFirst");
			Regex.NativeFieldInfoPtr_s_cacheLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_cacheLast");
			Regex.NativeFieldInfoPtr_s_maximumMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_maximumMatchTimeout");
			Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "DefaultMatchTimeout_ConfigKeyName");
			Regex.NativeFieldInfoPtr_s_defaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "s_defaultMatchTimeout");
			Regex.NativeFieldInfoPtr_InfiniteMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "InfiniteMatchTimeout");
			Regex.NativeFieldInfoPtr_internalMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "internalMatchTimeout");
			Regex.NativeFieldInfoPtr_MaxOptionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "MaxOptionShift");
			Regex.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "pattern");
			Regex.NativeFieldInfoPtr_roptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "roptions");
			Regex.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "factory");
			Regex.NativeFieldInfoPtr_caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "caps");
			Regex.NativeFieldInfoPtr_capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capnames");
			Regex.NativeFieldInfoPtr_capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capslist");
			Regex.NativeFieldInfoPtr_capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capsize");
			Regex.NativeFieldInfoPtr__runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_runnerref");
			Regex.NativeFieldInfoPtr__replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_replref");
			Regex.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_code");
			Regex.NativeFieldInfoPtr__refsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "_refsInitialized");
			Regex.NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664585);
			Regex.NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664586);
			Regex.NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664587);
			Regex.NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664588);
			Regex.NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664589);
			Regex.NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664590);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664591);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664592);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664593);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664594);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664595);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664596);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664597);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664598);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664599);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664600);
			Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664601);
			Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664602);
			Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664603);
			Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664604);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664605);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664606);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664607);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664608);
			Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664609);
			Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664610);
			Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664611);
			Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664612);
			Regex.NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664613);
			Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664615);
			Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664616);
			Regex.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664617);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664618);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664619);
			Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664620);
			Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664621);
			Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664622);
			Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664623);
			Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664624);
			Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664625);
			Regex.NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664626);
			Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664627);
			Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664628);
			Regex.NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664629);
			Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100664630);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0003B104 File Offset: 0x00039304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437998, XrefRangeEnd = 438010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isToAdd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr3) : null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0003B168 File Offset: 0x00039368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438097, RefRangeEnd = 438098, XrefRangeStart = 438010, XrefRangeEnd = 438097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isToAdd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr3) : null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0003B1CC File Offset: 0x000393CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438098, XrefRangeEnd = 438113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillCacheDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0003B200 File Offset: 0x00039400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438113, XrefRangeEnd = 438120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new Regex.CachedCodeEntry(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0003B26C File Offset: 0x0003946C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438128, RefRangeEnd = 438129, XrefRangeStart = 438120, XrefRangeEnd = 438128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new Regex.CachedCodeEntry(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0003B2D8 File Offset: 0x000394D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438139, RefRangeEnd = 438140, XrefRangeStart = 438129, XrefRangeEnd = 438139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0003B324 File Offset: 0x00039524
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438145, RefRangeEnd = 438149, XrefRangeStart = 438140, XrefRangeEnd = 438145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0003B378 File Offset: 0x00039578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438154, RefRangeEnd = 438155, XrefRangeStart = 438149, XrefRangeEnd = 438154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern, RegexOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0003B3DC File Offset: 0x000395DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438161, RefRangeEnd = 438164, XrefRangeStart = 438155, XrefRangeEnd = 438161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0003B44C File Offset: 0x0003964C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 438166, RefRangeEnd = 438188, XrefRangeStart = 438164, XrefRangeEnd = 438166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0003B49C File Offset: 0x0003969C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438188, XrefRangeEnd = 438189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0003B4F8 File Offset: 0x000396F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 438199, RefRangeEnd = 438207, XrefRangeStart = 438189, XrefRangeEnd = 438199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0003B550 File Offset: 0x00039750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438207, XrefRangeEnd = 438213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0003B5C4 File Offset: 0x000397C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438215, RefRangeEnd = 438218, XrefRangeStart = 438213, XrefRangeEnd = 438215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0003B614 File Offset: 0x00039814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438219, RefRangeEnd = 438220, XrefRangeStart = 438218, XrefRangeEnd = 438219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0003B674 File Offset: 0x00039874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438221, RefRangeEnd = 438223, XrefRangeStart = 438220, XrefRangeEnd = 438221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input, int beginning, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginning;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0003B6E0 File Offset: 0x000398E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438228, RefRangeEnd = 438229, XrefRangeStart = 438223, XrefRangeEnd = 438228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchCollection Matches(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0003B738 File Offset: 0x00039938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438247, RefRangeEnd = 438248, XrefRangeStart = 438229, XrefRangeEnd = 438247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0003B7AC File Offset: 0x000399AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438262, RefRangeEnd = 438266, XrefRangeStart = 438248, XrefRangeEnd = 438262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection Matches(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0003B7FC File Offset: 0x000399FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438279, RefRangeEnd = 438281, XrefRangeStart = 438266, XrefRangeEnd = 438279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchCollection Matches(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchCollection>(intPtr3) : null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0003B85C File Offset: 0x00039A5C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 438292, RefRangeEnd = 438322, XrefRangeStart = 438281, XrefRangeEnd = 438292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, string replacement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438322, XrefRangeEnd = 438342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0003B938 File Offset: 0x00039B38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438345, RefRangeEnd = 438348, XrefRangeStart = 438342, XrefRangeEnd = 438345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, string replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0003B994 File Offset: 0x00039B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438348, XrefRangeEnd = 438363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, string replacement, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0003BA0C File Offset: 0x00039C0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438376, RefRangeEnd = 438380, XrefRangeStart = 438363, XrefRangeEnd = 438376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0003BA64 File Offset: 0x00039C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438380, XrefRangeEnd = 438396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438396, XrefRangeEnd = 438401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0003BB28 File Offset: 0x00039D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438401, XrefRangeEnd = 438411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(string input, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0003BB94 File Offset: 0x00039D94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438460, RefRangeEnd = 438464, XrefRangeStart = 438411, XrefRangeEnd = 438460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(Regex regex, string input, int count, int startat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0003BC08 File Offset: 0x00039E08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438482, RefRangeEnd = 438485, XrefRangeStart = 438464, XrefRangeEnd = 438482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref matchTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0003BC3C File Offset: 0x00039E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438485, XrefRangeEnd = 438496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan InitDefaultMatchTimeout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0003BC6C File Offset: 0x00039E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438496, XrefRangeEnd = 438501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 438506, RefRangeEnd = 438515, XrefRangeStart = 438501, XrefRangeEnd = 438506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 438520, RefRangeEnd = 438530, XrefRangeStart = 438515, XrefRangeEnd = 438520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0003BD50 File Offset: 0x00039F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438530, XrefRangeEnd = 438535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0003BDAC File Offset: 0x00039FAC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 438558, RefRangeEnd = 438568, XrefRangeStart = 438535, XrefRangeEnd = 438558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addToCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0003BE24 File Offset: 0x0003A024
		public unsafe RegexOptions Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0003BE60 File Offset: 0x0003A060
		public unsafe bool RightToLeft
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 438568, RefRangeEnd = 438571, XrefRangeStart = 438568, XrefRangeEnd = 438568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0003BE9C File Offset: 0x0003A09C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438571, XrefRangeEnd = 438579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GroupNameFromNumber(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0003BF24 File Offset: 0x0003A124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438579, XrefRangeEnd = 438582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GroupNumberFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0003BF74 File Offset: 0x0003A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438582, XrefRangeEnd = 438600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0003BFA8 File Offset: 0x0003A1A8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 438623, RefRangeEnd = 438636, XrefRangeStart = 438600, XrefRangeEnd = 438623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginning;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0003C040 File Offset: 0x0003A240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438568, RefRangeEnd = 438571, XrefRangeStart = 438568, XrefRangeEnd = 438571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0003C07C File Offset: 0x0003A27C
		[CallerCount(0)]
		public unsafe bool UseOptionInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00004874 File Offset: 0x00002A74
		public Regex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0003C0B8 File Offset: 0x0003A2B8
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x0000487D File Offset: 0x00002A7D
		public unsafe static int CacheDictionarySwitchLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_CacheDictionarySwitchLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_CacheDictionarySwitchLimit, (void*)(&value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x0000488B File Offset: 0x00002A8B
		public unsafe static int s_cacheSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_cacheSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_cacheSize, (void*)(&value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00004899 File Offset: 0x00002A99
		public unsafe static Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0003C118 File Offset: 0x0003A318
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000048AB File Offset: 0x00002AAB
		public unsafe static int s_cacheCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_cacheCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_cacheCount, (void*)(&value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x0003C134 File Offset: 0x0003A334
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000048B9 File Offset: 0x00002AB9
		public unsafe static Regex.CachedCodeEntry s_cacheFirst
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_cacheFirst, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_cacheFirst, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x0003C15C File Offset: 0x0003A35C
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000048CB File Offset: 0x00002ACB
		public unsafe static Regex.CachedCodeEntry s_cacheLast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_cacheLast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_cacheLast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x0003C184 File Offset: 0x0003A384
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000048DD File Offset: 0x00002ADD
		public unsafe static TimeSpan s_maximumMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_maximumMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_maximumMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0003C1A0 File Offset: 0x0003A3A0
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000048EB File Offset: 0x00002AEB
		public unsafe static string DefaultMatchTimeout_ConfigKeyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x0003C1C0 File Offset: 0x0003A3C0
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x000048FD File Offset: 0x00002AFD
		public unsafe static TimeSpan s_defaultMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_s_defaultMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_s_defaultMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0000490B File Offset: 0x00002B0B
		public unsafe static TimeSpan InfiniteMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0003C1F8 File Offset: 0x0003A3F8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00004919 File Offset: 0x00002B19
		public unsafe TimeSpan internalMatchTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0003C220 File Offset: 0x0003A420
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00004934 File Offset: 0x00002B34
		public unsafe static int MaxOptionShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_MaxOptionShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_MaxOptionShift, (void*)(&value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0003C23C File Offset: 0x0003A43C
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00004942 File Offset: 0x00002B42
		public unsafe string pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0003C264 File Offset: 0x0003A464
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00004961 File Offset: 0x00002B61
		public unsafe RegexOptions roptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0003C28C File Offset: 0x0003A48C
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x0000497C File Offset: 0x00002B7C
		public unsafe RegexRunnerFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0003C2BC File Offset: 0x0003A4BC
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x0000499B File Offset: 0x00002B9B
		public unsafe Hashtable caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0003C2EC File Offset: 0x0003A4EC
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000049BA File Offset: 0x00002BBA
		public unsafe Hashtable capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0003C31C File Offset: 0x0003A51C
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x000049D9 File Offset: 0x00002BD9
		public unsafe Il2CppStringArray capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0003C34C File Offset: 0x0003A54C
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x000049F8 File Offset: 0x00002BF8
		public unsafe int capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0003C374 File Offset: 0x0003A574
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00004A13 File Offset: 0x00002C13
		public unsafe ExclusiveReference _runnerref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__runnerref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0003C3A4 File Offset: 0x0003A5A4
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00004A32 File Offset: 0x00002C32
		public unsafe WeakReference<RegexReplacement> _replref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__replref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference<RegexReplacement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__replref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00004A51 File Offset: 0x00002C51
		public unsafe RegexCode _code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0003C404 File Offset: 0x0003A604
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00004A70 File Offset: 0x00002C70
		public unsafe bool _refsInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__refsInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr__refsInitialized)) = value;
			}
		}

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeFieldInfoPtr_CacheDictionarySwitchLimit;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeFieldInfoPtr_s_cacheSize;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeFieldInfoPtr_s_cacheCount;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_s_cacheFirst;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_s_cacheLast;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_s_maximumMatchTimeout;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultMatchTimeout;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteMatchTimeout;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_internalMatchTimeout;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_MaxOptionShift;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_roptions;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeFieldInfoPtr_caps;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_capnames;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_capslist;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_capsize;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr__runnerref;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr__replref;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr__code;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr__refsInitialized;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedCode_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedCodeEntryInternal_Private_CachedCodeEntry_CachedCodeEntryKey_Boolean_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_FillCacheDictionary_Private_Void_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCacheValue_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCacheValueSmall_Private_Static_Boolean_CachedCodeEntryKey_byref_CachedCodeEntry_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_LookupCachedAndPromote_Private_Static_CachedCodeEntry_CachedCodeEntryKey_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_Int32_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_Int32_Int32_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_MatchCollection_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_MatchCollection_String_Int32_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_Int32_Int32_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_Split_Private_Static_Il2CppStringArray_Regex_String_Int32_Int32_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReferences_Protected_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_FamOrAssem_Boolean_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0;

		// Token: 0x020002CB RID: 715
		public sealed class CachedCodeEntryKey : ValueType
		{
			// Token: 0x06002B9D RID: 11165 RVA: 0x000C115C File Offset: 0x000BF35C
			// Note: this type is marked as 'beforefieldinit'.
			static CachedCodeEntryKey()
			{
				Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CachedCodeEntryKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr);
				Regex.CachedCodeEntryKey.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, "_options");
				Regex.CachedCodeEntryKey.NativeFieldInfoPtr__cultureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, "_cultureKey");
				Regex.CachedCodeEntryKey.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, "_pattern");
				Regex.CachedCodeEntryKey.NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, 100664631);
				Regex.CachedCodeEntryKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, 100664632);
				Regex.CachedCodeEntryKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, 100664633);
				Regex.CachedCodeEntryKey.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, 100664634);
				Regex.CachedCodeEntryKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, 100664635);
			}

			// Token: 0x06002B9E RID: 11166 RVA: 0x000C1228 File Offset: 0x000BF428
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 366005, RefRangeEnd = 366010, XrefRangeStart = 366005, XrefRangeEnd = 366010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref options;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureKey);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntryKey.NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B9F RID: 11167 RVA: 0x000C1298 File Offset: 0x000BF498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437981, XrefRangeEnd = 437986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntryKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002BA0 RID: 11168 RVA: 0x000C12EC File Offset: 0x000BF4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437986, XrefRangeEnd = 437988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(Regex.CachedCodeEntryKey other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntryKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002BA1 RID: 11169 RVA: 0x000C1344 File Offset: 0x000BF544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437988, XrefRangeEnd = 437990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator ==(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntryKey.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BA2 RID: 11170 RVA: 0x000C13A4 File Offset: 0x000BF5A4
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntryKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BA3 RID: 11171 RVA: 0x00013975 File Offset: 0x00011B75
			public CachedCodeEntryKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BA4 RID: 11172 RVA: 0x0001397E File Offset: 0x00011B7E
			public CachedCodeEntryKey()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr))
			{
			}

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000C13E8 File Offset: 0x000BF5E8
			// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x00013990 File Offset: 0x00011B90
			public unsafe RegexOptions _options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__options);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__options)) = value;
				}
			}

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000C1410 File Offset: 0x000BF610
			// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x000139AB File Offset: 0x00011BAB
			public unsafe string _cultureKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__cultureKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__cultureKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000C1438 File Offset: 0x000BF638
			// (set) Token: 0x06002BAA RID: 11178 RVA: 0x000139CA File Offset: 0x00011BCA
			public unsafe string _pattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__pattern);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntryKey.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002275 RID: 8821
			private static readonly IntPtr NativeFieldInfoPtr__options;

			// Token: 0x04002276 RID: 8822
			private static readonly IntPtr NativeFieldInfoPtr__cultureKey;

			// Token: 0x04002277 RID: 8823
			private static readonly IntPtr NativeFieldInfoPtr__pattern;

			// Token: 0x04002278 RID: 8824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RegexOptions_String_String_0;

			// Token: 0x04002279 RID: 8825
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400227A RID: 8826
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedCodeEntryKey_0;

			// Token: 0x0400227B RID: 8827
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CachedCodeEntryKey_CachedCodeEntryKey_0;

			// Token: 0x0400227C RID: 8828
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}

		// Token: 0x020002CC RID: 716
		public sealed class CachedCodeEntry : Object
		{
			// Token: 0x06002BAB RID: 11179 RVA: 0x000C1460 File Offset: 0x000BF660
			// Note: this type is marked as 'beforefieldinit'.
			static CachedCodeEntry()
			{
				Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Regex>.NativeClassPtr, "CachedCodeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr);
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Next");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Previous");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Key");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Code");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Caps");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Capnames");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Capslist");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Capsize");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_Runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "Runnerref");
				Regex.CachedCodeEntry.NativeFieldInfoPtr_ReplRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, "ReplRef");
				Regex.CachedCodeEntry.NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr, 100664636);
			}

			// Token: 0x06002BAC RID: 11180 RVA: 0x000C1568 File Offset: 0x000BF768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437990, XrefRangeEnd = 437998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CachedCodeEntry(Regex.CachedCodeEntryKey key, Hashtable capnames, Il2CppStringArray capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex.CachedCodeEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(key));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capslist);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(code);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.CachedCodeEntry.NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BAD RID: 11181 RVA: 0x000139E9 File Offset: 0x00011BE9
			public CachedCodeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000C1638 File Offset: 0x000BF838
			// (set) Token: 0x06002BAF RID: 11183 RVA: 0x000139F2 File Offset: 0x00011BF2
			public unsafe Regex.CachedCodeEntry Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000C1668 File Offset: 0x000BF868
			// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00013A11 File Offset: 0x00011C11
			public unsafe Regex.CachedCodeEntry Previous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Previous);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex.CachedCodeEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Previous), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x000C1698 File Offset: 0x000BF898
			// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00013A30 File Offset: 0x00011C30
			public Regex.CachedCodeEntryKey Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Key);
					return new Regex.CachedCodeEntryKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Key), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Regex.CachedCodeEntryKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000C16C8 File Offset: 0x000BF8C8
			// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x00013A5E File Offset: 0x00011C5E
			public unsafe RegexCode Code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Code);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Code), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000C16F8 File Offset: 0x000BF8F8
			// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x00013A7D File Offset: 0x00011C7D
			public unsafe Hashtable Caps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Caps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Caps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000C1728 File Offset: 0x000BF928
			// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x00013A9C File Offset: 0x00011C9C
			public unsafe Hashtable Capnames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capnames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000C1758 File Offset: 0x000BF958
			// (set) Token: 0x06002BBB RID: 11195 RVA: 0x00013ABB File Offset: 0x00011CBB
			public unsafe Il2CppStringArray Capslist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capslist);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000C1788 File Offset: 0x000BF988
			// (set) Token: 0x06002BBD RID: 11197 RVA: 0x00013ADA File Offset: 0x00011CDA
			public unsafe int Capsize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capsize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Capsize)) = value;
				}
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000C17B0 File Offset: 0x000BF9B0
			// (set) Token: 0x06002BBF RID: 11199 RVA: 0x00013AF5 File Offset: 0x00011CF5
			public unsafe ExclusiveReference Runnerref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Runnerref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_Runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000C17E0 File Offset: 0x000BF9E0
			// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x00013B14 File Offset: 0x00011D14
			public unsafe WeakReference<RegexReplacement> ReplRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_ReplRef);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference<RegexReplacement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.CachedCodeEntry.NativeFieldInfoPtr_ReplRef), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400227D RID: 8829
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x0400227E RID: 8830
			private static readonly IntPtr NativeFieldInfoPtr_Previous;

			// Token: 0x0400227F RID: 8831
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x04002280 RID: 8832
			private static readonly IntPtr NativeFieldInfoPtr_Code;

			// Token: 0x04002281 RID: 8833
			private static readonly IntPtr NativeFieldInfoPtr_Caps;

			// Token: 0x04002282 RID: 8834
			private static readonly IntPtr NativeFieldInfoPtr_Capnames;

			// Token: 0x04002283 RID: 8835
			private static readonly IntPtr NativeFieldInfoPtr_Capslist;

			// Token: 0x04002284 RID: 8836
			private static readonly IntPtr NativeFieldInfoPtr_Capsize;

			// Token: 0x04002285 RID: 8837
			private static readonly IntPtr NativeFieldInfoPtr_Runnerref;

			// Token: 0x04002286 RID: 8838
			private static readonly IntPtr NativeFieldInfoPtr_ReplRef;

			// Token: 0x04002287 RID: 8839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CachedCodeEntryKey_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_WeakReference_1_RegexReplacement_0;
		}
	}
}
