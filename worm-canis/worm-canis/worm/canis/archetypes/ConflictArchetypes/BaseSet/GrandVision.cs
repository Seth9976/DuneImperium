using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000205 RID: 517
	public class GrandVision : WormArchetype
	{
		// Token: 0x06001570 RID: 5488 RVA: 0x000A9234 File Offset: 0x000A7434
		// Note: this type is marked as 'beforefieldinit'.
		static GrandVision()
		{
			Il2CppClassPointerStore<GrandVision>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "GrandVision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrandVision>.NativeClassPtr);
			GrandVision.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrandVision>.NativeClassPtr, "archID");
			GrandVision.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrandVision>.NativeClassPtr, 100666666);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000A928C File Offset: 0x000A748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121038, XrefRangeEnd = 121138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrandVision()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrandVision>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrandVision.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0000A30D File Offset: 0x0000850D
		public GrandVision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x000A92C8 File Offset: 0x000A74C8
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000A316 File Offset: 0x00008516
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GrandVision.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrandVision.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
