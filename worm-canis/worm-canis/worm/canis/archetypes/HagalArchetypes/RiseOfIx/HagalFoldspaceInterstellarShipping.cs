using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.RiseOfIx
{
	// Token: 0x020001E5 RID: 485
	public class HagalFoldspaceInterstellarShipping : WormArchetype
	{
		// Token: 0x060014D0 RID: 5328 RVA: 0x000A7AB4 File Offset: 0x000A5CB4
		// Note: this type is marked as 'beforefieldinit'.
		static HagalFoldspaceInterstellarShipping()
		{
			Il2CppClassPointerStore<HagalFoldspaceInterstellarShipping>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.RiseOfIx", "HagalFoldspaceInterstellarShipping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalFoldspaceInterstellarShipping>.NativeClassPtr);
			HagalFoldspaceInterstellarShipping.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalFoldspaceInterstellarShipping>.NativeClassPtr, "archID");
			HagalFoldspaceInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalFoldspaceInterstellarShipping>.NativeClassPtr, 100666602);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000A7B0C File Offset: 0x000A5D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117307, XrefRangeEnd = 117403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalFoldspaceInterstellarShipping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalFoldspaceInterstellarShipping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalFoldspaceInterstellarShipping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00009FAD File Offset: 0x000081AD
		public HagalFoldspaceInterstellarShipping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x000A7B48 File Offset: 0x000A5D48
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x00009FB6 File Offset: 0x000081B6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalFoldspaceInterstellarShipping.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalFoldspaceInterstellarShipping.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
