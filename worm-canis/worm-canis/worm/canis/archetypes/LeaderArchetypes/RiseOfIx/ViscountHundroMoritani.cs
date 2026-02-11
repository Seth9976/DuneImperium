using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.LeaderArchetypes.RiseOfIx
{
	// Token: 0x0200012E RID: 302
	public class ViscountHundroMoritani : WormArchetype
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x0009F450 File Offset: 0x0009D650
		// Note: this type is marked as 'beforefieldinit'.
		static ViscountHundroMoritani()
		{
			Il2CppClassPointerStore<ViscountHundroMoritani>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.LeaderArchetypes.RiseOfIx", "ViscountHundroMoritani");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViscountHundroMoritani>.NativeClassPtr);
			ViscountHundroMoritani.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViscountHundroMoritani>.NativeClassPtr, "archID");
			ViscountHundroMoritani.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViscountHundroMoritani>.NativeClassPtr, 100666236);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0009F4A8 File Offset: 0x0009D6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87803, XrefRangeEnd = 87908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViscountHundroMoritani()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViscountHundroMoritani>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViscountHundroMoritani.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00008C60 File Offset: 0x00006E60
		public ViscountHundroMoritani(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0009F4E4 File Offset: 0x0009D6E4
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x00008C69 File Offset: 0x00006E69
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ViscountHundroMoritani.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViscountHundroMoritani.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
