using System;
using dwd.core.loader.loaders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.caching
{
	// Token: 0x02000190 RID: 400
	public class PrefabReference<T> : global::Il2CppSystem.Object where T : global::UnityEngine.Object
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x0006DED4 File Offset: 0x0006C0D4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabReference()
		{
			Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "PrefabReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr);
			PrefabReference<T>.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "killed");
			PrefabReference<T>.NativeFieldInfoPtr_loadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "loadOp");
			PrefabReference<T>.NativeFieldInfoPtr_instantiateLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "instantiateLoad");
			PrefabReference<T>.NativeFieldInfoPtr_componentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "componentType");
			PrefabReference<T>.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "transform");
			PrefabReference<T>.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "worldSpace");
			PrefabReference<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "source");
			PrefabReference<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "<Asset>k__BackingField");
			PrefabReference<T>.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666725);
			PrefabReference<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666726);
			PrefabReference<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666727);
			PrefabReference<T>.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666728);
			PrefabReference<T>.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666729);
			PrefabReference<T>.NativeMethodInfoPtr_SetAsset_Private_Void_AssetRequest_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666730);
			PrefabReference<T>.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666731);
			PrefabReference<T>.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666732);
			PrefabReference<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666733);
			PrefabReference<T>.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, 100666734);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0006E0A8 File Offset: 0x0006C2A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878252, RefRangeEnd = 878253, XrefRangeStart = 878249, XrefRangeEnd = 878252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabReference(Transform transform, bool worldSpace, IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x0006E114 File Offset: 0x0006C314
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0006E150 File Offset: 0x0006C350
		public unsafe virtual T Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x0006E1C8 File Offset: 0x0006C3C8
		public unsafe virtual global::UnityEngine.Object dwd.core.loader.caching.IAssetReference.Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0006E208 File Offset: 0x0006C408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0006E260 File Offset: 0x0006C460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878253, XrefRangeEnd = 878263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsset(AssetRequest<T> assetRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_SetAsset_Private_Void_AssetRequest_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006E2A4 File Offset: 0x0006C4A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878264, RefRangeEnd = 878265, XrefRangeStart = 878263, XrefRangeEnd = 878264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0006E2E0 File Offset: 0x0006C4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878265, XrefRangeEnd = 878273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0006E318 File Offset: 0x0006C518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878273, XrefRangeEnd = 878287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0006E34C File Offset: 0x0006C54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00009D17 File Offset: 0x00007F17
		public PrefabReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x0006E380 File Offset: 0x0006C580
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00009D20 File Offset: 0x00007F20
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x0006E3A8 File Offset: 0x0006C5A8
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00009D3B File Offset: 0x00007F3B
		public Nullable<AsyncOperationHandle<T>> loadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_loadOp);
				return new Nullable<AsyncOperationHandle<T>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<T>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_loadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<T>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00009D69 File Offset: 0x00007F69
		public AsyncOperationHandle<GameObject> instantiateLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_instantiateLoad);
				return new AsyncOperationHandle<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_instantiateLoad), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x0006E408 File Offset: 0x0006C608
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00009D97 File Offset: 0x00007F97
		public unsafe static Type componentType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PrefabReference<T>.NativeFieldInfoPtr_componentType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PrefabReference<T>.NativeFieldInfoPtr_componentType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x0006E430 File Offset: 0x0006C630
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x00009DA9 File Offset: 0x00007FA9
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x0006E460 File Offset: 0x0006C660
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public unsafe bool worldSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_worldSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_worldSpace)) = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x0006E488 File Offset: 0x0006C688
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00009DE3 File Offset: 0x00007FE3
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x0006E4B8 File Offset: 0x0006C6B8
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
		public unsafe T _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>.NativeFieldInfoPtr__Asset_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_loadOp;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr_instantiateLoad;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr_componentType;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_IReferenceTracker_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_T_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_SetAsset_Private_Void_AssetRequest_1_T_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000325 RID: 805
		[ObfuscatedName("dwd.core.loader.caching.PrefabReference`1+<Load>d__14")]
		public sealed class _Load_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x060024A6 RID: 9382 RVA: 0x0009E99C File Offset: 0x0009CB9C
			// Note: this type is marked as 'beforefieldinit'.
			static _Load_d__14()
			{
				Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabReference<T>>.NativeClassPtr, "<Load>d__14"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr);
				PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, "<>1__state");
				PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, "<>2__current");
				PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, "<>4__this");
				PrefabReference<T>._Load_d__14.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, "assetName");
				PrefabReference<T>._Load_d__14.NativeFieldInfoPtr__assetRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, "<assetRequest>5__2");
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666736);
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666737);
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666738);
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666739);
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666740);
				PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr, 100666741);
			}

			// Token: 0x060024A7 RID: 9383 RVA: 0x0009EAE0 File Offset: 0x0009CCE0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Load_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabReference<T>._Load_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024A8 RID: 9384 RVA: 0x0009EB28 File Offset: 0x0009CD28
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024A9 RID: 9385 RVA: 0x0009EB5C File Offset: 0x0009CD5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878245, XrefRangeEnd = 878249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x060024AA RID: 9386 RVA: 0x0009EB98 File Offset: 0x0009CD98
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024AB RID: 9387 RVA: 0x0009EBD8 File Offset: 0x0009CDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x060024AC RID: 9388 RVA: 0x0009EC0C File Offset: 0x0009CE0C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabReference<T>._Load_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024AD RID: 9389 RVA: 0x00010706 File Offset: 0x0000E906
			public _Load_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x060024AE RID: 9390 RVA: 0x0009EC4C File Offset: 0x0009CE4C
			// (set) Token: 0x060024AF RID: 9391 RVA: 0x0001070F File Offset: 0x0000E90F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0009EC74 File Offset: 0x0009CE74
			// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0001072A File Offset: 0x0000E92A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0009ECA4 File Offset: 0x0009CEA4
			// (set) Token: 0x060024B3 RID: 9395 RVA: 0x00010749 File Offset: 0x0000E949
			public unsafe PrefabReference<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabReference<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0009ECD4 File Offset: 0x0009CED4
			// (set) Token: 0x060024B5 RID: 9397 RVA: 0x00010768 File Offset: 0x0000E968
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0009ED04 File Offset: 0x0009CF04
			// (set) Token: 0x060024B7 RID: 9399 RVA: 0x00010796 File Offset: 0x0000E996
			public unsafe AssetRequest<T> _assetRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr__assetRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetRequest<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabReference<T>._Load_d__14.NativeFieldInfoPtr__assetRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018F5 RID: 6389
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018F6 RID: 6390
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018F7 RID: 6391
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018F8 RID: 6392
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x040018F9 RID: 6393
			private static readonly IntPtr NativeFieldInfoPtr__assetRequest_5__2;

			// Token: 0x040018FA RID: 6394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018FB RID: 6395
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018FC RID: 6396
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018FD RID: 6397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018FE RID: 6398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018FF RID: 6399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
