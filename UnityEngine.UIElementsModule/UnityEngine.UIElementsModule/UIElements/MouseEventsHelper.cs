using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000102 RID: 258
	public static class MouseEventsHelper : Object
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x0006542C File Offset: 0x0006362C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEventsHelper()
		{
			Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEventsHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr);
			MouseEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr, 100666276);
			MouseEventsHelper.NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr, 100666277);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00065484 File Offset: 0x00063684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315337, RefRangeEnd = 315340, XrefRangeStart = 315283, XrefRangeEnd = 315337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) where TLeaveEvent : MouseEventBase<TLeaveEvent>, new() where TEnterEvent : MouseEventBase<TEnterEvent>, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderMouse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderMouse);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventsHelper.MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0<TLeaveEvent, TEnterEvent>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x000654EC File Offset: 0x000636EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315361, RefRangeEnd = 315364, XrefRangeStart = 315340, XrefRangeEnd = 315361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderMouse);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderMouse);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventsHelper.NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00009BCF File Offset: 0x00007DCF
		public MouseEventsHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_SendMouseOverMouseOut_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0;

		// Token: 0x02000430 RID: 1072
		private sealed class MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0<TLeaveEvent, TEnterEvent>
		{
			// Token: 0x040029D4 RID: 10708
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MouseEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IMouseEvent_Vector2_0, Il2CppClassPointerStore<MouseEventsHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeaveEvent>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnterEvent>.NativeClassPtr))
			}))));
		}
	}
}
