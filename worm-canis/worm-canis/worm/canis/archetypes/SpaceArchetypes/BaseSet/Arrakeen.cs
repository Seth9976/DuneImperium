using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000113 RID: 275
	public class Arrakeen : WormArchetype
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x0009E07C File Offset: 0x0009C27C
		// Note: this type is marked as 'beforefieldinit'.
		static Arrakeen()
		{
			Il2CppClassPointerStore<Arrakeen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Arrakeen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Arrakeen>.NativeClassPtr);
			Arrakeen.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrakeen>.NativeClassPtr, "archID");
			Arrakeen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrakeen>.NativeClassPtr, 100666182);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0009E0D4 File Offset: 0x0009C2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84232, XrefRangeEnd = 84376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Arrakeen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Arrakeen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Arrakeen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00008987 File Offset: 0x00006B87
		public Arrakeen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0009E110 File Offset: 0x0009C310
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x00008990 File Offset: 0x00006B90
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Arrakeen.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Arrakeen.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
