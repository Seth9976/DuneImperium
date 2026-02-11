using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x0200018E RID: 398
	public class SpiceTrader : WormArchetype
	{
		// Token: 0x0600131D RID: 4893 RVA: 0x000A3AD0 File Offset: 0x000A1CD0
		// Note: this type is marked as 'beforefieldinit'.
		static SpiceTrader()
		{
			Il2CppClassPointerStore<SpiceTrader>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "SpiceTrader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpiceTrader>.NativeClassPtr);
			SpiceTrader.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpiceTrader>.NativeClassPtr, "archID");
			SpiceTrader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpiceTrader>.NativeClassPtr, 100666428);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000A3B28 File Offset: 0x000A1D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100660, XrefRangeEnd = 100867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpiceTrader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpiceTrader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpiceTrader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00009680 File Offset: 0x00007880
		public SpiceTrader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000A3B64 File Offset: 0x000A1D64
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00009689 File Offset: 0x00007889
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SpiceTrader.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpiceTrader.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
