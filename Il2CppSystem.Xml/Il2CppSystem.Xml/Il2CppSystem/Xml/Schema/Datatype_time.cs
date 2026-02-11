using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000141 RID: 321
	public class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x00089D4C File Offset: 0x00087F4C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_time()
		{
			Il2CppClassPointerStore<Datatype_time>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr);
			Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100667429);
			Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100667430);
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00089DA4 File Offset: 0x00087FA4
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00089DEC File Offset: 0x00087FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394371, XrefRangeEnd = 394375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_time()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0000BB9F File Offset: 0x00009D9F
		public Datatype_time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
