using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000147 RID: 327
	public class KeyboardNavigationManipulator : Manipulator
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x00072C04 File Offset: 0x00070E04
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardNavigationManipulator()
		{
			Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardNavigationManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr);
			KeyboardNavigationManipulator.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, "m_Action");
			KeyboardNavigationManipulator.NativeMethodInfoPtr__ctor_Public_Void_Action_2_KeyboardNavigationOperation_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666886);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666887);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666888);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_OnKeyDown_Internal_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666889);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationCancel_Private_Void_NavigationCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666890);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666891);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666892);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_Invoke_Private_Void_KeyboardNavigationOperation_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666893);
			KeyboardNavigationManipulator.NativeMethodInfoPtr_Method_Internal_Static_KeyboardNavigationOperation_byref___c__DisplayClass4_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, 100666894);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00072CFC File Offset: 0x00070EFC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320065, XrefRangeEnd = 320067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr__ctor_Public_Void_Action_2_KeyboardNavigationOperation_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00072D48 File Offset: 0x00070F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320078, XrefRangeEnd = 320115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyboardNavigationManipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00072D84 File Offset: 0x00070F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320115, XrefRangeEnd = 320152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyboardNavigationManipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00072DC0 File Offset: 0x00070FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320152, XrefRangeEnd = 320159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_OnKeyDown_Internal_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00072E04 File Offset: 0x00071004
		[CallerCount(0)]
		public unsafe void OnNavigationCancel(NavigationCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationCancel_Private_Void_NavigationCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00072E48 File Offset: 0x00071048
		[CallerCount(0)]
		public unsafe void OnNavigationSubmit(NavigationSubmitEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00072E8C File Offset: 0x0007108C
		[CallerCount(0)]
		public unsafe void OnNavigationMove(NavigationMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00072ED0 File Offset: 0x000710D0
		[CallerCount(0)]
		public unsafe void Invoke(KeyboardNavigationOperation operation, EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_Invoke_Private_Void_KeyboardNavigationOperation_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00072F20 File Offset: 0x00071120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320159, XrefRangeEnd = 320163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyboardNavigationOperation Method_Internal_Static_KeyboardNavigationOperation_byref___c__DisplayClass4_0_PDM_0(ref KeyboardNavigationManipulator.__c__DisplayClass4_0 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardNavigationManipulator.NativeMethodInfoPtr_Method_Internal_Static_KeyboardNavigationOperation_byref___c__DisplayClass4_0_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0000B245 File Offset: 0x00009445
		public KeyboardNavigationManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00072F64 File Offset: 0x00071164
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000B24E File Offset: 0x0000944E
		public unsafe Action<KeyboardNavigationOperation, EventBase> m_Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardNavigationManipulator.NativeFieldInfoPtr_m_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyboardNavigationOperation, EventBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardNavigationManipulator.NativeFieldInfoPtr_m_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeFieldInfoPtr_m_Action;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_2_KeyboardNavigationOperation_EventBase_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Internal_Void_KeyDownEvent_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationCancel_Private_Void_NavigationCancelEvent_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationSubmit_Private_Void_NavigationSubmitEvent_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationMove_Private_Void_NavigationMoveEvent_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_KeyboardNavigationOperation_EventBase_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_KeyboardNavigationOperation_byref___c__DisplayClass4_0_PDM_0;

		// Token: 0x02000473 RID: 1139
		[ObfuscatedName("UnityEngine.UIElements.KeyboardNavigationManipulator+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : ValueType
		{
			// Token: 0x06003C25 RID: 15397 RVA: 0x00019416 File Offset: 0x00017616
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<KeyboardNavigationManipulator.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyboardNavigationManipulator>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardNavigationManipulator.__c__DisplayClass4_0>.NativeClassPtr);
				KeyboardNavigationManipulator.__c__DisplayClass4_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardNavigationManipulator.__c__DisplayClass4_0>.NativeClassPtr, "evt");
			}

			// Token: 0x06003C26 RID: 15398 RVA: 0x0001944A File Offset: 0x0001764A
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003C27 RID: 15399 RVA: 0x00019453 File Offset: 0x00017653
			public __c__DisplayClass4_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardNavigationManipulator.__c__DisplayClass4_0>.NativeClassPtr))
			{
			}

			// Token: 0x1700123C RID: 4668
			// (get) Token: 0x06003C28 RID: 15400 RVA: 0x000F1B78 File Offset: 0x000EFD78
			// (set) Token: 0x06003C29 RID: 15401 RVA: 0x00019465 File Offset: 0x00017665
			public unsafe KeyDownEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardNavigationManipulator.__c__DisplayClass4_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyDownEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardNavigationManipulator.__c__DisplayClass4_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A6E RID: 10862
			private static readonly IntPtr NativeFieldInfoPtr_evt;
		}
	}
}
