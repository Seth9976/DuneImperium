using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers.cell
{
	// Token: 0x02000015 RID: 21
	public static class AttributeGeneratorParsers : Object
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00005B24 File Offset: 0x00003D24
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeGeneratorParsers()
		{
			Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeGeneratorParsers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr);
			AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeListParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr, 100663369);
			AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeArrayParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr, 100663370);
			AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeParser_Public_Static_AttributeGeneratorParser_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr, 100663371);
			AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeLocalizableTextParser_Public_Static_AttributeGeneratorParser_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr, 100663372);
			AttributeGeneratorParsers.NativeMethodInfoPtr_AbilityIDParser_Public_Static_AttributeGeneratorParser_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParsers>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005BB8 File Offset: 0x00003DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222796, XrefRangeEnd = 1222804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeGeneratorParser AttributeListParser(string columnName, string attributeName, string collectionType, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null, string valuePrefix = null, string valueSuffix = null, bool includeEmpty = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeListParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005C7C File Offset: 0x00003E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222804, XrefRangeEnd = 1222823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeGeneratorParser AttributeArrayParser(string columnName, string attributeName, string collectionType, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null, string valuePrefix = null, string valueSuffix = null, bool includeEmpty = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeArrayParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005D40 File Offset: 0x00003F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222823, XrefRangeEnd = 1222831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeGeneratorParser AttributeParser(string columnName, string attributeName, bool toLowerCase = false, string valuePrefix = "", string valueSuffix = "", string ignoreWord = "", bool includePunctuation = false, List<string> skipList = null, Dictionary<string, string> replaceMap = null, Dictionary<string, string> prefixReplaceMap = null, List<string> ignoreTrailingCharsList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toLowerCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ignoreWord);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePunctuation;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipList);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefixReplaceMap);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreTrailingCharsList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeParser_Public_Static_AttributeGeneratorParser_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005E3C File Offset: 0x0000403C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222831, XrefRangeEnd = 1222853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeGeneratorParser AttributeLocalizableTextParser(string columnName, string attributeName, string keyPrefix, string keySuffix, bool useId = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyPrefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keySuffix);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParsers.NativeMethodInfoPtr_AttributeLocalizableTextParser_Public_Static_AttributeGeneratorParser_String_String_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005EC4 File Offset: 0x000040C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222853, XrefRangeEnd = 1222867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeGeneratorParser AbilityIDParser(string columnName, string attributeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParsers.NativeMethodInfoPtr_AbilityIDParser_Public_Static_AttributeGeneratorParser_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002508 File Offset: 0x00000708
		public AttributeGeneratorParsers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_AttributeListParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_AttributeArrayParser_Public_Static_AttributeGeneratorParser_String_String_String_List_1_String_Dictionary_2_String_String_String_String_Boolean_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_AttributeParser_Public_Static_AttributeGeneratorParser_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_AttributeLocalizableTextParser_Public_Static_AttributeGeneratorParser_String_String_String_String_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_AbilityIDParser_Public_Static_AttributeGeneratorParser_String_String_0;
	}
}
