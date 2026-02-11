using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class PoolableObject : MonoBehaviour
{
	// Token: 0x0600023F RID: 575 RVA: 0x0001B9A8 File Offset: 0x00019BA8
	// Note: this type is marked as 'beforefieldinit'.
	static PoolableObject()
	{
		Il2CppClassPointerStore<PoolableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "PoolableObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr);
		PoolableObject.NativeFieldInfoPtr_maxPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "maxPoolSize");
		PoolableObject.NativeFieldInfoPtr_preloadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "preloadCount");
		PoolableObject.NativeFieldInfoPtr_doNotDestroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "doNotDestroyOnLoad");
		PoolableObject.NativeFieldInfoPtr_sendAwakeStartOnDestroyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "sendAwakeStartOnDestroyMessage");
		PoolableObject.NativeFieldInfoPtr_sendPoolableActivateDeactivateMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "sendPoolableActivateDeactivateMessages");
		PoolableObject.NativeFieldInfoPtr__isAvailableForPooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_isAvailableForPooling");
		PoolableObject.NativeFieldInfoPtr__createdWithPoolController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_createdWithPoolController");
		PoolableObject.NativeFieldInfoPtr__destroyMessageFromPoolController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_destroyMessageFromPoolController");
		PoolableObject.NativeFieldInfoPtr__wasPreloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_wasPreloaded");
		PoolableObject.NativeFieldInfoPtr__wasStartCalledByUnity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_wasStartCalledByUnity");
		PoolableObject.NativeFieldInfoPtr__myPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_myPool");
		PoolableObject.NativeFieldInfoPtr__serialNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_serialNumber");
		PoolableObject.NativeFieldInfoPtr__usageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "_usageCount");
		PoolableObject.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663596);
		PoolableObject.NativeMethodInfoPtr__InvokeMethodByName_Private_Static_Void_MonoBehaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663597);
		PoolableObject.NativeMethodInfoPtr__BroadcastMessageToGameObject_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663598);
		PoolableObject.NativeMethodInfoPtr__BroadcastMessageToAllChildren_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663599);
		PoolableObject.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663600);
		PoolableObject.NativeMethodInfoPtr_GetSerialNumber_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663601);
		PoolableObject.NativeMethodInfoPtr_GetUsageCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663602);
		PoolableObject.NativeMethodInfoPtr_DeactivateAllPoolableObjectsOfMyKind_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663603);
		PoolableObject.NativeMethodInfoPtr_IsDeactivated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663604);
		PoolableObject.NativeMethodInfoPtr_GetAllPoolableObjectsOfMyKind_Public_Il2CppReferenceArray_1_PoolableObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663605);
		PoolableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663606);
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0001BBB8 File Offset: 0x00019DB8
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0001BBEC File Offset: 0x00019DEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852836, XrefRangeEnd = 852840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _InvokeMethodByName(MonoBehaviour behaviour, string methodName)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr__InvokeMethodByName_Private_Static_Void_MonoBehaviour_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0001BC34 File Offset: 0x00019E34
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 852857, RefRangeEnd = 852859, XrefRangeStart = 852840, XrefRangeEnd = 852857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _BroadcastMessageToGameObject(GameObject go, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr__BroadcastMessageToGameObject_Private_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0001BC7C File Offset: 0x00019E7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852881, RefRangeEnd = 852882, XrefRangeStart = 852859, XrefRangeEnd = 852881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _BroadcastMessageToAllChildren(GameObject go, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr__BroadcastMessageToAllChildren_Private_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0001BCC4 File Offset: 0x00019EC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852882, XrefRangeEnd = 852889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0001BCF8 File Offset: 0x00019EF8
	[CallerCount(0)]
	public unsafe int GetSerialNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_GetSerialNumber_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0001BD34 File Offset: 0x00019F34
	[CallerCount(0)]
	public unsafe int GetUsageCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_GetUsageCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0001BD70 File Offset: 0x00019F70
	[CallerCount(0)]
	public unsafe int DeactivateAllPoolableObjectsOfMyKind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_DeactivateAllPoolableObjectsOfMyKind_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0001BDAC File Offset: 0x00019FAC
	[CallerCount(0)]
	public unsafe bool IsDeactivated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_IsDeactivated_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0001BDE8 File Offset: 0x00019FE8
	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<PoolableObject> GetAllPoolableObjectsOfMyKind(bool includeInactiveObjects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref includeInactiveObjects;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_GetAllPoolableObjectsOfMyKind_Public_Il2CppReferenceArray_1_PoolableObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PoolableObject>>(intPtr3) : null;
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0001BE34 File Offset: 0x0001A034
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852889, XrefRangeEnd = 852890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolableObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002F4E File Offset: 0x0000114E
	public PoolableObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x0600024C RID: 588 RVA: 0x0001BE70 File Offset: 0x0001A070
	// (set) Token: 0x0600024D RID: 589 RVA: 0x00002F57 File Offset: 0x00001157
	public unsafe int maxPoolSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_maxPoolSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_maxPoolSize)) = value;
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600024E RID: 590 RVA: 0x0001BE98 File Offset: 0x0001A098
	// (set) Token: 0x0600024F RID: 591 RVA: 0x00002F72 File Offset: 0x00001172
	public unsafe int preloadCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_preloadCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_preloadCount)) = value;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000250 RID: 592 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
	// (set) Token: 0x06000251 RID: 593 RVA: 0x00002F8D File Offset: 0x0000118D
	public unsafe bool doNotDestroyOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_doNotDestroyOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_doNotDestroyOnLoad)) = value;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000252 RID: 594 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
	// (set) Token: 0x06000253 RID: 595 RVA: 0x00002FA8 File Offset: 0x000011A8
	public unsafe bool sendAwakeStartOnDestroyMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_sendAwakeStartOnDestroyMessage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_sendAwakeStartOnDestroyMessage)) = value;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000254 RID: 596 RVA: 0x0001BF10 File Offset: 0x0001A110
	// (set) Token: 0x06000255 RID: 597 RVA: 0x00002FC3 File Offset: 0x000011C3
	public unsafe bool sendPoolableActivateDeactivateMessages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_sendPoolableActivateDeactivateMessages);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_sendPoolableActivateDeactivateMessages)) = value;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000256 RID: 598 RVA: 0x0001BF38 File Offset: 0x0001A138
	// (set) Token: 0x06000257 RID: 599 RVA: 0x00002FDE File Offset: 0x000011DE
	public unsafe bool _isAvailableForPooling
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__isAvailableForPooling);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__isAvailableForPooling)) = value;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000258 RID: 600 RVA: 0x0001BF60 File Offset: 0x0001A160
	// (set) Token: 0x06000259 RID: 601 RVA: 0x00002FF9 File Offset: 0x000011F9
	public unsafe bool _createdWithPoolController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__createdWithPoolController);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__createdWithPoolController)) = value;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600025A RID: 602 RVA: 0x0001BF88 File Offset: 0x0001A188
	// (set) Token: 0x0600025B RID: 603 RVA: 0x00003014 File Offset: 0x00001214
	public unsafe bool _destroyMessageFromPoolController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__destroyMessageFromPoolController);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__destroyMessageFromPoolController)) = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600025C RID: 604 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
	// (set) Token: 0x0600025D RID: 605 RVA: 0x0000302F File Offset: 0x0000122F
	public unsafe bool _wasPreloaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__wasPreloaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__wasPreloaded)) = value;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x0600025E RID: 606 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
	// (set) Token: 0x0600025F RID: 607 RVA: 0x0000304A File Offset: 0x0000124A
	public unsafe bool _wasStartCalledByUnity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__wasStartCalledByUnity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__wasStartCalledByUnity)) = value;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000260 RID: 608 RVA: 0x0001C000 File Offset: 0x0001A200
	// (set) Token: 0x06000261 RID: 609 RVA: 0x00003065 File Offset: 0x00001265
	public unsafe ObjectPoolController.ObjectPool _myPool
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__myPool);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPoolController.ObjectPool>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__myPool), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000262 RID: 610 RVA: 0x0001C030 File Offset: 0x0001A230
	// (set) Token: 0x06000263 RID: 611 RVA: 0x00003084 File Offset: 0x00001284
	public unsafe int _serialNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__serialNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__serialNumber)) = value;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000264 RID: 612 RVA: 0x0001C058 File Offset: 0x0001A258
	// (set) Token: 0x06000265 RID: 613 RVA: 0x0000309F File Offset: 0x0000129F
	public unsafe int _usageCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__usageCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr__usageCount)) = value;
		}
	}

	// Token: 0x040001AF RID: 431
	private static readonly IntPtr NativeFieldInfoPtr_maxPoolSize;

	// Token: 0x040001B0 RID: 432
	private static readonly IntPtr NativeFieldInfoPtr_preloadCount;

	// Token: 0x040001B1 RID: 433
	private static readonly IntPtr NativeFieldInfoPtr_doNotDestroyOnLoad;

	// Token: 0x040001B2 RID: 434
	private static readonly IntPtr NativeFieldInfoPtr_sendAwakeStartOnDestroyMessage;

	// Token: 0x040001B3 RID: 435
	private static readonly IntPtr NativeFieldInfoPtr_sendPoolableActivateDeactivateMessages;

	// Token: 0x040001B4 RID: 436
	private static readonly IntPtr NativeFieldInfoPtr__isAvailableForPooling;

	// Token: 0x040001B5 RID: 437
	private static readonly IntPtr NativeFieldInfoPtr__createdWithPoolController;

	// Token: 0x040001B6 RID: 438
	private static readonly IntPtr NativeFieldInfoPtr__destroyMessageFromPoolController;

	// Token: 0x040001B7 RID: 439
	private static readonly IntPtr NativeFieldInfoPtr__wasPreloaded;

	// Token: 0x040001B8 RID: 440
	private static readonly IntPtr NativeFieldInfoPtr__wasStartCalledByUnity;

	// Token: 0x040001B9 RID: 441
	private static readonly IntPtr NativeFieldInfoPtr__myPool;

	// Token: 0x040001BA RID: 442
	private static readonly IntPtr NativeFieldInfoPtr__serialNumber;

	// Token: 0x040001BB RID: 443
	private static readonly IntPtr NativeFieldInfoPtr__usageCount;

	// Token: 0x040001BC RID: 444
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x040001BD RID: 445
	private static readonly IntPtr NativeMethodInfoPtr__InvokeMethodByName_Private_Static_Void_MonoBehaviour_String_0;

	// Token: 0x040001BE RID: 446
	private static readonly IntPtr NativeMethodInfoPtr__BroadcastMessageToGameObject_Private_Static_Void_GameObject_String_0;

	// Token: 0x040001BF RID: 447
	private static readonly IntPtr NativeMethodInfoPtr__BroadcastMessageToAllChildren_Private_Static_Void_GameObject_String_0;

	// Token: 0x040001C0 RID: 448
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x040001C1 RID: 449
	private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Int32_0;

	// Token: 0x040001C2 RID: 450
	private static readonly IntPtr NativeMethodInfoPtr_GetUsageCount_Public_Int32_0;

	// Token: 0x040001C3 RID: 451
	private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllPoolableObjectsOfMyKind_Public_Int32_0;

	// Token: 0x040001C4 RID: 452
	private static readonly IntPtr NativeMethodInfoPtr_IsDeactivated_Public_Boolean_0;

	// Token: 0x040001C5 RID: 453
	private static readonly IntPtr NativeMethodInfoPtr_GetAllPoolableObjectsOfMyKind_Public_Il2CppReferenceArray_1_PoolableObject_Boolean_0;

	// Token: 0x040001C6 RID: 454
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
