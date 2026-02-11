using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200002F RID: 47
	public class TwoAxisInputControl : global::Il2CppSystem.Object
	{
		// Token: 0x06000345 RID: 837 RVA: 0x000139D4 File Offset: 0x00011BD4
		// Note: this type is marked as 'beforefieldinit'.
		static TwoAxisInputControl()
		{
			Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TwoAxisInputControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr);
			TwoAxisInputControl.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "Null");
			TwoAxisInputControl.NativeFieldInfoPtr__X_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<X>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__Y_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<Y>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__Left_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<Left>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__Right_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<Right>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__Up_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<Up>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__Down_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<Down>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<UpdateTick>k__BackingField");
			TwoAxisInputControl.NativeFieldInfoPtr_DeadZoneFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "DeadZoneFunc");
			TwoAxisInputControl.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "sensitivity");
			TwoAxisInputControl.NativeFieldInfoPtr_lowerDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "lowerDeadZone");
			TwoAxisInputControl.NativeFieldInfoPtr_upperDeadZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "upperDeadZone");
			TwoAxisInputControl.NativeFieldInfoPtr_stateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "stateThreshold");
			TwoAxisInputControl.NativeFieldInfoPtr_Raw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "Raw");
			TwoAxisInputControl.NativeFieldInfoPtr_thisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "thisState");
			TwoAxisInputControl.NativeFieldInfoPtr_lastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "lastState");
			TwoAxisInputControl.NativeFieldInfoPtr_thisValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "thisValue");
			TwoAxisInputControl.NativeFieldInfoPtr_lastValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "lastValue");
			TwoAxisInputControl.NativeFieldInfoPtr_clearInputState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "clearInputState");
			TwoAxisInputControl.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, "<HasChanged>k__BackingField");
			TwoAxisInputControl.NativeMethodInfoPtr_get_X_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663745);
			TwoAxisInputControl.NativeMethodInfoPtr_set_X_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663746);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663747);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Y_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663748);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Left_Public_get_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663749);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Left_Protected_set_Void_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663750);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Right_Public_get_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663751);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Right_Protected_set_Void_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663752);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Up_Public_get_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663753);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Up_Protected_set_Void_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663754);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Down_Public_get_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663755);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Down_Protected_set_Void_OneAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663756);
			TwoAxisInputControl.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663757);
			TwoAxisInputControl.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663758);
			TwoAxisInputControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663759);
			TwoAxisInputControl.NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663760);
			TwoAxisInputControl.NativeMethodInfoPtr_Filter_Public_Void_TwoAxisInputControl_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663761);
			TwoAxisInputControl.NativeMethodInfoPtr_UpdateWithAxes_Internal_Void_Single_Single_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663762);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663763);
			TwoAxisInputControl.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663764);
			TwoAxisInputControl.NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663765);
			TwoAxisInputControl.NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663766);
			TwoAxisInputControl.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663767);
			TwoAxisInputControl.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663768);
			TwoAxisInputControl.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663769);
			TwoAxisInputControl.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663770);
			TwoAxisInputControl.NativeMethodInfoPtr_get_State_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663771);
			TwoAxisInputControl.NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663772);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Value_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663773);
			TwoAxisInputControl.NativeMethodInfoPtr_get_LastValue_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663774);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663775);
			TwoAxisInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663776);
			TwoAxisInputControl.NativeMethodInfoPtr_set_HasChanged_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663777);
			TwoAxisInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663778);
			TwoAxisInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663779);
			TwoAxisInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663780);
			TwoAxisInputControl.NativeMethodInfoPtr_get_Angle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663781);
			TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663782);
			TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663783);
			TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_TwoAxisInputControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr, 100663784);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00013EB4 File Offset: 0x000120B4
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00013EF0 File Offset: 0x000120F0
		public unsafe float X
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_X_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_X_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00013F30 File Offset: 0x00012130
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00013F6C File Offset: 0x0001216C
		public unsafe float Y
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Y_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 644458, RefRangeEnd = 644459, XrefRangeStart = 644458, XrefRangeEnd = 644459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Y_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00013FAC File Offset: 0x000121AC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00013FEC File Offset: 0x000121EC
		public unsafe OneAxisInputControl Left
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Left_Public_get_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Left_Protected_set_Void_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00014030 File Offset: 0x00012230
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00014070 File Offset: 0x00012270
		public unsafe OneAxisInputControl Right
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Right_Public_get_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Right_Protected_set_Void_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000140B4 File Offset: 0x000122B4
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000140F4 File Offset: 0x000122F4
		public unsafe OneAxisInputControl Up
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Up_Public_get_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Up_Protected_set_Void_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00014138 File Offset: 0x00012338
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00014178 File Offset: 0x00012378
		public unsafe OneAxisInputControl Down
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Down_Public_get_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Down_Protected_set_Void_OneAxisInputControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000141BC File Offset: 0x000123BC
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000141F8 File Offset: 0x000123F8
		public unsafe ulong UpdateTick
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00014238 File Offset: 0x00012438
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 773588, RefRangeEnd = 773595, XrefRangeStart = 773559, XrefRangeEnd = 773588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwoAxisInputControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoAxisInputControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00014274 File Offset: 0x00012474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 773599, RefRangeEnd = 773603, XrefRangeStart = 773595, XrefRangeEnd = 773599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearInputState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000142A8 File Offset: 0x000124A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773611, RefRangeEnd = 773612, XrefRangeStart = 773603, XrefRangeEnd = 773611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Filter(TwoAxisInputControl twoAxisInputControl, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(twoAxisInputControl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_Filter_Public_Void_TwoAxisInputControl_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000142F8 File Offset: 0x000124F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 773633, RefRangeEnd = 773639, XrefRangeStart = 773612, XrefRangeEnd = 773633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWithAxes(float x, float y, ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateTick;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_UpdateWithAxes_Internal_Void_Single_Single_UInt64_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00014360 File Offset: 0x00012560
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0001439C File Offset: 0x0001259C
		public unsafe float Sensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773639, XrefRangeEnd = 773643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000143DC File Offset: 0x000125DC
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00014418 File Offset: 0x00012618
		public unsafe float StateThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 773647, RefRangeEnd = 773648, XrefRangeStart = 773643, XrefRangeEnd = 773647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00014458 File Offset: 0x00012658
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00014494 File Offset: 0x00012694
		public unsafe float LowerDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773648, XrefRangeEnd = 773652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000144D4 File Offset: 0x000126D4
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00014510 File Offset: 0x00012710
		public unsafe float UpperDeadZone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773652, XrefRangeEnd = 773656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00014550 File Offset: 0x00012750
		public unsafe bool State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_State_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0001458C File Offset: 0x0001278C
		public unsafe bool LastState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000145C8 File Offset: 0x000127C8
		public unsafe Vector2 Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Value_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00014604 File Offset: 0x00012804
		public unsafe Vector2 LastValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_LastValue_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00014640 File Offset: 0x00012840
		public unsafe Vector2 Vector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0001467C File Offset: 0x0001287C
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000146B8 File Offset: 0x000128B8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_set_HasChanged_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000367 RID: 871 RVA: 0x000146F8 File Offset: 0x000128F8
		public unsafe virtual bool IsPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00014734 File Offset: 0x00012934
		public unsafe virtual bool WasPressed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00014770 File Offset: 0x00012970
		public unsafe virtual bool WasReleased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000147AC File Offset: 0x000129AC
		public unsafe float Angle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 773660, RefRangeEnd = 773662, XrefRangeStart = 773656, XrefRangeEnd = 773660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_get_Angle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000147E8 File Offset: 0x000129E8
		[CallerCount(0)]
		public unsafe static implicit operator bool(TwoAxisInputControl instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TwoAxisInputControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001482C File Offset: 0x00012A2C
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(TwoAxisInputControl instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_TwoAxisInputControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00014870 File Offset: 0x00012A70
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(TwoAxisInputControl instance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoAxisInputControl.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_TwoAxisInputControl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000032FE File Offset: 0x000014FE
		public TwoAxisInputControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000148B4 File Offset: 0x00012AB4
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003307 File Offset: 0x00001507
		public unsafe static TwoAxisInputControl Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwoAxisInputControl.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwoAxisInputControl.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000148DC File Offset: 0x00012ADC
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003319 File Offset: 0x00001519
		public unsafe float _X_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__X_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__X_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00014904 File Offset: 0x00012B04
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00003334 File Offset: 0x00001534
		public unsafe float _Y_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Y_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Y_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0001492C File Offset: 0x00012B2C
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000334F File Offset: 0x0000154F
		public unsafe OneAxisInputControl _Left_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Left_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Left_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001495C File Offset: 0x00012B5C
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000336E File Offset: 0x0000156E
		public unsafe OneAxisInputControl _Right_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Right_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Right_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001498C File Offset: 0x00012B8C
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000338D File Offset: 0x0000158D
		public unsafe OneAxisInputControl _Up_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Up_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Up_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000149BC File Offset: 0x00012BBC
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000033AC File Offset: 0x000015AC
		public unsafe OneAxisInputControl _Down_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Down_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneAxisInputControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__Down_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000149EC File Offset: 0x00012BEC
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000033CB File Offset: 0x000015CB
		public unsafe ulong _UpdateTick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__UpdateTick_k__BackingField)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00014A14 File Offset: 0x00012C14
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000033E6 File Offset: 0x000015E6
		public unsafe DeadZoneFunc DeadZoneFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_DeadZoneFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadZoneFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_DeadZoneFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00014A44 File Offset: 0x00012C44
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003405 File Offset: 0x00001605
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00014A6C File Offset: 0x00012C6C
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003420 File Offset: 0x00001620
		public unsafe float lowerDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lowerDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lowerDeadZone)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00014A94 File Offset: 0x00012C94
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0000343B File Offset: 0x0000163B
		public unsafe float upperDeadZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_upperDeadZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_upperDeadZone)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00014ABC File Offset: 0x00012CBC
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003456 File Offset: 0x00001656
		public unsafe float stateThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_stateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_stateThreshold)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00014AE4 File Offset: 0x00012CE4
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003471 File Offset: 0x00001671
		public unsafe bool Raw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_Raw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_Raw)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00014B0C File Offset: 0x00012D0C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0000348C File Offset: 0x0000168C
		public unsafe bool thisState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_thisState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_thisState)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00014B34 File Offset: 0x00012D34
		// (set) Token: 0x0600038E RID: 910 RVA: 0x000034A7 File Offset: 0x000016A7
		public unsafe bool lastState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lastState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lastState)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00014B5C File Offset: 0x00012D5C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x000034C2 File Offset: 0x000016C2
		public unsafe Vector2 thisValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_thisValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_thisValue)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00014B84 File Offset: 0x00012D84
		// (set) Token: 0x06000392 RID: 914 RVA: 0x000034DD File Offset: 0x000016DD
		public unsafe Vector2 lastValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lastValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_lastValue)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00014BAC File Offset: 0x00012DAC
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000034F8 File Offset: 0x000016F8
		public unsafe bool clearInputState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_clearInputState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr_clearInputState)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00014BD4 File Offset: 0x00012DD4
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00003513 File Offset: 0x00001713
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoAxisInputControl.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr__X_k__BackingField;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr__Y_k__BackingField;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr__Left_k__BackingField;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr__Right_k__BackingField;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr__Up_k__BackingField;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr__Down_k__BackingField;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr__UpdateTick_k__BackingField;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_DeadZoneFunc;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_lowerDeadZone;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_upperDeadZone;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_stateThreshold;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_Raw;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_thisState;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_lastState;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_thisValue;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_lastValue;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_clearInputState;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_X_Public_get_Single_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_set_X_Protected_set_Void_Single_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_get_Y_Public_get_Single_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_set_Y_Protected_set_Void_Single_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_OneAxisInputControl_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_set_Left_Protected_set_Void_OneAxisInputControl_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_OneAxisInputControl_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_set_Right_Protected_set_Void_OneAxisInputControl_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_OneAxisInputControl_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_set_Up_Protected_set_Void_OneAxisInputControl_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_get_Down_Public_get_OneAxisInputControl_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_set_Down_Protected_set_Void_OneAxisInputControl_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateTick_Public_get_UInt64_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateTick_Protected_set_Void_UInt64_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_ClearInputState_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Void_TwoAxisInputControl_Single_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWithAxes_Internal_Void_Single_Single_UInt64_Single_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_get_Sensitivity_Public_get_Single_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_set_Sensitivity_Public_set_Void_Single_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_get_StateThreshold_Public_get_Single_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_set_StateThreshold_Public_set_Void_Single_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerDeadZone_Public_get_Single_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_set_LowerDeadZone_Public_set_Void_Single_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperDeadZone_Public_get_Single_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_set_UpperDeadZone_Public_set_Void_Single_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_Boolean_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_LastState_Public_get_Boolean_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Vector2_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Vector2_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Protected_set_Void_Boolean_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPressed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_WasPressed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_WasReleased_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_get_Angle_Public_get_Single_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_TwoAxisInputControl_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_TwoAxisInputControl_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_TwoAxisInputControl_0;
	}
}
