using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.RiseOfIx
{
	// Token: 0x020001FF RID: 511
	public class TradeMonopoly : WormArchetype
	{
		// Token: 0x06001552 RID: 5458 RVA: 0x000A8DCC File Offset: 0x000A6FCC
		// Note: this type is marked as 'beforefieldinit'.
		static TradeMonopoly()
		{
			Il2CppClassPointerStore<TradeMonopoly>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.RiseOfIx", "TradeMonopoly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradeMonopoly>.NativeClassPtr);
			TradeMonopoly.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TradeMonopoly>.NativeClassPtr, "archID");
			TradeMonopoly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeMonopoly>.NativeClassPtr, 100666654);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x000A8E24 File Offset: 0x000A7024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120320, XrefRangeEnd = 120434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TradeMonopoly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradeMonopoly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TradeMonopoly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0000A26B File Offset: 0x0000846B
		public TradeMonopoly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x000A8E60 File Offset: 0x000A7060
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x0000A274 File Offset: 0x00008474
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TradeMonopoly.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TradeMonopoly.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
