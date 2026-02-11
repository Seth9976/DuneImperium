using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace CanisData.parsers.cell
{
	// Token: 0x0200000F RID: 15
	public class AbilityRefParser : Object
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00004C44 File Offset: 0x00002E44
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityRefParser()
		{
			Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "AbilityRefParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr);
			AbilityRefParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr, "columnName");
			AbilityRefParser.NativeFieldInfoPtr_attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr, "attributeName");
			AbilityRefParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr, 100663347);
			AbilityRefParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr, 100663348);
			AbilityRefParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr, 100663349);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityRefParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004D10 File Offset: 0x00002F10
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityRefParser(string columnName, string attributeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityRefParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityRefParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004D70 File Offset: 0x00002F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222551, XrefRangeEnd = 1222582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityRefParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000231C File Offset: 0x0000051C
		public AbilityRefParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004DDC File Offset: 0x00002FDC
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002325 File Offset: 0x00000525
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityRefParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityRefParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004E04 File Offset: 0x00003004
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002344 File Offset: 0x00000544
		public unsafe string attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityRefParser.NativeFieldInfoPtr_attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityRefParser.NativeFieldInfoPtr_attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_attributeName;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
