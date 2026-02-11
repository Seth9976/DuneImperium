using System;
using Canis.attributes;
using dwd.core.data.composition;
using dwd.core.data.composition.subscription;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000040 RID: 64
public sealed class SubscriptionProvider : MonoBehaviour
{
	// Token: 0x06000509 RID: 1289 RVA: 0x00027678 File Offset: 0x00025878
	// Note: this type is marked as 'beforefieldinit'.
	static SubscriptionProvider()
	{
		Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "SubscriptionProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr);
		SubscriptionProvider.NativeFieldInfoPtr_subscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, "subscribers");
		SubscriptionProvider.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, "_Data");
		SubscriptionProvider.NativeFieldInfoPtr_attributesComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, "attributesComponent");
		SubscriptionProvider.NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664033);
		SubscriptionProvider.NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664034);
		SubscriptionProvider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664035);
		SubscriptionProvider.NativeMethodInfoPtr_deliverSubscription_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664036);
		SubscriptionProvider.NativeMethodInfoPtr_add_Private_Void_ISubscriber_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664037);
		SubscriptionProvider.NativeMethodInfoPtr_remove_Private_Void_ISubscriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664038);
		SubscriptionProvider.NativeMethodInfoPtr_getProvider_Private_Static_SubscriptionProvider_ISubscriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664039);
		SubscriptionProvider.NativeMethodInfoPtr_TryGetProvider_Public_Static_Boolean_ISubscriber_byref_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664040);
		SubscriptionProvider.NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664041);
		SubscriptionProvider.NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664042);
		SubscriptionProvider.NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_SubscriptionProvider_ISubscriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664043);
		SubscriptionProvider.NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__get_Model_Private_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664044);
		SubscriptionProvider.NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__set_Model_Private_Virtual_Final_New_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664045);
		SubscriptionProvider.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664046);
		SubscriptionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664047);
		SubscriptionProvider.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664048);
		SubscriptionProvider.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr, 100664049);
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x00027838 File Offset: 0x00025A38
	// (set) Token: 0x0600050B RID: 1291 RVA: 0x00027878 File Offset: 0x00025A78
	public unsafe DataComposition Data
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 857417, RefRangeEnd = 857474, XrefRangeStart = 857409, XrefRangeEnd = 857417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x000278BC File Offset: 0x00025ABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857474, XrefRangeEnd = 857492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x000278F0 File Offset: 0x00025AF0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 857513, RefRangeEnd = 857515, XrefRangeStart = 857492, XrefRangeEnd = 857513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void deliverSubscription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_deliverSubscription_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00027924 File Offset: 0x00025B24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857515, XrefRangeEnd = 857523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add(ISubscriber subscriber, bool updateDataImmediately)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateDataImmediately;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_add_Private_Void_ISubscriber_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00027974 File Offset: 0x00025B74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857523, XrefRangeEnd = 857527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove(ISubscriber subscriber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_remove_Private_Void_ISubscriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x000279B8 File Offset: 0x00025BB8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857538, RefRangeEnd = 857539, XrefRangeStart = 857527, XrefRangeEnd = 857538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SubscriptionProvider getProvider(ISubscriber subscriber)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_getProvider_Private_Static_SubscriptionProvider_ISubscriber_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
		}
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x000279FC File Offset: 0x00025BFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857539, XrefRangeEnd = 857551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetProvider(ISubscriber subscriber, out SubscriptionProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_TryGetProvider_Public_Static_Boolean_ISubscriber_byref_SubscriptionProvider_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		provider = ((intPtr4 == 0) ? null : new SubscriptionProvider(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00027A60 File Offset: 0x00025C60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857551, XrefRangeEnd = 857552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Subscribe(ISubscriber subscriber, out SubscriptionProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		provider = ((intPtr4 == 0) ? null : new SubscriptionProvider(intPtr4));
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00027AB8 File Offset: 0x00025CB8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857562, RefRangeEnd = 857565, XrefRangeStart = 857552, XrefRangeEnd = 857562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Subscribe(ISubscriber subscriber, out SubscriptionProvider provider, bool updateDataImmediately)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateDataImmediately;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_Boolean_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		provider = ((intPtr4 == 0) ? null : new SubscriptionProvider(intPtr4));
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00027B20 File Offset: 0x00025D20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857565, XrefRangeEnd = 857572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unsubscribe(SubscriptionProvider provider, ISubscriber subscriber)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subscriber);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_SubscriptionProvider_ISubscriber_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000515 RID: 1301 RVA: 0x00027B68 File Offset: 0x00025D68
	// (set) Token: 0x06000516 RID: 1302 RVA: 0x00027BA8 File Offset: 0x00025DA8
	public unsafe DataComposition dwd.core.data.IView<dwd.core.data.composition.DataComposition>.Model
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__get_Model_Private_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 857417, RefRangeEnd = 857474, XrefRangeStart = 857417, XrefRangeEnd = 857474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__set_Model_Private_Virtual_Final_New_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00027BEC File Offset: 0x00025DEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857572, XrefRangeEnd = 857577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IHasAttributes boardgames_attributes_IAttributesProvider_GetAttributes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00027C2C File Offset: 0x00025E2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857577, XrefRangeEnd = 857585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubscriptionProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubscriptionProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00027C68 File Offset: 0x00025E68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject IGameObject_get_gameObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00027CA8 File Offset: 0x00025EA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform IGameObject_get_transform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubscriptionProvider.NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00003D40 File Offset: 0x00001F40
	public SubscriptionProvider(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x0600051C RID: 1308 RVA: 0x00027CE8 File Offset: 0x00025EE8
	// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003D49 File Offset: 0x00001F49
	public unsafe List<ISubscriber> subscribers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr_subscribers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISubscriber>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr_subscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x0600051E RID: 1310 RVA: 0x00027D18 File Offset: 0x00025F18
	// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003D68 File Offset: 0x00001F68
	public unsafe DataComposition _Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr__Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000520 RID: 1312 RVA: 0x00027D48 File Offset: 0x00025F48
	// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003D87 File Offset: 0x00001F87
	public unsafe AttributeDataComponent attributesComponent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr_attributesComponent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDataComponent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubscriptionProvider.NativeFieldInfoPtr_attributesComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040003AC RID: 940
	private static readonly IntPtr NativeFieldInfoPtr_subscribers;

	// Token: 0x040003AD RID: 941
	private static readonly IntPtr NativeFieldInfoPtr__Data;

	// Token: 0x040003AE RID: 942
	private static readonly IntPtr NativeFieldInfoPtr_attributesComponent;

	// Token: 0x040003AF RID: 943
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_DataComposition_0;

	// Token: 0x040003B0 RID: 944
	private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_DataComposition_0;

	// Token: 0x040003B1 RID: 945
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	// Token: 0x040003B2 RID: 946
	private static readonly IntPtr NativeMethodInfoPtr_deliverSubscription_Private_Void_0;

	// Token: 0x040003B3 RID: 947
	private static readonly IntPtr NativeMethodInfoPtr_add_Private_Void_ISubscriber_Boolean_0;

	// Token: 0x040003B4 RID: 948
	private static readonly IntPtr NativeMethodInfoPtr_remove_Private_Void_ISubscriber_0;

	// Token: 0x040003B5 RID: 949
	private static readonly IntPtr NativeMethodInfoPtr_getProvider_Private_Static_SubscriptionProvider_ISubscriber_0;

	// Token: 0x040003B6 RID: 950
	private static readonly IntPtr NativeMethodInfoPtr_TryGetProvider_Public_Static_Boolean_ISubscriber_byref_SubscriptionProvider_0;

	// Token: 0x040003B7 RID: 951
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_0;

	// Token: 0x040003B8 RID: 952
	private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Public_Static_Void_ISubscriber_byref_SubscriptionProvider_Boolean_0;

	// Token: 0x040003B9 RID: 953
	private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Public_Static_Void_SubscriptionProvider_ISubscriber_0;

	// Token: 0x040003BA RID: 954
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__get_Model_Private_Virtual_Final_New_get_DataComposition_0;

	// Token: 0x040003BB RID: 955
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_IView_dwd_core_data_composition_DataComposition__set_Model_Private_Virtual_Final_New_set_Void_DataComposition_0;

	// Token: 0x040003BC RID: 956
	private static readonly IntPtr NativeMethodInfoPtr_boardgames_attributes_IAttributesProvider_GetAttributes_Private_Virtual_Final_New_IHasAttributes_0;

	// Token: 0x040003BD RID: 957
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040003BE RID: 958
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_gameObject_Private_Virtual_Final_New_GameObject_0;

	// Token: 0x040003BF RID: 959
	private static readonly IntPtr NativeMethodInfoPtr_IGameObject_get_transform_Private_Virtual_Final_New_Transform_0;
}
