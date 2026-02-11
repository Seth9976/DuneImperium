using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000146 RID: 326
	public class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0008A198 File Offset: 0x00088398
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_day()
		{
			Il2CppClassPointerStore<Datatype_day>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_day");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr);
			Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100667439);
			Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100667440);
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x0008A1F0 File Offset: 0x000883F0
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0008A238 File Offset: 0x00088438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394391, XrefRangeEnd = 394395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_day()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public Datatype_day(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
