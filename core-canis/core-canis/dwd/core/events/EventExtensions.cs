using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace dwd.core.events
{
	// Token: 0x020001B7 RID: 439
	public static class EventExtensions : Object
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x00075AB8 File Offset: 0x00073CB8
		// Note: this type is marked as 'beforefieldinit'.
		static EventExtensions()
		{
			Il2CppClassPointerStore<EventExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.events", "EventExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr);
			EventExtensions.NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr, 100667211);
			EventExtensions.NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr, 100667212);
			EventExtensions.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr, 100667213);
			EventExtensions.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr, 100667214);
			EventExtensions.NativeMethodInfoPtr_DispatchEvent_Public_Static_Void_Object_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventExtensions>.NativeClassPtr, 100667215);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00075B4C File Offset: 0x00073D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 880551, RefRangeEnd = 880553, XrefRangeStart = 880543, XrefRangeEnd = 880551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddListener<T>(this Object source, Action listener) where T : DWDEvent
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventExtensions.MethodInfoStoreGeneric_AddListener_Public_Static_Void_Object_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00075B94 File Offset: 0x00073D94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 880561, RefRangeEnd = 880567, XrefRangeStart = 880553, XrefRangeEnd = 880561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddListener<T>(this Object source, Action<T> listener) where T : DWDEvent
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventExtensions.MethodInfoStoreGeneric_AddListener_Public_Static_Void_Object_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00075BDC File Offset: 0x00073DDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 880575, RefRangeEnd = 880577, XrefRangeStart = 880567, XrefRangeEnd = 880575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveListener<T>(this Object source, Action listener) where T : DWDEvent
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventExtensions.MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Object_Action_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00075C24 File Offset: 0x00073E24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 880585, RefRangeEnd = 880591, XrefRangeStart = 880577, XrefRangeEnd = 880585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveListener<T>(this Object source, Action<T> listener) where T : DWDEvent
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventExtensions.MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Object_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00075C6C File Offset: 0x00073E6C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 880600, RefRangeEnd = 880614, XrefRangeStart = 880591, XrefRangeEnd = 880600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DispatchEvent(this Object source, DWDEvent evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventExtensions.NativeMethodInfoPtr_DispatchEvent_Public_Static_Void_Object_DWDEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000AD04 File Offset: 0x00008F04
		public EventExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_1_T_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_1_T_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Static_Void_Object_DWDEvent_0;

		// Token: 0x0200035A RID: 858
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Static_Void_Object_Action_0<T>
		{
			// Token: 0x04001ABD RID: 6845
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventExtensions.NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_0, Il2CppClassPointerStore<EventExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035B RID: 859
		private sealed class MethodInfoStoreGeneric_AddListener_Public_Static_Void_Object_Action_1_T_0<T>
		{
			// Token: 0x04001ABE RID: 6846
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventExtensions.NativeMethodInfoPtr_AddListener_Public_Static_Void_Object_Action_1_T_0, Il2CppClassPointerStore<EventExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035C RID: 860
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Object_Action_0<T>
		{
			// Token: 0x04001ABF RID: 6847
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventExtensions.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_0, Il2CppClassPointerStore<EventExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035D RID: 861
		private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Object_Action_1_T_0<T>
		{
			// Token: 0x04001AC0 RID: 6848
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventExtensions.NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Object_Action_1_T_0, Il2CppClassPointerStore<EventExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
