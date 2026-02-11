using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200014F RID: 335
	public class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
	{
		// Token: 0x06001BFD RID: 7165 RVA: 0x0008BADC File Offset: 0x00089CDC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_tokenV1Compat()
		{
			Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_tokenV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr);
			Datatype_tokenV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr, 100667498);
			Datatype_tokenV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr, 100667499);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0008BB34 File Offset: 0x00089D34
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_tokenV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0008BB7C File Offset: 0x00089D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_tokenV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_tokenV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_tokenV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0000BCAD File Offset: 0x00009EAD
		public Datatype_tokenV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
