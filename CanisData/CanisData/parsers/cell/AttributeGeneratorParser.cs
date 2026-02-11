using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace CanisData.parsers.cell
{
	// Token: 0x02000014 RID: 20
	public class AttributeGeneratorParser : Object
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00005784 File Offset: 0x00003984
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeGeneratorParser()
		{
			Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AttributeGeneratorParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr);
			AttributeGeneratorParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, "columnName");
			AttributeGeneratorParser.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, "attributeName");
			AttributeGeneratorParser.NativeFieldInfoPtr_generator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, "generator");
			AttributeGeneratorParser.NativeFieldInfoPtr__parseEmptyCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, "_parseEmptyCell");
			AttributeGeneratorParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663363);
			AttributeGeneratorParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_AttributeValueGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663364);
			AttributeGeneratorParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663365);
			AttributeGeneratorParser.NativeMethodInfoPtr_WithFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663366);
			AttributeGeneratorParser.NativeMethodInfoPtr_WithListFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663367);
			AttributeGeneratorParser.NativeMethodInfoPtr_ParseEmptyCell_Public_AttributeGeneratorParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr, 100663368);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000587C File Offset: 0x00003A7C
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000058B4 File Offset: 0x00003AB4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeGeneratorParser(string columnName, string attributeName, AttributeValueGenerator generator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeGeneratorParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_AttributeValueGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005924 File Offset: 0x00003B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222757, XrefRangeEnd = 1222764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005990 File Offset: 0x00003B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222764, XrefRangeEnd = 1222780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeGeneratorParser WithFilter(AttributeValueGenerator filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr_WithFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000059E0 File Offset: 0x00003BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222780, XrefRangeEnd = 1222796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeGeneratorParser WithListFilter(AttributeValueGenerator filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr_WithListFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005A30 File Offset: 0x00003C30
		[CallerCount(0)]
		public unsafe AttributeGeneratorParser ParseEmptyCell(bool newValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeGeneratorParser.NativeMethodInfoPtr_ParseEmptyCell_Public_AttributeGeneratorParser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeGeneratorParser>(intPtr3) : null;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002487 File Offset: 0x00000687
		public AttributeGeneratorParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005A7C File Offset: 0x00003C7C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002490 File Offset: 0x00000690
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00005AA4 File Offset: 0x00003CA4
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000024AF File Offset: 0x000006AF
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00005ACC File Offset: 0x00003CCC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000024CE File Offset: 0x000006CE
		public unsafe AttributeValueGenerator generator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_generator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeValueGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr_generator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00005AFC File Offset: 0x00003CFC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000024ED File Offset: 0x000006ED
		public unsafe bool _parseEmptyCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr__parseEmptyCell);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeGeneratorParser.NativeFieldInfoPtr__parseEmptyCell)) = value;
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_generator;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__parseEmptyCell;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_AttributeValueGenerator_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_WithFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_WithListFilter_Public_AttributeGeneratorParser_AttributeValueGenerator_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_ParseEmptyCell_Public_AttributeGeneratorParser_Boolean_0;
	}
}
