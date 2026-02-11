using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200002C RID: 44
public sealed class EventHandlers : Object
{
	// Token: 0x06000421 RID: 1057 RVA: 0x000239C0 File Offset: 0x00021BC0
	// Note: this type is marked as 'beforefieldinit'.
	static EventHandlers()
	{
		Il2CppClassPointerStore<EventHandlers>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "EventHandlers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr);
		EventHandlers.NativeFieldInfoPtr_typeDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, "typeDelegates");
		EventHandlers.NativeFieldInfoPtr_singleArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, "singleArg");
		EventHandlers.NativeFieldInfoPtr_keysToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, "keysToRemove");
		EventHandlers.NativeMethodInfoPtr_AddHandler_Public_Void_Type_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663883);
		EventHandlers.NativeMethodInfoPtr_RemoveHandler_Public_Int32_Type_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663884);
		EventHandlers.NativeMethodInfoPtr_DispatchEvent_Public_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663885);
		EventHandlers.NativeMethodInfoPtr_Cleanup_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663886);
		EventHandlers.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663887);
		EventHandlers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr, 100663888);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00023AA4 File Offset: 0x00021CA4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 856096, RefRangeEnd = 856100, XrefRangeStart = 856049, XrefRangeEnd = 856096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHandler(Type eventType, Delegate handler, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr_AddHandler_Public_Void_Type_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00023B08 File Offset: 0x00021D08
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 856120, RefRangeEnd = 856124, XrefRangeStart = 856100, XrefRangeEnd = 856120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RemoveHandler(Type eventType, Delegate handler, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr_RemoveHandler_Public_Int32_Type_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00023B78 File Offset: 0x00021D78
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 856182, RefRangeEnd = 856186, XrefRangeStart = 856124, XrefRangeEnd = 856182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DispatchEvent(DWDEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr_DispatchEvent_Public_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00023BC8 File Offset: 0x00021DC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856258, RefRangeEnd = 856260, XrefRangeStart = 856186, XrefRangeEnd = 856258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Cleanup(bool logCleanedTypes = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref logCleanedTypes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr_Cleanup_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00023C14 File Offset: 0x00021E14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856264, RefRangeEnd = 856265, XrefRangeStart = 856260, XrefRangeEnd = 856264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00023C48 File Offset: 0x00021E48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856273, RefRangeEnd = 856274, XrefRangeStart = 856265, XrefRangeEnd = 856273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventHandlers()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventHandlers>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventHandlers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00003970 File Offset: 0x00001B70
	public EventHandlers(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000429 RID: 1065 RVA: 0x00023C84 File Offset: 0x00021E84
	// (set) Token: 0x0600042A RID: 1066 RVA: 0x00003979 File Offset: 0x00001B79
	public unsafe Dictionary<Type, List<WeakDelegate>> typeDelegates
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlers.NativeFieldInfoPtr_typeDelegates);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, List<WeakDelegate>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventHandlers.NativeFieldInfoPtr_typeDelegates), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x0600042B RID: 1067 RVA: 0x00023CB4 File Offset: 0x00021EB4
	// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003998 File Offset: 0x00001B98
	public unsafe static Il2CppReferenceArray<Object> singleArg
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(EventHandlers.NativeFieldInfoPtr_singleArg, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(EventHandlers.NativeFieldInfoPtr_singleArg, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x0600042D RID: 1069 RVA: 0x00023CDC File Offset: 0x00021EDC
	// (set) Token: 0x0600042E RID: 1070 RVA: 0x000039AA File Offset: 0x00001BAA
	public unsafe static List<Type> keysToRemove
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(EventHandlers.NativeFieldInfoPtr_keysToRemove, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(EventHandlers.NativeFieldInfoPtr_keysToRemove, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000308 RID: 776
	private static readonly IntPtr NativeFieldInfoPtr_typeDelegates;

	// Token: 0x04000309 RID: 777
	private static readonly IntPtr NativeFieldInfoPtr_singleArg;

	// Token: 0x0400030A RID: 778
	private static readonly IntPtr NativeFieldInfoPtr_keysToRemove;

	// Token: 0x0400030B RID: 779
	private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Public_Void_Type_Delegate_Boolean_0;

	// Token: 0x0400030C RID: 780
	private static readonly IntPtr NativeMethodInfoPtr_RemoveHandler_Public_Int32_Type_Delegate_Boolean_0;

	// Token: 0x0400030D RID: 781
	private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Boolean_DWDEvent_0;

	// Token: 0x0400030E RID: 782
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Boolean_Boolean_0;

	// Token: 0x0400030F RID: 783
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	// Token: 0x04000310 RID: 784
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
