using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.IntrigueArchetypes.BaseSet
{
	// Token: 0x02000165 RID: 357
	public class MasterTactician : WormArchetype
	{
		// Token: 0x06001250 RID: 4688 RVA: 0x000A1CB4 File Offset: 0x0009FEB4
		// Note: this type is marked as 'beforefieldinit'.
		static MasterTactician()
		{
			Il2CppClassPointerStore<MasterTactician>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.IntrigueArchetypes.BaseSet", "MasterTactician");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MasterTactician>.NativeClassPtr);
			MasterTactician.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MasterTactician>.NativeClassPtr, "archID");
			MasterTactician.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MasterTactician>.NativeClassPtr, 100666346);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000A1D0C File Offset: 0x0009FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93978, XrefRangeEnd = 94091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MasterTactician()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MasterTactician>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MasterTactician.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000922D File Offset: 0x0000742D
		public MasterTactician(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x000A1D48 File Offset: 0x0009FF48
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00009236 File Offset: 0x00007436
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MasterTactician.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MasterTactician.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
