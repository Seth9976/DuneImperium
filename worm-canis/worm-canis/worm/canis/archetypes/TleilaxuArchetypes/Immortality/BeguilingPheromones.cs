using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000E9 RID: 233
	public class BeguilingPheromones : WormArchetype
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x0009C1A4 File Offset: 0x0009A3A4
		// Note: this type is marked as 'beforefieldinit'.
		static BeguilingPheromones()
		{
			Il2CppClassPointerStore<BeguilingPheromones>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "BeguilingPheromones");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeguilingPheromones>.NativeClassPtr);
			BeguilingPheromones.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeguilingPheromones>.NativeClassPtr, "archID");
			BeguilingPheromones.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeguilingPheromones>.NativeClassPtr, 100666098);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0009C1FC File Offset: 0x0009A3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78201, XrefRangeEnd = 78385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeguilingPheromones()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeguilingPheromones>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeguilingPheromones.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00008519 File Offset: 0x00006719
		public BeguilingPheromones(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0009C238 File Offset: 0x0009A438
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00008522 File Offset: 0x00006722
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeguilingPheromones.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeguilingPheromones.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
