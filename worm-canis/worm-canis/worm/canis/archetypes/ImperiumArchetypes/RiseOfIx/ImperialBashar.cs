using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.RiseOfIx
{
	// Token: 0x02000182 RID: 386
	public class ImperialBashar : WormArchetype
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x000A3200 File Offset: 0x000A1400
		// Note: this type is marked as 'beforefieldinit'.
		static ImperialBashar()
		{
			Il2CppClassPointerStore<ImperialBashar>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.RiseOfIx", "ImperialBashar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImperialBashar>.NativeClassPtr);
			ImperialBashar.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImperialBashar>.NativeClassPtr, "archID");
			ImperialBashar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImperialBashar>.NativeClassPtr, 100666404);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000A3258 File Offset: 0x000A1458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98273, XrefRangeEnd = 98474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImperialBashar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImperialBashar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImperialBashar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0000953C File Offset: 0x0000773C
		public ImperialBashar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000A3294 File Offset: 0x000A1494
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00009545 File Offset: 0x00007745
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImperialBashar.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImperialBashar.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
