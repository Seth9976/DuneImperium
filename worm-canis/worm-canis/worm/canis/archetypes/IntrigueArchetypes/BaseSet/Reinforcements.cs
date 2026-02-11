using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200016C RID: 364
	public class Reinforcements : WormArchetype
	{
		// Token: 0x06001273 RID: 4723 RVA: 0x000A21D8 File Offset: 0x000A03D8
		// Note: this type is marked as 'beforefieldinit'.
		static Reinforcements()
		{
			Il2CppClassPointerStore<Reinforcements>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "Reinforcements");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr);
			Reinforcements.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, "archID");
			Reinforcements.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr, 100666360);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000A2230 File Offset: 0x000A0430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94747, XrefRangeEnd = 94848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Reinforcements()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Reinforcements>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reinforcements.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000092EA File Offset: 0x000074EA
		public Reinforcements(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x000A226C File Offset: 0x000A046C
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x000092F3 File Offset: 0x000074F3
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Reinforcements.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Reinforcements.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
