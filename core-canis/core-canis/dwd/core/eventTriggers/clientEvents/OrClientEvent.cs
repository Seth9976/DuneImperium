using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Networking.clientevents;

namespace dwd.core.eventTriggers.clientEvents
{
	// Token: 0x020001B2 RID: 434
	public class OrClientEvent : ClientEvent
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x000754C8 File Offset: 0x000736C8
		// Note: this type is marked as 'beforefieldinit'.
		static OrClientEvent()
		{
			Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientEvents", "OrClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr);
			OrClientEvent.NativeFieldInfoPtr_subevents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr, "subevents");
			OrClientEvent.NativeFieldInfoPtr_Subevents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr, "Subevents");
			OrClientEvent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ClientEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr, 100667205);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00075534 File Offset: 0x00073734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880498, XrefRangeEnd = 880507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrClientEvent(Il2CppReferenceArray<ClientEvent> subevents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrClientEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subevents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrClientEvent.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ClientEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0000AB4D File Offset: 0x00008D4D
		public OrClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00075580 File Offset: 0x00073780
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x0000AB56 File Offset: 0x00008D56
		public unsafe Il2CppReferenceArray<ClientEvent> subevents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrClientEvent.NativeFieldInfoPtr_subevents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClientEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrClientEvent.NativeFieldInfoPtr_subevents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000755B0 File Offset: 0x000737B0
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x0000AB75 File Offset: 0x00008D75
		public unsafe ReadOnlyCollection<ClientEvent> Subevents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrClientEvent.NativeFieldInfoPtr_Subevents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ClientEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrClientEvent.NativeFieldInfoPtr_Subevents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeFieldInfoPtr_subevents;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeFieldInfoPtr_Subevents;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ClientEvent_0;
	}
}
