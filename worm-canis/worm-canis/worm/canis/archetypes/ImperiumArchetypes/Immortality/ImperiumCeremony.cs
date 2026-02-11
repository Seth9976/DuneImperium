using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019D RID: 413
	public class ImperiumCeremony : WormArchetype
	{
		// Token: 0x06001368 RID: 4968 RVA: 0x000A45D4 File Offset: 0x000A27D4
		// Note: this type is marked as 'beforefieldinit'.
		static ImperiumCeremony()
		{
			Il2CppClassPointerStore<ImperiumCeremony>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ImperiumCeremony");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImperiumCeremony>.NativeClassPtr);
			ImperiumCeremony.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImperiumCeremony>.NativeClassPtr, "archID");
			ImperiumCeremony.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImperiumCeremony>.NativeClassPtr, 100666458);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000A462C File Offset: 0x000A282C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103664, XrefRangeEnd = 103855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImperiumCeremony()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImperiumCeremony>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImperiumCeremony.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00009815 File Offset: 0x00007A15
		public ImperiumCeremony(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x000A4668 File Offset: 0x000A2868
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0000981E File Offset: 0x00007A1E
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImperiumCeremony.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImperiumCeremony.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
