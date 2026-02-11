using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EC RID: 236
	public class XmlSerializerImplementation : Object
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x000093D5 File Offset: 0x000075D5
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializerImplementation()
		{
			Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializerImplementation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr);
			XmlSerializerImplementation.NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerImplementation>.NativeClassPtr, 100666786);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00074EE0 File Offset: 0x000730E0
		public unsafe virtual XmlSerializationWriter Writer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389570, XrefRangeEnd = 389575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSerializerImplementation.NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializationWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000940E File Offset: 0x0000760E
		public XmlSerializerImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_get_Writer_Public_Virtual_New_get_XmlSerializationWriter_0;
	}
}
