using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace InControl
{
	// Token: 0x02000026 RID: 38
	public class InputControl : OneAxisInputControl
	{
		// Token: 0x06000272 RID: 626 RVA: 0x00010A98 File Offset: 0x0000EC98
		// Note: this type is marked as 'beforefieldinit'.
		static InputControl()
		{
			Il2CppClassPointerStore<InputControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InputControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputControl>.NativeClassPtr);
			InputControl.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "Null");
			InputControl.NativeFieldInfoPtr__Handle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "<Handle>k__BackingField");
			InputControl.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "<Target>k__BackingField");
			InputControl.NativeFieldInfoPtr_Passive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "Passive");
			InputControl.NativeFieldInfoPtr__IsButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "<IsButton>k__BackingField");
			InputControl.NativeFieldInfoPtr__IsAnalog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "<IsAnalog>k__BackingField");
			InputControl.NativeFieldInfoPtr_zeroTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputControl>.NativeClassPtr, "zeroTick");
			InputControl.NativeMethodInfoPtr_get_Handle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663638);
			InputControl.NativeMethodInfoPtr_set_Handle_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663639);
			InputControl.NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663640);
			InputControl.NativeMethodInfoPtr_set_Target_Protected_set_Void_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663641);
			InputControl.NativeMethodInfoPtr_get_IsButton_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663642);
			InputControl.NativeMethodInfoPtr_set_IsButton_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663643);
			InputControl.NativeMethodInfoPtr_get_IsAnalog_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663644);
			InputControl.NativeMethodInfoPtr_set_IsAnalog_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663645);
			InputControl.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663646);
			InputControl.NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663647);
			InputControl.NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663648);
			InputControl.NativeMethodInfoPtr_SetZeroTick_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663649);
			InputControl.NativeMethodInfoPtr_get_IsOnZeroTick_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663650);
			InputControl.NativeMethodInfoPtr_get_IsStandard_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputControl>.NativeClassPtr, 100663651);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00010C6C File Offset: 0x0000EE6C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		public unsafe string Handle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_Handle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_set_Handle_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00010D24 File Offset: 0x0000EF24
		public unsafe InputControlType Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_set_Target_Protected_set_Void_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00010D64 File Offset: 0x0000EF64
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		public unsafe bool IsButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_IsButton_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_set_IsButton_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00010E1C File Offset: 0x0000F01C
		public unsafe bool IsAnalog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_IsAnalog_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_set_IsAnalog_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00010E5C File Offset: 0x0000F05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769365, XrefRangeEnd = 769369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00010E98 File Offset: 0x0000F098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 769375, RefRangeEnd = 769377, XrefRangeStart = 769369, XrefRangeEnd = 769375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl(string handle, InputControlType target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769377, XrefRangeEnd = 769378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputControl(string handle, InputControlType target, bool passive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputControl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00010F5C File Offset: 0x0000F15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 769378, RefRangeEnd = 769379, XrefRangeStart = 769378, XrefRangeEnd = 769378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZeroTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_SetZeroTick_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00010F90 File Offset: 0x0000F190
		public unsafe bool IsOnZeroTick
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 769379, RefRangeEnd = 769380, XrefRangeStart = 769379, XrefRangeEnd = 769379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_IsOnZeroTick_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00010FCC File Offset: 0x0000F1CC
		public unsafe bool IsStandard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 769384, RefRangeEnd = 769385, XrefRangeStart = 769380, XrefRangeEnd = 769384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputControl.NativeMethodInfoPtr_get_IsStandard_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002E1D File Offset: 0x0000101D
		public InputControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00011008 File Offset: 0x0000F208
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002E26 File Offset: 0x00001026
		public unsafe static InputControl Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InputControl.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputControl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputControl.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00011030 File Offset: 0x0000F230
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002E38 File Offset: 0x00001038
		public unsafe string _Handle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__Handle_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__Handle_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00011058 File Offset: 0x0000F258
		// (set) Token: 0x06000287 RID: 647 RVA: 0x00002E57 File Offset: 0x00001057
		public unsafe InputControlType _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__Target_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__Target_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00011080 File Offset: 0x0000F280
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002E72 File Offset: 0x00001072
		public unsafe bool Passive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr_Passive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr_Passive)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000110A8 File Offset: 0x0000F2A8
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002E8D File Offset: 0x0000108D
		public unsafe bool _IsButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__IsButton_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__IsButton_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000110D0 File Offset: 0x0000F2D0
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00002EA8 File Offset: 0x000010A8
		public unsafe bool _IsAnalog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__IsAnalog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr__IsAnalog_k__BackingField)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000110F8 File Offset: 0x0000F2F8
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002EC3 File Offset: 0x000010C3
		public unsafe ulong zeroTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr_zeroTick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputControl.NativeFieldInfoPtr_zeroTick)) = value;
			}
		}

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr__Handle_k__BackingField;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_Passive;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__IsButton_k__BackingField;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr__IsAnalog_k__BackingField;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_zeroTick;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_String_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Protected_set_Void_String_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_InputControlType_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_InputControlType_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_IsButton_Public_get_Boolean_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_set_IsButton_Protected_set_Void_Boolean_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnalog_Public_get_Boolean_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAnalog_Protected_set_Void_Boolean_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputControlType_Boolean_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_SetZeroTick_Internal_Void_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnZeroTick_Internal_get_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStandard_Public_get_Boolean_0;
	}
}
