using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ConflictArchetypes.BaseSet
{
	// Token: 0x02000209 RID: 521
	public class SecureImperialBasin : WormArchetype
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x000A9524 File Offset: 0x000A7724
		// Note: this type is marked as 'beforefieldinit'.
		static SecureImperialBasin()
		{
			Il2CppClassPointerStore<SecureImperialBasin>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ConflictArchetypes.BaseSet", "SecureImperialBasin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureImperialBasin>.NativeClassPtr);
			SecureImperialBasin.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureImperialBasin>.NativeClassPtr, "archID");
			SecureImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureImperialBasin>.NativeClassPtr, 100666674);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000A957C File Offset: 0x000A777C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121438, XrefRangeEnd = 121571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureImperialBasin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureImperialBasin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureImperialBasin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0000A379 File Offset: 0x00008579
		public SecureImperialBasin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x000A95B8 File Offset: 0x000A77B8
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x0000A382 File Offset: 0x00008582
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecureImperialBasin.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecureImperialBasin.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
