using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000151 RID: 337
	public class Datatype_NMTOKEN : Datatype_token
	{
		// Token: 0x06001C05 RID: 7173 RVA: 0x0008BC94 File Offset: 0x00089E94
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_NMTOKEN()
		{
			Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_NMTOKEN");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr);
			Datatype_NMTOKEN.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100667502);
			Datatype_NMTOKEN.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100667503);
			Datatype_NMTOKEN.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr, 100667504);
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0008BD00 File Offset: 0x00089F00
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NMTOKEN.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0008BD48 File Offset: 0x00089F48
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NMTOKEN.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0008BD90 File Offset: 0x00089F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_NMTOKEN()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_NMTOKEN>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_NMTOKEN.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0000BCBF File Offset: 0x00009EBF
		public Datatype_NMTOKEN(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
