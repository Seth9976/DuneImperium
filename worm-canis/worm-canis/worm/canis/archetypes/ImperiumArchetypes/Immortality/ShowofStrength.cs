using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x020001A8 RID: 424
	public class ShowofStrength : WormArchetype
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x000A4DE8 File Offset: 0x000A2FE8
		// Note: this type is marked as 'beforefieldinit'.
		static ShowofStrength()
		{
			Il2CppClassPointerStore<ShowofStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ShowofStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowofStrength>.NativeClassPtr);
			ShowofStrength.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowofStrength>.NativeClassPtr, "archID");
			ShowofStrength.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowofStrength>.NativeClassPtr, 100666480);
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000A4E40 File Offset: 0x000A3040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105944, XrefRangeEnd = 106168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowofStrength()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowofStrength>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowofStrength.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0000993E File Offset: 0x00007B3E
		public ShowofStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000A4E7C File Offset: 0x000A307C
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00009947 File Offset: 0x00007B47
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowofStrength.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowofStrength.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
