using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.HagalArchetypes.BaseSet
{
	// Token: 0x020001F0 RID: 496
	public class HagalConspire : WormArchetype
	{
		// Token: 0x06001507 RID: 5383 RVA: 0x000A82C8 File Offset: 0x000A64C8
		// Note: this type is marked as 'beforefieldinit'.
		static HagalConspire()
		{
			Il2CppClassPointerStore<HagalConspire>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.HagalArchetypes.BaseSet", "HagalConspire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalConspire>.NativeClassPtr);
			HagalConspire.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalConspire>.NativeClassPtr, "archID");
			HagalConspire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalConspire>.NativeClassPtr, 100666624);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000A8320 File Offset: 0x000A6520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118540, XrefRangeEnd = 118666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalConspire()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalConspire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalConspire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0000A0D6 File Offset: 0x000082D6
		public HagalConspire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000A835C File Offset: 0x000A655C
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0000A0DF File Offset: 0x000082DF
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HagalConspire.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HagalConspire.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
