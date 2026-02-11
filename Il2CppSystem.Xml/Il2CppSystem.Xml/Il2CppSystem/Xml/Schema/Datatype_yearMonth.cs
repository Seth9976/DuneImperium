using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000143 RID: 323
	public class Datatype_yearMonth : Datatype_dateTimeBase
	{
		// Token: 0x06001B98 RID: 7064 RVA: 0x00089F04 File Offset: 0x00088104
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_yearMonth()
		{
			Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_yearMonth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr);
			Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100667433);
			Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100667434);
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00089F5C File Offset: 0x0008815C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00089FA4 File Offset: 0x000881A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394379, XrefRangeEnd = 394383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_yearMonth()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0000BBB1 File Offset: 0x00009DB1
		public Datatype_yearMonth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
