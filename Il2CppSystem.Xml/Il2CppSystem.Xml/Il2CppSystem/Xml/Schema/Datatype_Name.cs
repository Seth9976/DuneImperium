using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000152 RID: 338
	public class Datatype_Name : Datatype_token
	{
		// Token: 0x06001C0A RID: 7178 RVA: 0x0008BDCC File Offset: 0x00089FCC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_Name()
		{
			Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_Name");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr);
			Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100667505);
			Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr, 100667506);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0008BE24 File Offset: 0x0008A024
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_Name.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0008BE6C File Offset: 0x0008A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_Name()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_Name>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_Name.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		public Datatype_Name(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
