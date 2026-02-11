using System;
using dwd.core;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using validators;

namespace lib.validators.validationResolvers
{
	// Token: 0x02000008 RID: 8
	public class EventsOnValidationResolver : AbstractValidationResolver
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002DEC File Offset: 0x00000FEC
		// Note: this type is marked as 'beforefieldinit'.
		static EventsOnValidationResolver()
		{
			Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "lib.validators.validationResolvers", "EventsOnValidationResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr);
			EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr, "onModuleActiveStateChange");
			EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChangeInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr, "onModuleActiveStateChangeInvert");
			EventsOnValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr, 100663307);
			EventsOnValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002E6C File Offset: 0x0000106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267452, XrefRangeEnd = 1267468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsOnValidationResolver.NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002EA8 File Offset: 0x000010A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267468, XrefRangeEnd = 1267478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsOnValidationResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsOnValidationResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsOnValidationResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002137 File Offset: 0x00000337
		public EventsOnValidationResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002EE4 File Offset: 0x000010E4
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002140 File Offset: 0x00000340
		public unsafe UnityEventBool onModuleActiveStateChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002F14 File Offset: 0x00001114
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000215F File Offset: 0x0000035F
		public unsafe UnityEventBool onModuleActiveStateChangeInvert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChangeInvert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventBool>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsOnValidationResolver.NativeFieldInfoPtr_onModuleActiveStateChangeInvert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_onModuleActiveStateChange;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_onModuleActiveStateChangeInvert;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_onValidate_Protected_Virtual_Void_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
