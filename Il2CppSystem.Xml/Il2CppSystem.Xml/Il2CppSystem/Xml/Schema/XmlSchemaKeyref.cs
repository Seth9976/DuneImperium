using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CA RID: 458
	public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x000B4618 File Offset: 0x000B2818
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaKeyref()
		{
			Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaKeyref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr);
			XmlSchemaKeyref.NativeFieldInfoPtr_refer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, "refer");
			XmlSchemaKeyref.NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668859);
			XmlSchemaKeyref.NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668860);
			XmlSchemaKeyref.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr, 100668861);
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000B4698 File Offset: 0x000B2898
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x000B46D8 File Offset: 0x000B28D8
		public unsafe XmlQualifiedName Refer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 412376, RefRangeEnd = 412377, XrefRangeStart = 412367, XrefRangeEnd = 412376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000B471C File Offset: 0x000B291C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412393, RefRangeEnd = 412394, XrefRangeStart = 412377, XrefRangeEnd = 412393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaKeyref()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaKeyref>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKeyref.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000105F0 File Offset: 0x0000E7F0
		public XmlSchemaKeyref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x000B4758 File Offset: 0x000B2958
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x000105F9 File Offset: 0x0000E7F9
		public unsafe XmlQualifiedName refer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaKeyref.NativeFieldInfoPtr_refer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaKeyref.NativeFieldInfoPtr_refer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeFieldInfoPtr_refer;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_get_Refer_Public_get_XmlQualifiedName_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_set_Refer_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
