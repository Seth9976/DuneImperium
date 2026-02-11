using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TleilaxuArchetypes.Immortality
{
	// Token: 0x020000F6 RID: 246
	public class StitchedHorror : WormArchetype
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x0009CB30 File Offset: 0x0009AD30
		// Note: this type is marked as 'beforefieldinit'.
		static StitchedHorror()
		{
			Il2CppClassPointerStore<StitchedHorror>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TleilaxuArchetypes.Immortality", "StitchedHorror");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StitchedHorror>.NativeClassPtr);
			StitchedHorror.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchedHorror>.NativeClassPtr, "archID");
			StitchedHorror.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StitchedHorror>.NativeClassPtr, 100666124);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0009CB88 File Offset: 0x0009AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80496, XrefRangeEnd = 80672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StitchedHorror()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StitchedHorror>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StitchedHorror.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00008678 File Offset: 0x00006878
		public StitchedHorror(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0009CBC4 File Offset: 0x0009ADC4
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00008681 File Offset: 0x00006881
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StitchedHorror.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StitchedHorror.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
