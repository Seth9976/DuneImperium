using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000026 RID: 38
	public class ClickDetector : Object
	{
		// Token: 0x0600027D RID: 637 RVA: 0x000256CC File Offset: 0x000238CC
		// Note: this type is marked as 'beforefieldinit'.
		static ClickDetector()
		{
			Il2CppClassPointerStore<ClickDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ClickDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr);
			ClickDetector.NativeFieldInfoPtr_m_ClickStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "m_ClickStatus");
			ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "<s_DoubleClickTime>k__BackingField");
			ClickDetector.NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663619);
			ClickDetector.NativeMethodInfoPtr_set_s_DoubleClickTime_Internal_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663620);
			ClickDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663621);
			ClickDetector.NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663622);
			ClickDetector.NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663623);
			ClickDetector.NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663624);
			ClickDetector.NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663625);
			ClickDetector.NativeMethodInfoPtr_ContainsPointer_Private_Static_Boolean_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663626);
			ClickDetector.NativeMethodInfoPtr_Cleanup_Internal_Void_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, 100663627);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000257D8 File Offset: 0x000239D8
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00025808 File Offset: 0x00023A08
		public unsafe static int s_DoubleClickTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284787, XrefRangeEnd = 284791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284791, XrefRangeEnd = 284795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_set_s_DoubleClickTime_Internal_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002583C File Offset: 0x00023A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284834, RefRangeEnd = 284835, XrefRangeStart = 284795, XrefRangeEnd = 284834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00025878 File Offset: 0x00023A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284835, XrefRangeEnd = 284860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartClickTracking(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000258BC File Offset: 0x00023ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284908, RefRangeEnd = 284909, XrefRangeStart = 284860, XrefRangeEnd = 284908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClickEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00025900 File Offset: 0x00023B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284909, XrefRangeEnd = 284918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelClickTracking(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00025944 File Offset: 0x00023B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284951, RefRangeEnd = 284952, XrefRangeStart = 284918, XrefRangeEnd = 284951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00025988 File Offset: 0x00023B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284952, XrefRangeEnd = 284958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsPointer(VisualElement element, Vector2 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_ContainsPointer_Private_Static_Boolean_VisualElement_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000259D8 File Offset: 0x00023BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284976, RefRangeEnd = 284977, XrefRangeStart = 284958, XrefRangeEnd = 284976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup(List<VisualElement> elements)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.NativeMethodInfoPtr_Cleanup_Internal_Void_List_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002BAA File Offset: 0x00000DAA
		public ClickDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00025A1C File Offset: 0x00023C1C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00002BB3 File Offset: 0x00000DB3
		public unsafe List<ClickDetector.ButtonClickStatus> m_ClickStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.NativeFieldInfoPtr_m_ClickStatus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClickDetector.ButtonClickStatus>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.NativeFieldInfoPtr_m_ClickStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00025A4C File Offset: 0x00023C4C
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002BD2 File Offset: 0x00000DD2
		public unsafe static int _s_DoubleClickTime_k__BackingField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClickDetector.NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_m_ClickStatus;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr__s_DoubleClickTime_k__BackingField;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_get_s_DoubleClickTime_Internal_Static_get_Int32_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_set_s_DoubleClickTime_Internal_Static_set_Void_Int32_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_StartClickTracking_Private_Void_EventBase_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_SendClickEvent_Private_Void_EventBase_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_CancelClickTracking_Private_Void_EventBase_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Public_Void_EventBase_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPointer_Private_Static_Boolean_VisualElement_Vector2_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_List_1_VisualElement_0;

		// Token: 0x02000326 RID: 806
		public class ButtonClickStatus : Object
		{
			// Token: 0x0600352C RID: 13612 RVA: 0x000DCD90 File Offset: 0x000DAF90
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonClickStatus()
			{
				Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClickDetector>.NativeClassPtr, "ButtonClickStatus");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr);
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_Target");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_PointerDownPosition");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_LastPointerDownTime");
				ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, "m_ClickCount");
				ClickDetector.ButtonClickStatus.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, 100663629);
				ClickDetector.ButtonClickStatus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr, 100663630);
			}

			// Token: 0x0600352D RID: 13613 RVA: 0x000DCE34 File Offset: 0x000DB034
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 284784, RefRangeEnd = 284787, XrefRangeStart = 284781, XrefRangeEnd = 284784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.ButtonClickStatus.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600352E RID: 13614 RVA: 0x000DCE68 File Offset: 0x000DB068
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonClickStatus()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickDetector.ButtonClickStatus>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickDetector.ButtonClickStatus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600352F RID: 13615 RVA: 0x0001592C File Offset: 0x00013B2C
			public ButtonClickStatus(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x06003530 RID: 13616 RVA: 0x000DCEA4 File Offset: 0x000DB0A4
			// (set) Token: 0x06003531 RID: 13617 RVA: 0x00015935 File Offset: 0x00013B35
			public unsafe VisualElement m_Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x06003532 RID: 13618 RVA: 0x000DCED4 File Offset: 0x000DB0D4
			// (set) Token: 0x06003533 RID: 13619 RVA: 0x00015954 File Offset: 0x00013B54
			public unsafe Vector3 m_PointerDownPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_PointerDownPosition)) = value;
				}
			}

			// Token: 0x17001080 RID: 4224
			// (get) Token: 0x06003534 RID: 13620 RVA: 0x000DCEFC File Offset: 0x000DB0FC
			// (set) Token: 0x06003535 RID: 13621 RVA: 0x0001596F File Offset: 0x00013B6F
			public unsafe long m_LastPointerDownTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_LastPointerDownTime)) = value;
				}
			}

			// Token: 0x17001081 RID: 4225
			// (get) Token: 0x06003536 RID: 13622 RVA: 0x000DCF24 File Offset: 0x000DB124
			// (set) Token: 0x06003537 RID: 13623 RVA: 0x0001598A File Offset: 0x00013B8A
			public unsafe int m_ClickCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickDetector.ButtonClickStatus.NativeFieldInfoPtr_m_ClickCount)) = value;
				}
			}

			// Token: 0x0400263B RID: 9787
			private static readonly IntPtr NativeFieldInfoPtr_m_Target;

			// Token: 0x0400263C RID: 9788
			private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownPosition;

			// Token: 0x0400263D RID: 9789
			private static readonly IntPtr NativeFieldInfoPtr_m_LastPointerDownTime;

			// Token: 0x0400263E RID: 9790
			private static readonly IntPtr NativeFieldInfoPtr_m_ClickCount;

			// Token: 0x0400263F RID: 9791
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04002640 RID: 9792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
