using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000FA RID: 250
	public class UnnaturalReflexes : WormArchetype
	{
		// Token: 0x06001039 RID: 4153 RVA: 0x0009CE20 File Offset: 0x0009B020
		// Note: this type is marked as 'beforefieldinit'.
		static UnnaturalReflexes()
		{
			Il2CppClassPointerStore<UnnaturalReflexes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "UnnaturalReflexes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnnaturalReflexes>.NativeClassPtr);
			UnnaturalReflexes.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnnaturalReflexes>.NativeClassPtr, "archID");
			UnnaturalReflexes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnnaturalReflexes>.NativeClassPtr, 100666132);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0009CE78 File Offset: 0x0009B078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81219, XrefRangeEnd = 81403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnnaturalReflexes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnnaturalReflexes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnnaturalReflexes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000086E4 File Offset: 0x000068E4
		public UnnaturalReflexes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0009CEB4 File Offset: 0x0009B0B4
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x000086ED File Offset: 0x000068ED
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnnaturalReflexes.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnnaturalReflexes.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
