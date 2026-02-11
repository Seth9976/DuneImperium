using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200001C RID: 28
	public class PlayerOneAxisAction : OneAxisInputControl
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000E204 File Offset: 0x0000C404
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerOneAxisAction()
		{
			Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "PlayerOneAxisAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr);
			PlayerOneAxisAction.NativeFieldInfoPtr_negativeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, "negativeAction");
			PlayerOneAxisAction.NativeFieldInfoPtr_positiveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, "positiveAction");
			PlayerOneAxisAction.NativeFieldInfoPtr_LastInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, "LastInputType");
			PlayerOneAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, "OnLastInputTypeChanged");
			PlayerOneAxisAction.NativeFieldInfoPtr__UserData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, "<UserData>k__BackingField");
			PlayerOneAxisAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663554);
			PlayerOneAxisAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663555);
			PlayerOneAxisAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663556);
			PlayerOneAxisAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663557);
			PlayerOneAxisAction.NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663558);
			PlayerOneAxisAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663559);
			PlayerOneAxisAction.NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663560);
			PlayerOneAxisAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663561);
			PlayerOneAxisAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663562);
			PlayerOneAxisAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663563);
			PlayerOneAxisAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr, 100663564);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000E374 File Offset: 0x0000C574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768865, XrefRangeEnd = 768870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768870, XrefRangeEnd = 768875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000E43C File Offset: 0x0000C63C
		public unsafe Object UserData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000E480 File Offset: 0x0000C680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768875, XrefRangeEnd = 768878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerOneAxisAction(PlayerAction negativeAction, PlayerAction positiveAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerOneAxisAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(negativeAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positiveAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768878, XrefRangeEnd = 768886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000E52C File Offset: 0x0000C72C
		[CallerCount(0)]
		public unsafe void ProcessActionUpdate(PlayerAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000E570 File Offset: 0x0000C770
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		public new unsafe float LowerDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000E5EC File Offset: 0x0000C7EC
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000E628 File Offset: 0x0000C828
		public new unsafe float UpperDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerOneAxisAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000299A File Offset: 0x00000B9A
		public PlayerOneAxisAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000E668 File Offset: 0x0000C868
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000029A3 File Offset: 0x00000BA3
		public unsafe PlayerAction negativeAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_negativeAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_negativeAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000E698 File Offset: 0x0000C898
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe PlayerAction positiveAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_positiveAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_positiveAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000029E1 File Offset: 0x00000BE1
		public unsafe BindingSourceType LastInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_LastInputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_LastInputType)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x000029FC File Offset: 0x00000BFC
		public unsafe Action<BindingSourceType> OnLastInputTypeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BindingSourceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000E720 File Offset: 0x0000C920
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002A1B File Offset: 0x00000C1B
		public unsafe Object _UserData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr__UserData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerOneAxisAction.NativeFieldInfoPtr__UserData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_negativeAction;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_positiveAction;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_LastInputType;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_OnLastInputTypeChanged;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr__UserData_k__BackingField;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Object_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;
	}
}
