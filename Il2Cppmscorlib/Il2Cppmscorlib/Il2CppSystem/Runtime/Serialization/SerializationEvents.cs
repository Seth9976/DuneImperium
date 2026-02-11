using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000322 RID: 802
	public sealed class SerializationEvents : Object
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x000F8E0C File Offset: 0x000F700C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEvents()
		{
			Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr);
			SerializationEvents.NativeFieldInfoPtr__onSerializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "_onSerializingMethods");
			SerializationEvents.NativeFieldInfoPtr__onSerializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "_onSerializedMethods");
			SerializationEvents.NativeFieldInfoPtr__onDeserializingMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "_onDeserializingMethods");
			SerializationEvents.NativeFieldInfoPtr__onDeserializedMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, "_onDeserializedMethods");
			SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670992);
			SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670993);
			SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670994);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670995);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670996);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670997);
			SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670998);
			SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100670999);
			SerializationEvents.NativeMethodInfoPtr_InvokeOnDelegate_Private_Static_Void_Object_StreamingContext_List_1_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671000);
			SerializationEvents.NativeMethodInfoPtr_AddOnDelegate_Private_Static_SerializationEventHandler_Object_SerializationEventHandler_List_1_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr, 100671001);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000F8F54 File Offset: 0x000F7154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384633, XrefRangeEnd = 1384657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEvents(Type t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEvents>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000F8FA0 File Offset: 0x000F71A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1384681, RefRangeEnd = 1384689, XrefRangeStart = 1384657, XrefRangeEnd = 1384681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr3) : null;
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x000F9004 File Offset: 0x000F7204
		public unsafe bool HasOnSerializingEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000F9040 File Offset: 0x000F7240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384689, XrefRangeEnd = 1384690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnSerializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000F909C File Offset: 0x000F729C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1384691, RefRangeEnd = 1384693, XrefRangeStart = 1384690, XrefRangeEnd = 1384691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserializing(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000F90F8 File Offset: 0x000F72F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1384694, RefRangeEnd = 1384696, XrefRangeStart = 1384693, XrefRangeEnd = 1384694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserialized(Object obj, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000F9154 File Offset: 0x000F7354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384696, XrefRangeEnd = 1384697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnSerialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000F91B8 File Offset: 0x000F73B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384698, RefRangeEnd = 1384699, XrefRangeStart = 1384697, XrefRangeEnd = 1384698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler AddOnDeserialized(Object obj, SerializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000F921C File Offset: 0x000F741C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384699, XrefRangeEnd = 1384700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnDelegate(Object obj, StreamingContext context, List<MethodInfo> methods)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_InvokeOnDelegate_Private_Static_Void_Object_StreamingContext_List_1_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000F927C File Offset: 0x000F747C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1384724, RefRangeEnd = 1384733, XrefRangeStart = 1384700, XrefRangeEnd = 1384724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationEventHandler AddOnDelegate(Object obj, SerializationEventHandler handler, List<MethodInfo> methods)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEvents.NativeMethodInfoPtr_AddOnDelegate_Private_Static_SerializationEventHandler_Object_SerializationEventHandler_List_1_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00010D25 File Offset: 0x0000EF25
		public SerializationEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x000F92E4 File Offset: 0x000F74E4
		// (set) Token: 0x060030EF RID: 12527 RVA: 0x00010D2E File Offset: 0x0000EF2E
		public unsafe List<MethodInfo> _onSerializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onSerializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onSerializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x000F9314 File Offset: 0x000F7514
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00010D4D File Offset: 0x0000EF4D
		public unsafe List<MethodInfo> _onSerializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onSerializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onSerializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x000F9344 File Offset: 0x000F7544
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00010D6C File Offset: 0x0000EF6C
		public unsafe List<MethodInfo> _onDeserializingMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onDeserializingMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onDeserializingMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000F9374 File Offset: 0x000F7574
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x00010D8B File Offset: 0x0000EF8B
		public unsafe List<MethodInfo> _onDeserializedMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onDeserializedMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MethodInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationEvents.NativeFieldInfoPtr__onDeserializedMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeFieldInfoPtr__onSerializingMethods;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeFieldInfoPtr__onSerializedMethods;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeFieldInfoPtr__onDeserializingMethods;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeFieldInfoPtr__onDeserializedMethods;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsWithAttribute_Private_List_1_MethodInfo_Type_Type_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_get_HasOnSerializingEvents_Internal_get_Boolean_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_AddOnSerialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_SerializationEventHandler_Object_SerializationEventHandler_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDelegate_Private_Static_Void_Object_StreamingContext_List_1_MethodInfo_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDelegate_Private_Static_SerializationEventHandler_Object_SerializationEventHandler_List_1_MethodInfo_0;
	}
}
