using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x0200020E RID: 526
	public class SkirmishC : WormArchetype
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x000A98D0 File Offset: 0x000A7AD0
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishC()
		{
			Il2CppClassPointerStore<SkirmishC>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SkirmishC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishC>.NativeClassPtr);
			SkirmishC.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishC>.NativeClassPtr, "archID");
			SkirmishC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishC>.NativeClassPtr, 100666684);
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000A9928 File Offset: 0x000A7B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122047, XrefRangeEnd = 122147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000A400 File Offset: 0x00008600
		public SkirmishC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x000A9964 File Offset: 0x000A7B64
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000A409 File Offset: 0x00008609
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkirmishC.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkirmishC.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
