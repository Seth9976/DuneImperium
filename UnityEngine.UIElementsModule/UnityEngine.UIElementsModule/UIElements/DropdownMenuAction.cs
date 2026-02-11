using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B9 RID: 185
	public class DropdownMenuAction : DropdownMenuItem
	{
		// Token: 0x06001124 RID: 4388 RVA: 0x0005920C File Offset: 0x0005740C
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownMenuAction()
		{
			Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownMenuAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr);
			DropdownMenuAction.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "<name>k__BackingField");
			DropdownMenuAction.NativeFieldInfoPtr__status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "<status>k__BackingField");
			DropdownMenuAction.NativeFieldInfoPtr__eventInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "<eventInfo>k__BackingField");
			DropdownMenuAction.NativeFieldInfoPtr__userData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "<userData>k__BackingField");
			DropdownMenuAction.NativeFieldInfoPtr_actionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "actionCallback");
			DropdownMenuAction.NativeFieldInfoPtr_actionStatusCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, "actionStatusCallback");
			DropdownMenuAction.NativeMethodInfoPtr_set_status_Private_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665730);
			DropdownMenuAction.NativeMethodInfoPtr_set_eventInfo_Private_set_Void_DropdownMenuEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665731);
			DropdownMenuAction.NativeMethodInfoPtr_set_userData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665732);
			DropdownMenuAction.NativeMethodInfoPtr_AlwaysEnabled_Public_Static_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665733);
			DropdownMenuAction.NativeMethodInfoPtr_AlwaysDisabled_Public_Static_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665734);
			DropdownMenuAction.NativeMethodInfoPtr__ctor_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665735);
			DropdownMenuAction.NativeMethodInfoPtr_UpdateActionStatus_Public_Void_DropdownMenuEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr, 100665736);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00008A6E File Offset: 0x00006C6E
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00059340 File Offset: 0x00057540
		public unsafe DropdownMenuAction.Status status
		{
			get
			{
				return this._status_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_set_status_Private_set_Void_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00008A76 File Offset: 0x00006C76
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00059380 File Offset: 0x00057580
		public unsafe DropdownMenuEventInfo eventInfo
		{
			get
			{
				return this._eventInfo_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311423, XrefRangeEnd = 311424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_set_eventInfo_Private_set_Void_DropdownMenuEventInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00008A7E File Offset: 0x00006C7E
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x000593C4 File Offset: 0x000575C4
		public unsafe Object userData
		{
			get
			{
				return this._userData_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_set_userData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00059408 File Offset: 0x00057608
		[CallerCount(0)]
		public unsafe static DropdownMenuAction.Status AlwaysEnabled(DropdownMenuAction a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_AlwaysEnabled_Public_Static_Status_DropdownMenuAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005944C File Offset: 0x0005764C
		[CallerCount(0)]
		public unsafe static DropdownMenuAction.Status AlwaysDisabled(DropdownMenuAction a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_AlwaysDisabled_Public_Static_Status_DropdownMenuAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00059490 File Offset: 0x00057690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311424, XrefRangeEnd = 311429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, Object userData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenuAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionStatusCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr__ctor_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00059514 File Offset: 0x00057714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311430, RefRangeEnd = 311431, XrefRangeStart = 311429, XrefRangeEnd = 311430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActionStatus(DropdownMenuEventInfo eventInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenuAction.NativeMethodInfoPtr_UpdateActionStatus_Public_Void_DropdownMenuEventInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000089A7 File Offset: 0x00006BA7
		public DropdownMenuAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00059558 File Offset: 0x00057758
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x000089B0 File Offset: 0x00006BB0
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00059580 File Offset: 0x00057780
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x000089CF File Offset: 0x00006BCF
		public unsafe DropdownMenuAction.Status _status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__status_k__BackingField)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000595A8 File Offset: 0x000577A8
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x000089EA File Offset: 0x00006BEA
		public unsafe DropdownMenuEventInfo _eventInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__eventInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DropdownMenuEventInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__eventInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000595D8 File Offset: 0x000577D8
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x00008A09 File Offset: 0x00006C09
		public unsafe Object _userData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__userData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr__userData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x00059608 File Offset: 0x00057808
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00008A28 File Offset: 0x00006C28
		public unsafe Action<DropdownMenuAction> actionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr_actionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DropdownMenuAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr_actionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00059638 File Offset: 0x00057838
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x00008A47 File Offset: 0x00006C47
		public unsafe Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr_actionStatusCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DropdownMenuAction, DropdownMenuAction.Status>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenuAction.NativeFieldInfoPtr_actionStatusCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00008A66 File Offset: 0x00006C66
		public string name
		{
			get
			{
				return this._name_k__BackingField;
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00008A86 File Offset: 0x00006C86
		public void Execute()
		{
			Action<DropdownMenuAction> actionCallback = this.actionCallback;
			if (actionCallback != null)
			{
				actionCallback.Invoke(this);
			}
		}

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeFieldInfoPtr__status_k__BackingField;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr__eventInfo_k__BackingField;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr__userData_k__BackingField;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_actionCallback;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr_actionStatusCallback;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_set_status_Private_set_Void_Status_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_set_eventInfo_Private_set_Void_DropdownMenuEventInfo_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_set_userData_Private_set_Void_Object_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_AlwaysEnabled_Public_Static_Status_DropdownMenuAction_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_AlwaysDisabled_Public_Static_Status_DropdownMenuAction_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActionStatus_Public_Void_DropdownMenuEventInfo_0;

		// Token: 0x020003E3 RID: 995
		[Flags]
		public enum Status
		{
			// Token: 0x04002951 RID: 10577
			None = 0,
			// Token: 0x04002952 RID: 10578
			Normal = 1,
			// Token: 0x04002953 RID: 10579
			Disabled = 2,
			// Token: 0x04002954 RID: 10580
			Checked = 4,
			// Token: 0x04002955 RID: 10581
			Hidden = 8
		}
	}
}
