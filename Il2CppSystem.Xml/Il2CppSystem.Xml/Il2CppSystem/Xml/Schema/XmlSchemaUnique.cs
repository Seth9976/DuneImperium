using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C8 RID: 456
	public class XmlSchemaUnique : XmlSchemaIdentityConstraint
	{
		// Token: 0x0600267B RID: 9851 RVA: 0x0001056C File Offset: 0x0000E76C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaUnique()
		{
			Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaUnique");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr);
			XmlSchemaUnique.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr, 100668857);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000B45A0 File Offset: 0x000B27A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412365, RefRangeEnd = 412367, XrefRangeStart = 412364, XrefRangeEnd = 412365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaUnique()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaUnique>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaUnique.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000105A5 File Offset: 0x0000E7A5
		public XmlSchemaUnique(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
