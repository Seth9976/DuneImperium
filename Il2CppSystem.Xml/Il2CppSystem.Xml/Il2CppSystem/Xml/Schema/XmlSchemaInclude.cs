using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CC RID: 460
	public class XmlSchemaInclude : XmlSchemaExternal
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x000B4990 File Offset: 0x000B2B90
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaInclude()
		{
			Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaInclude");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr);
			XmlSchemaInclude.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr, "annotation");
			XmlSchemaInclude.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr, 100668866);
			XmlSchemaInclude.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr, 100668867);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000B49FC File Offset: 0x000B2BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412399, RefRangeEnd = 412400, XrefRangeStart = 412398, XrefRangeEnd = 412399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaInclude()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaInclude>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaInclude.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000B4A38 File Offset: 0x000B2C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaInclude.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0001065F File Offset: 0x0000E85F
		public XmlSchemaInclude(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x000B4A88 File Offset: 0x000B2C88
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x00010668 File Offset: 0x0000E868
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInclude.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaInclude.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;
	}
}
