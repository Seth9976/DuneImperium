using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000150 RID: 336
	public class Datatype_language : Datatype_token
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x0008BBB8 File Offset: 0x00089DB8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_language()
		{
			Il2CppClassPointerStore<Datatype_language>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_language");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr);
			Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100667500);
			Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr, 100667501);
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0008BC10 File Offset: 0x00089E10
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_language.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0008BC58 File Offset: 0x00089E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_language()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_language>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_language.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0000BCB6 File Offset: 0x00009EB6
		public Datatype_language(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
