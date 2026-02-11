using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001BB RID: 443
	public class DuncanIdaho : WormArchetype
	{
		// Token: 0x060013FE RID: 5118 RVA: 0x000A5BDC File Offset: 0x000A3DDC
		// Note: this type is marked as 'beforefieldinit'.
		static DuncanIdaho()
		{
			Il2CppClassPointerStore<DuncanIdaho>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "DuncanIdaho");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuncanIdaho>.NativeClassPtr);
			DuncanIdaho.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuncanIdaho>.NativeClassPtr, "archID");
			DuncanIdaho.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuncanIdaho>.NativeClassPtr, 100666518);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000A5C34 File Offset: 0x000A3E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109440, XrefRangeEnd = 109632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuncanIdaho()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuncanIdaho>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuncanIdaho.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00009B3F File Offset: 0x00007D3F
		public DuncanIdaho(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x000A5C70 File Offset: 0x000A3E70
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x00009B48 File Offset: 0x00007D48
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DuncanIdaho.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DuncanIdaho.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
