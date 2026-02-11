using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x0200015B RID: 347
	public class CHOAMShares : WormArchetype
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x000A155C File Offset: 0x0009F75C
		// Note: this type is marked as 'beforefieldinit'.
		static CHOAMShares()
		{
			Il2CppClassPointerStore<CHOAMShares>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "CHOAMShares");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CHOAMShares>.NativeClassPtr);
			CHOAMShares.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CHOAMShares>.NativeClassPtr, "archID");
			CHOAMShares.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CHOAMShares>.NativeClassPtr, 100666326);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000A15B4 File Offset: 0x0009F7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92901, XrefRangeEnd = 93002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CHOAMShares()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CHOAMShares>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CHOAMShares.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0000911F File Offset: 0x0000731F
		public CHOAMShares(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000A15F0 File Offset: 0x0009F7F0
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00009128 File Offset: 0x00007328
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CHOAMShares.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CHOAMShares.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
