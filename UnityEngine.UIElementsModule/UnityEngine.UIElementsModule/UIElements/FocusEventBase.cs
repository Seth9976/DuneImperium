using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E0 RID: 224
	public class FocusEventBase<T> : EventBase<T> where T : FocusEventBase<T>, new()
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x000605F4 File Offset: 0x0005E7F4
		// Note: this type is marked as 'beforefieldinit'.
		static FocusEventBase()
		{
			Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr);
			FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<relatedTarget>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<direction>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<focusController>k__BackingField");
			FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, "<IsFocusDelegated>k__BackingField");
			FocusEventBase<T>.NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666004);
			FocusEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666005);
			FocusEventBase<T>.NativeMethodInfoPtr_get_direction_Public_Virtual_Final_New_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666006);
			FocusEventBase<T>.NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666007);
			FocusEventBase<T>.NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666008);
			FocusEventBase<T>.NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666009);
			FocusEventBase<T>.NativeMethodInfoPtr_get_IsFocusDelegated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666010);
			FocusEventBase<T>.NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666011);
			FocusEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666012);
			FocusEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666013);
			FocusEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666014);
			FocusEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr, 100666015);
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x000607A0 File Offset: 0x0005E9A0
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000607E0 File Offset: 0x0005E9E0
		public unsafe virtual Focusable relatedTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00060824 File Offset: 0x0005EA24
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x00060864 File Offset: 0x0005EA64
		public unsafe virtual FocusChangeDirection direction
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_direction_Public_Virtual_Final_New_get_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000608A8 File Offset: 0x0005EAA8
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000608E8 File Offset: 0x0005EAE8
		public unsafe FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0006092C File Offset: 0x0005EB2C
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x00060968 File Offset: 0x0005EB68
		public unsafe bool IsFocusDelegated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_get_IsFocusDelegated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000609A8 File Offset: 0x0005EBA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313840, RefRangeEnd = 313842, XrefRangeStart = 313837, XrefRangeEnd = 313840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000609E4 File Offset: 0x0005EBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313842, XrefRangeEnd = 313853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00060A18 File Offset: 0x0005EC18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313866, RefRangeEnd = 313870, XrefRangeStart = 313853, XrefRangeEnd = 313866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relatedTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusController);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsFocusDelegated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00060A9C File Offset: 0x0005EC9C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 313878, RefRangeEnd = 313886, XrefRangeStart = 313870, XrefRangeEnd = 313878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000096F8 File Offset: 0x000078F8
		public FocusEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00060AD8 File Offset: 0x0005ECD8
		// (set) Token: 0x06001342 RID: 4930 RVA: 0x00009701 File Offset: 0x00007901
		public unsafe Focusable _relatedTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__relatedTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00060B08 File Offset: 0x0005ED08
		// (set) Token: 0x06001344 RID: 4932 RVA: 0x00009720 File Offset: 0x00007920
		public unsafe FocusChangeDirection _direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__direction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001345 RID: 4933 RVA: 0x00060B38 File Offset: 0x0005ED38
		// (set) Token: 0x06001346 RID: 4934 RVA: 0x0000973F File Offset: 0x0000793F
		public unsafe FocusController _focusController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__focusController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x00060B68 File Offset: 0x0005ED68
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x0000975E File Offset: 0x0000795E
		public unsafe bool _IsFocusDelegated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusEventBase<T>.NativeFieldInfoPtr__IsFocusDelegated_k__BackingField)) = value;
			}
		}

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeFieldInfoPtr__relatedTarget_k__BackingField;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeFieldInfoPtr__direction_k__BackingField;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeFieldInfoPtr__focusController_k__BackingField;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeFieldInfoPtr__IsFocusDelegated_k__BackingField;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_relatedTarget_Public_Virtual_Final_New_get_Focusable_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_set_relatedTarget_Private_set_Void_Focusable_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_Virtual_Final_New_get_FocusChangeDirection_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Private_set_Void_FocusChangeDirection_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Protected_get_FocusController_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_set_focusController_Private_set_Void_FocusController_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFocusDelegated_Internal_get_Boolean_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFocusDelegated_Private_set_Void_Boolean_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IEventHandler_Focusable_FocusChangeDirection_FocusController_Boolean_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
