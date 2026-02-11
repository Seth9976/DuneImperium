using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace InControl
{
	// Token: 0x0200001B RID: 27
	public class PlayerActionSet : Object
	{
		// Token: 0x0600016C RID: 364 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerActionSet()
		{
			Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "PlayerActionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr);
			PlayerActionSet.NativeFieldInfoPtr__Device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<Device>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__IncludeDevices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<IncludeDevices>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__ExcludeDevices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<ExcludeDevices>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__Actions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<Actions>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__UpdateTick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<UpdateTick>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr_LastInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "LastInputType");
			PlayerActionSet.NativeFieldInfoPtr_OnLastInputTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "OnLastInputTypeChanged");
			PlayerActionSet.NativeFieldInfoPtr_LastInputTypeChangedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "LastInputTypeChangedTick");
			PlayerActionSet.NativeFieldInfoPtr_LastDeviceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "LastDeviceClass");
			PlayerActionSet.NativeFieldInfoPtr_LastDeviceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "LastDeviceStyle");
			PlayerActionSet.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<Enabled>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__PreventInputWhileListeningForBinding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<PreventInputWhileListeningForBinding>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr__UserData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "<UserData>k__BackingField");
			PlayerActionSet.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "actions");
			PlayerActionSet.NativeFieldInfoPtr_oneAxisActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "oneAxisActions");
			PlayerActionSet.NativeFieldInfoPtr_twoAxisActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "twoAxisActions");
			PlayerActionSet.NativeFieldInfoPtr_actionsByName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "actionsByName");
			PlayerActionSet.NativeFieldInfoPtr_listenOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "listenOptions");
			PlayerActionSet.NativeFieldInfoPtr_listenWithAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "listenWithAction");
			PlayerActionSet.NativeFieldInfoPtr_activeDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "activeDevice");
			PlayerActionSet.NativeFieldInfoPtr_currentDataFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, "currentDataFormatVersion");
			PlayerActionSet.NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663514);
			PlayerActionSet.NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663515);
			PlayerActionSet.NativeMethodInfoPtr_get_IncludeDevices_Public_get_List_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663516);
			PlayerActionSet.NativeMethodInfoPtr_set_IncludeDevices_Private_set_Void_List_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663517);
			PlayerActionSet.NativeMethodInfoPtr_get_ExcludeDevices_Public_get_List_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663518);
			PlayerActionSet.NativeMethodInfoPtr_set_ExcludeDevices_Private_set_Void_List_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663519);
			PlayerActionSet.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663520);
			PlayerActionSet.NativeMethodInfoPtr_set_Actions_Private_set_Void_ReadOnlyCollection_1_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663521);
			PlayerActionSet.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663522);
			PlayerActionSet.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663523);
			PlayerActionSet.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663524);
			PlayerActionSet.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663525);
			PlayerActionSet.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663526);
			PlayerActionSet.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663527);
			PlayerActionSet.NativeMethodInfoPtr_get_PreventInputWhileListeningForBinding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663528);
			PlayerActionSet.NativeMethodInfoPtr_set_PreventInputWhileListeningForBinding_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663529);
			PlayerActionSet.NativeMethodInfoPtr_get_UserData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663530);
			PlayerActionSet.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663531);
			PlayerActionSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663532);
			PlayerActionSet.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663533);
			PlayerActionSet.NativeMethodInfoPtr_CreatePlayerAction_Protected_PlayerAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663534);
			PlayerActionSet.NativeMethodInfoPtr_AddPlayerAction_Internal_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663535);
			PlayerActionSet.NativeMethodInfoPtr_CreateOneAxisPlayerAction_Protected_PlayerOneAxisAction_PlayerAction_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663536);
			PlayerActionSet.NativeMethodInfoPtr_CreateTwoAxisPlayerAction_Protected_PlayerTwoAxisAction_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663537);
			PlayerActionSet.NativeMethodInfoPtr_get_Item_Public_get_PlayerAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663538);
			PlayerActionSet.NativeMethodInfoPtr_GetPlayerActionByName_Public_PlayerAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663539);
			PlayerActionSet.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663540);
			PlayerActionSet.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663541);
			PlayerActionSet.NativeMethodInfoPtr_FindActiveDevice_Private_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663542);
			PlayerActionSet.NativeMethodInfoPtr_ClearInputState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663543);
			PlayerActionSet.NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663544);
			PlayerActionSet.NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663545);
			PlayerActionSet.NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663546);
			PlayerActionSet.NativeMethodInfoPtr_get_ListenOptions_Public_get_BindingListenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663547);
			PlayerActionSet.NativeMethodInfoPtr_set_ListenOptions_Public_set_Void_BindingListenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663548);
			PlayerActionSet.NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663549);
			PlayerActionSet.NativeMethodInfoPtr_SaveData_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663550);
			PlayerActionSet.NativeMethodInfoPtr_LoadData_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663551);
			PlayerActionSet.NativeMethodInfoPtr_Save_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663552);
			PlayerActionSet.NativeMethodInfoPtr_Load_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr, 100663553);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		public unsafe InputDevice Device
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000D43C File Offset: 0x0000B63C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000D47C File Offset: 0x0000B67C
		public unsafe List<InputDevice> IncludeDevices
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_IncludeDevices_Public_get_List_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_IncludeDevices_Private_set_Void_List_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000D500 File Offset: 0x0000B700
		public unsafe List<InputDevice> ExcludeDevices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_ExcludeDevices_Public_get_List_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_ExcludeDevices_Private_set_Void_List_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000D544 File Offset: 0x0000B744
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000D584 File Offset: 0x0000B784
		public unsafe ReadOnlyCollection<PlayerAction> Actions
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PlayerAction>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_Actions_Private_set_Void_ReadOnlyCollection_1_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000D604 File Offset: 0x0000B804
		public unsafe ulong UpdateTick
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000D644 File Offset: 0x0000B844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768474, XrefRangeEnd = 768479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000D688 File Offset: 0x0000B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768479, XrefRangeEnd = 768484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000D708 File Offset: 0x0000B908
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000D748 File Offset: 0x0000B948
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000D784 File Offset: 0x0000B984
		public unsafe bool PreventInputWhileListeningForBinding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_PreventInputWhileListeningForBinding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_PreventInputWhileListeningForBinding_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000D804 File Offset: 0x0000BA04
		public unsafe Object UserData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_UserData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000D848 File Offset: 0x0000BA48
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 768542, RefRangeEnd = 768552, XrefRangeStart = 768484, XrefRangeEnd = 768542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerActionSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActionSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000D884 File Offset: 0x0000BA84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 768557, RefRangeEnd = 768563, XrefRangeStart = 768552, XrefRangeEnd = 768557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 768567, RefRangeEnd = 768614, XrefRangeStart = 768563, XrefRangeEnd = 768567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAction CreatePlayerAction(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_CreatePlayerAction_Protected_PlayerAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000D908 File Offset: 0x0000BB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768640, RefRangeEnd = 768641, XrefRangeStart = 768614, XrefRangeEnd = 768640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerAction(PlayerAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_AddPlayerAction_Internal_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000D94C File Offset: 0x0000BB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768641, XrefRangeEnd = 768652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(negativeAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positiveAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_CreateOneAxisPlayerAction_Protected_PlayerOneAxisAction_PlayerAction_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerOneAxisAction>(intPtr3) : null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 768668, RefRangeEnd = 768675, XrefRangeStart = 768652, XrefRangeEnd = 768668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(negativeXAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positiveXAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(negativeYAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positiveYAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_CreateTwoAxisPlayerAction_Protected_PlayerTwoAxisAction_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr3) : null;
		}

		// Token: 0x17000096 RID: 150
		public unsafe PlayerAction this[string actionName]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768675, XrefRangeEnd = 768678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_Item_Public_get_PlayerAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 768681, RefRangeEnd = 768692, XrefRangeStart = 768678, XrefRangeEnd = 768681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAction GetPlayerActionByName(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_GetPlayerActionByName_Public_PlayerAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768720, RefRangeEnd = 768722, XrefRangeStart = 768692, XrefRangeEnd = 768720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000DB24 File Offset: 0x0000BD24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 768738, RefRangeEnd = 768742, XrefRangeStart = 768722, XrefRangeEnd = 768738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000DB58 File Offset: 0x0000BD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768751, RefRangeEnd = 768753, XrefRangeStart = 768742, XrefRangeEnd = 768751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDevice FindActiveDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_FindActiveDevice_Private_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000DB98 File Offset: 0x0000BD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768766, RefRangeEnd = 768767, XrefRangeStart = 768753, XrefRangeEnd = 768766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_ClearInputState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768767, XrefRangeEnd = 768772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768772, XrefRangeEnd = 768783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public unsafe bool IsListeningForBinding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000DC9C File Offset: 0x0000BE9C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000DCDC File Offset: 0x0000BEDC
		public unsafe BindingListenOptions ListenOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_ListenOptions_Public_get_BindingListenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingListenOptions>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768783, XrefRangeEnd = 768789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_set_ListenOptions_Public_set_Void_BindingListenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public unsafe InputDevice ActiveDevice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768789, XrefRangeEnd = 768793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000DD60 File Offset: 0x0000BF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768819, RefRangeEnd = 768820, XrefRangeStart = 768793, XrefRangeEnd = 768819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> SaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_SaveData_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768846, RefRangeEnd = 768847, XrefRangeStart = 768820, XrefRangeEnd = 768846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadData(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_LoadData_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768852, RefRangeEnd = 768854, XrefRangeStart = 768847, XrefRangeEnd = 768852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_Save_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000DE1C File Offset: 0x0000C01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768864, RefRangeEnd = 768865, XrefRangeStart = 768854, XrefRangeEnd = 768864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActionSet.NativeMethodInfoPtr_Load_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002733 File Offset: 0x00000933
		public PlayerActionSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000DE60 File Offset: 0x0000C060
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000273C File Offset: 0x0000093C
		public unsafe InputDevice _Device_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Device_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Device_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000DE90 File Offset: 0x0000C090
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000275B File Offset: 0x0000095B
		public unsafe List<InputDevice> _IncludeDevices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__IncludeDevices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__IncludeDevices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000277A File Offset: 0x0000097A
		public unsafe List<InputDevice> _ExcludeDevices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__ExcludeDevices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__ExcludeDevices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002799 File Offset: 0x00000999
		public unsafe ReadOnlyCollection<PlayerAction> _Actions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Actions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<PlayerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Actions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000DF20 File Offset: 0x0000C120
		// (set) Token: 0x0600019F RID: 415 RVA: 0x000027B8 File Offset: 0x000009B8
		public unsafe ulong _UpdateTick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__UpdateTick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__UpdateTick_k__BackingField)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000DF48 File Offset: 0x0000C148
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000027D3 File Offset: 0x000009D3
		public unsafe BindingSourceType LastInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastInputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastInputType)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000DF70 File Offset: 0x0000C170
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000027EE File Offset: 0x000009EE
		public unsafe Action<BindingSourceType> OnLastInputTypeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_OnLastInputTypeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BindingSourceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_OnLastInputTypeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000280D File Offset: 0x00000A0D
		public unsafe ulong LastInputTypeChangedTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastInputTypeChangedTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastInputTypeChangedTick)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002828 File Offset: 0x00000A28
		public unsafe InputDeviceClass LastDeviceClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastDeviceClass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastDeviceClass)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002843 File Offset: 0x00000A43
		public unsafe InputDeviceStyle LastDeviceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastDeviceStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_LastDeviceStyle)) = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000E018 File Offset: 0x0000C218
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002879 File Offset: 0x00000A79
		public unsafe bool _PreventInputWhileListeningForBinding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__PreventInputWhileListeningForBinding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__PreventInputWhileListeningForBinding_k__BackingField)) = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000E068 File Offset: 0x0000C268
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002894 File Offset: 0x00000A94
		public unsafe Object _UserData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__UserData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr__UserData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000E098 File Offset: 0x0000C298
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000028B3 File Offset: 0x00000AB3
		public unsafe List<PlayerAction> actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000028D2 File Offset: 0x00000AD2
		public unsafe List<PlayerOneAxisAction> oneAxisActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_oneAxisActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerOneAxisAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_oneAxisActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x000028F1 File Offset: 0x00000AF1
		public unsafe List<PlayerTwoAxisAction> twoAxisActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_twoAxisActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerTwoAxisAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_twoAxisActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000E128 File Offset: 0x0000C328
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002910 File Offset: 0x00000B10
		public unsafe Dictionary<string, PlayerAction> actionsByName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_actionsByName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayerAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_actionsByName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000E158 File Offset: 0x0000C358
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000292F File Offset: 0x00000B2F
		public unsafe BindingListenOptions listenOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_listenOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingListenOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_listenOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000E188 File Offset: 0x0000C388
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000294E File Offset: 0x00000B4E
		public unsafe PlayerAction listenWithAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_listenWithAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_listenWithAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000296D File Offset: 0x00000B6D
		public unsafe InputDevice activeDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_activeDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActionSet.NativeFieldInfoPtr_activeDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0000298C File Offset: 0x00000B8C
		public unsafe static ushort currentDataFormatVersion
		{
			get
			{
				ushort num;
				IL2CPP.il2cpp_field_static_get_value(PlayerActionSet.NativeFieldInfoPtr_currentDataFormatVersion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerActionSet.NativeFieldInfoPtr_currentDataFormatVersion, (void*)(&value));
			}
		}

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr__Device_k__BackingField;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr__IncludeDevices_k__BackingField;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr__ExcludeDevices_k__BackingField;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr__Actions_k__BackingField;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr__UpdateTick_k__BackingField;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_LastInputType;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_OnLastInputTypeChanged;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_LastInputTypeChangedTick;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_LastDeviceClass;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_LastDeviceStyle;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr__PreventInputWhileListeningForBinding_k__BackingField;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr__UserData_k__BackingField;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_oneAxisActions;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_twoAxisActions;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_actionsByName;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_listenOptions;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_listenWithAction;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_activeDevice;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_currentDataFormatVersion;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Public_get_InputDevice_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_set_Device_Public_set_Void_InputDevice_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeDevices_Public_get_List_1_InputDevice_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeDevices_Private_set_Void_List_1_InputDevice_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_get_ExcludeDevices_Public_get_List_1_InputDevice_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_set_ExcludeDevices_Private_set_Void_List_1_InputDevice_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_get_Actions_Public_get_ReadOnlyCollection_1_PlayerAction_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_set_Actions_Private_set_Void_ReadOnlyCollection_1_PlayerAction_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_PreventInputWhileListeningForBinding_Public_get_Boolean_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_set_PreventInputWhileListeningForBinding_Public_set_Void_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Object_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayerAction_Protected_PlayerAction_String_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerAction_Internal_Void_PlayerAction_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_CreateOneAxisPlayerAction_Protected_PlayerOneAxisAction_PlayerAction_PlayerAction_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_CreateTwoAxisPlayerAction_Protected_PlayerTwoAxisAction_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_PlayerAction_String_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerActionByName_Public_PlayerAction_String_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_FindActiveDevice_Private_InputDevice_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Void_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_get_ListenOptions_Public_get_BindingListenOptions_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_set_ListenOptions_Public_set_Void_BindingListenOptions_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_SaveData_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_String_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_String_0;
	}
}
