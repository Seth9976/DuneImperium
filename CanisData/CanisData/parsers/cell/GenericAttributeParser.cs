using System;
using System.Runtime.InteropServices;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers.cell
{
	// Token: 0x02000019 RID: 25
	public class GenericAttributeParser : Object
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00006B58 File Offset: 0x00004D58
		// Note: this type is marked as 'beforefieldinit'.
		static GenericAttributeParser()
		{
			Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "GenericAttributeParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr);
			GenericAttributeParser.NativeFieldInfoPtr_attributeNameLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, "attributeNameLookup");
			GenericAttributeParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, "columnName");
			GenericAttributeParser.NativeMethodInfoPtr_InitializeLookup_Public_Static_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, 100663403);
			GenericAttributeParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, 100663404);
			GenericAttributeParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, 100663405);
			GenericAttributeParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr, 100663406);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006C00 File Offset: 0x00004E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1223467, RefRangeEnd = 1223468, XrefRangeStart = 1223443, XrefRangeEnd = 1223467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeLookup([Optional] Il2CppReferenceArray<Type> attributeContainers)
		{
			if (attributeContainers == null)
			{
				attributeContainers = new Il2CppReferenceArray<Type>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeContainers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributeParser.NativeMethodInfoPtr_InitializeLookup_Public_Static_Void_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00006C44 File Offset: 0x00004E44
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributeParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006C7C File Offset: 0x00004E7C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericAttributeParser(string columnName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericAttributeParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericAttributeParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006CC8 File Offset: 0x00004EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223468, XrefRangeEnd = 1223504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GenericAttributeParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000026B7 File Offset: 0x000008B7
		public static void InitializeLookup(params Type[] attributeContainers)
		{
			GenericAttributeParser.InitializeLookup(new Il2CppReferenceArray<Type>(attributeContainers));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000026C4 File Offset: 0x000008C4
		public GenericAttributeParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00006D34 File Offset: 0x00004F34
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000026CD File Offset: 0x000008CD
		public unsafe static Dictionary<string, string> attributeNameLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GenericAttributeParser.NativeFieldInfoPtr_attributeNameLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericAttributeParser.NativeFieldInfoPtr_attributeNameLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00006D5C File Offset: 0x00004F5C
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x000026DF File Offset: 0x000008DF
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributeParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericAttributeParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_attributeNameLookup;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_InitializeLookup_Public_Static_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
