using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200015D RID: 349
	public class CouncilorsDispensation : WormArchetype
	{
		// Token: 0x06001228 RID: 4648 RVA: 0x000A16D4 File Offset: 0x0009F8D4
		// Note: this type is marked as 'beforefieldinit'.
		static CouncilorsDispensation()
		{
			Il2CppClassPointerStore<CouncilorsDispensation>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "CouncilorsDispensation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CouncilorsDispensation>.NativeClassPtr);
			CouncilorsDispensation.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CouncilorsDispensation>.NativeClassPtr, "archID");
			CouncilorsDispensation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CouncilorsDispensation>.NativeClassPtr, 100666330);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000A172C File Offset: 0x0009F92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93117, XrefRangeEnd = 93218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CouncilorsDispensation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CouncilorsDispensation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CouncilorsDispensation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00009155 File Offset: 0x00007355
		public CouncilorsDispensation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x000A1768 File Offset: 0x0009F968
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0000915E File Offset: 0x0000735E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CouncilorsDispensation.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CouncilorsDispensation.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
