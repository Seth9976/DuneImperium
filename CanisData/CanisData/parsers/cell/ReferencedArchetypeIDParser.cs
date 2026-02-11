using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData.parsers.cell
{
	// Token: 0x0200001E RID: 30
	public class ReferencedArchetypeIDParser : Object
	{
		// Token: 0x060000FD RID: 253 RVA: 0x000074F4 File Offset: 0x000056F4
		// Note: this type is marked as 'beforefieldinit'.
		static ReferencedArchetypeIDParser()
		{
			Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "ReferencedArchetypeIDParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr);
			ReferencedArchetypeIDParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr, "columnName");
			ReferencedArchetypeIDParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr, 100663424);
			ReferencedArchetypeIDParser.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr, 100663425);
			ReferencedArchetypeIDParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr, 100663426);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00007574 File Offset: 0x00005774
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedArchetypeIDParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000075AC File Offset: 0x000057AC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferencedArchetypeIDParser(string columnName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferencedArchetypeIDParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferencedArchetypeIDParser.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000075F8 File Offset: 0x000057F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223651, XrefRangeEnd = 1223691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReferencedArchetypeIDParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000281A File Offset: 0x00000A1A
		public ReferencedArchetypeIDParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00007664 File Offset: 0x00005864
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002823 File Offset: 0x00000A23
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferencedArchetypeIDParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferencedArchetypeIDParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
