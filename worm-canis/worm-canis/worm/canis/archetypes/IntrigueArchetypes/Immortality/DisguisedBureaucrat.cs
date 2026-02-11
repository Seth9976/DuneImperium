using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.Immortality
{
	// Token: 0x0200014B RID: 331
	public class DisguisedBureaucrat : WormArchetype
	{
		// Token: 0x060011CE RID: 4558 RVA: 0x000A099C File Offset: 0x0009EB9C
		// Note: this type is marked as 'beforefieldinit'.
		static DisguisedBureaucrat()
		{
			Il2CppClassPointerStore<DisguisedBureaucrat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.Immortality", "DisguisedBureaucrat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisguisedBureaucrat>.NativeClassPtr);
			DisguisedBureaucrat.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisguisedBureaucrat>.NativeClassPtr, "archID");
			DisguisedBureaucrat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisguisedBureaucrat>.NativeClassPtr, 100666294);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000A09F4 File Offset: 0x0009EBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91036, XrefRangeEnd = 91159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisguisedBureaucrat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisguisedBureaucrat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisguisedBureaucrat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00008F6F File Offset: 0x0000716F
		public DisguisedBureaucrat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000A0A30 File Offset: 0x0009EC30
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x00008F78 File Offset: 0x00007178
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DisguisedBureaucrat.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DisguisedBureaucrat.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
