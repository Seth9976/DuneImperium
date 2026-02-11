using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000203 RID: 515
	public class CloakandDagger : WormArchetype
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x000A90BC File Offset: 0x000A72BC
		// Note: this type is marked as 'beforefieldinit'.
		static CloakandDagger()
		{
			Il2CppClassPointerStore<CloakandDagger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "CloakandDagger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloakandDagger>.NativeClassPtr);
			CloakandDagger.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloakandDagger>.NativeClassPtr, "archID");
			CloakandDagger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloakandDagger>.NativeClassPtr, 100666662);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000A9114 File Offset: 0x000A7314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120833, XrefRangeEnd = 120933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CloakandDagger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloakandDagger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloakandDagger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0000A2D7 File Offset: 0x000084D7
		public CloakandDagger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000A9150 File Offset: 0x000A7350
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000A2E0 File Offset: 0x000084E0
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CloakandDagger.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CloakandDagger.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
