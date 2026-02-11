using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000142 RID: 322
	public class Datatype_date : Datatype_dateTimeBase
	{
		// Token: 0x06001B94 RID: 7060 RVA: 0x00089E28 File Offset: 0x00088028
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_date()
		{
			Il2CppClassPointerStore<Datatype_date>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_date");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr);
			Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100667431);
			Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr, 100667432);
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00089E80 File Offset: 0x00088080
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_date.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00089EC8 File Offset: 0x000880C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394375, XrefRangeEnd = 394379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_date()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_date>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_date.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		public Datatype_date(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
