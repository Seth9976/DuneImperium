using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x0200002B RID: 43
public sealed class EventDispatcher : MonoBehaviour
{
	// Token: 0x0600040D RID: 1037 RVA: 0x000233F4 File Offset: 0x000215F4
	// Note: this type is marked as 'beforefieldinit'.
	static EventDispatcher()
	{
		Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "EventDispatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr);
		EventDispatcher.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "<Instance>k__BackingField");
		EventDispatcher.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "listeners");
		EventDispatcher.NativeMethodInfoPtr_get_Instance_Public_Static_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663869);
		EventDispatcher.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663870);
		EventDispatcher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663871);
		EventDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663872);
		EventDispatcher.NativeMethodInfoPtr_AddListener_Public_Void_Action_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663873);
		EventDispatcher.NativeMethodInfoPtr_AddListener_Public_Void_Action_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663874);
		EventDispatcher.NativeMethodInfoPtr_addListener_Private_Void_Type_Delegate_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663875);
		EventDispatcher.NativeMethodInfoPtr_RemoveListener_Public_Void_Action_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663876);
		EventDispatcher.NativeMethodInfoPtr_RemoveListener_Public_Void_Action_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663877);
		EventDispatcher.NativeMethodInfoPtr_removeListener_Private_Void_Type_Delegate_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663878);
		EventDispatcher.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663879);
		EventDispatcher.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663880);
		EventDispatcher.NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663881);
		EventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663882);
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x00023564 File Offset: 0x00021764
	// (set) Token: 0x0600040F RID: 1039 RVA: 0x00023598 File Offset: 0x00021798
	public unsafe static EventDispatcher Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855916, XrefRangeEnd = 855918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_get_Instance_Public_Static_get_EventDispatcher_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855918, XrefRangeEnd = 855922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EventDispatcher_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x000235D0 File Offset: 0x000217D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855922, XrefRangeEnd = 855926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00023604 File Offset: 0x00021804
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855926, XrefRangeEnd = 855936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00023638 File Offset: 0x00021838
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855942, RefRangeEnd = 855943, XrefRangeStart = 855936, XrefRangeEnd = 855942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddListener<T>(Action listener, global::Il2CppSystem.Object producer) where T : DWDEvent
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.MethodInfoStoreGeneric_AddListener_Public_Void_Action_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0002368C File Offset: 0x0002188C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855949, RefRangeEnd = 855950, XrefRangeStart = 855943, XrefRangeEnd = 855949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddListener<T>(Action<T> listener, global::Il2CppSystem.Object producer) where T : DWDEvent
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.MethodInfoStoreGeneric_AddListener_Public_Void_Action_1_T_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x000236E0 File Offset: 0x000218E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 855968, RefRangeEnd = 855970, XrefRangeStart = 855950, XrefRangeEnd = 855968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addListener(Type eventType, Delegate listener, global::Il2CppSystem.Object producer, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_addListener_Private_Void_Type_Delegate_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00023754 File Offset: 0x00021954
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855976, RefRangeEnd = 855977, XrefRangeStart = 855970, XrefRangeEnd = 855976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveListener<T>(Action listener, global::Il2CppSystem.Object producer) where T : DWDEvent
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.MethodInfoStoreGeneric_RemoveListener_Public_Void_Action_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x000237A8 File Offset: 0x000219A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 855983, RefRangeEnd = 855984, XrefRangeStart = 855977, XrefRangeEnd = 855983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveListener<T>(Action<T> listener, global::Il2CppSystem.Object producer) where T : DWDEvent
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.MethodInfoStoreGeneric_RemoveListener_Public_Void_Action_1_T_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x000237FC File Offset: 0x000219FC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 855995, RefRangeEnd = 855997, XrefRangeStart = 855984, XrefRangeEnd = 855995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeListener(Type eventType, Delegate listener, global::Il2CppSystem.Object producer, bool withParam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventType);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(producer);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withParam;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_removeListener_Private_Void_Type_Delegate_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00023870 File Offset: 0x00021A70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 855997, XrefRangeEnd = 856006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllListeners(global::Il2CppSystem.Object producer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(producer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x000238B4 File Offset: 0x00021AB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856006, XrefRangeEnd = 856008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x000238E8 File Offset: 0x00021AE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856028, RefRangeEnd = 856029, XrefRangeStart = 856008, XrefRangeEnd = 856028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchEvent(DWDEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0002392C File Offset: 0x00021B2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856029, XrefRangeEnd = 856049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventDispatcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00003936 File Offset: 0x00001B36
	public EventDispatcher(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x00023968 File Offset: 0x00021B68
	// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000393F File Offset: 0x00001B3F
	public unsafe static EventDispatcher _Instance_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x0600041F RID: 1055 RVA: 0x00023990 File Offset: 0x00021B90
	// (set) Token: 0x06000420 RID: 1056 RVA: 0x00003951 File Offset: 0x00001B51
	public unsafe EventListeners listeners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_listeners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListeners>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_listeners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040002F8 RID: 760
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	// Token: 0x040002F9 RID: 761
	private static readonly IntPtr NativeFieldInfoPtr_listeners;

	// Token: 0x040002FA RID: 762
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_EventDispatcher_0;

	// Token: 0x040002FB RID: 763
	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EventDispatcher_0;

	// Token: 0x040002FC RID: 764
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040002FD RID: 765
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040002FE RID: 766
	private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_Action_Object_0;

	// Token: 0x040002FF RID: 767
	private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_Action_1_T_Object_0;

	// Token: 0x04000300 RID: 768
	private static readonly IntPtr NativeMethodInfoPtr_addListener_Private_Void_Type_Delegate_Object_Boolean_0;

	// Token: 0x04000301 RID: 769
	private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Action_Object_0;

	// Token: 0x04000302 RID: 770
	private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Action_1_T_Object_0;

	// Token: 0x04000303 RID: 771
	private static readonly IntPtr NativeMethodInfoPtr_removeListener_Private_Void_Type_Delegate_Object_Boolean_0;

	// Token: 0x04000304 RID: 772
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_Object_0;

	// Token: 0x04000305 RID: 773
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	// Token: 0x04000306 RID: 774
	private static readonly IntPtr NativeMethodInfoPtr_DispatchEvent_Public_Void_DWDEvent_0;

	// Token: 0x04000307 RID: 775
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200023A RID: 570
	private sealed class MethodInfoStoreGeneric_AddListener_Public_Void_Action_Object_0<T>
	{
		// Token: 0x0400154A RID: 5450
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventDispatcher.NativeMethodInfoPtr_AddListener_Public_Void_Action_Object_0, Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200023B RID: 571
	private sealed class MethodInfoStoreGeneric_AddListener_Public_Void_Action_1_T_Object_0<T>
	{
		// Token: 0x0400154B RID: 5451
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventDispatcher.NativeMethodInfoPtr_AddListener_Public_Void_Action_1_T_Object_0, Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200023C RID: 572
	private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Void_Action_Object_0<T>
	{
		// Token: 0x0400154C RID: 5452
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventDispatcher.NativeMethodInfoPtr_RemoveListener_Public_Void_Action_Object_0, Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200023D RID: 573
	private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Void_Action_1_T_Object_0<T>
	{
		// Token: 0x0400154D RID: 5453
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventDispatcher.NativeMethodInfoPtr_RemoveListener_Public_Void_Action_1_T_Object_0, Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
