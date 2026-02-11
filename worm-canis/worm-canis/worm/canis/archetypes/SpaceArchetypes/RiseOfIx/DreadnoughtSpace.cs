using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.SpaceArchetypes.RiseOfIx
{
	// Token: 0x0200010E RID: 270
	public class DreadnoughtSpace : WormArchetype
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x0009DCD0 File Offset: 0x0009BED0
		// Note: this type is marked as 'beforefieldinit'.
		static DreadnoughtSpace()
		{
			Il2CppClassPointerStore<DreadnoughtSpace>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.SpaceArchetypes.RiseOfIx", "DreadnoughtSpace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DreadnoughtSpace>.NativeClassPtr);
			DreadnoughtSpace.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DreadnoughtSpace>.NativeClassPtr, "archID");
			DreadnoughtSpace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DreadnoughtSpace>.NativeClassPtr, 100666172);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0009DD28 File Offset: 0x0009BF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83607, XrefRangeEnd = 83724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DreadnoughtSpace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DreadnoughtSpace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DreadnoughtSpace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00008900 File Offset: 0x00006B00
		public DreadnoughtSpace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0009DD64 File Offset: 0x0009BF64
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00008909 File Offset: 0x00006B09
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DreadnoughtSpace.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DreadnoughtSpace.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
