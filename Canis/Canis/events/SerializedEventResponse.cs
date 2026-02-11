using System;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.events
{
	// Token: 0x020000B4 RID: 180
	public class SerializedEventResponse : Object
	{
		// Token: 0x06000867 RID: 2151 RVA: 0x0003B708 File Offset: 0x00039908
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedEventResponse()
		{
			Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.events", "SerializedEventResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr);
			SerializedEventResponse.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr, "Event");
			SerializedEventResponse.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr, "Actions");
			SerializedEventResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr, 100665025);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0003B774 File Offset: 0x00039974
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedEventResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedEventResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedEventResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000054B9 File Offset: 0x000036B9
		public SerializedEventResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0003B7B0 File Offset: 0x000399B0
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x000054C2 File Offset: 0x000036C2
		public unsafe SerializedEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventResponse.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventResponse.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0003B7E0 File Offset: 0x000399E0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x000054E1 File Offset: 0x000036E1
		public unsafe List<SerializedAction> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventResponse.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedEventResponse.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
