using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x0200006B RID: 107
	public class SpawnEffectVoodoo : EntityVoodoo
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x0001E100 File Offset: 0x0001C300
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnEffectVoodoo()
		{
			Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "SpawnEffectVoodoo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr);
			SpawnEffectVoodoo.NativeFieldInfoPtr_fxPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, "fxPrefab");
			SpawnEffectVoodoo.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, "instance");
			SpawnEffectVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, 100664156);
			SpawnEffectVoodoo.NativeMethodInfoPtr_DetachAndTransitionOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, 100664157);
			SpawnEffectVoodoo.NativeMethodInfoPtr_TransitionOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, 100664158);
			SpawnEffectVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr, 100664159);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112859, XrefRangeEnd = 1112867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnWaypointReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnEffectVoodoo.NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001E1E4 File Offset: 0x0001C3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112867, XrefRangeEnd = 1112873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachAndTransitionOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnEffectVoodoo.NativeMethodInfoPtr_DetachAndTransitionOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001E218 File Offset: 0x0001C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112873, XrefRangeEnd = 1112877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnEffectVoodoo.NativeMethodInfoPtr_TransitionOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001E24C File Offset: 0x0001C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112877, XrefRangeEnd = 1112881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnEffectVoodoo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnEffectVoodoo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnEffectVoodoo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00005118 File Offset: 0x00003318
		public SpawnEffectVoodoo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x0001E288 File Offset: 0x0001C488
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00005121 File Offset: 0x00003321
		public unsafe FXUnit fxPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnEffectVoodoo.NativeFieldInfoPtr_fxPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnEffectVoodoo.NativeFieldInfoPtr_fxPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005140 File Offset: 0x00003340
		public unsafe FXUnit instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnEffectVoodoo.NativeFieldInfoPtr_instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnEffectVoodoo.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_fxPrefab;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_OnWaypointReached_Public_Virtual_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_DetachAndTransitionOut_Public_Void_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_TransitionOut_Public_Void_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
