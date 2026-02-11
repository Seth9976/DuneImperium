using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B8 RID: 184
	public class LoadAssetOperation<TObject> : WaitForCurrentOperationAsyncOperationBase<TObject> where TObject : Object
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x0002DF9C File Offset: 0x0002C19C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadAssetOperation()
		{
			Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "LoadAssetOperation`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr);
			LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "m_AssetLoadedAction");
			LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_TableEntryOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "m_TableEntryOperation");
			LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_LoadAssetOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "m_LoadAssetOperation");
			LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AutoRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "m_AutoRelease");
			LoadAssetOperation<TObject>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "Pool");
			LoadAssetOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664950);
			LoadAssetOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_AssetTable_AssetTableEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664951);
			LoadAssetOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664952);
			LoadAssetOperation<TObject>.NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664953);
			LoadAssetOperation<TObject>.NativeMethodInfoPtr_CompleteAndRelease_Public_Void_TObject_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664954);
			LoadAssetOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, 100664955);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0002E0E4 File Offset: 0x0002C2E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1077797, RefRangeEnd = 1077800, XrefRangeStart = 1077797, XrefRangeEnd = 1077800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadAssetOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002E120 File Offset: 0x0002C320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077858, RefRangeEnd = 1077859, XrefRangeStart = 1077853, XrefRangeEnd = 1077858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle<LocalizedDatabase<AssetTable, AssetTableEntry>.TableEntryResult> loadTableEntryOperation, bool autoRelease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadTableEntryOperation));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRelease;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_AssetTable_AssetTableEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002E178 File Offset: 0x0002C378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077859, XrefRangeEnd = 1077893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAssetOperation<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077893, XrefRangeEnd = 1077899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssetLoaded(AsyncOperationHandle<TObject> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077899, XrefRangeEnd = 1077909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAndRelease(TObject result, bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = result;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.NativeMethodInfoPtr_CompleteAndRelease_Public_Void_TObject_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0002E294 File Offset: 0x0002C494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077909, XrefRangeEnd = 1077916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAssetOperation<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00005D22 File Offset: 0x00003F22
		public LoadAssetOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0002E2D0 File Offset: 0x0002C4D0
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00005D2B File Offset: 0x00003F2B
		public unsafe Action<AsyncOperationHandle<TObject>> m_AssetLoadedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AssetLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002E300 File Offset: 0x0002C500
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00005D4A File Offset: 0x00003F4A
		public AsyncOperationHandle<LocalizedDatabase<AssetTable, AssetTableEntry>.TableEntryResult> m_TableEntryOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_TableEntryOperation);
				return new AsyncOperationHandle<LocalizedDatabase<AssetTable, AssetTableEntry>.TableEntryResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<AssetTable, AssetTableEntry>.TableEntryResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_TableEntryOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LocalizedDatabase<AssetTable, AssetTableEntry>.TableEntryResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0002E330 File Offset: 0x0002C530
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00005D78 File Offset: 0x00003F78
		public AsyncOperationHandle<TObject> m_LoadAssetOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_LoadAssetOperation);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_LoadAssetOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002E360 File Offset: 0x0002C560
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00005DA6 File Offset: 0x00003FA6
		public unsafe bool m_AutoRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AutoRelease);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAssetOperation<TObject>.NativeFieldInfoPtr_m_AutoRelease)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0002E388 File Offset: 0x0002C588
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public unsafe static ObjectPool<LoadAssetOperation<TObject>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadAssetOperation<TObject>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LoadAssetOperation<TObject>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadAssetOperation<TObject>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetLoadedAction;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntryOperation;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadAssetOperation;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoRelease;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TableEntryResult_AssetTable_AssetTableEntry_Boolean_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_AssetLoaded_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAndRelease_Public_Void_TObject_Boolean_String_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0200016D RID: 365
		[ObfuscatedName("UnityEngine.Localization.Operations.LoadAssetOperation`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F78 RID: 3960 RVA: 0x00042200 File Offset: 0x00040400
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadAssetOperation<TObject>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr);
				LoadAssetOperation<TObject>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr, "<>9");
				LoadAssetOperation<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr, 100664958);
				LoadAssetOperation<TObject>.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_LoadAssetOperation_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr, 100664959);
			}

			// Token: 0x06000F79 RID: 3961 RVA: 0x000422A4 File Offset: 0x000404A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAssetOperation<TObject>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F7A RID: 3962 RVA: 0x000422E0 File Offset: 0x000404E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadAssetOperation<TObject> __cctor_b__11_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAssetOperation<TObject>.__c.NativeMethodInfoPtr___cctor_b__11_0_Internal_LoadAssetOperation_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadAssetOperation<TObject>>(intPtr3) : null;
			}

			// Token: 0x06000F7B RID: 3963 RVA: 0x00008738 File Offset: 0x00006938
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00042320 File Offset: 0x00040520
			// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00008741 File Offset: 0x00006941
			public unsafe static LoadAssetOperation<TObject>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadAssetOperation<TObject>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadAssetOperation<TObject>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadAssetOperation<TObject>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AA6 RID: 2726
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AA7 RID: 2727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AA8 RID: 2728
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__11_0_Internal_LoadAssetOperation_1_TObject_0;
		}
	}
}
