using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers.cell
{
	// Token: 0x02000016 RID: 22
	public class AttributeParser : Object
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00005F1C File Offset: 0x0000411C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeParser()
		{
			Il2CppClassPointerStore<AttributeParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr);
			AttributeParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "columnName");
			AttributeParser.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "attributeName");
			AttributeParser.NativeFieldInfoPtr_valuePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "valuePrefix");
			AttributeParser.NativeFieldInfoPtr_valueSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "valueSuffix");
			AttributeParser.NativeFieldInfoPtr_toLowerCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "toLowerCase");
			AttributeParser.NativeFieldInfoPtr_ignoreWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "ignoreWord");
			AttributeParser.NativeFieldInfoPtr_includePunctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "includePunctuation");
			AttributeParser.NativeFieldInfoPtr_skipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "skipList");
			AttributeParser.NativeFieldInfoPtr_replaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "replaceMap");
			AttributeParser.NativeFieldInfoPtr_prefixReplaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "prefixReplaceMap");
			AttributeParser.NativeFieldInfoPtr_ignoreTrailingCharsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, "ignoreTrailingCharsList");
			AttributeParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, 100663374);
			AttributeParser.NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, 100663375);
			AttributeParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, 100663376);
			AttributeParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr, 100663377);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00006078 File Offset: 0x00004278
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000060B0 File Offset: 0x000042B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222867, XrefRangeEnd = 1222881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeParser.NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000611C File Offset: 0x0000431C
		[CallerCount(123)]
		[CachedScanResults(RefRangeStart = 1222911, RefRangeEnd = 1223034, XrefRangeStart = 1222881, XrefRangeEnd = 1222911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeParser(string columnName, string attributeName, bool toLowerCase = false, string valuePrefix = "", string valueSuffix = "", string ignoreWord = "", bool includePunctuation = false, List<string> skipList = null, Dictionary<string, string> replaceMap = null, Dictionary<string, string> prefixReplaceMap = null, List<string> ignoreTrailingCharsList = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeParser>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006220 File Offset: 0x00004420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223034, XrefRangeEnd = 1223094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Parse(string cell, ref ScriptBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cell);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002511 File Offset: 0x00000711
		public AttributeParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000628C File Offset: 0x0000448C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000251A File Offset: 0x0000071A
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000062B4 File Offset: 0x000044B4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002539 File Offset: 0x00000739
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000062DC File Offset: 0x000044DC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002558 File Offset: 0x00000758
		public unsafe string valuePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_valuePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_valuePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006304 File Offset: 0x00004504
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002577 File Offset: 0x00000777
		public unsafe string valueSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_valueSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_valueSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000632C File Offset: 0x0000452C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002596 File Offset: 0x00000796
		public unsafe bool toLowerCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_toLowerCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_toLowerCase)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000025B1 File Offset: 0x000007B1
		public unsafe string ignoreWord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_ignoreWord);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_ignoreWord), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000025D0 File Offset: 0x000007D0
		public unsafe bool includePunctuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_includePunctuation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_includePunctuation)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000063A4 File Offset: 0x000045A4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000025EB File Offset: 0x000007EB
		public unsafe List<string> skipList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_skipList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_skipList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000063D4 File Offset: 0x000045D4
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000260A File Offset: 0x0000080A
		public unsafe Dictionary<string, string> replaceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_replaceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_replaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006404 File Offset: 0x00004604
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002629 File Offset: 0x00000829
		public unsafe Dictionary<string, string> prefixReplaceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_prefixReplaceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_prefixReplaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00006434 File Offset: 0x00004634
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002648 File Offset: 0x00000848
		public unsafe List<string> ignoreTrailingCharsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_ignoreTrailingCharsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeParser.NativeFieldInfoPtr_ignoreTrailingCharsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_valuePrefix;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_valueSuffix;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_toLowerCase;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_ignoreWord;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_includePunctuation;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_skipList;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_replaceMap;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_prefixReplaceMap;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_ignoreTrailingCharsList;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeValue_Public_Static_String_String_Boolean_String_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_String_String_Boolean_List_1_String_Dictionary_2_String_String_Dictionary_2_String_String_List_1_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
