using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019F RID: 415
	public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAttributeGroupRef()
		{
			Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAttributeGroupRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr);
			XmlSchemaAttributeGroupRef.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr, "refName");
			XmlSchemaAttributeGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr, 100668566);
			XmlSchemaAttributeGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr, 100668567);
			XmlSchemaAttributeGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr, 100668568);
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000AC434 File Offset: 0x000AA634
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x000AC474 File Offset: 0x000AA674
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroupRef.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411107, RefRangeEnd = 411108, XrefRangeStart = 411098, XrefRangeEnd = 411107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroupRef.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x000AC4B8 File Offset: 0x000AA6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411114, RefRangeEnd = 411115, XrefRangeStart = 411108, XrefRangeEnd = 411114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttributeGroupRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAttributeGroupRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroupRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0000F5FE File Offset: 0x0000D7FE
		public XmlSchemaAttributeGroupRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000AC4F4 File Offset: 0x000AA6F4
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0000F607 File Offset: 0x0000D807
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroupRef.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroupRef.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
