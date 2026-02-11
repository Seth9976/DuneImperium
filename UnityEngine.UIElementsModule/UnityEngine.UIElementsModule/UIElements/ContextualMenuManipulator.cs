using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003B RID: 59
	public class ContextualMenuManipulator : MouseManipulator
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualMenuManipulator()
		{
			Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ContextualMenuManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr);
			ContextualMenuManipulator.NativeFieldInfoPtr_m_MenuBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, "m_MenuBuilder");
			ContextualMenuManipulator.NativeMethodInfoPtr__ctor_Public_Void_Action_1_ContextualMenuPopulateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663972);
			ContextualMenuManipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663973);
			ContextualMenuManipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663974);
			ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseUpDownEvent_Private_Void_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663975);
			ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseDownEventOSX_Private_Void_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663976);
			ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseUpEventOSX_Private_Void_MouseUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663977);
			ContextualMenuManipulator.NativeMethodInfoPtr_OnKeyUpEvent_Private_Void_KeyUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663978);
			ContextualMenuManipulator.NativeMethodInfoPtr_DoDisplayMenu_Private_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663979);
			ContextualMenuManipulator.NativeMethodInfoPtr_OnContextualMenuEvent_Private_Void_ContextualMenuPopulateEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr, 100663980);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288140, RefRangeEnd = 288141, XrefRangeStart = 288125, XrefRangeEnd = 288140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualMenuManipulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(menuBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr__ctor_Public_Void_Action_1_ContextualMenuPopulateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0002ED28 File Offset: 0x0002CF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288141, XrefRangeEnd = 288195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuManipulator.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0002ED64 File Offset: 0x0002CF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288195, XrefRangeEnd = 288249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualMenuManipulator.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288249, XrefRangeEnd = 288255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseUpDownEvent(IMouseEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseUpDownEvent_Private_Void_IMouseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0002EDE4 File Offset: 0x0002CFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288255, XrefRangeEnd = 288263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDownEventOSX(MouseDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseDownEventOSX_Private_Void_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002EE28 File Offset: 0x0002D028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288263, XrefRangeEnd = 288271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseUpEventOSX(MouseUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_OnMouseUpEventOSX_Private_Void_MouseUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002EE6C File Offset: 0x0002D06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288271, XrefRangeEnd = 288273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyUpEvent(KeyUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_OnKeyUpEvent_Private_Void_KeyUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0002EEB0 File Offset: 0x0002D0B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288279, RefRangeEnd = 288283, XrefRangeStart = 288273, XrefRangeEnd = 288279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDisplayMenu(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_DoDisplayMenu_Private_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		[CallerCount(0)]
		public unsafe void OnContextualMenuEvent(ContextualMenuPopulateEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualMenuManipulator.NativeMethodInfoPtr_OnContextualMenuEvent_Private_Void_ContextualMenuPopulateEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00003575 File Offset: 0x00001775
		public ContextualMenuManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0002EF38 File Offset: 0x0002D138
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0000357E File Offset: 0x0000177E
		public unsafe Action<ContextualMenuPopulateEvent> m_MenuBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManipulator.NativeFieldInfoPtr_m_MenuBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ContextualMenuPopulateEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualMenuManipulator.NativeFieldInfoPtr_m_MenuBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_m_MenuBuilder;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_ContextualMenuPopulateEvent_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUpDownEvent_Private_Void_IMouseEvent_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDownEventOSX_Private_Void_MouseDownEvent_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUpEventOSX_Private_Void_MouseUpEvent_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyUpEvent_Private_Void_KeyUpEvent_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_DoDisplayMenu_Private_Void_EventBase_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_OnContextualMenuEvent_Private_Void_ContextualMenuPopulateEvent_0;
	}
}
