using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F8 RID: 248
	public class TleilaxuInfiltrator : WormArchetype
	{
		// Token: 0x0600102F RID: 4143 RVA: 0x0009CCA8 File Offset: 0x0009AEA8
		// Note: this type is marked as 'beforefieldinit'.
		static TleilaxuInfiltrator()
		{
			Il2CppClassPointerStore<TleilaxuInfiltrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "TleilaxuInfiltrator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TleilaxuInfiltrator>.NativeClassPtr);
			TleilaxuInfiltrator.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TleilaxuInfiltrator>.NativeClassPtr, "archID");
			TleilaxuInfiltrator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TleilaxuInfiltrator>.NativeClassPtr, 100666128);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0009CD00 File Offset: 0x0009AF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80863, XrefRangeEnd = 81043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TleilaxuInfiltrator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TleilaxuInfiltrator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TleilaxuInfiltrator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x000086AE File Offset: 0x000068AE
		public TleilaxuInfiltrator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0009CD3C File Offset: 0x0009AF3C
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x000086B7 File Offset: 0x000068B7
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TleilaxuInfiltrator.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TleilaxuInfiltrator.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
