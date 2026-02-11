using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000087 RID: 135
	public class EventsForInputModuleActivation : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x000198A4 File Offset: 0x00017AA4
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForInputModuleActivation()
		{
			Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "EventsForInputModuleActivation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr);
			EventsForInputModuleActivation.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, "inputModuleType");
			EventsForInputModuleActivation.NativeFieldInfoPtr_onModuleActiveStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, "onModuleActiveStateChange");
			EventsForInputModuleActivation.NativeFieldInfoPtr_cachedActiveValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, "cachedActiveValue");
			EventsForInputModuleActivation.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, 100664022);
			EventsForInputModuleActivation.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, 100664023);
			EventsForInputModuleActivation.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, 100664024);
			EventsForInputModuleActivation.NativeMethodInfoPtr_checkAndFireEvent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, 100664025);
			EventsForInputModuleActivation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr, 100664026);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00019974 File Offset: 0x00017B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124928, XrefRangeEnd = 1124941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForInputModuleActivation.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000199B0 File Offset: 0x00017BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124941, XrefRangeEnd = 1124947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForInputModuleActivation.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000199EC File Offset: 0x00017BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124947, XrefRangeEnd = 1124950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForInputModuleActivation.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00019A28 File Offset: 0x00017C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1124960, RefRangeEnd = 1124962, XrefRangeStart = 1124950, XrefRangeEnd = 1124960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void checkAndFireEvent(bool activeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivation.NativeMethodInfoPtr_checkAndFireEvent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00019A68 File Offset: 0x00017C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124962, XrefRangeEnd = 1124974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForInputModuleActivation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForInputModuleActivation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForInputModuleActivation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000053FF File Offset: 0x000035FF
		public EventsForInputModuleActivation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00019AA4 File Offset: 0x00017CA4
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00005408 File Offset: 0x00003608
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00019ACC File Offset: 0x00017CCC
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00005427 File Offset: 0x00003627
		public unsafe UnityEventBool onModuleActiveStateChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_onModuleActiveStateChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_onModuleActiveStateChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00019AFC File Offset: 0x00017CFC
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00005446 File Offset: 0x00003646
		public Nullable<bool> cachedActiveValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_cachedActiveValue);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForInputModuleActivation.NativeFieldInfoPtr_cachedActiveValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_onModuleActiveStateChange;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_cachedActiveValue;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_checkAndFireEvent_Private_Void_Boolean_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
