using System;
using CanisData.generation.builders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace CanisData.parsers.cell
{
	// Token: 0x0200001A RID: 26
	public class ICellParser : Il2CppObjectBase
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00006D84 File Offset: 0x00004F84
		// Note: this type is marked as 'beforefieldinit'.
		static ICellParser()
		{
			Il2CppClassPointerStore<ICellParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.parsers.cell", "ICellParser");
			ICellParser.NativeMethodInfoPtr_get_ColumnName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICellParser>.NativeClassPtr, 100663408);
			ICellParser.NativeMethodInfoPtr_Parse_Public_Abstract_Virtual_New_Void_String_byref_ScriptBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICellParser>.NativeClassPtr, 100663409);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00006DD4 File Offset: 0x00004FD4
		public unsafe virtual string ColumnName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICellParser.NativeMethodInfoPtr_get_ColumnName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00006E18 File Offset: 0x00005018
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICellParser.NativeMethodInfoPtr_Parse_Public_Abstract_Virtual_New_Void_String_byref_ScriptBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			builder = ((intPtr4 == 0) ? null : new ScriptBuilder(intPtr4));
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000026FE File Offset: 0x000008FE
		public ICellParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Abstract_Virtual_New_Void_String_byref_ScriptBuilder_0;
	}
}
