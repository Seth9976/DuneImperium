using System;
using dwd.core.data.composition;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.rendererManagement
{
	// Token: 0x020000FF RID: 255
	public class RenderRequester : MonoBehaviour
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0004EF44 File Offset: 0x0004D144
		// Note: this type is marked as 'beforefieldinit'.
		static RenderRequester()
		{
			Il2CppClassPointerStore<RenderRequester>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement", "RenderRequester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr);
			RenderRequester.NativeFieldInfoPtr__registered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, "<registered>k__BackingField");
			RenderRequester.NativeFieldInfoPtr__manager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, "<manager>k__BackingField");
			RenderRequester.NativeFieldInfoPtr_configFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, "configFactory");
			RenderRequester.NativeMethodInfoPtr_get_registered_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665461);
			RenderRequester.NativeMethodInfoPtr_set_registered_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665462);
			RenderRequester.NativeMethodInfoPtr_get_manager_Protected_get_RendererManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665463);
			RenderRequester.NativeMethodInfoPtr_set_manager_Private_set_Void_RendererManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665464);
			RenderRequester.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665465);
			RenderRequester.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665466);
			RenderRequester.NativeMethodInfoPtr_register_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665467);
			RenderRequester.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665468);
			RenderRequester.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665469);
			RenderRequester.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665470);
			RenderRequester.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665471);
			RenderRequester.NativeMethodInfoPtr_UpdateCards_Public_Virtual_Final_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665472);
			RenderRequester.NativeMethodInfoPtr_updateCards_Protected_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665473);
			RenderRequester.NativeMethodInfoPtr_getConfig_Protected_VisibilityConfiguration_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665474);
			RenderRequester.NativeMethodInfoPtr_setVisibility_Protected_Void_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_GlobalTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665475);
			RenderRequester.NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665476);
			RenderRequester.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr, 100665477);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0004F104 File Offset: 0x0004D304
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x0004F140 File Offset: 0x0004D340
		public unsafe bool registered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_get_registered_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_set_registered_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x0004F180 File Offset: 0x0004D380
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0004F1C0 File Offset: 0x0004D3C0
		public unsafe RendererManager manager
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_get_manager_Protected_get_RendererManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RendererManager>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_set_manager_Private_set_Void_RendererManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0004F204 File Offset: 0x0004D404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0004F238 File Offset: 0x0004D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867906, XrefRangeEnd = 867913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0004F26C File Offset: 0x0004D46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867913, XrefRangeEnd = 867919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void register()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_register_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0004F2A0 File Offset: 0x0004D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867919, XrefRangeEnd = 867945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0004F2D4 File Offset: 0x0004D4D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderRequester.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0004F310 File Offset: 0x0004D510
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderRequester.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0004F34C File Offset: 0x0004D54C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderRequester.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0004F388 File Offset: 0x0004D588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867945, XrefRangeEnd = 867948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCards(Dictionary<DataComposition, VisibilityConfiguration> cards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_UpdateCards_Public_Virtual_Final_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0004F3CC File Offset: 0x0004D5CC
		[CallerCount(0)]
		public unsafe virtual void updateCards(Dictionary<DataComposition, VisibilityConfiguration> cards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderRequester.NativeMethodInfoPtr_updateCards_Protected_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0004F41C File Offset: 0x0004D61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867956, RefRangeEnd = 867957, XrefRangeStart = 867948, XrefRangeEnd = 867956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityConfiguration getConfig(IDictionary<DataComposition, VisibilityConfiguration> cards, DataComposition card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_getConfig_Protected_VisibilityConfiguration_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityConfiguration>(intPtr3) : null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0004F480 File Offset: 0x0004D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867957, XrefRangeEnd = 867958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setVisibility(IDictionary<DataComposition, VisibilityConfiguration> cards, DataComposition card, GlobalTransform transform, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr_setVisibility_Protected_Void_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_GlobalTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0004F4F0 File Offset: 0x0004D6F0
		public unsafe virtual int Layer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderRequester.NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0004F538 File Offset: 0x0004D738
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderRequester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderRequester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderRequester.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00007104 File Offset: 0x00005304
		public RenderRequester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0004F574 File Offset: 0x0004D774
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0000710D File Offset: 0x0000530D
		public unsafe bool _registered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr__registered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr__registered_k__BackingField)) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0004F59C File Offset: 0x0004D79C
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00007128 File Offset: 0x00005328
		public unsafe RendererManager _manager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr__manager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RendererManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr__manager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0004F5CC File Offset: 0x0004D7CC
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00007147 File Offset: 0x00005347
		public unsafe IConfigurationFactory configFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr_configFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurationFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderRequester.NativeFieldInfoPtr_configFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeFieldInfoPtr__registered_k__BackingField;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr__manager_k__BackingField;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr_configFactory;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_get_registered_Protected_get_Boolean_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_set_registered_Private_set_Void_Boolean_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_manager_Protected_get_RendererManager_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_set_manager_Private_set_Void_RendererManager_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_register_Protected_Void_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCards_Public_Virtual_Final_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_updateCards_Protected_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_getConfig_Protected_VisibilityConfiguration_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_setVisibility_Protected_Void_IDictionary_2_DataComposition_VisibilityConfiguration_DataComposition_GlobalTransform_Boolean_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
