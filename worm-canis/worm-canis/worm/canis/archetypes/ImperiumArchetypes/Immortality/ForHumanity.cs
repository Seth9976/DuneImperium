using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019B RID: 411
	public class ForHumanity : WormArchetype
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x000A445C File Offset: 0x000A265C
		// Note: this type is marked as 'beforefieldinit'.
		static ForHumanity()
		{
			Il2CppClassPointerStore<ForHumanity>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "ForHumanity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForHumanity>.NativeClassPtr);
			ForHumanity.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForHumanity>.NativeClassPtr, "archID");
			ForHumanity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForHumanity>.NativeClassPtr, 100666454);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000A44B4 File Offset: 0x000A26B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103237, XrefRangeEnd = 103448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForHumanity()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForHumanity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForHumanity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000097DF File Offset: 0x000079DF
		public ForHumanity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x000A44F0 File Offset: 0x000A26F0
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x000097E8 File Offset: 0x000079E8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ForHumanity.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ForHumanity.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
