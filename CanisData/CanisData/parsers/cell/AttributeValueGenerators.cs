using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace CanisData.parsers.cell
{
	// Token: 0x02000017 RID: 23
	public static class AttributeValueGenerators : Object
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00006464 File Offset: 0x00004664
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeValueGenerators()
		{
			Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeValueGenerators");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr);
			AttributeValueGenerators.NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663378);
			AttributeValueGenerators.NativeMethodInfoPtr_ValueGenerator_Public_Static_AttributeValueGenerator_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663379);
			AttributeValueGenerators.NativeMethodInfoPtr_CollectionAttributeValueGenerator_Private_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_Action_1_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663380);
			AttributeValueGenerators.NativeMethodInfoPtr_ListAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663381);
			AttributeValueGenerators.NativeMethodInfoPtr_ArrayAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663382);
			AttributeValueGenerators.NativeMethodInfoPtr_LocalizableTextValueGenerator_Public_Static_AttributeValueGenerator_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663383);
			AttributeValueGenerators.NativeMethodInfoPtr_WithFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663384);
			AttributeValueGenerators.NativeMethodInfoPtr_WithListFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, 100663385);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006534 File Offset: 0x00004734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223246, XrefRangeEnd = 1223260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeValue(string cell, bool toLowerCase = false, string ignoreWord = "", bool includePunctuation = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toLowerCase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ignoreWord);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePunctuation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000065A0 File Offset: 0x000047A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1223305, RefRangeEnd = 1223306, XrefRangeStart = 1223260, XrefRangeEnd = 1223305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator ValueGenerator(bool toLowerCase = false, string valuePrefix = "", string valueSuffix = "", string ignoreWord = "", bool includePunctuation = false, List<string> skipList = null, Dictionary<string, string> replaceMap = null, Dictionary<string, string> prefixReplaceMap = null, List<string> ignoreTrailingCharsList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref toLowerCase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ignoreWord);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePunctuation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipList);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefixReplaceMap);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreTrailingCharsList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_ValueGenerator_Public_Static_AttributeValueGenerator_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006674 File Offset: 0x00004874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1223347, RefRangeEnd = 1223350, XrefRangeStart = 1223306, XrefRangeEnd = 1223347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator CollectionAttributeValueGenerator(string collectionType, string valuePrefix, string valueSuffix, List<string> skipTokenList, Dictionary<string, string> replaceMap, bool includeEmpty, Action<StringBuilder> buildCollectionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEmpty;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buildCollectionType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_CollectionAttributeValueGenerator_Private_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_Action_1_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006724 File Offset: 0x00004924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1223362, RefRangeEnd = 1223364, XrefRangeStart = 1223350, XrefRangeEnd = 1223362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator ListAttributeValueGenerator(string collectionType, string valuePrefix = null, string valueSuffix = null, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null, bool includeEmpty = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_ListAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000067C0 File Offset: 0x000049C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223364, XrefRangeEnd = 1223376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator ArrayAttributeValueGenerator(string collectionType, string valuePrefix = null, string valueSuffix = null, List<string> skipTokenList = null, Dictionary<string, string> replaceMap = null, bool includeEmpty = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_ArrayAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000685C File Offset: 0x00004A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223376, XrefRangeEnd = 1223392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator LocalizableTextValueGenerator(string keyPrefix, string keySuffix, bool useId = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyPrefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keySuffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_LocalizableTextValueGenerator_Public_Static_AttributeValueGenerator_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000068C0 File Offset: 0x00004AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223392, XrefRangeEnd = 1223408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator WithFilter(this AttributeValueGenerator other, AttributeValueGenerator filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_WithFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006918 File Offset: 0x00004B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223408, XrefRangeEnd = 1223424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeValueGenerator WithListFilter(this AttributeValueGenerator other, AttributeValueGenerator filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.NativeMethodInfoPtr_WithListFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr3) : null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002667 File Offset: 0x00000867
		public AttributeValueGenerators(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_ValueGenerator_Public_Static_AttributeValueGenerator_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_CollectionAttributeValueGenerator_Private_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_Action_1_StringBuilder_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_ListAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAttributeValueGenerator_Public_Static_AttributeValueGenerator_String_String_String_List_1_String_Dictionary_2_String_String_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_LocalizableTextValueGenerator_Public_Static_AttributeValueGenerator_String_String_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_WithFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_WithListFilter_Public_Static_AttributeValueGenerator_AttributeValueGenerator_AttributeValueGenerator_0;

		// Token: 0x02000036 RID: 54
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06000232 RID: 562 RVA: 0x0000B0B0 File Offset: 0x000092B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_toLowerCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "toLowerCase");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "ignoreWord");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_includePunctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "includePunctuation");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_prefixReplaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "prefixReplaceMap");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valuePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "valuePrefix");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreTrailingCharsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "ignoreTrailingCharsList");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_replaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "replaceMap");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valueSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "valueSuffix");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_skipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, "skipList");
				AttributeValueGenerators.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, 100663386);
				AttributeValueGenerators.__c__DisplayClass1_0.NativeMethodInfoPtr__ValueGenerator_b__0_Internal_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr, 100663387);
			}

			// Token: 0x06000233 RID: 563 RVA: 0x0000B1B8 File Offset: 0x000093B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000234 RID: 564 RVA: 0x0000B1F4 File Offset: 0x000093F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223094, XrefRangeEnd = 1223149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ValueGenerator_b__0(string cell, ScriptBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass1_0.NativeMethodInfoPtr__ValueGenerator_b__0_Internal_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000235 RID: 565 RVA: 0x000032B1 File Offset: 0x000014B1
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000236 RID: 566 RVA: 0x0000B250 File Offset: 0x00009450
			// (set) Token: 0x06000237 RID: 567 RVA: 0x000032BA File Offset: 0x000014BA
			public unsafe bool toLowerCase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_toLowerCase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_toLowerCase)) = value;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000238 RID: 568 RVA: 0x0000B278 File Offset: 0x00009478
			// (set) Token: 0x06000239 RID: 569 RVA: 0x000032D5 File Offset: 0x000014D5
			public unsafe string ignoreWord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreWord);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreWord), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x0600023A RID: 570 RVA: 0x0000B2A0 File Offset: 0x000094A0
			// (set) Token: 0x0600023B RID: 571 RVA: 0x000032F4 File Offset: 0x000014F4
			public unsafe bool includePunctuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_includePunctuation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_includePunctuation)) = value;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600023C RID: 572 RVA: 0x0000B2C8 File Offset: 0x000094C8
			// (set) Token: 0x0600023D RID: 573 RVA: 0x0000330F File Offset: 0x0000150F
			public unsafe Dictionary<string, string> prefixReplaceMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_prefixReplaceMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_prefixReplaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600023E RID: 574 RVA: 0x0000B2F8 File Offset: 0x000094F8
			// (set) Token: 0x0600023F RID: 575 RVA: 0x0000332E File Offset: 0x0000152E
			public unsafe string valuePrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valuePrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valuePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000B320 File Offset: 0x00009520
			// (set) Token: 0x06000241 RID: 577 RVA: 0x0000334D File Offset: 0x0000154D
			public unsafe List<string> ignoreTrailingCharsList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreTrailingCharsList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_ignoreTrailingCharsList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000B350 File Offset: 0x00009550
			// (set) Token: 0x06000243 RID: 579 RVA: 0x0000336C File Offset: 0x0000156C
			public unsafe Dictionary<string, string> replaceMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_replaceMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_replaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000B380 File Offset: 0x00009580
			// (set) Token: 0x06000245 RID: 581 RVA: 0x0000338B File Offset: 0x0000158B
			public unsafe string valueSuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valueSuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_valueSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0000B3A8 File Offset: 0x000095A8
			// (set) Token: 0x06000247 RID: 583 RVA: 0x000033AA File Offset: 0x000015AA
			public unsafe List<string> skipList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_skipList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass1_0.NativeFieldInfoPtr_skipList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeFieldInfoPtr_toLowerCase;

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeFieldInfoPtr_ignoreWord;

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeFieldInfoPtr_includePunctuation;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeFieldInfoPtr_prefixReplaceMap;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeFieldInfoPtr_valuePrefix;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeFieldInfoPtr_ignoreTrailingCharsList;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeFieldInfoPtr_replaceMap;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeFieldInfoPtr_valueSuffix;

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeFieldInfoPtr_skipList;

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeMethodInfoPtr__ValueGenerator_b__0_Internal_String_String_ScriptBuilder_0;
		}

		// Token: 0x02000037 RID: 55
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000248 RID: 584 RVA: 0x0000B3D8 File Offset: 0x000095D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_splitOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "splitOptions");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_buildCollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "buildCollectionType");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_skipTokenList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "skipTokenList");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valuePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "valuePrefix");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_replaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "replaceMap");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valueSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, "valueSuffix");
				AttributeValueGenerators.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, 100663388);
				AttributeValueGenerators.__c__DisplayClass2_0.NativeMethodInfoPtr__CollectionAttributeValueGenerator_b__0_Internal_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr, 100663389);
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000B4A4 File Offset: 0x000096A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000B4E0 File Offset: 0x000096E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223149, XrefRangeEnd = 1223198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CollectionAttributeValueGenerator_b__0(string cell, ScriptBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass2_0.NativeMethodInfoPtr__CollectionAttributeValueGenerator_b__0_Internal_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600024B RID: 587 RVA: 0x000033C9 File Offset: 0x000015C9
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600024C RID: 588 RVA: 0x0000B53C File Offset: 0x0000973C
			// (set) Token: 0x0600024D RID: 589 RVA: 0x000033D2 File Offset: 0x000015D2
			public unsafe StringSplitOptions splitOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_splitOptions);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_splitOptions)) = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x0600024E RID: 590 RVA: 0x0000B564 File Offset: 0x00009764
			// (set) Token: 0x0600024F RID: 591 RVA: 0x000033ED File Offset: 0x000015ED
			public unsafe Action<StringBuilder> buildCollectionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_buildCollectionType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StringBuilder>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_buildCollectionType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000250 RID: 592 RVA: 0x0000B594 File Offset: 0x00009794
			// (set) Token: 0x06000251 RID: 593 RVA: 0x0000340C File Offset: 0x0000160C
			public unsafe List<string> skipTokenList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_skipTokenList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_skipTokenList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000252 RID: 594 RVA: 0x0000B5C4 File Offset: 0x000097C4
			// (set) Token: 0x06000253 RID: 595 RVA: 0x0000342B File Offset: 0x0000162B
			public unsafe string valuePrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valuePrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valuePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000254 RID: 596 RVA: 0x0000B5EC File Offset: 0x000097EC
			// (set) Token: 0x06000255 RID: 597 RVA: 0x0000344A File Offset: 0x0000164A
			public unsafe Dictionary<string, string> replaceMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_replaceMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_replaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000256 RID: 598 RVA: 0x0000B61C File Offset: 0x0000981C
			// (set) Token: 0x06000257 RID: 599 RVA: 0x00003469 File Offset: 0x00001669
			public unsafe string valueSuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valueSuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass2_0.NativeFieldInfoPtr_valueSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeFieldInfoPtr_splitOptions;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeFieldInfoPtr_buildCollectionType;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeFieldInfoPtr_skipTokenList;

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeFieldInfoPtr_valuePrefix;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeFieldInfoPtr_replaceMap;

			// Token: 0x0400015B RID: 347
			private static readonly IntPtr NativeFieldInfoPtr_valueSuffix;

			// Token: 0x0400015C RID: 348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeMethodInfoPtr__CollectionAttributeValueGenerator_b__0_Internal_String_String_ScriptBuilder_0;
		}

		// Token: 0x02000038 RID: 56
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000258 RID: 600 RVA: 0x0000B644 File Offset: 0x00009844
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass3_0.NativeFieldInfoPtr_collectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr, "collectionType");
				AttributeValueGenerators.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr, 100663390);
				AttributeValueGenerators.__c__DisplayClass3_0.NativeMethodInfoPtr__ListAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr, 100663391);
			}

			// Token: 0x06000259 RID: 601 RVA: 0x0000B6AC File Offset: 0x000098AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000B6E8 File Offset: 0x000098E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223198, XrefRangeEnd = 1223206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ListAttributeValueGenerator_b__0(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass3_0.NativeMethodInfoPtr__ListAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600025B RID: 603 RVA: 0x00003488 File Offset: 0x00001688
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600025C RID: 604 RVA: 0x0000B72C File Offset: 0x0000992C
			// (set) Token: 0x0600025D RID: 605 RVA: 0x00003491 File Offset: 0x00001691
			public unsafe string collectionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass3_0.NativeFieldInfoPtr_collectionType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass3_0.NativeFieldInfoPtr_collectionType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeFieldInfoPtr_collectionType;

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeMethodInfoPtr__ListAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0;
		}

		// Token: 0x02000039 RID: 57
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600025E RID: 606 RVA: 0x0000B754 File Offset: 0x00009954
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass4_0.NativeFieldInfoPtr_collectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr, "collectionType");
				AttributeValueGenerators.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr, 100663392);
				AttributeValueGenerators.__c__DisplayClass4_0.NativeMethodInfoPtr__ArrayAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr, 100663393);
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000B7BC File Offset: 0x000099BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000260 RID: 608 RVA: 0x0000B7F8 File Offset: 0x000099F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223206, XrefRangeEnd = 1223214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ArrayAttributeValueGenerator_b__0(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass4_0.NativeMethodInfoPtr__ArrayAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000261 RID: 609 RVA: 0x000034B0 File Offset: 0x000016B0
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000262 RID: 610 RVA: 0x0000B83C File Offset: 0x00009A3C
			// (set) Token: 0x06000263 RID: 611 RVA: 0x000034B9 File Offset: 0x000016B9
			public unsafe string collectionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass4_0.NativeFieldInfoPtr_collectionType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass4_0.NativeFieldInfoPtr_collectionType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeFieldInfoPtr_collectionType;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeMethodInfoPtr__ArrayAttributeValueGenerator_b__0_Internal_Void_StringBuilder_0;
		}

		// Token: 0x0200003A RID: 58
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000264 RID: 612 RVA: 0x0000B864 File Offset: 0x00009A64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keyPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr, "keyPrefix");
				AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_useId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr, "useId");
				AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keySuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr, "keySuffix");
				AttributeValueGenerators.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr, 100663394);
				AttributeValueGenerators.__c__DisplayClass5_0.NativeMethodInfoPtr__LocalizableTextValueGenerator_b__0_Internal_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr, 100663395);
			}

			// Token: 0x06000265 RID: 613 RVA: 0x0000B8F4 File Offset: 0x00009AF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000266 RID: 614 RVA: 0x0000B930 File Offset: 0x00009B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223214, XrefRangeEnd = 1223219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _LocalizableTextValueGenerator_b__0(string cell, ScriptBuilder scriptBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scriptBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass5_0.NativeMethodInfoPtr__LocalizableTextValueGenerator_b__0_Internal_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000267 RID: 615 RVA: 0x000034D8 File Offset: 0x000016D8
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0000B98C File Offset: 0x00009B8C
			// (set) Token: 0x06000269 RID: 617 RVA: 0x000034E1 File Offset: 0x000016E1
			public unsafe string keyPrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keyPrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keyPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600026A RID: 618 RVA: 0x0000B9B4 File Offset: 0x00009BB4
			// (set) Token: 0x0600026B RID: 619 RVA: 0x00003500 File Offset: 0x00001700
			public unsafe bool useId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_useId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_useId)) = value;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600026C RID: 620 RVA: 0x0000B9DC File Offset: 0x00009BDC
			// (set) Token: 0x0600026D RID: 621 RVA: 0x0000351B File Offset: 0x0000171B
			public unsafe string keySuffix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keySuffix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass5_0.NativeFieldInfoPtr_keySuffix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeFieldInfoPtr_keyPrefix;

			// Token: 0x04000165 RID: 357
			private static readonly IntPtr NativeFieldInfoPtr_useId;

			// Token: 0x04000166 RID: 358
			private static readonly IntPtr NativeFieldInfoPtr_keySuffix;

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeMethodInfoPtr__LocalizableTextValueGenerator_b__0_Internal_String_String_ScriptBuilder_0;
		}

		// Token: 0x0200003B RID: 59
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600026E RID: 622 RVA: 0x0000BA04 File Offset: 0x00009C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr, "other");
				AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr, "filter");
				AttributeValueGenerators.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr, 100663396);
				AttributeValueGenerators.__c__DisplayClass6_0.NativeMethodInfoPtr__WithFilter_b__0_Internal_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr, 100663397);
			}

			// Token: 0x0600026F RID: 623 RVA: 0x0000BA80 File Offset: 0x00009C80
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000270 RID: 624 RVA: 0x0000BABC File Offset: 0x00009CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223219, XrefRangeEnd = 1223220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _WithFilter_b__0(string cell, ScriptBuilder scriptBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scriptBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass6_0.NativeMethodInfoPtr__WithFilter_b__0_Internal_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0000353A File Offset: 0x0000173A
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000272 RID: 626 RVA: 0x0000BB18 File Offset: 0x00009D18
			// (set) Token: 0x06000273 RID: 627 RVA: 0x00003543 File Offset: 0x00001743
			public unsafe AttributeValueGenerator other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000274 RID: 628 RVA: 0x0000BB48 File Offset: 0x00009D48
			// (set) Token: 0x06000275 RID: 629 RVA: 0x00003562 File Offset: 0x00001762
			public unsafe AttributeValueGenerator filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass6_0.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeFieldInfoPtr_filter;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeMethodInfoPtr__WithFilter_b__0_Internal_String_String_ScriptBuilder_0;
		}

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("CanisData.parsers.cell.AttributeValueGenerators+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06000276 RID: 630 RVA: 0x0000BB78 File Offset: 0x00009D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeValueGenerators>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr);
				AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr, "filter");
				AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr, "other");
				AttributeValueGenerators.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr, 100663398);
				AttributeValueGenerators.__c__DisplayClass7_0.NativeMethodInfoPtr__WithListFilter_b__0_Internal_String_String_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr, 100663399);
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0000BBF4 File Offset: 0x00009DF4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeValueGenerators.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0000BC30 File Offset: 0x00009E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223220, XrefRangeEnd = 1223246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _WithListFilter_b__0(string cell, ScriptBuilder scriptBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scriptBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeValueGenerators.__c__DisplayClass7_0.NativeMethodInfoPtr__WithListFilter_b__0_Internal_String_String_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00003581 File Offset: 0x00001781
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600027A RID: 634 RVA: 0x0000BC8C File Offset: 0x00009E8C
			// (set) Token: 0x0600027B RID: 635 RVA: 0x0000358A File Offset: 0x0000178A
			public unsafe AttributeValueGenerator filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x0600027C RID: 636 RVA: 0x0000BCBC File Offset: 0x00009EBC
			// (set) Token: 0x0600027D RID: 637 RVA: 0x000035A9 File Offset: 0x000017A9
			public unsafe AttributeValueGenerator other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeValueGenerators.__c__DisplayClass7_0.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeFieldInfoPtr_filter;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeMethodInfoPtr__WithListFilter_b__0_Internal_String_String_ScriptBuilder_0;
		}
	}
}
