using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E3 RID: 227
	public class XmlSerializationGeneratedCode : Object
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x00008D49 File Offset: 0x00006F49
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializationGeneratedCode()
		{
			Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializationGeneratedCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr);
			XmlSerializationGeneratedCode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr, 100666569);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0006EDF4 File Offset: 0x0006CFF4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializationGeneratedCode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializationGeneratedCode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializationGeneratedCode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00008D82 File Offset: 0x00006F82
		public XmlSerializationGeneratedCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
