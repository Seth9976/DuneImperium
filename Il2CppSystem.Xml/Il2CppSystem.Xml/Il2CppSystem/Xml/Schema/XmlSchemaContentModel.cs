using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AA RID: 426
	public class XmlSchemaContentModel : XmlSchemaAnnotated
	{
		// Token: 0x06002520 RID: 9504 RVA: 0x000AF37C File Offset: 0x000AD57C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaContentModel()
		{
			Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaContentModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr);
			XmlSchemaContentModel.NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668671);
			XmlSchemaContentModel.NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668672);
			XmlSchemaContentModel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr, 100668673);
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000AF3E8 File Offset: 0x000AD5E8
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x000AF434 File Offset: 0x000AD634
		public unsafe virtual XmlSchemaContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaContentModel.NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaContentModel.NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000AF484 File Offset: 0x000AD684
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaContentModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaContentModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaContentModel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0000FB2B File Offset: 0x0000DD2B
		public XmlSchemaContentModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_Abstract_Virtual_New_get_XmlSchemaContent_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_Abstract_Virtual_New_set_Void_XmlSchemaContent_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
