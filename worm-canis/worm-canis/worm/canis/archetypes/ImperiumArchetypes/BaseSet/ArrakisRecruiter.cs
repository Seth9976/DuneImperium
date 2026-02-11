using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.BaseSet
{
	// Token: 0x020001AF RID: 431
	public class ArrakisRecruiter : WormArchetype
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x000A530C File Offset: 0x000A350C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrakisRecruiter()
		{
			Il2CppClassPointerStore<ArrakisRecruiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.BaseSet", "ArrakisRecruiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrakisRecruiter>.NativeClassPtr);
			ArrakisRecruiter.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrakisRecruiter>.NativeClassPtr, "archID");
			ArrakisRecruiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrakisRecruiter>.NativeClassPtr, 100666494);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000A5364 File Offset: 0x000A3564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107326, XrefRangeEnd = 107505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrakisRecruiter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrakisRecruiter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrakisRecruiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000099FB File Offset: 0x00007BFB
		public ArrakisRecruiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x000A53A0 File Offset: 0x000A35A0
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00009A04 File Offset: 0x00007C04
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrakisRecruiter.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrakisRecruiter.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
