using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000103 RID: 259
	public static class PointerEventsHelper : Object
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x00065554 File Offset: 0x00063754
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventsHelper()
		{
			Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventsHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr);
			PointerEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr, 100666278);
			PointerEventsHelper.NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr, 100666279);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x000655AC File Offset: 0x000637AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315418, RefRangeEnd = 315421, XrefRangeStart = 315364, XrefRangeEnd = 315418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) where TLeaveEvent : PointerEventBase<TLeaveEvent>, new() where TEnterEvent : PointerEventBase<TEnterEvent>, new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderPointer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventsHelper.MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0<TLeaveEvent, TEnterEvent>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00065624 File Offset: 0x00063824
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315442, RefRangeEnd = 315445, XrefRangeStart = 315421, XrefRangeEnd = 315442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousTopElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTopElementUnderPointer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventsHelper.NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00009BD8 File Offset: 0x00007DD8
		public PointerEventsHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_SendOverOut_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0;

		// Token: 0x02000431 RID: 1073
		private sealed class MethodInfoStoreGeneric_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0<TLeaveEvent, TEnterEvent>
		{
			// Token: 0x040029D5 RID: 10709
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PointerEventsHelper.NativeMethodInfoPtr_SendEnterLeave_Internal_Static_Void_VisualElement_VisualElement_IPointerEvent_Vector2_Int32_0, Il2CppClassPointerStore<PointerEventsHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TLeaveEvent>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnterEvent>.NativeClassPtr))
			}))));
		}
	}
}
