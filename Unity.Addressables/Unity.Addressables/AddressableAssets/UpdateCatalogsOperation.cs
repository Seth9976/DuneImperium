using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000017 RID: 23
	public class UpdateCatalogsOperation : AsyncOperationBase<List<IResourceLocator>>
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000E61C File Offset: 0x0000C81C
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateCatalogsOperation()
		{
			Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "UpdateCatalogsOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr);
			UpdateCatalogsOperation.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "m_Addressables");
			UpdateCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "m_LocatorInfos");
			UpdateCatalogsOperation.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "m_DepOp");
			UpdateCatalogsOperation.NativeFieldInfoPtr_m_CleanCacheOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "m_CleanCacheOp");
			UpdateCatalogsOperation.NativeFieldInfoPtr_m_AutoCleanBundleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "m_AutoCleanBundleCache");
			UpdateCatalogsOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663740);
			UpdateCatalogsOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663741);
			UpdateCatalogsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663742);
			UpdateCatalogsOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663743);
			UpdateCatalogsOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663744);
			UpdateCatalogsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663745);
			UpdateCatalogsOperation.NativeMethodInfoPtr_OnCleanCacheCompleted_Private_Void_AsyncOperationHandle_1_Boolean_List_1_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, 100663746);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000E73C File Offset: 0x0000C93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162557, XrefRangeEnd = 1162561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateCatalogsOperation(AddressablesImpl aa)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000E788 File Offset: 0x0000C988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162561, XrefRangeEnd = 1162636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<List<IResourceLocator>> Start(IEnumerable<string> catalogIds, bool autoCleanBundleCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogIds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCleanBundleCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<List<IResourceLocator>>(intPtr);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162636, XrefRangeEnd = 1162666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCatalogsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000E828 File Offset: 0x0000CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162666, XrefRangeEnd = 1162669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCatalogsOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000E864 File Offset: 0x0000CA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162669, XrefRangeEnd = 1162675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCatalogsOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162675, XrefRangeEnd = 1162765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateCatalogsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162765, XrefRangeEnd = 1162780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCleanCacheCompleted(AsyncOperationHandle<bool> handle, List<IResourceLocator> catalogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(catalogs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.NativeMethodInfoPtr_OnCleanCacheCompleted_Private_Void_AsyncOperationHandle_1_Boolean_List_1_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000028DD File Offset: 0x00000ADD
		public UpdateCatalogsOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000E94C File Offset: 0x0000CB4C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000028E6 File Offset: 0x00000AE6
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000E97C File Offset: 0x0000CB7C
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002905 File Offset: 0x00000B05
		public unsafe List<ResourceLocatorInfo> m_LocatorInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ResourceLocatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_LocatorInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002924 File Offset: 0x00000B24
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002952 File Offset: 0x00000B52
		public AsyncOperationHandle<bool> m_CleanCacheOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_CleanCacheOp);
				return new AsyncOperationHandle<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_CleanCacheOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000EA0C File Offset: 0x0000CC0C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002980 File Offset: 0x00000B80
		public unsafe bool m_AutoCleanBundleCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_AutoCleanBundleCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.NativeFieldInfoPtr_m_AutoCleanBundleCache)) = value;
			}
		}

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_m_LocatorInfos;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanCacheOp;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoCleanBundleCache;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_List_1_IResourceLocator_IEnumerable_1_String_Boolean_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_OnCleanCacheCompleted_Private_Void_AsyncOperationHandle_1_Boolean_List_1_IResourceLocator_0;

		// Token: 0x02000077 RID: 119
		[ObfuscatedName("UnityEngine.AddressableAssets.UpdateCatalogsOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000500 RID: 1280 RVA: 0x00017FBC File Offset: 0x000161BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr);
				UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr, "<>9");
				UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr, "<>9__6_0");
				UpdateCatalogsOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr, 100663748);
				UpdateCatalogsOperation.__c.NativeMethodInfoPtr__Start_b__6_0_Internal_Boolean_IResourceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr, 100663749);
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00018038 File Offset: 0x00016238
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCatalogsOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x00018074 File Offset: 0x00016274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162524, XrefRangeEnd = 1162533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__6_0(IResourceProvider rp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.__c.NativeMethodInfoPtr__Start_b__6_0_Internal_Boolean_IResourceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x000040CD File Offset: 0x000022CD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000504 RID: 1284 RVA: 0x000180C4 File Offset: 0x000162C4
			// (set) Token: 0x06000505 RID: 1285 RVA: 0x000040D6 File Offset: 0x000022D6
			public unsafe static UpdateCatalogsOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateCatalogsOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000506 RID: 1286 RVA: 0x000180EC File Offset: 0x000162EC
			// (set) Token: 0x06000507 RID: 1287 RVA: 0x000040E8 File Offset: 0x000022E8
			public unsafe static Func<IResourceProvider, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IResourceProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UpdateCatalogsOperation.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400037C RID: 892
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400037D RID: 893
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400037E RID: 894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400037F RID: 895
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Internal_Boolean_IResourceProvider_0;
		}

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("UnityEngine.AddressableAssets.UpdateCatalogsOperation+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06000508 RID: 1288 RVA: 0x00018114 File Offset: 0x00016314
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateCatalogsOperation>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr);
				UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr_catalogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr, "catalogs");
				UpdateCatalogsOperation.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr, 100663750);
				UpdateCatalogsOperation.__c__DisplayClass11_0.NativeMethodInfoPtr__OnCleanCacheCompleted_b__0_Internal_Void_AsyncOperationHandle_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr, 100663751);
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00018190 File Offset: 0x00016390
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCatalogsOperation.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x000181CC File Offset: 0x000163CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162533, XrefRangeEnd = 1162557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCleanCacheCompleted_b__0(AsyncOperationHandle<bool> obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeMethodInfoPtr__OnCleanCacheCompleted_b__0_Internal_Void_AsyncOperationHandle_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x000040FA File Offset: 0x000022FA
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x0600050C RID: 1292 RVA: 0x00018214 File Offset: 0x00016414
			// (set) Token: 0x0600050D RID: 1293 RVA: 0x00004103 File Offset: 0x00002303
			public unsafe UpdateCatalogsOperation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateCatalogsOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x00018244 File Offset: 0x00016444
			// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004122 File Offset: 0x00002322
			public unsafe List<IResourceLocator> catalogs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr_catalogs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IResourceLocator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateCatalogsOperation.__c__DisplayClass11_0.NativeFieldInfoPtr_catalogs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000380 RID: 896
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000381 RID: 897
			private static readonly IntPtr NativeFieldInfoPtr_catalogs;

			// Token: 0x04000382 RID: 898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000383 RID: 899
			private static readonly IntPtr NativeMethodInfoPtr__OnCleanCacheCompleted_b__0_Internal_Void_AsyncOperationHandle_1_Boolean_0;
		}
	}
}
