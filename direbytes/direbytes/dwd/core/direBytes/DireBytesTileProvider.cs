using System;
using dwd.core.data.composition;
using dwd.core.prefabs.implementations.byflavor;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x0200000E RID: 14
	public class DireBytesTileProvider : PrefabProvider
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000547C File Offset: 0x0000367C
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesTileProvider()
		{
			Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireBytesTileProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr);
			DireBytesTileProvider.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr, "prefabLoader");
			DireBytesTileProvider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr, 100663381);
			DireBytesTileProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr, 100663382);
			DireBytesTileProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr, 100663383);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000054FC File Offset: 0x000036FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234619, XrefRangeEnd = 1234623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesTileProvider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005530 File Offset: 0x00003730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234623, XrefRangeEnd = 1234654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SubscriptionProvider GetPrefabForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesTileProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000558C File Offset: 0x0000378C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesTileProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesTileProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesTileProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002547 File Offset: 0x00000747
		public DireBytesTileProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000055C8 File Offset: 0x000037C8
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002550 File Offset: 0x00000750
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesTileProvider.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesTileProvider.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
