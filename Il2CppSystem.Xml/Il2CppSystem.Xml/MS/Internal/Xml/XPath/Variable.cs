using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000206 RID: 518
	public class Variable : AstNode
	{
		// Token: 0x06002D5F RID: 11615 RVA: 0x000D0CA8 File Offset: 0x000CEEA8
		// Note: this type is marked as 'beforefieldinit'.
		static Variable()
		{
			Il2CppClassPointerStore<Variable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Variable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variable>.NativeClassPtr);
			Variable.NativeFieldInfoPtr__localname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable>.NativeClassPtr, "_localname");
			Variable.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable>.NativeClassPtr, "_prefix");
			Variable.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable>.NativeClassPtr, 100669847);
			Variable.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable>.NativeClassPtr, 100669848);
			Variable.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable>.NativeClassPtr, 100669849);
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000D0D3C File Offset: 0x000CEF3C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Variable(string name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Variable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000D0D9C File Offset: 0x000CEF9C
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x000D0DE4 File Offset: 0x000CEFE4
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40756, RefRangeEnd = 40759, XrefRangeStart = 40756, XrefRangeEnd = 40759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00012B9B File Offset: 0x00010D9B
		public Variable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000D0E2C File Offset: 0x000CF02C
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x00012BA4 File Offset: 0x00010DA4
		public unsafe string _localname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable.NativeFieldInfoPtr__localname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable.NativeFieldInfoPtr__localname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000D0E54 File Offset: 0x000CF054
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x00012BC3 File Offset: 0x00010DC3
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeFieldInfoPtr__localname;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;
	}
}
