using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x02000104 RID: 260
	public class Memocorders : WormArchetype
	{
		// Token: 0x0600106B RID: 4203 RVA: 0x0009D578 File Offset: 0x0009B778
		// Note: this type is marked as 'beforefieldinit'.
		static Memocorders()
		{
			Il2CppClassPointerStore<Memocorders>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Memocorders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memocorders>.NativeClassPtr);
			Memocorders.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Memocorders>.NativeClassPtr, "archID");
			Memocorders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memocorders>.NativeClassPtr, 100666152);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0009D5D0 File Offset: 0x0009B7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82466, XrefRangeEnd = 82595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Memocorders()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Memocorders>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memocorders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000087F2 File Offset: 0x000069F2
		public Memocorders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0009D60C File Offset: 0x0009B80C
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x000087FB File Offset: 0x000069FB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Memocorders.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Memocorders.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
