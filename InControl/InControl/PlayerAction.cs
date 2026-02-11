using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.IO;

namespace InControl
{
	// Token: 0x0200001A RID: 26
	public class PlayerAction : OneAxisInputControl
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000B86C File Offset: 0x00009A6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerAction()
		{
			Il2CppClassPointerStore<PlayerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "PlayerAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr);
			PlayerAction.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "<Name>k__BackingField");
			PlayerAction.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "<Owner>k__BackingField");
			PlayerAction.NativeFieldInfoPtr_ListenOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "ListenOptions");
			PlayerAction.NativeFieldInfoPtr_LastInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "LastInputType");
			PlayerAction.NativeFieldInfoPtr_OnLastInputTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "OnLastInputTypeChanged");
			PlayerAction.NativeFieldInfoPtr_LastInputTypeChangedTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "LastInputTypeChangedTick");
			PlayerAction.NativeFieldInfoPtr_LastDeviceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "LastDeviceClass");
			PlayerAction.NativeFieldInfoPtr_LastDeviceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "LastDeviceStyle");
			PlayerAction.NativeFieldInfoPtr_OnBindingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "OnBindingsChanged");
			PlayerAction.NativeFieldInfoPtr__UserData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "<UserData>k__BackingField");
			PlayerAction.NativeFieldInfoPtr_defaultBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "defaultBindings");
			PlayerAction.NativeFieldInfoPtr_regularBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "regularBindings");
			PlayerAction.NativeFieldInfoPtr_visibleBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "visibleBindings");
			PlayerAction.NativeFieldInfoPtr_bindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "bindings");
			PlayerAction.NativeFieldInfoPtr_unfilteredBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "unfilteredBindings");
			PlayerAction.NativeFieldInfoPtr_bindingSourceListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "bindingSourceListeners");
			PlayerAction.NativeFieldInfoPtr_triggerBindingEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "triggerBindingEnded");
			PlayerAction.NativeFieldInfoPtr_triggerBindingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "triggerBindingChanged");
			PlayerAction.NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "device");
			PlayerAction.NativeFieldInfoPtr_activeDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, "activeDevice");
			PlayerAction.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663464);
			PlayerAction.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663465);
			PlayerAction.NativeMethodInfoPtr_get_Owner_Public_get_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663466);
			PlayerAction.NativeMethodInfoPtr_set_Owner_Private_set_Void_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663467);
			PlayerAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663468);
			PlayerAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663469);
			PlayerAction.NativeMethodInfoPtr_add_OnBindingsChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663470);
			PlayerAction.NativeMethodInfoPtr_remove_OnBindingsChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663471);
			PlayerAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663472);
			PlayerAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663473);
			PlayerAction.NativeMethodInfoPtr__ctor_Public_Void_String_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663474);
			PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663475);
			PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663476);
			PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_KeyCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663477);
			PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663478);
			PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663479);
			PlayerAction.NativeMethodInfoPtr_AddBinding_Public_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663480);
			PlayerAction.NativeMethodInfoPtr_InsertBindingAt_Public_Boolean_Int32_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663481);
			PlayerAction.NativeMethodInfoPtr_ReplaceBinding_Public_Boolean_BindingSource_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663482);
			PlayerAction.NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663483);
			PlayerAction.NativeMethodInfoPtr_FindBinding_Public_BindingSource_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663484);
			PlayerAction.NativeMethodInfoPtr_HardRemoveBinding_Private_Void_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663485);
			PlayerAction.NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663486);
			PlayerAction.NativeMethodInfoPtr_RemoveBindingAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663487);
			PlayerAction.NativeMethodInfoPtr_CountBindingsOfType_Private_Int32_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663488);
			PlayerAction.NativeMethodInfoPtr_RemoveFirstBindingOfType_Private_Void_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663489);
			PlayerAction.NativeMethodInfoPtr_IndexOfFirstInvalidBinding_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663490);
			PlayerAction.NativeMethodInfoPtr_ClearBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663491);
			PlayerAction.NativeMethodInfoPtr_ResetBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663492);
			PlayerAction.NativeMethodInfoPtr_ListenForBinding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663493);
			PlayerAction.NativeMethodInfoPtr_ListenForBindingReplacing_Public_Void_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663494);
			PlayerAction.NativeMethodInfoPtr_StopListeningForBinding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663495);
			PlayerAction.NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663496);
			PlayerAction.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663497);
			PlayerAction.NativeMethodInfoPtr_get_UnfilteredBindings_Public_get_ReadOnlyCollection_1_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663498);
			PlayerAction.NativeMethodInfoPtr_RemoveOrphanedBindings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663499);
			PlayerAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663500);
			PlayerAction.NativeMethodInfoPtr_UpdateBindings_Private_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663501);
			PlayerAction.NativeMethodInfoPtr_DetectBindings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663502);
			PlayerAction.NativeMethodInfoPtr_UpdateVisibleBindings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663503);
			PlayerAction.NativeMethodInfoPtr_get_Device_Internal_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663504);
			PlayerAction.NativeMethodInfoPtr_set_Device_Internal_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663505);
			PlayerAction.NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663506);
			PlayerAction.NativeMethodInfoPtr_get_LastInputTypeIsDevice_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663507);
			PlayerAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663508);
			PlayerAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663509);
			PlayerAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663510);
			PlayerAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663511);
			PlayerAction.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663512);
			PlayerAction.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr, 100663513);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000BE14 File Offset: 0x0000A014
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_Name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000BE90 File Offset: 0x0000A090
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		public unsafe PlayerActionSet Owner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_Owner_Public_get_PlayerActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerActionSet>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_Owner_Private_set_Void_PlayerActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000BF14 File Offset: 0x0000A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767988, XrefRangeEnd = 767993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000BF58 File Offset: 0x0000A158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767993, XrefRangeEnd = 767998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000BF9C File Offset: 0x0000A19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768002, RefRangeEnd = 768003, XrefRangeStart = 767998, XrefRangeEnd = 768002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnBindingsChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_add_OnBindingsChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768007, RefRangeEnd = 768008, XrefRangeStart = 768003, XrefRangeEnd = 768007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnBindingsChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_remove_OnBindingsChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000C024 File Offset: 0x0000A224
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000C064 File Offset: 0x0000A264
		public unsafe Object UserData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768079, RefRangeEnd = 768080, XrefRangeStart = 768008, XrefRangeEnd = 768079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAction(string name, PlayerActionSet owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr__ctor_Public_Void_String_PlayerActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000C108 File Offset: 0x0000A308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 768094, RefRangeEnd = 768098, XrefRangeStart = 768080, XrefRangeEnd = 768094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000C14C File Offset: 0x0000A34C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 768104, RefRangeEnd = 768132, XrefRangeStart = 768098, XrefRangeEnd = 768104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultBinding([Optional] Il2CppStructArray<Key> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Key>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Il2CppStructArray_1_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000C19C File Offset: 0x0000A39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768132, XrefRangeEnd = 768137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultBinding(KeyCombo keyCombo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyCombo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_KeyCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 768142, RefRangeEnd = 768148, XrefRangeStart = 768137, XrefRangeEnd = 768142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultBinding(Mouse control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000C21C File Offset: 0x0000A41C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 768153, RefRangeEnd = 768185, XrefRangeStart = 768148, XrefRangeEnd = 768153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultBinding(InputControlType control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddDefaultBinding_Public_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000C25C File Offset: 0x0000A45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768195, RefRangeEnd = 768196, XrefRangeStart = 768185, XrefRangeEnd = 768195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_AddBinding_Public_Boolean_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000C2AC File Offset: 0x0000A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768196, XrefRangeEnd = 768214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InsertBindingAt(int index, BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_InsertBindingAt_Public_Boolean_Int32_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000C308 File Offset: 0x0000A508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768214, XrefRangeEnd = 768231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(findBinding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withBinding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_ReplaceBinding_Public_Boolean_BindingSource_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000C368 File Offset: 0x0000A568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 768237, RefRangeEnd = 768240, XrefRangeStart = 768231, XrefRangeEnd = 768237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768240, XrefRangeEnd = 768246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingSource FindBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_FindBinding_Public_BindingSource_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingSource>(intPtr3) : null;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000C408 File Offset: 0x0000A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768246, XrefRangeEnd = 768257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HardRemoveBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_HardRemoveBinding_Private_Void_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000C44C File Offset: 0x0000A64C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768264, RefRangeEnd = 768265, XrefRangeStart = 768257, XrefRangeEnd = 768264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000C490 File Offset: 0x0000A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768265, XrefRangeEnd = 768270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBindingAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_RemoveBindingAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768270, XrefRangeEnd = 768274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountBindingsOfType(BindingSourceType bindingSourceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingSourceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_CountBindingsOfType_Private_Int32_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000C51C File Offset: 0x0000A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768274, XrefRangeEnd = 768279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingSourceType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_RemoveFirstBindingOfType_Private_Void_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000C55C File Offset: 0x0000A75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768279, XrefRangeEnd = 768283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfFirstInvalidBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_IndexOfFirstInvalidBinding_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000C598 File Offset: 0x0000A798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 768291, RefRangeEnd = 768294, XrefRangeStart = 768283, XrefRangeEnd = 768291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_ClearBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768306, RefRangeEnd = 768307, XrefRangeStart = 768294, XrefRangeEnd = 768306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_ResetBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000C600 File Offset: 0x0000A800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768312, RefRangeEnd = 768314, XrefRangeStart = 768307, XrefRangeEnd = 768312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListenForBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_ListenForBinding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000C634 File Offset: 0x0000A834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768319, RefRangeEnd = 768320, XrefRangeStart = 768314, XrefRangeEnd = 768319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListenForBindingReplacing(BindingSource binding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_ListenForBindingReplacing_Public_Void_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000C678 File Offset: 0x0000A878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768321, RefRangeEnd = 768323, XrefRangeStart = 768320, XrefRangeEnd = 768321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopListeningForBinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_StopListeningForBinding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public unsafe bool IsListeningForBinding
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 768323, RefRangeEnd = 768327, XrefRangeStart = 768323, XrefRangeEnd = 768323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public unsafe ReadOnlyCollection<BindingSource> Bindings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BindingSource>>(intPtr3) : null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000C728 File Offset: 0x0000A928
		public unsafe ReadOnlyCollection<BindingSource> UnfilteredBindings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_UnfilteredBindings_Public_get_ReadOnlyCollection_1_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BindingSource>>(intPtr3) : null;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000C768 File Offset: 0x0000A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768327, XrefRangeEnd = 768334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOrphanedBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_RemoveOrphanedBindings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000C79C File Offset: 0x0000A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768334, XrefRangeEnd = 768339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(ulong updateTick, float deltaTime, InputDevice device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000C7FC File Offset: 0x0000A9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768367, RefRangeEnd = 768369, XrefRangeStart = 768339, XrefRangeEnd = 768367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindings(ulong updateTick, float deltaTime)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_UpdateBindings_Private_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000C848 File Offset: 0x0000AA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 768407, RefRangeEnd = 768409, XrefRangeStart = 768369, XrefRangeEnd = 768407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_DetectBindings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000C87C File Offset: 0x0000AA7C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 768418, RefRangeEnd = 768432, XrefRangeStart = 768409, XrefRangeEnd = 768418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibleBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_UpdateVisibleBindings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000C8B0 File Offset: 0x0000AAB0
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		public unsafe InputDevice Device
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 768434, RefRangeEnd = 768435, XrefRangeStart = 768432, XrefRangeEnd = 768434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_Device_Internal_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768435, XrefRangeEnd = 768437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_Device_Internal_set_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000C934 File Offset: 0x0000AB34
		public unsafe InputDevice ActiveDevice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 768441, RefRangeEnd = 768442, XrefRangeStart = 768437, XrefRangeEnd = 768441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr3) : null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C974 File Offset: 0x0000AB74
		public unsafe bool LastInputTypeIsDevice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_LastInputTypeIsDevice_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		public new unsafe float LowerDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000CA68 File Offset: 0x0000AC68
		public new unsafe float UpperDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768461, RefRangeEnd = 768462, XrefRangeStart = 768442, XrefRangeEnd = 768461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataFormatVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768473, RefRangeEnd = 768474, XrefRangeStart = 768462, XrefRangeEnd = 768473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(BinaryWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerAction.NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000024C8 File Offset: 0x000006C8
		public void AddDefaultBinding(params Key[] keys)
		{
			this.AddDefaultBinding(new Il2CppStructArray<Key>(keys));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000024D6 File Offset: 0x000006D6
		public PlayerAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		// (set) Token: 0x06000145 RID: 325 RVA: 0x000024DF File Offset: 0x000006DF
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000CB64 File Offset: 0x0000AD64
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000024FE File Offset: 0x000006FE
		public unsafe PlayerActionSet _Owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__Owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerActionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000CB94 File Offset: 0x0000AD94
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000251D File Offset: 0x0000071D
		public unsafe BindingListenOptions ListenOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_ListenOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingListenOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_ListenOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		// (set) Token: 0x0600014B RID: 331 RVA: 0x0000253C File Offset: 0x0000073C
		public unsafe BindingSourceType LastInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastInputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastInputType)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002557 File Offset: 0x00000757
		public unsafe Action<BindingSourceType> OnLastInputTypeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_OnLastInputTypeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BindingSourceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_OnLastInputTypeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000CC1C File Offset: 0x0000AE1C
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002576 File Offset: 0x00000776
		public unsafe ulong LastInputTypeChangedTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastInputTypeChangedTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastInputTypeChangedTick)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000CC44 File Offset: 0x0000AE44
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002591 File Offset: 0x00000791
		public unsafe InputDeviceClass LastDeviceClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastDeviceClass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastDeviceClass)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000025AC File Offset: 0x000007AC
		public unsafe InputDeviceStyle LastDeviceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastDeviceStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_LastDeviceStyle)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000CC94 File Offset: 0x0000AE94
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000025C7 File Offset: 0x000007C7
		public unsafe Action OnBindingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_OnBindingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_OnBindingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000025E6 File Offset: 0x000007E6
		public unsafe Object _UserData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__UserData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr__UserData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe List<BindingSource> defaultBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_defaultBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_defaultBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000CD24 File Offset: 0x0000AF24
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002624 File Offset: 0x00000824
		public unsafe List<BindingSource> regularBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_regularBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_regularBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000CD54 File Offset: 0x0000AF54
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe List<BindingSource> visibleBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_visibleBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_visibleBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000CD84 File Offset: 0x0000AF84
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002662 File Offset: 0x00000862
		public unsafe ReadOnlyCollection<BindingSource> bindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_bindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_bindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002681 File Offset: 0x00000881
		public unsafe ReadOnlyCollection<BindingSource> unfilteredBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_unfilteredBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<BindingSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_unfilteredBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000026A0 File Offset: 0x000008A0
		public unsafe Il2CppReferenceArray<BindingSourceListener> bindingSourceListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_bindingSourceListeners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BindingSourceListener>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_bindingSourceListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000CE14 File Offset: 0x0000B014
		// (set) Token: 0x06000165 RID: 357 RVA: 0x000026BF File Offset: 0x000008BF
		public unsafe bool triggerBindingEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_triggerBindingEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_triggerBindingEnded)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000CE3C File Offset: 0x0000B03C
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000026DA File Offset: 0x000008DA
		public unsafe bool triggerBindingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_triggerBindingChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_triggerBindingChanged)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000CE64 File Offset: 0x0000B064
		// (set) Token: 0x06000169 RID: 361 RVA: 0x000026F5 File Offset: 0x000008F5
		public unsafe InputDevice device
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_device);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_device), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000CE94 File Offset: 0x0000B094
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002714 File Offset: 0x00000914
		public unsafe InputDevice activeDevice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_activeDevice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerAction.NativeFieldInfoPtr_activeDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_ListenOptions;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_LastInputType;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_OnLastInputTypeChanged;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_LastInputTypeChangedTick;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_LastDeviceClass;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_LastDeviceStyle;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_OnBindingsChanged;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__UserData_k__BackingField;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_defaultBindings;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_regularBindings;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_visibleBindings;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_bindings;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_unfilteredBindings;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_bindingSourceListeners;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_triggerBindingEnded;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_triggerBindingChanged;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_device;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_activeDevice;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_String_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_PlayerActionSet_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Private_set_Void_PlayerActionSet_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBindingsChanged_Public_add_Void_Action_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBindingsChanged_Public_rem_Void_Action_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Object_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PlayerActionSet_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultBinding_Public_Void_BindingSource_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Il2CppStructArray_1_Key_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultBinding_Public_Void_KeyCombo_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultBinding_Public_Void_Mouse_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultBinding_Public_Void_InputControlType_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Boolean_BindingSource_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_InsertBindingAt_Public_Boolean_Int32_BindingSource_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceBinding_Public_Boolean_BindingSource_BindingSource_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_HasBinding_Public_Boolean_BindingSource_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_FindBinding_Public_BindingSource_BindingSource_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_HardRemoveBinding_Private_Void_BindingSource_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_BindingSource_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBindingAt_Public_Void_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_CountBindingsOfType_Private_Int32_BindingSourceType_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFirstBindingOfType_Private_Void_BindingSourceType_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfFirstInvalidBinding_Private_Int32_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_ClearBindings_Public_Void_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_ResetBindings_Public_Void_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_ListenForBinding_Public_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_ListenForBindingReplacing_Public_Void_BindingSource_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_StopListeningForBinding_Public_Void_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsListeningForBinding_Public_get_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_BindingSource_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_UnfilteredBindings_Public_get_ReadOnlyCollection_1_BindingSource_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOrphanedBindings_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_InputDevice_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindings_Private_Void_UInt64_Single_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_DetectBindings_Private_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibleBindings_Private_Void_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_get_Device_Internal_get_InputDevice_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_set_Device_Internal_set_Void_InputDevice_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDevice_Public_get_InputDevice_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_get_LastInputTypeIsDevice_Private_get_Boolean_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_BinaryReader_UInt16_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_BinaryWriter_0;
	}
}
