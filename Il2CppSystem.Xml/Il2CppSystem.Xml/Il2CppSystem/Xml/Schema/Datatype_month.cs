using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000147 RID: 327
	public class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x0008A274 File Offset: 0x00088474
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_month()
		{
			Il2CppClassPointerStore<Datatype_month>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_month");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr);
			Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100667441);
			Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100667442);
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0008A2CC File Offset: 0x000884CC
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0008A314 File Offset: 0x00088514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394395, XrefRangeEnd = 394399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_month()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0000BBD5 File Offset: 0x00009DD5
		public Datatype_month(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
