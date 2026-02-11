using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000203 RID: 515
	public class Operand : AstNode
	{
		// Token: 0x06002D43 RID: 11587 RVA: 0x000D06E4 File Offset: 0x000CE8E4
		// Note: this type is marked as 'beforefieldinit'.
		static Operand()
		{
			Il2CppClassPointerStore<Operand>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Operand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Operand>.NativeClassPtr);
			Operand.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operand>.NativeClassPtr, "_type");
			Operand.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operand>.NativeClassPtr, "_val");
			Operand.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operand>.NativeClassPtr, 100669836);
			Operand.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operand>.NativeClassPtr, 100669837);
			Operand.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operand>.NativeClassPtr, 100669838);
			Operand.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operand>.NativeClassPtr, 100669839);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x000D078C File Offset: 0x000CE98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425610, XrefRangeEnd = 425612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Operand(string val)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Operand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operand.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000D07D8 File Offset: 0x000CE9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425617, RefRangeEnd = 425618, XrefRangeStart = 425612, XrefRangeEnd = 425617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Operand(double val)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Operand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operand.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000D0820 File Offset: 0x000CEA20
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operand.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x000D0868 File Offset: 0x000CEA68
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operand.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00012ADB File Offset: 0x00010CDB
		public Operand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000D08B0 File Offset: 0x000CEAB0
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x00012AE4 File Offset: 0x00010CE4
		public unsafe XPathResultType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operand.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operand.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x000D08D8 File Offset: 0x000CEAD8
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x00012AFF File Offset: 0x00010CFF
		public unsafe Object _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operand.NativeFieldInfoPtr__val);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operand.NativeFieldInfoPtr__val), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;
	}
}
