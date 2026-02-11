using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013E RID: 318
	public class Finesse : WormArchetype
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000A0010 File Offset: 0x0009E210
		// Note: this type is marked as 'beforefieldinit'.
		static Finesse()
		{
			Il2CppClassPointerStore<Finesse>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "Finesse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Finesse>.NativeClassPtr);
			Finesse.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Finesse>.NativeClassPtr, "archID");
			Finesse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finesse>.NativeClassPtr, 100666268);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000A0068 File Offset: 0x0009E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89521, XrefRangeEnd = 89651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Finesse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Finesse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Finesse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00008E10 File Offset: 0x00007010
		public Finesse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000A00A4 File Offset: 0x0009E2A4
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00008E19 File Offset: 0x00007019
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Finesse.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Finesse.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
