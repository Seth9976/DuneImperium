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
	// Token: 0x02000010 RID: 16
	public class AttributeCollectionParser : Object
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00004E2C File Offset: 0x0000302C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeCollectionParser()
		{
			Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeCollectionParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr);
			AttributeCollectionParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "columnName");
			AttributeCollectionParser.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "attributeName");
			AttributeCollectionParser.NativeFieldInfoPtr_collectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "collectionType");
			AttributeCollectionParser.NativeFieldInfoPtr_valuePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "valuePrefix");
			AttributeCollectionParser.NativeFieldInfoPtr_valueSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "valueSuffix");
			AttributeCollectionParser.NativeFieldInfoPtr_skipTokenList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "skipTokenList");
			AttributeCollectionParser.NativeFieldInfoPtr_replaceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, "replaceMap");
			AttributeCollectionParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, 100663350);
			AttributeCollectionParser.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, 100663351);
			AttributeCollectionParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, 100663352);
			AttributeCollectionParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr, 100663353);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004F38 File Offset: 0x00003138
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollectionParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004F70 File Offset: 0x00003170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222582, XrefRangeEnd = 1222607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeCollectionParser(string columnName, string attributeName, string collectionType, string valuePrefix, string valueSuffix, List<string> skipTokenList, Dictionary<string, string> replaceMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeCollectionParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(collectionType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valuePrefix);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueSuffix);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skipTokenList);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollectionParser.NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(0)]
		public unsafe virtual void BuildCollectionType(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeCollectionParser.NativeMethodInfoPtr_BuildCollectionType_Protected_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000507C File Offset: 0x0000327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222607, XrefRangeEnd = 1222662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeCollectionParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002363 File Offset: 0x00000563
		public AttributeCollectionParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000050E8 File Offset: 0x000032E8
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000236C File Offset: 0x0000056C
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00005110 File Offset: 0x00003310
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000238B File Offset: 0x0000058B
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00005138 File Offset: 0x00003338
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000023AA File Offset: 0x000005AA
		public unsafe string collectionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_collectionType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_collectionType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00005160 File Offset: 0x00003360
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000023C9 File Offset: 0x000005C9
		public unsafe string valuePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_valuePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_valuePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00005188 File Offset: 0x00003388
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000023E8 File Offset: 0x000005E8
		public unsafe string valueSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_valueSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_valueSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000051B0 File Offset: 0x000033B0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002407 File Offset: 0x00000607
		public unsafe List<string> skipTokenList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_skipTokenList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_skipTokenList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000051E0 File Offset: 0x000033E0
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002426 File Offset: 0x00000626
		public unsafe Dictionary<string, string> replaceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_replaceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollectionParser.NativeFieldInfoPtr_replaceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_collectionType;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_valuePrefix;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_valueSuffix;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_skipTokenList;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_replaceMap;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_String_String_String_String_List_1_String_Dictionary_2_String_String_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_BuildCollectionType_Protected_Abstract_Virtual_New_Void_StringBuilder_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
