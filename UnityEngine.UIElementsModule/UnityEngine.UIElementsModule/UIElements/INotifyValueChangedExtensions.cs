using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000064 RID: 100
	public static class INotifyValueChangedExtensions : Object
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x0003D930 File Offset: 0x0003BB30
		// Note: this type is marked as 'beforefieldinit'.
		static INotifyValueChangedExtensions()
		{
			Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "INotifyValueChangedExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr);
			INotifyValueChangedExtensions.NativeMethodInfoPtr_RegisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr, 100664616);
			INotifyValueChangedExtensions.NativeMethodInfoPtr_UnregisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr, 100664617);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0003D988 File Offset: 0x0003BB88
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295595, RefRangeEnd = 295607, XrefRangeStart = 295590, XrefRangeEnd = 295595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(INotifyValueChangedExtensions.MethodInfoStoreGeneric_RegisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0003D9DC File Offset: 0x0003BBDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 295612, RefRangeEnd = 295617, XrefRangeStart = 295607, XrefRangeEnd = 295612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(INotifyValueChangedExtensions.MethodInfoStoreGeneric_UnregisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00005435 File Offset: 0x00003635
		public INotifyValueChangedExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_RegisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0;

		// Token: 0x02000383 RID: 899
		private sealed class MethodInfoStoreGeneric_RegisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0<T>
		{
			// Token: 0x040027C3 RID: 10179
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(INotifyValueChangedExtensions.NativeMethodInfoPtr_RegisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0, Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000384 RID: 900
		private sealed class MethodInfoStoreGeneric_UnregisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0<T>
		{
			// Token: 0x040027C4 RID: 10180
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(INotifyValueChangedExtensions.NativeMethodInfoPtr_UnregisterValueChangedCallback_Public_Static_Boolean_INotifyValueChanged_1_T_EventCallback_1_ChangeEvent_1_T_0, Il2CppClassPointerStore<INotifyValueChangedExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
