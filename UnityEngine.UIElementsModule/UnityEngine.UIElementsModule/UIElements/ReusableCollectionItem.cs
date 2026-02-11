using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000034 RID: 52
	public class ReusableCollectionItem : Object
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x0002C254 File Offset: 0x0002A454
		// Note: this type is marked as 'beforefieldinit'.
		static ReusableCollectionItem()
		{
			Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ReusableCollectionItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr);
			ReusableCollectionItem.NativeFieldInfoPtr__bindableElement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "<bindableElement>k__BackingField");
			ReusableCollectionItem.NativeFieldInfoPtr__animator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "<animator>k__BackingField");
			ReusableCollectionItem.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "<index>k__BackingField");
			ReusableCollectionItem.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "<id>k__BackingField");
			ReusableCollectionItem.NativeFieldInfoPtr__isDragGhost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "<isDragGhost>k__BackingField");
			ReusableCollectionItem.NativeFieldInfoPtr_onGeometryChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "onGeometryChanged");
			ReusableCollectionItem.NativeFieldInfoPtr_m_GeometryChangedEventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "m_GeometryChangedEventCallback");
			ReusableCollectionItem.NativeFieldInfoPtr_onDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, "onDestroy");
			ReusableCollectionItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663881);
			ReusableCollectionItem.NativeMethodInfoPtr_get_bindableElement_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663882);
			ReusableCollectionItem.NativeMethodInfoPtr_set_bindableElement_Protected_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663883);
			ReusableCollectionItem.NativeMethodInfoPtr_get_animator_Public_get_ValueAnimation_1_StyleValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663884);
			ReusableCollectionItem.NativeMethodInfoPtr_set_animator_Public_set_Void_ValueAnimation_1_StyleValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663885);
			ReusableCollectionItem.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663886);
			ReusableCollectionItem.NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663887);
			ReusableCollectionItem.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663888);
			ReusableCollectionItem.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663889);
			ReusableCollectionItem.NativeMethodInfoPtr_get_isDragGhost_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663890);
			ReusableCollectionItem.NativeMethodInfoPtr_set_isDragGhost_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663891);
			ReusableCollectionItem.NativeMethodInfoPtr_add_onGeometryChanged_Public_add_Void_Action_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663892);
			ReusableCollectionItem.NativeMethodInfoPtr_remove_onGeometryChanged_Public_rem_Void_Action_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663893);
			ReusableCollectionItem.NativeMethodInfoPtr_add_onDestroy_Internal_add_Void_Action_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663894);
			ReusableCollectionItem.NativeMethodInfoPtr_remove_onDestroy_Internal_rem_Void_Action_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663895);
			ReusableCollectionItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663896);
			ReusableCollectionItem.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663897);
			ReusableCollectionItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663898);
			ReusableCollectionItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663899);
			ReusableCollectionItem.NativeMethodInfoPtr_DestroyElement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663900);
			ReusableCollectionItem.NativeMethodInfoPtr_SetSelected_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663901);
			ReusableCollectionItem.NativeMethodInfoPtr_SetDragGhost_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663902);
			ReusableCollectionItem.NativeMethodInfoPtr_OnGeometryChanged_Protected_Void_GeometryChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr, 100663903);
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		public unsafe virtual VisualElement rootElement
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0002C53C File Offset: 0x0002A73C
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0002C57C File Offset: 0x0002A77C
		public unsafe VisualElement bindableElement
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_get_bindableElement_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287291, XrefRangeEnd = 287292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_set_bindableElement_Protected_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0002C5C0 File Offset: 0x0002A7C0
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0002C600 File Offset: 0x0002A800
		public unsafe UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> animator
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_get_animator_Public_get_ValueAnimation_1_StyleValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_set_animator_Public_set_Void_ValueAnimation_1_StyleValues_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0002C644 File Offset: 0x0002A844
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0002C680 File Offset: 0x0002A880
		public unsafe int index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0002C6C0 File Offset: 0x0002A8C0
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0002C73C File Offset: 0x0002A93C
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0002C778 File Offset: 0x0002A978
		public unsafe bool isDragGhost
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_get_isDragGhost_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_set_isDragGhost_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287321, RefRangeEnd = 287323, XrefRangeStart = 287316, XrefRangeEnd = 287321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onGeometryChanged(Action<ReusableCollectionItem> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_add_onGeometryChanged_Public_add_Void_Action_1_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0002C7FC File Offset: 0x0002A9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287328, RefRangeEnd = 287330, XrefRangeStart = 287323, XrefRangeEnd = 287328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onGeometryChanged(Action<ReusableCollectionItem> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_remove_onGeometryChanged_Public_rem_Void_Action_1_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0002C840 File Offset: 0x0002AA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287335, RefRangeEnd = 287336, XrefRangeStart = 287330, XrefRangeEnd = 287335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onDestroy(Action<ReusableCollectionItem> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_add_onDestroy_Internal_add_Void_Action_1_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0002C884 File Offset: 0x0002AA84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287341, RefRangeEnd = 287342, XrefRangeStart = 287336, XrefRangeEnd = 287341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onDestroy(Action<ReusableCollectionItem> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_remove_onDestroy_Internal_rem_Void_Action_1_ReusableCollectionItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 287350, RefRangeEnd = 287354, XrefRangeStart = 287342, XrefRangeEnd = 287350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableCollectionItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReusableCollectionItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0002C904 File Offset: 0x0002AB04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init(VisualElement item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0002C954 File Offset: 0x0002AB54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287363, RefRangeEnd = 287365, XrefRangeStart = 287354, XrefRangeEnd = 287363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreAttachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0002C990 File Offset: 0x0002AB90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287374, RefRangeEnd = 287376, XrefRangeStart = 287365, XrefRangeEnd = 287374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DetachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		[CallerCount(0)]
		public unsafe virtual void DestroyElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_DestroyElement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0002CA08 File Offset: 0x0002AC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287376, XrefRangeEnd = 287383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSelected(bool selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_SetSelected_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0002CA54 File Offset: 0x0002AC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287397, RefRangeEnd = 287398, XrefRangeStart = 287383, XrefRangeEnd = 287397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDragGhost(bool dragGhost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragGhost;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableCollectionItem.NativeMethodInfoPtr_SetDragGhost_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0002CAA0 File Offset: 0x0002ACA0
		[CallerCount(0)]
		public unsafe void OnGeometryChanged(GeometryChangedEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableCollectionItem.NativeMethodInfoPtr_OnGeometryChanged_Protected_Void_GeometryChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000316A File Offset: 0x0000136A
		public ReusableCollectionItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003173 File Offset: 0x00001373
		public unsafe VisualElement _bindableElement_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__bindableElement_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__bindableElement_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0002CB14 File Offset: 0x0002AD14
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003192 File Offset: 0x00001392
		public unsafe UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> _animator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__animator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__animator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0002CB44 File Offset: 0x0002AD44
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x000031B1 File Offset: 0x000013B1
		public unsafe int _index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0002CB6C File Offset: 0x0002AD6C
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x000031CC File Offset: 0x000013CC
		public unsafe int _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__id_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__id_k__BackingField)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0002CB94 File Offset: 0x0002AD94
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x000031E7 File Offset: 0x000013E7
		public unsafe bool _isDragGhost_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__isDragGhost_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr__isDragGhost_k__BackingField)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0002CBBC File Offset: 0x0002ADBC
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003202 File Offset: 0x00001402
		public unsafe Action<ReusableCollectionItem> onGeometryChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_onGeometryChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReusableCollectionItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_onGeometryChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0002CBEC File Offset: 0x0002ADEC
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003221 File Offset: 0x00001421
		public unsafe EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_m_GeometryChangedEventCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<GeometryChangedEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_m_GeometryChangedEventCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0002CC1C File Offset: 0x0002AE1C
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003240 File Offset: 0x00001440
		public unsafe Action<ReusableCollectionItem> onDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_onDestroy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReusableCollectionItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableCollectionItem.NativeFieldInfoPtr_onDestroy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr__bindableElement_k__BackingField;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr__animator_k__BackingField;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr__isDragGhost_k__BackingField;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_onGeometryChanged;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_m_GeometryChangedEventCallback;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_onDestroy;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_rootElement_Public_Virtual_New_get_VisualElement_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_bindableElement_Public_get_VisualElement_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_set_bindableElement_Protected_set_Void_VisualElement_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_ValueAnimation_1_StyleValues_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_set_animator_Public_set_Void_ValueAnimation_1_StyleValues_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_get_isDragGhost_Internal_get_Boolean_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_set_isDragGhost_Private_set_Void_Boolean_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_add_onGeometryChanged_Public_add_Void_Action_1_ReusableCollectionItem_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_remove_onGeometryChanged_Public_rem_Void_Action_1_ReusableCollectionItem_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_add_onDestroy_Internal_add_Void_Action_1_ReusableCollectionItem_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDestroy_Internal_rem_Void_Action_1_ReusableCollectionItem_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_VisualElement_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_PreAttachElement_Public_Virtual_New_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_DetachElement_Public_Virtual_New_Void_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_DestroyElement_Public_Virtual_New_Void_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_SetDragGhost_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_OnGeometryChanged_Protected_Void_GeometryChangedEvent_0;

		// Token: 0x0400032A RID: 810
		public const int UndefinedIndex = -1;
	}
}
