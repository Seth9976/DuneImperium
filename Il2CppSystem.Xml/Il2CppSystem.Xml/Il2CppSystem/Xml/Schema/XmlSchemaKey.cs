using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001C9 RID: 457
	public class XmlSchemaKey : XmlSchemaIdentityConstraint
	{
		// Token: 0x0600267E RID: 9854 RVA: 0x000105AE File Offset: 0x0000E7AE
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaKey()
		{
			Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr);
			XmlSchemaKey.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr, 100668858);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x000B45DC File Offset: 0x000B27DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412365, RefRangeEnd = 412367, XrefRangeStart = 412365, XrefRangeEnd = 412367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaKey()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaKey>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaKey.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x000105E7 File Offset: 0x0000E7E7
		public XmlSchemaKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
