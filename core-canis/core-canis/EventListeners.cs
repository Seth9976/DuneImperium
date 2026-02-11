using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200002D RID: 45
public sealed class EventListeners : Object
{
	// Token: 0x0600042F RID: 1071 RVA: 0x00023D04 File Offset: 0x00021F04
	// Note: this type is marked as 'beforefieldinit'.
	static EventListeners()
	{
		Il2CppClassPointerStore<EventListeners>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "EventListeners");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventListeners>.NativeClassPtr);
		EventListeners.NativeFieldInfoPtr_handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, "handlers");
		EventListeners.NativeFieldInfoPtr_keysToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, "keysToRemove");
		EventListeners.NativeMethodInfoPtr_AddListener_Public_Void_Object_Type_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663890);
		EventListeners.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_Type_Delegate_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663891);
		EventListeners.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663892);
		EventListeners.NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663893);
		EventListeners.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663894);
		EventListeners.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListeners>.NativeClassPtr, 100663895);
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00023DD4 File Offset: 0x00021FD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856274, XrefRangeEnd = 856292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddListener(Object producer, Type eventType, Delegate listener, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(producer);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr_AddListener_Public_Void_Object_Type_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00023E48 File Offset: 0x00022048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856292, XrefRangeEnd = 856303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveListener(Object producer, Type eventType, Delegate listener, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(producer);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_Type_Delegate_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00023EBC File Offset: 0x000220BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856303, XrefRangeEnd = 856312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllListeners(Object producer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(producer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00023F00 File Offset: 0x00022100
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856312, XrefRangeEnd = 856316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchEvent(DWDEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00023F44 File Offset: 0x00022144
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856362, RefRangeEnd = 856364, XrefRangeStart = 856316, XrefRangeEnd = 856362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00023F78 File Offset: 0x00022178
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856364, XrefRangeEnd = 856379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventListeners()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventListeners>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListeners.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x000039BC File Offset: 0x00001BBC
	public EventListeners(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x00023FB4 File Offset: 0x000221B4
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x000039C5 File Offset: 0x00001BC5
	public unsafe Dictionary<Object, EventHandlers> handlers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListeners.NativeFieldInfoPtr_handlers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, EventHandlers>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListeners.NativeFieldInfoPtr_handlers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000439 RID: 1081 RVA: 0x00023FE4 File Offset: 0x000221E4
	// (set) Token: 0x0600043A RID: 1082 RVA: 0x000039E4 File Offset: 0x00001BE4
	public unsafe List<Object> keysToRemove
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListeners.NativeFieldInfoPtr_keysToRemove);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListeners.NativeFieldInfoPtr_keysToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000311 RID: 785
	private static readonly IntPtr NativeFieldInfoPtr_handlers;

	// Token: 0x04000312 RID: 786
	private static readonly IntPtr NativeFieldInfoPtr_keysToRemove;

	// Token: 0x04000313 RID: 787
	private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_Object_Type_Delegate_Boolean_0;

	// Token: 0x04000314 RID: 788
	private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Object_Type_Delegate_Boolean_0;

	// Token: 0x04000315 RID: 789
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0;

	// Token: 0x04000316 RID: 790
	private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0;

	// Token: 0x04000317 RID: 791
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	// Token: 0x04000318 RID: 792
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
