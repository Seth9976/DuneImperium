using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000145 RID: 325
	public class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x06001BA0 RID: 7072 RVA: 0x0008A0BC File Offset: 0x000882BC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_monthDay()
		{
			Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_monthDay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr);
			Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100667437);
			Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100667438);
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0008A114 File Offset: 0x00088314
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0008A15C File Offset: 0x0008835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394387, XrefRangeEnd = 394391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_monthDay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000BBC3 File Offset: 0x00009DC3
		public Datatype_monthDay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
