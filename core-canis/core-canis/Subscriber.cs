using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200003E RID: 62
public class Subscriber : MonoBehaviour
{
	// Token: 0x060004E0 RID: 1248 RVA: 0x00026AFC File Offset: 0x00024CFC
	// Note: this type is marked as 'beforefieldinit'.
	static Subscriber()
	{
		Il2CppClassPointerStore<Subscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "Subscriber");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subscriber>.NativeClassPtr);
		Subscriber.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "provider");
		Subscriber.NativeFieldInfoPtr_subscriberEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "subscriberEnabled");
		Subscriber.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "quitting");
		Subscriber.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, "_data");
		Subscriber.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664006);
		Subscriber.NativeMethodInfoPtr_onEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664007);
		Subscriber.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664008);
		Subscriber.NativeMethodInfoPtr_onDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664009);
		Subscriber.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664010);
		Subscriber.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664011);
		Subscriber.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664012);
		Subscriber.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664013);
		Subscriber.NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664014);
		Subscriber.NativeMethodInfoPtr_handleApplicationQuit_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664015);
		Subscriber.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664016);
		Subscriber.NativeMethodInfoPtr_update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664017);
		Subscriber.NativeMethodInfoPtr_get_data_Protected_Virtual_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664018);
		Subscriber.NativeMethodInfoPtr_set_data_Protected_Virtual_New_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664019);
		Subscriber.NativeMethodInfoPtr_dataChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664020);
		Subscriber.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664021);
		Subscriber.NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664022);
		Subscriber.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664023);
		Subscriber.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, 100664024);
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00026CF8 File Offset: 0x00024EF8
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00026D2C File Offset: 0x00024F2C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_onEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00026D68 File Offset: 0x00024F68
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00026D9C File Offset: 0x00024F9C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_onDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00026DD8 File Offset: 0x00024FD8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857395, RefRangeEnd = 857396, XrefRangeStart = 857394, XrefRangeEnd = 857395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00026E0C File Offset: 0x0002500C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00026E48 File Offset: 0x00025048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857396, XrefRangeEnd = 857403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00026E7C File Offset: 0x0002507C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00026EB8 File Offset: 0x000250B8
	[CallerCount(0)]
	public unsafe virtual void dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00026EEC File Offset: 0x000250EC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void handleApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_handleApplicationQuit_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00026F28 File Offset: 0x00025128
	[CallerCount(0)]
	public unsafe virtual void dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00026F5C File Offset: 0x0002515C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x060004ED RID: 1261 RVA: 0x00026F98 File Offset: 0x00025198
	// (set) Token: 0x060004EE RID: 1262 RVA: 0x00026FE4 File Offset: 0x000251E4
	public unsafe virtual DataComposition data
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_get_data_Protected_Virtual_New_get_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857404, RefRangeEnd = 857405, XrefRangeStart = 857403, XrefRangeEnd = 857404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_set_data_Protected_Virtual_New_set_Void_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00027034 File Offset: 0x00025234
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void dataChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber.NativeMethodInfoPtr_dataChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00027070 File Offset: 0x00025270
	public unsafe virtual DataComposition Data
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x000270B0 File Offset: 0x000252B0
	[CallerCount(0)]
	public unsafe virtual void Republish()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x000270E4 File Offset: 0x000252E4
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Subscriber()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subscriber>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00027120 File Offset: 0x00025320
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Transform dwd_core_data_composition_subscription_ISubscriber_get_transform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber.NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00003CBA File Offset: 0x00001EBA
	public Subscriber(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00027160 File Offset: 0x00025360
	// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00003CC3 File Offset: 0x00001EC3
	public unsafe SubscriptionProvider provider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_provider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00027190 File Offset: 0x00025390
	// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00003CE2 File Offset: 0x00001EE2
	public unsafe bool subscriberEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_subscriberEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_subscriberEnabled)) = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000271B8 File Offset: 0x000253B8
	// (set) Token: 0x060004FA RID: 1274 RVA: 0x00003CFD File Offset: 0x00001EFD
	public unsafe bool quitting
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_quitting);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr_quitting)) = value;
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x060004FB RID: 1275 RVA: 0x000271E0 File Offset: 0x000253E0
	// (set) Token: 0x060004FC RID: 1276 RVA: 0x00003D18 File Offset: 0x00001F18
	public unsafe DataComposition _data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr__data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400038C RID: 908
	private static readonly IntPtr NativeFieldInfoPtr_provider;

	// Token: 0x0400038D RID: 909
	private static readonly IntPtr NativeFieldInfoPtr_subscriberEnabled;

	// Token: 0x0400038E RID: 910
	private static readonly IntPtr NativeFieldInfoPtr_quitting;

	// Token: 0x0400038F RID: 911
	private static readonly IntPtr NativeFieldInfoPtr__data;

	// Token: 0x04000390 RID: 912
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x04000391 RID: 913
	private static readonly IntPtr NativeMethodInfoPtr_onEnable_Protected_Virtual_New_Void_0;

	// Token: 0x04000392 RID: 914
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x04000393 RID: 915
	private static readonly IntPtr NativeMethodInfoPtr_onDisable_Protected_Virtual_New_Void_0;

	// Token: 0x04000394 RID: 916
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x04000395 RID: 917
	private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0;

	// Token: 0x04000396 RID: 918
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x04000397 RID: 919
	private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_New_Void_0;

	// Token: 0x04000398 RID: 920
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0;

	// Token: 0x04000399 RID: 921
	private static readonly IntPtr NativeMethodInfoPtr_handleApplicationQuit_Protected_Virtual_New_Void_0;

	// Token: 0x0400039A RID: 922
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_ManagedUpdate_Private_Virtual_Final_New_Void_0;

	// Token: 0x0400039B RID: 923
	private static readonly IntPtr NativeMethodInfoPtr_update_Protected_Virtual_New_Void_0;

	// Token: 0x0400039C RID: 924
	private static readonly IntPtr NativeMethodInfoPtr_get_data_Protected_Virtual_New_get_DataComposition_0;

	// Token: 0x0400039D RID: 925
	private static readonly IntPtr NativeMethodInfoPtr_set_data_Protected_Virtual_New_set_Void_DataComposition_0;

	// Token: 0x0400039E RID: 926
	private static readonly IntPtr NativeMethodInfoPtr_dataChanged_Protected_Virtual_New_Void_0;

	// Token: 0x0400039F RID: 927
	private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_DataComposition_0;

	// Token: 0x040003A0 RID: 928
	private static readonly IntPtr NativeMethodInfoPtr_Republish_Public_Virtual_Final_New_Void_0;

	// Token: 0x040003A1 RID: 929
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x040003A2 RID: 930
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_data_composition_subscription_ISubscriber_get_transform_Private_Virtual_Final_New_Transform_0;
}
