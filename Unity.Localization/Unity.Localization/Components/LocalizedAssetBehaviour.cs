using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000C6 RID: 198
	public class LocalizedAssetBehaviour<TObject, TReference> : LocalizedMonoBehaviour where TObject : Object where TReference : LocalizedAsset<TObject>, new()
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x000309F0 File Offset: 0x0002EBF0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetBehaviour()
		{
			Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizedAssetBehaviour`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TReference>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr);
			LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_LocalizedAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, "m_LocalizedAssetReference");
			LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_ChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, "m_ChangeHandler");
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_get_AssetReference_Public_get_TReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665050);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_set_AssetReference_Public_set_Void_TReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665051);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665052);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665053);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665054);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665055);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665056);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665057);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_UpdateAsset_Protected_Abstract_Virtual_New_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665058);
			LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr, 100665059);
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00030B60 File Offset: 0x0002ED60
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00030B9C File Offset: 0x0002ED9C
		public unsafe TReference AssetReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_get_AssetReference_Public_get_TReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TReference>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078762, XrefRangeEnd = 1078764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TReference).IsValueType)
					{
						TReference treference = value;
						intPtr = ((treference is string) ? IL2CPP.ManagedStringToIl2Cpp(treference as string) : IL2CPP.Il2CppObjectBaseToPtr(treference as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_set_AssetReference_Public_set_Void_TReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00030C14 File Offset: 0x0002EE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00030C50 File Offset: 0x0002EE50
		[CallerCount(0)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		[CallerCount(0)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00030CF4 File Offset: 0x0002EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078764, XrefRangeEnd = 1078773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterChangeHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00030D30 File Offset: 0x0002EF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078773, XrefRangeEnd = 1078776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearChangeHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00030D6C File Offset: 0x0002EF6C
		[CallerCount(0)]
		public unsafe virtual void UpdateAsset(TObject localizedAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = localizedAsset;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref localizedAsset;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr_UpdateAsset_Protected_Abstract_Virtual_New_Void_TObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078776, XrefRangeEnd = 1078779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetBehaviour<TObject, TReference>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetBehaviour<TObject, TReference>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00006616 File Offset: 0x00004816
		public LocalizedAssetBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00030E2C File Offset: 0x0002F02C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00030E54 File Offset: 0x0002F054
		public unsafe TReference m_LocalizedAssetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_LocalizedAssetReference);
				return IL2CPP.PointerToValueGeneric<TReference>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_LocalizedAssetReference);
				Type typeFromHandle = typeof(TReference);
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00030EFC File Offset: 0x0002F0FC
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0000661F File Offset: 0x0000481F
		public unsafe LocalizedAsset<TObject>.ChangeHandler m_ChangeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_ChangeHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedAsset<TObject>.ChangeHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedAssetBehaviour<TObject, TReference>.NativeFieldInfoPtr_m_ChangeHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalizedAssetReference;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_m_ChangeHandler;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetReference_Public_get_TReference_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_set_AssetReference_Public_set_Void_TReference_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAsset_Protected_Abstract_Virtual_New_Void_TObject_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
