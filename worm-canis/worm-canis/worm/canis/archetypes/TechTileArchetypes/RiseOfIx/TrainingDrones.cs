using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.archetypes.TechTileArchetypes.RiseOfIx
{
	// Token: 0x0200010B RID: 267
	public class TrainingDrones : WormArchetype
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x0009DA9C File Offset: 0x0009BC9C
		// Note: this type is marked as 'beforefieldinit'.
		static TrainingDrones()
		{
			Il2CppClassPointerStore<TrainingDrones>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.archetypes.TechTileArchetypes.RiseOfIx", "TrainingDrones");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrainingDrones>.NativeClassPtr);
			TrainingDrones.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrainingDrones>.NativeClassPtr, "archID");
			TrainingDrones.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrainingDrones>.NativeClassPtr, 100666166);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0009DAF4 File Offset: 0x0009BCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83269, XrefRangeEnd = 83377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrainingDrones()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrainingDrones>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrainingDrones.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000088AF File Offset: 0x00006AAF
		public TrainingDrones(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0009DB30 File Offset: 0x0009BD30
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x000088B8 File Offset: 0x00006AB8
		public unsafe static ArchetypeID archID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrainingDrones.NativeFieldInfoPtr_archID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrainingDrones.NativeFieldInfoPtr_archID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr_archID;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
