using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000193 RID: 403
	public class WeirdingWay : WormArchetype
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x000A3E7C File Offset: 0x000A207C
		// Note: this type is marked as 'beforefieldinit'.
		static WeirdingWay()
		{
			Il2CppClassPointerStore<WeirdingWay>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "WeirdingWay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeirdingWay>.NativeClassPtr);
			WeirdingWay.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeirdingWay>.NativeClassPtr, "archID");
			WeirdingWay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeirdingWay>.NativeClassPtr, 100666438);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000A3ED4 File Offset: 0x000A20D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101710, XrefRangeEnd = 101895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeirdingWay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeirdingWay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeirdingWay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00009707 File Offset: 0x00007907
		public WeirdingWay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x000A3F10 File Offset: 0x000A2110
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00009710 File Offset: 0x00007910
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WeirdingWay.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WeirdingWay.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
