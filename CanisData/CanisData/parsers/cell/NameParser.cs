using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.parsers.cell
{
	// Token: 0x0200001D RID: 29
	public class NameParser : Object
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00007268 File Offset: 0x00005468
		// Note: this type is marked as 'beforefieldinit'.
		static NameParser()
		{
			Il2CppClassPointerStore<NameParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "NameParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameParser>.NativeClassPtr);
			NameParser.NativeFieldInfoPtr_columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameParser>.NativeClassPtr, "columnName");
			NameParser.NativeFieldInfoPtr_namePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameParser>.NativeClassPtr, "namePrefix");
			NameParser.NativeFieldInfoPtr_nameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameParser>.NativeClassPtr, "nameSuffix");
			NameParser.NativeFieldInfoPtr_changeNameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameParser>.NativeClassPtr, "changeNameList");
			NameParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameParser>.NativeClassPtr, 100663421);
			NameParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameParser>.NativeClassPtr, 100663422);
			NameParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameParser>.NativeClassPtr, 100663423);
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00007324 File Offset: 0x00005524
		public unsafe virtual string ColumnName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameParser.NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000735C File Offset: 0x0000555C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1223598, RefRangeEnd = 1223613, XrefRangeStart = 1223587, XrefRangeEnd = 1223598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameParser(string columnName, string namePrefix = "", string nameSuffix = "", List<string> changeNameList = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namePrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameSuffix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changeNameList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameParser.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000073E0 File Offset: 0x000055E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1223613, XrefRangeEnd = 1223651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NameParser.NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002795 File Offset: 0x00000995
		public NameParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000744C File Offset: 0x0000564C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000279E File Offset: 0x0000099E
		public unsafe string columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00007474 File Offset: 0x00005674
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000027BD File Offset: 0x000009BD
		public unsafe string namePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_namePrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_namePrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000027DC File Offset: 0x000009DC
		public unsafe string nameSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_nameSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_nameSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000074C4 File Offset: 0x000056C4
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000027FB File Offset: 0x000009FB
		public unsafe List<string> changeNameList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_changeNameList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameParser.NativeFieldInfoPtr_changeNameList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_columnName;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_namePrefix;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_nameSuffix;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_changeNameList;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_List_1_String_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Virtual_Final_New_Void_String_byref_ScriptBuilder_0;
	}
}
