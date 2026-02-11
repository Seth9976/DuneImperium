using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x020000FC RID: 252
	public class Artillery : WormArchetype
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x0009CF98 File Offset: 0x0009B198
		// Note: this type is marked as 'beforefieldinit'.
		static Artillery()
		{
			Il2CppClassPointerStore<Artillery>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "Artillery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Artillery>.NativeClassPtr);
			Artillery.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Artillery>.NativeClassPtr, "archID");
			Artillery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Artillery>.NativeClassPtr, 100666136);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81553, XrefRangeEnd = 81642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Artillery()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Artillery>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Artillery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0000871A File Offset: 0x0000691A
		public Artillery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0009D02C File Offset: 0x0009B22C
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x00008723 File Offset: 0x00006923
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Artillery.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Artillery.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
