using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.RiseOfIx
{
	// Token: 0x0200013A RID: 314
	public class CannonTurrets : WormArchetype
	{
		// Token: 0x06001179 RID: 4473 RVA: 0x0009FD20 File Offset: 0x0009DF20
		// Note: this type is marked as 'beforefieldinit'.
		static CannonTurrets()
		{
			Il2CppClassPointerStore<CannonTurrets>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.RiseOfIx", "CannonTurrets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CannonTurrets>.NativeClassPtr);
			CannonTurrets.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CannonTurrets>.NativeClassPtr, "archID");
			CannonTurrets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CannonTurrets>.NativeClassPtr, 100666260);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0009FD78 File Offset: 0x0009DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89062, XrefRangeEnd = 89175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CannonTurrets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CannonTurrets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CannonTurrets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00008DA4 File Offset: 0x00006FA4
		public CannonTurrets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0009FDB4 File Offset: 0x0009DFB4
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00008DAD File Offset: 0x00006FAD
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CannonTurrets.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CannonTurrets.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
