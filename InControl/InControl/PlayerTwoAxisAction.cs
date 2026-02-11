using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200001D RID: 29
	public class PlayerTwoAxisAction : TwoAxisInputControl
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x0000E750 File Offset: 0x0000C950
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTwoAxisAction()
		{
			Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "PlayerTwoAxisAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr);
			PlayerTwoAxisAction.NativeFieldInfoPtr_negativeXAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "negativeXAction");
			PlayerTwoAxisAction.NativeFieldInfoPtr_positiveXAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "positiveXAction");
			PlayerTwoAxisAction.NativeFieldInfoPtr_negativeYAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "negativeYAction");
			PlayerTwoAxisAction.NativeFieldInfoPtr_positiveYAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "positiveYAction");
			PlayerTwoAxisAction.NativeFieldInfoPtr__InvertXAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "<InvertXAxis>k__BackingField");
			PlayerTwoAxisAction.NativeFieldInfoPtr__InvertYAxis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "<InvertYAxis>k__BackingField");
			PlayerTwoAxisAction.NativeFieldInfoPtr_LastInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "LastInputType");
			PlayerTwoAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "OnLastInputTypeChanged");
			PlayerTwoAxisAction.NativeFieldInfoPtr__UserData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, "<UserData>k__BackingField");
			PlayerTwoAxisAction.NativeMethodInfoPtr_get_InvertXAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663565);
			PlayerTwoAxisAction.NativeMethodInfoPtr_set_InvertXAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663566);
			PlayerTwoAxisAction.NativeMethodInfoPtr_get_InvertYAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663567);
			PlayerTwoAxisAction.NativeMethodInfoPtr_set_InvertYAxis_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663568);
			PlayerTwoAxisAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663569);
			PlayerTwoAxisAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663570);
			PlayerTwoAxisAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663571);
			PlayerTwoAxisAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663572);
			PlayerTwoAxisAction.NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663573);
			PlayerTwoAxisAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663574);
			PlayerTwoAxisAction.NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663575);
			PlayerTwoAxisAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663576);
			PlayerTwoAxisAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663577);
			PlayerTwoAxisAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663578);
			PlayerTwoAxisAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr, 100663579);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000E960 File Offset: 0x0000CB60
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000E99C File Offset: 0x0000CB9C
		public unsafe bool InvertXAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_get_InvertXAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_set_InvertXAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000EA18 File Offset: 0x0000CC18
		public unsafe bool InvertYAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_get_InvertYAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_set_InvertYAxis_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000EA58 File Offset: 0x0000CC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768886, XrefRangeEnd = 768891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000EA9C File Offset: 0x0000CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768891, XrefRangeEnd = 768896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLastInputTypeChanged(Action<BindingSourceType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public unsafe Object UserData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_get_UserData_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000EB64 File Offset: 0x0000CD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768896, XrefRangeEnd = 768904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTwoAxisAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTwoAxisAction>.NativeClassPtr))
		{
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000EBE8 File Offset: 0x0000CDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 768922, RefRangeEnd = 768923, XrefRangeStart = 768904, XrefRangeEnd = 768922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000EC34 File Offset: 0x0000CE34
		[CallerCount(0)]
		public unsafe void ProcessActionUpdate(PlayerAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000EC78 File Offset: 0x0000CE78
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		public new unsafe float LowerDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public new unsafe float UpperDeadZone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTwoAxisAction.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002A3A File Offset: 0x00000C3A
		public PlayerTwoAxisAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000ED70 File Offset: 0x0000CF70
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002A43 File Offset: 0x00000C43
		public unsafe PlayerAction negativeXAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_negativeXAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_negativeXAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002A62 File Offset: 0x00000C62
		public unsafe PlayerAction positiveXAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_positiveXAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_positiveXAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002A81 File Offset: 0x00000C81
		public unsafe PlayerAction negativeYAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_negativeYAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_negativeYAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000EE00 File Offset: 0x0000D000
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002AA0 File Offset: 0x00000CA0
		public unsafe PlayerAction positiveYAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_positiveYAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_positiveYAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000EE30 File Offset: 0x0000D030
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002ABF File Offset: 0x00000CBF
		public unsafe bool _InvertXAxis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__InvertXAxis_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__InvertXAxis_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000EE58 File Offset: 0x0000D058
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002ADA File Offset: 0x00000CDA
		public unsafe bool _InvertYAxis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__InvertYAxis_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__InvertYAxis_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002AF5 File Offset: 0x00000CF5
		public unsafe BindingSourceType LastInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_LastInputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_LastInputType)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002B10 File Offset: 0x00000D10
		public unsafe Action<BindingSourceType> OnLastInputTypeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BindingSourceType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr_OnLastInputTypeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000EED8 File Offset: 0x0000D0D8
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002B2F File Offset: 0x00000D2F
		public unsafe Object _UserData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__UserData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTwoAxisAction.NativeFieldInfoPtr__UserData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_negativeXAction;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_positiveXAction;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_negativeYAction;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_positiveYAction;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr__InvertXAxis_k__BackingField;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__InvertYAxis_k__BackingField;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_LastInputType;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_OnLastInputTypeChanged;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr__UserData_k__BackingField;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertXAxis_Public_get_Boolean_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertXAxis_Public_set_Void_Boolean_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertYAxis_Public_get_Boolean_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_set_InvertYAxis_Public_set_Void_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLastInputTypeChanged_Public_add_Void_Action_1_BindingSourceType_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLastInputTypeChanged_Public_rem_Void_Action_1_BindingSourceType_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Object_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Object_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayerAction_PlayerAction_PlayerAction_PlayerAction_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_UInt64_Single_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_ProcessActionUpdate_Private_Void_PlayerAction_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;
	}
}
