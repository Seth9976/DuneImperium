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
	// Token: 0x020000FE RID: 254
	public class RendererManager : MonoBehaviour
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0004E914 File Offset: 0x0004CB14
		// Note: this type is marked as 'beforefieldinit'.
		static RendererManager()
		{
			Il2CppClassPointerStore<RendererManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement", "RendererManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererManager>.NativeClassPtr);
			RendererManager.NativeFieldInfoPtr__PrefabProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "<PrefabProvider>k__BackingField");
			RendererManager.NativeFieldInfoPtr__ConfigFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "<ConfigFactory>k__BackingField");
			RendererManager.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "<Initialized>k__BackingField");
			RendererManager.NativeFieldInfoPtr_dataToConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "dataToConfig");
			RendererManager.NativeFieldInfoPtr_requesterMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "requesterMap");
			RendererManager.NativeFieldInfoPtr_layers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "layers");
			RendererManager.NativeFieldInfoPtr_gettingCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "gettingCards");
			RendererManager.NativeMethodInfoPtr_get_PrefabProvider_Public_get_IRenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665448);
			RendererManager.NativeMethodInfoPtr_set_PrefabProvider_Private_set_Void_IRenderProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665449);
			RendererManager.NativeMethodInfoPtr_get_ConfigFactory_Public_get_IConfigurationFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665450);
			RendererManager.NativeMethodInfoPtr_set_ConfigFactory_Private_set_Void_IConfigurationFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665451);
			RendererManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665452);
			RendererManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665453);
			RendererManager.NativeMethodInfoPtr_Get_Public_Static_RendererManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665454);
			RendererManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665455);
			RendererManager.NativeMethodInfoPtr_Register_Public_Void_IRenderRequester_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665456);
			RendererManager.NativeMethodInfoPtr_Unregister_Public_Void_IRenderRequester_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665457);
			RendererManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665458);
			RendererManager.NativeMethodInfoPtr_GetCards_Public_Dictionary_2_DataComposition_VisibilityConfiguration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665459);
			RendererManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665460);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0004EAD4 File Offset: 0x0004CCD4
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x0004EB14 File Offset: 0x0004CD14
		public unsafe IRenderProvider PrefabProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_get_PrefabProvider_Public_get_IRenderProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRenderProvider>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_set_PrefabProvider_Private_set_Void_IRenderProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0004EB58 File Offset: 0x0004CD58
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x0004EB98 File Offset: 0x0004CD98
		public unsafe IConfigurationFactory ConfigFactory
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_get_ConfigFactory_Public_get_IConfigurationFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurationFactory>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_set_ConfigFactory_Private_set_Void_IConfigurationFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004EBDC File Offset: 0x0004CDDC
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0004EC18 File Offset: 0x0004CE18
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0004EC58 File Offset: 0x0004CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867771, XrefRangeEnd = 867774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RendererManager Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_Get_Public_Static_RendererManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RendererManager>(intPtr3) : null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867774, XrefRangeEnd = 867787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0004ECC0 File Offset: 0x0004CEC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 867823, RefRangeEnd = 867825, XrefRangeStart = 867787, XrefRangeEnd = 867823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(IRenderRequester area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_Register_Public_Void_IRenderRequester_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0004ED04 File Offset: 0x0004CF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867825, XrefRangeEnd = 867845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister(IRenderRequester area)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(area);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_Unregister_Public_Void_IRenderRequester_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0004ED48 File Offset: 0x0004CF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867845, XrefRangeEnd = 867850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0004ED7C File Offset: 0x0004CF7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867883, RefRangeEnd = 867884, XrefRangeStart = 867850, XrefRangeEnd = 867883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<DataComposition, VisibilityConfiguration> GetCards(int maxLayer = 2147483647)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr_GetCards_Public_Dictionary_2_DataComposition_VisibilityConfiguration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<DataComposition, VisibilityConfiguration>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867884, XrefRangeEnd = 867906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0000702A File Offset: 0x0000522A
		public RendererManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0004EE04 File Offset: 0x0004D004
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00007033 File Offset: 0x00005233
		public unsafe IRenderProvider _PrefabProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__PrefabProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRenderProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__PrefabProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0004EE34 File Offset: 0x0004D034
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00007052 File Offset: 0x00005252
		public unsafe IConfigurationFactory _ConfigFactory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__ConfigFactory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurationFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__ConfigFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0004EE64 File Offset: 0x0004D064
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00007071 File Offset: 0x00005271
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0004EE8C File Offset: 0x0004D08C
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x0000708C File Offset: 0x0000528C
		public unsafe Dictionary<DataComposition, VisibilityConfiguration> dataToConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_dataToConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DataComposition, VisibilityConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_dataToConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0004EEBC File Offset: 0x0004D0BC
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x000070AB File Offset: 0x000052AB
		public unsafe Dictionary<int, List<IRenderRequester>> requesterMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_requesterMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<IRenderRequester>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_requesterMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0004EEEC File Offset: 0x0004D0EC
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x000070CA File Offset: 0x000052CA
		public unsafe List<int> layers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_layers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_layers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0004EF1C File Offset: 0x0004D11C
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x000070E9 File Offset: 0x000052E9
		public unsafe bool gettingCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_gettingCards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererManager.NativeFieldInfoPtr_gettingCards)) = value;
			}
		}

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr__PrefabProvider_k__BackingField;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr__ConfigFactory_k__BackingField;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr_dataToConfig;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_requesterMap;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_layers;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_gettingCards;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabProvider_Public_get_IRenderProvider_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_set_PrefabProvider_Private_set_Void_IRenderProvider_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigFactory_Public_get_IConfigurationFactory_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_set_ConfigFactory_Private_set_Void_IConfigurationFactory_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_RendererManager_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_IRenderRequester_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_IRenderRequester_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_GetCards_Public_Dictionary_2_DataComposition_VisibilityConfiguration_Int32_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
