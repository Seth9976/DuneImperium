using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x02000144 RID: 324
	public class SecondWave : WormArchetype
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x000A0478 File Offset: 0x0009E678
		// Note: this type is marked as 'beforefieldinit'.
		static SecondWave()
		{
			Il2CppClassPointerStore<SecondWave>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "SecondWave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecondWave>.NativeClassPtr);
			SecondWave.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondWave>.NativeClassPtr, "archID");
			SecondWave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecondWave>.NativeClassPtr, 100666280);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000A04D0 File Offset: 0x0009E6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90233, XrefRangeEnd = 90346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecondWave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecondWave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecondWave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00008EB2 File Offset: 0x000070B2
		public SecondWave(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x000A050C File Offset: 0x0009E70C
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00008EBB File Offset: 0x000070BB
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecondWave.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecondWave.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
