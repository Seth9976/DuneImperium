using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.moz
{
	// Token: 0x0200011F RID: 287
	public class PointToMozObject : FindMozObject
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x00046314 File Offset: 0x00044514
		// Note: this type is marked as 'beforefieldinit'.
		static PointToMozObject()
		{
			Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "PointToMozObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr);
			PointToMozObject.NativeFieldInfoPtr_moz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr, "moz");
			PointToMozObject.NativeMethodInfoPtr_get_Moz_Public_Virtual_get_BaseMoz_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr, 100665167);
			PointToMozObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr, 100665168);
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00046380 File Offset: 0x00044580
		public unsafe override BaseMoz Moz
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointToMozObject.NativeMethodInfoPtr_get_Moz_Public_Virtual_get_BaseMoz_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr3) : null;
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000463CC File Offset: 0x000445CC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointToMozObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointToMozObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointToMozObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00008437 File Offset: 0x00006637
		public PointToMozObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00046408 File Offset: 0x00044608
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00008440 File Offset: 0x00006640
		public unsafe BaseMoz moz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointToMozObject.NativeFieldInfoPtr_moz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseMoz>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointToMozObject.NativeFieldInfoPtr_moz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_moz;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_get_Moz_Public_Virtual_get_BaseMoz_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
