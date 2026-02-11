using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000207 RID: 519
	public class Machinations : WormArchetype
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x000A93AC File Offset: 0x000A75AC
		// Note: this type is marked as 'beforefieldinit'.
		static Machinations()
		{
			Il2CppClassPointerStore<Machinations>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "Machinations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Machinations>.NativeClassPtr);
			Machinations.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Machinations>.NativeClassPtr, "archID");
			Machinations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Machinations>.NativeClassPtr, 100666670);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000A9404 File Offset: 0x000A7604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121238, XrefRangeEnd = 121338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Machinations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Machinations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Machinations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0000A343 File Offset: 0x00008543
		public Machinations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x000A9440 File Offset: 0x000A7640
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x0000A34C File Offset: 0x0000854C
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Machinations.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Machinations.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
