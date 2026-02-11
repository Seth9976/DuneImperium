using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000174 RID: 372
	public class WaterPeddlersUnion : WormArchetype
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x000A27B8 File Offset: 0x000A09B8
		// Note: this type is marked as 'beforefieldinit'.
		static WaterPeddlersUnion()
		{
			Il2CppClassPointerStore<WaterPeddlersUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "WaterPeddlersUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterPeddlersUnion>.NativeClassPtr);
			WaterPeddlersUnion.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterPeddlersUnion>.NativeClassPtr, "archID");
			WaterPeddlersUnion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterPeddlersUnion>.NativeClassPtr, 100666376);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000A2810 File Offset: 0x000A0A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95616, XrefRangeEnd = 95717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterPeddlersUnion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterPeddlersUnion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterPeddlersUnion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000093C2 File Offset: 0x000075C2
		public WaterPeddlersUnion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000A284C File Offset: 0x000A0A4C
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x000093CB File Offset: 0x000075CB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaterPeddlersUnion.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaterPeddlersUnion.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
