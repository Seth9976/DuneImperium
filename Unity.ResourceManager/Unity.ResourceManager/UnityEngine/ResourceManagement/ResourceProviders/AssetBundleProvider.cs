using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000031 RID: 49
	public class AssetBundleProvider : ResourceProviderBase
	{
		// Token: 0x060002BE RID: 702 RVA: 0x0000F520 File Offset: 0x0000D720
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleProvider()
		{
			Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "AssetBundleProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr);
			AssetBundleProvider.NativeFieldInfoPtr_m_UnloadingBundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, "m_UnloadingBundles");
			AssetBundleProvider.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663729);
			AssetBundleProvider.NativeMethodInfoPtr_get_UnloadingBundles_FamOrAssem_Static_get_Dictionary_2_String_AssetBundleUnloadOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663730);
			AssetBundleProvider.NativeMethodInfoPtr_set_UnloadingBundles_Internal_Static_set_Void_Dictionary_2_String_AssetBundleUnloadOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663731);
			AssetBundleProvider.NativeMethodInfoPtr_get_UnloadingAssetBundleCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663732);
			AssetBundleProvider.NativeMethodInfoPtr_get_AssetBundleCount_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663733);
			AssetBundleProvider.NativeMethodInfoPtr_WaitForAllUnloadingBundlesToComplete_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663734);
			AssetBundleProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663735);
			AssetBundleProvider.NativeMethodInfoPtr_GetDefaultType_Public_Virtual_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663736);
			AssetBundleProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663737);
			AssetBundleProvider.NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_Virtual_New_IOperationCacheKey_ResourceManager_IResourceLocation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663738);
			AssetBundleProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, 100663739);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000F640 File Offset: 0x0000D840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139752, XrefRangeEnd = 1139764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000F668 File Offset: 0x0000D868
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000F69C File Offset: 0x0000D89C
		public unsafe static Dictionary<string, AssetBundleUnloadOperation> UnloadingBundles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139764, XrefRangeEnd = 1139768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_get_UnloadingBundles_FamOrAssem_Static_get_Dictionary_2_String_AssetBundleUnloadOperation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AssetBundleUnloadOperation>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139768, XrefRangeEnd = 1139774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_set_UnloadingBundles_Internal_Static_set_Void_Dictionary_2_String_AssetBundleUnloadOperation_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public unsafe static int UnloadingAssetBundleCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1139782, RefRangeEnd = 1139785, XrefRangeStart = 1139774, XrefRangeEnd = 1139782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_get_UnloadingAssetBundleCount_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000F704 File Offset: 0x0000D904
		public unsafe static int AssetBundleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139785, XrefRangeEnd = 1139793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_get_AssetBundleCount_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000F734 File Offset: 0x0000D934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139808, RefRangeEnd = 1139809, XrefRangeStart = 1139793, XrefRangeEnd = 1139808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitForAllUnloadingBundlesToComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr_WaitForAllUnloadingBundlesToComplete_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000F75C File Offset: 0x0000D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139809, XrefRangeEnd = 1139829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Provide(ProvideHandle providerInterface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(providerInterface));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleProvider.NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139829, XrefRangeEnd = 1139835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetDefaultType(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleProvider.NativeMethodInfoPtr_GetDefaultType_Public_Virtual_Type_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000F80C File Offset: 0x0000DA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139835, XrefRangeEnd = 1139872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release(IResourceLocation location, Object asset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleProvider.NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000F86C File Offset: 0x0000DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139872, XrefRangeEnd = 1139883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetBundleProvider.NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_Virtual_New_IOperationCacheKey_ResourceManager_IResourceLocation_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr3) : null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000F8EC File Offset: 0x0000DAEC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetBundleProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000326C File Offset: 0x0000146C
		public AssetBundleProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000F928 File Offset: 0x0000DB28
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00003275 File Offset: 0x00001475
		public unsafe static Dictionary<string, AssetBundleUnloadOperation> m_UnloadingBundles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssetBundleProvider.NativeFieldInfoPtr_m_UnloadingBundles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AssetBundleUnloadOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetBundleProvider.NativeFieldInfoPtr_m_UnloadingBundles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_m_UnloadingBundles;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_UnloadingBundles_FamOrAssem_Static_get_Dictionary_2_String_AssetBundleUnloadOperation_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_set_UnloadingBundles_Internal_Static_set_Void_Dictionary_2_String_AssetBundleUnloadOperation_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_UnloadingAssetBundleCount_Internal_Static_get_Int32_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetBundleCount_Internal_Static_get_Int32_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_WaitForAllUnloadingBundlesToComplete_Internal_Static_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Virtual_Void_ProvideHandle_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultType_Public_Virtual_Type_IResourceLocation_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_IResourceLocation_Object_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_CreateCacheKeyForLocation_Internal_Virtual_New_IOperationCacheKey_ResourceManager_IResourceLocation_Type_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000080 RID: 128
		[ObfuscatedName("UnityEngine.ResourceManagement.ResourceProviders.AssetBundleProvider+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600063C RID: 1596 RVA: 0x0001DD58 File Offset: 0x0001BF58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetBundleProvider>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr);
				AssetBundleProvider.__c__DisplayClass12_0.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr, "location");
				AssetBundleProvider.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr, 100663741);
				AssetBundleProvider.__c__DisplayClass12_0.NativeMethodInfoPtr__Release_b__0_Internal_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr, 100663742);
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetBundleProvider.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x0001DDFC File Offset: 0x0001BFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1139741, XrefRangeEnd = 1139752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Release_b__0(AsyncOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetBundleProvider.__c__DisplayClass12_0.NativeMethodInfoPtr__Release_b__0_Internal_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x0000458E File Offset: 0x0000278E
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001DE40 File Offset: 0x0001C040
			// (set) Token: 0x06000641 RID: 1601 RVA: 0x00004597 File Offset: 0x00002797
			public unsafe IResourceLocation location
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleProvider.__c__DisplayClass12_0.NativeFieldInfoPtr_location);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetBundleProvider.__c__DisplayClass12_0.NativeFieldInfoPtr_location), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000474 RID: 1140
			private static readonly IntPtr NativeFieldInfoPtr_location;

			// Token: 0x04000475 RID: 1141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000476 RID: 1142
			private static readonly IntPtr NativeMethodInfoPtr__Release_b__0_Internal_Void_AsyncOperation_0;
		}
	}
}
