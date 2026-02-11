using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace lib.canis.menus.ui
{
	// Token: 0x0200000A RID: 10
	public class CustomToggleGroup : UIBehaviour
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000038DC File Offset: 0x00001ADC
		// Note: this type is marked as 'beforefieldinit'.
		static CustomToggleGroup()
		{
			Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "lib.canis.menus.ui", "CustomToggleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr);
			CustomToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "m_AllowSwitchOff");
			CustomToggleGroup.NativeFieldInfoPtr_m_AddAllChildTogglesOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "m_AddAllChildTogglesOnEnable");
			CustomToggleGroup.NativeFieldInfoPtr_toggleRemovers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "toggleRemovers");
			CustomToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663332);
			CustomToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663333);
			CustomToggleGroup.NativeMethodInfoPtr_get_m_Toggles_Private_get_List_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663334);
			CustomToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663335);
			CustomToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663336);
			CustomToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663337);
			CustomToggleGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663338);
			CustomToggleGroup.NativeMethodInfoPtr_SubscribeAndGetRemover_Private_UnityAction_Toggle_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663339);
			CustomToggleGroup.NativeMethodInfoPtr_SubscribeGroupToToggle_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663340);
			CustomToggleGroup.NativeMethodInfoPtr_AddAllChildToggles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663341);
			CustomToggleGroup.NativeMethodInfoPtr_RemoveAllToggles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663342);
			CustomToggleGroup.NativeMethodInfoPtr_AddToggleRange_Public_Void_List_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663343);
			CustomToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663344);
			CustomToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663345);
			CustomToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663346);
			CustomToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663347);
			CustomToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663348);
			CustomToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663349);
			CustomToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663350);
			CustomToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663351);
			CustomToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, 100663352);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003AEC File Offset: 0x00001CEC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003B28 File Offset: 0x00001D28
		public unsafe bool allowSwitchOff
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003B68 File Offset: 0x00001D68
		public unsafe List<Toggle> m_Toggles
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1253603, RefRangeEnd = 1253607, XrefRangeStart = 1253596, XrefRangeEnd = 1253603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_get_m_Toggles_Private_get_List_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Toggle>>(intPtr3) : null;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003BA8 File Offset: 0x00001DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253607, XrefRangeEnd = 1253615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomToggleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253615, XrefRangeEnd = 1253618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003C20 File Offset: 0x00001E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253618, XrefRangeEnd = 1253620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003C5C File Offset: 0x00001E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253620, XrefRangeEnd = 1253622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003C90 File Offset: 0x00001E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253622, XrefRangeEnd = 1253637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction SubscribeAndGetRemover(Toggle toggle, UnityAction<bool> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_SubscribeAndGetRemover_Private_UnityAction_Toggle_UnityAction_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr3) : null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003CF4 File Offset: 0x00001EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253637, XrefRangeEnd = 1253668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeGroupToToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_SubscribeGroupToToggle_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003D38 File Offset: 0x00001F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253675, RefRangeEnd = 1253677, XrefRangeStart = 1253668, XrefRangeEnd = 1253675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAllChildToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_AddAllChildToggles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003D6C File Offset: 0x00001F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253712, RefRangeEnd = 1253713, XrefRangeStart = 1253677, XrefRangeEnd = 1253712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_RemoveAllToggles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253713, XrefRangeEnd = 1253728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToggleRange(List<Toggle> newToggles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newToggles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_AddToggleRange_Public_Void_List_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003DE4 File Offset: 0x00001FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253728, XrefRangeEnd = 1253741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateToggleIsInGroup(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003E28 File Offset: 0x00002028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253784, RefRangeEnd = 1253786, XrefRangeStart = 1253741, XrefRangeEnd = 1253784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003E78 File Offset: 0x00002078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253786, XrefRangeEnd = 1253805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003EBC File Offset: 0x000020BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253844, RefRangeEnd = 1253846, XrefRangeStart = 1253805, XrefRangeEnd = 1253844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003F00 File Offset: 0x00002100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253918, RefRangeEnd = 1253920, XrefRangeStart = 1253846, XrefRangeEnd = 1253918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003F34 File Offset: 0x00002134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253920, XrefRangeEnd = 1253949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyTogglesOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003F70 File Offset: 0x00002170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1253974, RefRangeEnd = 1253977, XrefRangeStart = 1253949, XrefRangeEnd = 1253974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Toggle> ActiveToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Toggle>>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003FB0 File Offset: 0x000021B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253977, XrefRangeEnd = 1253984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle GetFirstActiveToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003FF0 File Offset: 0x000021F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253984, XrefRangeEnd = 1254018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllTogglesOff(bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sendCallback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000221A File Offset: 0x0000041A
		public CustomToggleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004030 File Offset: 0x00002230
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002223 File Offset: 0x00000423
		public unsafe bool m_AllowSwitchOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004058 File Offset: 0x00002258
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000223E File Offset: 0x0000043E
		public unsafe bool m_AddAllChildTogglesOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_m_AddAllChildTogglesOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_m_AddAllChildTogglesOnEnable)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004080 File Offset: 0x00002280
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002259 File Offset: 0x00000459
		public unsafe Dictionary<Toggle, Delegate> toggleRemovers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_toggleRemovers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Toggle, Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.NativeFieldInfoPtr_toggleRemovers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowSwitchOff;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_m_AddAllChildTogglesOnEnable;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_toggleRemovers;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_m_Toggles_Private_get_List_1_Toggle_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeAndGetRemover_Private_UnityAction_Toggle_UnityAction_1_Boolean_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeGroupToToggle_Private_Void_Toggle_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_AddAllChildToggles_Public_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllToggles_Public_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_AddToggleRange_Public_Void_List_1_Toggle_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidState_Public_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0;

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("lib.canis.menus.ui.CustomToggleGroup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000152 RID: 338 RVA: 0x00006EB0 File Offset: 0x000050B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr);
				CustomToggleGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, "<>9");
				CustomToggleGroup.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, "<>9__22_0");
				CustomToggleGroup.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, "<>9__23_0");
				CustomToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, 100663354);
				CustomToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__22_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, 100663355);
				CustomToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__23_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr, 100663356);
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00006F54 File Offset: 0x00005154
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomToggleGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x00006F90 File Offset: 0x00005190
			[CallerCount(0)]
			public unsafe bool _AnyTogglesOn_b__22_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__22_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00006FE0 File Offset: 0x000051E0
			[CallerCount(0)]
			public unsafe bool _ActiveToggles_b__23_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__23_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000156 RID: 342 RVA: 0x000029D3 File Offset: 0x00000BD3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00007030 File Offset: 0x00005230
			// (set) Token: 0x06000158 RID: 344 RVA: 0x000029DC File Offset: 0x00000BDC
			public unsafe static CustomToggleGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomToggleGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000159 RID: 345 RVA: 0x00007058 File Offset: 0x00005258
			// (set) Token: 0x0600015A RID: 346 RVA: 0x000029EE File Offset: 0x00000BEE
			public unsafe static Predicate<Toggle> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600015B RID: 347 RVA: 0x00007080 File Offset: 0x00005280
			// (set) Token: 0x0600015C RID: 348 RVA: 0x00002A00 File Offset: 0x00000C00
			public unsafe static Func<Toggle, bool> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Toggle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CustomToggleGroup.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x040000D1 RID: 209
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040000D2 RID: 210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000D3 RID: 211
			private static readonly IntPtr NativeMethodInfoPtr__AnyTogglesOn_b__22_0_Internal_Boolean_Toggle_0;

			// Token: 0x040000D4 RID: 212
			private static readonly IntPtr NativeMethodInfoPtr__ActiveToggles_b__23_0_Internal_Boolean_Toggle_0;
		}

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("lib.canis.menus.ui.CustomToggleGroup+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600015D RID: 349 RVA: 0x000070A8 File Offset: 0x000052A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr);
				CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr, "toggle");
				CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr, "action");
				CustomToggleGroup.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr, 100663357);
				CustomToggleGroup.__c__DisplayClass12_0.NativeMethodInfoPtr__SubscribeAndGetRemover_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr, 100663358);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00007124 File Offset: 0x00005324
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00007160 File Offset: 0x00005360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253591, XrefRangeEnd = 1253595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SubscribeAndGetRemover_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c__DisplayClass12_0.NativeMethodInfoPtr__SubscribeAndGetRemover_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00002A12 File Offset: 0x00000C12
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000161 RID: 353 RVA: 0x00007194 File Offset: 0x00005394
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00002A1B File Offset: 0x00000C1B
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000163 RID: 355 RVA: 0x000071C4 File Offset: 0x000053C4
			// (set) Token: 0x06000164 RID: 356 RVA: 0x00002A3A File Offset: 0x00000C3A
			public unsafe UnityAction<bool> action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass12_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D5 RID: 213
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x040000D6 RID: 214
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040000D7 RID: 215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeMethodInfoPtr__SubscribeAndGetRemover_b__0_Internal_Void_0;
		}

		// Token: 0x02000023 RID: 35
		[ObfuscatedName("lib.canis.menus.ui.CustomToggleGroup+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06000165 RID: 357 RVA: 0x000071F4 File Offset: 0x000053F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomToggleGroup>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr);
				CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr, "toggle");
				CustomToggleGroup.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr, 100663359);
				CustomToggleGroup.__c__DisplayClass13_0.NativeMethodInfoPtr__SubscribeGroupToToggle_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr, 100663360);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00007270 File Offset: 0x00005470
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomToggleGroup.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000072AC File Offset: 0x000054AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253595, XrefRangeEnd = 1253596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SubscribeGroupToToggle_b__0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomToggleGroup.__c__DisplayClass13_0.NativeMethodInfoPtr__SubscribeGroupToToggle_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000168 RID: 360 RVA: 0x00002A59 File Offset: 0x00000C59
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000169 RID: 361 RVA: 0x000072EC File Offset: 0x000054EC
			// (set) Token: 0x0600016A RID: 362 RVA: 0x00002A62 File Offset: 0x00000C62
			public unsafe CustomToggleGroup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomToggleGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600016B RID: 363 RVA: 0x0000731C File Offset: 0x0000551C
			// (set) Token: 0x0600016C RID: 364 RVA: 0x00002A81 File Offset: 0x00000C81
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomToggleGroup.__c__DisplayClass13_0.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr__SubscribeGroupToToggle_b__0_Internal_Void_Boolean_0;
		}
	}
}
