using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.loader
{
	// Token: 0x02000180 RID: 384
	public class LoaderStrategy : ScriptableObject
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x0006BE38 File Offset: 0x0006A038
		// Note: this type is marked as 'beforefieldinit'.
		static LoaderStrategy()
		{
			Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader", "LoaderStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr);
			LoaderStrategy.NativeFieldInfoPtr_orderedAssetLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr, "orderedAssetLoaders");
			LoaderStrategy.NativeFieldInfoPtr_sceneLoadSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr, "sceneLoadSource");
			LoaderStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr, 100666643);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0006BEA4 File Offset: 0x0006A0A4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoaderStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoaderStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoaderStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00009914 File Offset: 0x00007B14
		public LoaderStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000991D File Offset: 0x00007B1D
		public unsafe List<AssetLoader> orderedAssetLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoaderStrategy.NativeFieldInfoPtr_orderedAssetLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AssetLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoaderStrategy.NativeFieldInfoPtr_orderedAssetLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0006BF10 File Offset: 0x0006A110
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000993C File Offset: 0x00007B3C
		public unsafe SceneLoadSource sceneLoadSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoaderStrategy.NativeFieldInfoPtr_sceneLoadSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneLoadSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoaderStrategy.NativeFieldInfoPtr_sceneLoadSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr_orderedAssetLoaders;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr_sceneLoadSource;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
