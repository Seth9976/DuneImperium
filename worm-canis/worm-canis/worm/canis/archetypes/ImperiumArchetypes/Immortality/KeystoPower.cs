using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.ImperiumArchetypes.Immortality
{
	// Token: 0x0200019F RID: 415
	public class KeystoPower : WormArchetype
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x000A474C File Offset: 0x000A294C
		// Note: this type is marked as 'beforefieldinit'.
		static KeystoPower()
		{
			Il2CppClassPointerStore<KeystoPower>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.ImperiumArchetypes.Immortality", "KeystoPower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeystoPower>.NativeClassPtr);
			KeystoPower.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeystoPower>.NativeClassPtr, "archID");
			KeystoPower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeystoPower>.NativeClassPtr, 100666462);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000A47A4 File Offset: 0x000A29A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104042, XrefRangeEnd = 104242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeystoPower()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeystoPower>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeystoPower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0000984B File Offset: 0x00007A4B
		public KeystoPower(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000A47E0 File Offset: 0x000A29E0
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00009854 File Offset: 0x00007A54
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeystoPower.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeystoPower.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
