using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.BaseSet
{
	// Token: 0x02000114 RID: 276
	public class Carthag : WormArchetype
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x0009E138 File Offset: 0x0009C338
		// Note: this type is marked as 'beforefieldinit'.
		static Carthag()
		{
			Il2CppClassPointerStore<Carthag>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.BaseSet", "Carthag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Carthag>.NativeClassPtr);
			Carthag.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Carthag>.NativeClassPtr, "archID");
			Carthag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Carthag>.NativeClassPtr, 100666184);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0009E190 File Offset: 0x0009C390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84376, XrefRangeEnd = 84520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Carthag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Carthag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Carthag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000089A2 File Offset: 0x00006BA2
		public Carthag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0009E1CC File Offset: 0x0009C3CC
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x000089AB File Offset: 0x00006BAB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Carthag.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Carthag.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
