using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000145 RID: 325
	public class SecretForces : WormArchetype
	{
		// Token: 0x060011B0 RID: 4528 RVA: 0x000A0534 File Offset: 0x0009E734
		// Note: this type is marked as 'beforefieldinit'.
		static SecretForces()
		{
			Il2CppClassPointerStore<SecretForces>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "SecretForces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretForces>.NativeClassPtr);
			SecretForces.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretForces>.NativeClassPtr, "archID");
			SecretForces.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretForces>.NativeClassPtr, 100666282);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x000A058C File Offset: 0x0009E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90346, XrefRangeEnd = 90447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecretForces()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretForces>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecretForces.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00008ECD File Offset: 0x000070CD
		public SecretForces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000A05C8 File Offset: 0x0009E7C8
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00008ED6 File Offset: 0x000070D6
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecretForces.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecretForces.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
