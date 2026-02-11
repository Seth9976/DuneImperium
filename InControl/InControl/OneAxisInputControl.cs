using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x0200002E RID: 46
	public class OneAxisInputControl : Object
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x000127DC File Offset: 0x000109DC
		// Note: this type is marked as 'beforefieldinit'.
		static OneAxisInputControl()
		{
			Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OneAxisInputControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr);
			OneAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "<UpdateTick>k__BackingField");
			OneAxisInputControl.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "sensitivity");
			OneAxisInputControl.NativeFieldInfoPtr_lowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "lowerDeadZone");
			OneAxisInputControl.NativeFieldInfoPtr_upperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "upperDeadZone");
			OneAxisInputControl.NativeFieldInfoPtr_stateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "stateThreshold");
			OneAxisInputControl.NativeFieldInfoPtr_isNullControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "isNullControl");
			OneAxisInputControl.NativeFieldInfoPtr_FirstRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "FirstRepeatDelay");
			OneAxisInputControl.NativeFieldInfoPtr_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "RepeatDelay");
			OneAxisInputControl.NativeFieldInfoPtr_Raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "Raw");
			OneAxisInputControl.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "enabled");
			OneAxisInputControl.NativeFieldInfoPtr_ownerEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "ownerEnabled");
			OneAxisInputControl.NativeFieldInfoPtr_pendingTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "pendingTick");
			OneAxisInputControl.NativeFieldInfoPtr_pendingCommit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "pendingCommit");
			OneAxisInputControl.NativeFieldInfoPtr_nextRepeatTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "nextRepeatTime");
			OneAxisInputControl.NativeFieldInfoPtr_wasRepeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "wasRepeated");
			OneAxisInputControl.NativeFieldInfoPtr_clearInputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "clearInputState");
			OneAxisInputControl.NativeFieldInfoPtr_lastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "lastState");
			OneAxisInputControl.NativeFieldInfoPtr_nextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "nextState");
			OneAxisInputControl.NativeFieldInfoPtr_thisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, "thisState");
			OneAxisInputControl.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663706);
			OneAxisInputControl.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663707);
			OneAxisInputControl.NativeMethodInfoPtr_PrepareForUpdate_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663708);
			OneAxisInputControl.NativeMethodInfoPtr_UpdateWithState_Public_Boolean_Boolean_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663709);
			OneAxisInputControl.NativeMethodInfoPtr_UpdateWithValue_Public_Boolean_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663710);
			OneAxisInputControl.NativeMethodInfoPtr_UpdateWithRawValue_Internal_Boolean_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663711);
			OneAxisInputControl.NativeMethodInfoPtr_SetValue_Internal_Void_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663712);
			OneAxisInputControl.NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663713);
			OneAxisInputControl.NativeMethodInfoPtr_Commit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663714);
			OneAxisInputControl.NativeMethodInfoPtr_CommitWithState_Public_Void_Boolean_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663715);
			OneAxisInputControl.NativeMethodInfoPtr_CommitWithValue_Public_Void_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663716);
			OneAxisInputControl.NativeMethodInfoPtr_CommitWithSides_Internal_Void_InputControl_InputControl_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663717);
			OneAxisInputControl.NativeMethodInfoPtr_get_State_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663718);
			OneAxisInputControl.NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663719);
			OneAxisInputControl.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663720);
			OneAxisInputControl.NativeMethodInfoPtr_get_LastValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663721);
			OneAxisInputControl.NativeMethodInfoPtr_get_RawValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663722);
			OneAxisInputControl.NativeMethodInfoPtr_get_NextRawValue_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663723);
			OneAxisInputControl.NativeMethodInfoPtr_get_HasInput_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663724);
			OneAxisInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663725);
			OneAxisInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663726);
			OneAxisInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663727);
			OneAxisInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663728);
			OneAxisInputControl.NativeMethodInfoPtr_get_WasRepeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663729);
			OneAxisInputControl.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663730);
			OneAxisInputControl.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663731);
			OneAxisInputControl.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663732);
			OneAxisInputControl.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663733);
			OneAxisInputControl.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663734);
			OneAxisInputControl.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663735);
			OneAxisInputControl.NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663736);
			OneAxisInputControl.NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663737);
			OneAxisInputControl.NativeMethodInfoPtr_get_IsNullControl_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663738);
			OneAxisInputControl.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663739);
			OneAxisInputControl.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663740);
			OneAxisInputControl.NativeMethodInfoPtr_get_EnabledInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663741);
			OneAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663742);
			OneAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663743);
			OneAxisInputControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr, 100663744);
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00012C94 File Offset: 0x00010E94
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public unsafe ulong UpdateTick
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00012D10 File Offset: 0x00010F10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 773308, RefRangeEnd = 773311, XrefRangeStart = 773307, XrefRangeEnd = 773308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareForUpdate(ulong updateTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_PrepareForUpdate_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00012D50 File Offset: 0x00010F50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 773312, RefRangeEnd = 773318, XrefRangeStart = 773311, XrefRangeEnd = 773312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateWithState(bool state, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_UpdateWithState_Public_Boolean_Boolean_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00012DB8 File Offset: 0x00010FB8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 773324, RefRangeEnd = 773354, XrefRangeStart = 773318, XrefRangeEnd = 773324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateWithValue(float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_UpdateWithValue_Public_Boolean_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00012E20 File Offset: 0x00011020
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 773361, RefRangeEnd = 773372, XrefRangeStart = 773354, XrefRangeEnd = 773361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateWithRawValue(float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_UpdateWithRawValue_Internal_Boolean_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00012E88 File Offset: 0x00011088
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 773376, RefRangeEnd = 773388, XrefRangeStart = 773372, XrefRangeEnd = 773376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value, ulong updateTick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_SetValue_Internal_Void_Single_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00012ED4 File Offset: 0x000110D4
		[CallerCount(0)]
		public unsafe virtual void ClearInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00012F08 File Offset: 0x00011108
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 773396, RefRangeEnd = 773426, XrefRangeStart = 773388, XrefRangeEnd = 773396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Commit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_Commit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00012F3C File Offset: 0x0001113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773426, XrefRangeEnd = 773428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitWithState(bool state, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_CommitWithState_Public_Void_Boolean_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00012F98 File Offset: 0x00011198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773428, XrefRangeEnd = 773430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitWithValue(float value, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_CommitWithValue_Public_Void_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00012FF4 File Offset: 0x000111F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773430, XrefRangeEnd = 773440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitWithSides(InputControl negativeSide, InputControl positiveSide, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(negativeSide);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positiveSide);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_CommitWithSides_Internal_Void_InputControl_InputControl_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00013064 File Offset: 0x00011264
		public unsafe bool State
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 773440, RefRangeEnd = 773471, XrefRangeStart = 773440, XrefRangeEnd = 773440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_State_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000130A0 File Offset: 0x000112A0
		public unsafe bool LastState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000130DC File Offset: 0x000112DC
		public unsafe float Value
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 773471, RefRangeEnd = 773484, XrefRangeStart = 773471, XrefRangeEnd = 773471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00013118 File Offset: 0x00011318
		public unsafe float LastValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_LastValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00013154 File Offset: 0x00011354
		public unsafe float RawValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_RawValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00013190 File Offset: 0x00011390
		public unsafe float NextRawValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_NextRawValue_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000131CC File Offset: 0x000113CC
		public unsafe bool HasInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773488, RefRangeEnd = 773489, XrefRangeStart = 773484, XrefRangeEnd = 773488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_HasInput_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00013208 File Offset: 0x00011408
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773489, XrefRangeEnd = 773490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00013244 File Offset: 0x00011444
		public unsafe virtual bool IsPressed
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 773440, RefRangeEnd = 773471, XrefRangeStart = 773440, XrefRangeEnd = 773471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00013280 File Offset: 0x00011480
		public unsafe virtual bool WasPressed
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 773490, RefRangeEnd = 773516, XrefRangeStart = 773490, XrefRangeEnd = 773490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000132BC File Offset: 0x000114BC
		public unsafe virtual bool WasReleased
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773516, RefRangeEnd = 773517, XrefRangeStart = 773516, XrefRangeEnd = 773516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000132F8 File Offset: 0x000114F8
		public unsafe bool WasRepeated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773517, RefRangeEnd = 773518, XrefRangeStart = 773517, XrefRangeEnd = 773517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_WasRepeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00013334 File Offset: 0x00011534
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00013370 File Offset: 0x00011570
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773518, RefRangeEnd = 773519, XrefRangeStart = 773518, XrefRangeEnd = 773518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000133B0 File Offset: 0x000115B0
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000133EC File Offset: 0x000115EC
		public unsafe float LowerDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773519, RefRangeEnd = 773520, XrefRangeStart = 773519, XrefRangeEnd = 773519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0001342C File Offset: 0x0001162C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00013468 File Offset: 0x00011668
		public unsafe float UpperDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773520, RefRangeEnd = 773521, XrefRangeStart = 773520, XrefRangeEnd = 773520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000134A8 File Offset: 0x000116A8
		// (set) Token: 0x06000316 RID: 790 RVA: 0x000134E4 File Offset: 0x000116E4
		public unsafe float StateThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00013524 File Offset: 0x00011724
		public unsafe bool IsNullControl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_IsNullControl_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00013560 File Offset: 0x00011760
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0001359C File Offset: 0x0001179C
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000135DC File Offset: 0x000117DC
		public unsafe bool EnabledInHierarchy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_get_EnabledInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00013618 File Offset: 0x00011818
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 773521, RefRangeEnd = 773548, XrefRangeStart = 773521, XrefRangeEnd = 773521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(OneAxisInputControl instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_OneAxisInputControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001365C File Offset: 0x0001185C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 773548, RefRangeEnd = 773558, XrefRangeStart = 773548, XrefRangeEnd = 773548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float(OneAxisInputControl instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_OneAxisInputControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000136A0 File Offset: 0x000118A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773558, XrefRangeEnd = 773559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OneAxisInputControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneAxisInputControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneAxisInputControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000030F4 File Offset: 0x000012F4
		public OneAxisInputControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000136DC File Offset: 0x000118DC
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000030FD File Offset: 0x000012FD
		public unsafe ulong _UpdateTick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00013704 File Offset: 0x00011904
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00003118 File Offset: 0x00001318
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0001372C File Offset: 0x0001192C
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00003133 File Offset: 0x00001333
		public unsafe float lowerDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_lowerDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_lowerDeadZone)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00013754 File Offset: 0x00011954
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000314E File Offset: 0x0000134E
		public unsafe float upperDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_upperDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_upperDeadZone)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0001377C File Offset: 0x0001197C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00003169 File Offset: 0x00001369
		public unsafe float stateThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_stateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_stateThreshold)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000137A4 File Offset: 0x000119A4
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00003184 File Offset: 0x00001384
		public unsafe bool isNullControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_isNullControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_isNullControl)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000137CC File Offset: 0x000119CC
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0000319F File Offset: 0x0000139F
		public unsafe float FirstRepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_FirstRepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_FirstRepeatDelay)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000137F4 File Offset: 0x000119F4
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000031BA File Offset: 0x000013BA
		public unsafe float RepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_RepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_RepeatDelay)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001381C File Offset: 0x00011A1C
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000031D5 File Offset: 0x000013D5
		public unsafe bool Raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_Raw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_Raw)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00013844 File Offset: 0x00011A44
		// (set) Token: 0x06000332 RID: 818 RVA: 0x000031F0 File Offset: 0x000013F0
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0001386C File Offset: 0x00011A6C
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0000320B File Offset: 0x0000140B
		public unsafe bool ownerEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_ownerEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_ownerEnabled)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00013894 File Offset: 0x00011A94
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00003226 File Offset: 0x00001426
		public unsafe ulong pendingTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_pendingTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_pendingTick)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000138BC File Offset: 0x00011ABC
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00003241 File Offset: 0x00001441
		public unsafe bool pendingCommit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_pendingCommit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_pendingCommit)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000138E4 File Offset: 0x00011AE4
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000325C File Offset: 0x0000145C
		public unsafe float nextRepeatTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_nextRepeatTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_nextRepeatTime)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0001390C File Offset: 0x00011B0C
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00003277 File Offset: 0x00001477
		public unsafe bool wasRepeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_wasRepeated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_wasRepeated)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00013934 File Offset: 0x00011B34
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00003292 File Offset: 0x00001492
		public unsafe bool clearInputState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_clearInputState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_clearInputState)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0001395C File Offset: 0x00011B5C
		// (set) Token: 0x06000340 RID: 832 RVA: 0x000032AD File Offset: 0x000014AD
		public unsafe InputControlState lastState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_lastState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_lastState)) = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00013984 File Offset: 0x00011B84
		// (set) Token: 0x06000342 RID: 834 RVA: 0x000032C8 File Offset: 0x000014C8
		public unsafe InputControlState nextState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_nextState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_nextState)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000139AC File Offset: 0x00011BAC
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000032E3 File Offset: 0x000014E3
		public unsafe InputControlState thisState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_thisState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneAxisInputControl.NativeFieldInfoPtr_thisState)) = value;
			}
		}

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr__UpdateTick_k__BackingField;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_lowerDeadZone;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_upperDeadZone;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_stateThreshold;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_isNullControl;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_FirstRepeatDelay;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_RepeatDelay;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_Raw;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_ownerEnabled;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_pendingTick;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_pendingCommit;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_nextRepeatTime;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_wasRepeated;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_clearInputState;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_lastState;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_nextState;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_thisState;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForUpdate_Private_Void_UInt64_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithState_Public_Boolean_Boolean_UInt64_Single_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithValue_Public_Boolean_Single_UInt64_Single_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithRawValue_Internal_Boolean_Single_UInt64_Single_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_Single_UInt64_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_Commit_Public_Void_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_CommitWithState_Public_Void_Boolean_UInt64_Single_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_CommitWithValue_Public_Void_Single_UInt64_Single_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_CommitWithSides_Internal_Void_InputControl_InputControl_UInt64_Single_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_Boolean_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Single_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_get_RawValue_Public_get_Single_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_get_NextRawValue_Internal_get_Single_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInput_Internal_get_Boolean_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_get_WasRepeated_Public_get_Boolean_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullControl_Public_get_Boolean_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledInHierarchy_Public_get_Boolean_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_OneAxisInputControl_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_OneAxisInputControl_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
