using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000168 RID: 360
	public class Datatype_ENUMERATION : Datatype_NMTOKEN
	{
		// Token: 0x06001CE2 RID: 7394 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_ENUMERATION()
		{
			Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_ENUMERATION");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr);
			Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100667627);
			Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr, 100667628);
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0008F5F8 File Offset: 0x0008D7F8
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_ENUMERATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0008F640 File Offset: 0x0008D840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_ENUMERATION()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_ENUMERATION>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_ENUMERATION.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x0000BFCE File Offset: 0x0000A1CE
		public Datatype_ENUMERATION(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
