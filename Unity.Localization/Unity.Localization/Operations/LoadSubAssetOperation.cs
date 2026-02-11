using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B9 RID: 185
	public class LoadSubAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject> where TObject : Object
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		// Note: this type is marked as 'beforefieldinit'.
		static LoadSubAssetOperation()
		{
			Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "LoadSubAssetOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr);
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_AssetLoadedAction");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_AssetOperation");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_PreloadOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_PreloadOperations");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_Address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_Address");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_IsSubAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_IsSubAsset");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_SubAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "m_SubAssetName");
			LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "Pool");
			LoadSubAssetOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, 100664960);
			LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, 100664961);
			LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, 100664962);
			LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, 100664963);
			LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, 100664964);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002E50C File Offset: 0x0002C70C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1077797, RefRangeEnd = 1077800, XrefRangeStart = 1077797, XrefRangeEnd = 1077800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadSubAssetOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSubAssetOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002E548 File Offset: 0x0002C748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077951, RefRangeEnd = 1077952, XrefRangeStart = 1077916, XrefRangeEnd = 1077951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle<Il2CppReferenceArray<Object>> preloadOperations, string address, bool isSubAsset, string subAssetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(preloadOperations));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSubAsset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subAssetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077952, XrefRangeEnd = 1077987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002E600 File Offset: 0x0002C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077987, XrefRangeEnd = 1077994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssetLoaded(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002E648 File Offset: 0x0002C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077994, XrefRangeEnd = 1078004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadSubAssetOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00005DD3 File Offset: 0x00003FD3
		public LoadSubAssetOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0002E684 File Offset: 0x0002C884
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00005DDC File Offset: 0x00003FDC
		public unsafe Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00005DFB File Offset: 0x00003FFB
		public AsyncOperationHandle<TObject> m_AssetOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetOperation);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00005E29 File Offset: 0x00004029
		public AsyncOperationHandle<Il2CppReferenceArray<Object>> m_PreloadOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_PreloadOperations);
				return new AsyncOperationHandle<Il2CppReferenceArray<Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<Object>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_PreloadOperations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Il2CppReferenceArray<Object>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0002E714 File Offset: 0x0002C914
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x00005E57 File Offset: 0x00004057
		public unsafe string m_Address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_Address);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_Address), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002E73C File Offset: 0x0002C93C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00005E76 File Offset: 0x00004076
		public unsafe bool m_IsSubAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_IsSubAsset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_IsSubAsset)) = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0002E764 File Offset: 0x0002C964
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00005E91 File Offset: 0x00004091
		public unsafe string m_SubAssetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_SubAssetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_m_SubAssetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0002E78C File Offset: 0x0002C98C
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x00005EB0 File Offset: 0x000040B0
		public unsafe static ObjectPool<LoadSubAssetOperation<TObject>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LoadSubAssetOperation<TObject>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadSubAssetOperation<TObject>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetLoadedAction;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetOperation;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadOperations;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_m_Address;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSubAsset;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_m_SubAssetName;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_Il2CppReferenceArray_1_Object_String_Boolean_String_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0200016E RID: 366
		[ObfuscatedName("UnityEngine.Localization.Operations.LoadSubAssetOperation`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F7E RID: 3966 RVA: 0x00042348 File Offset: 0x00040548
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr);
				LoadSubAssetOperation<TObject>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr, "<>9");
				LoadSubAssetOperation<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr, 100664967);
				LoadSubAssetOperation<TObject>.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_LoadSubAssetOperation_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr, 100664968);
			}

			// Token: 0x06000F7F RID: 3967 RVA: 0x000423EC File Offset: 0x000405EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadSubAssetOperation<TObject>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSubAssetOperation<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F80 RID: 3968 RVA: 0x00042428 File Offset: 0x00040628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadSubAssetOperation<TObject> __cctor_b__12_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSubAssetOperation<TObject>.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_LoadSubAssetOperation_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadSubAssetOperation<TObject>>(intPtr3) : null;
			}

			// Token: 0x06000F81 RID: 3969 RVA: 0x00008753 File Offset: 0x00006953
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00042468 File Offset: 0x00040668
			// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0000875C File Offset: 0x0000695C
			public unsafe static LoadSubAssetOperation<TObject>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadSubAssetOperation<TObject>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadSubAssetOperation<TObject>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadSubAssetOperation<TObject>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AA9 RID: 2729
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AAA RID: 2730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AAB RID: 2731
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__12_0_Internal_LoadSubAssetOperation_1_TObject_0;
		}
	}
}
