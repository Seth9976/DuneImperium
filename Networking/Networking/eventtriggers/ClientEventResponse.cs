using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.clientevents;
using Networking.eventtriggers.clientactions;

namespace Networking.eventtriggers
{
	// Token: 0x020000BA RID: 186
	public class ClientEventResponse : Object
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00015E84 File Offset: 0x00014084
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEventResponse()
		{
			Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.eventtriggers", "ClientEventResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr);
			ClientEventResponse.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr, "Event");
			ClientEventResponse.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr, "Action");
			ClientEventResponse.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr, "Handle");
			ClientEventResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr, 100663670);
			ClientEventResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr, 100663671);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00015F18 File Offset: 0x00014118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195324, XrefRangeEnd = 1195326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientEventResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00015F5C File Offset: 0x0001415C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00005C93 File Offset: 0x00003E93
		public ClientEventResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00015F98 File Offset: 0x00014198
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00005C9C File Offset: 0x00003E9C
		public unsafe ClientEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00015FC8 File Offset: 0x000141C8
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00005CBB File Offset: 0x00003EBB
		public unsafe Il2CppReferenceArray<ClientAction> Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClientAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00015FF8 File Offset: 0x000141F8
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00005CDA File Offset: 0x00003EDA
		public unsafe ClientEventResponseID Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientEventResponse.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_Action;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
