using System;
using dwd.core.eventTriggers.conditional;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.clientevents;

namespace dwd.core.eventTriggers.clientEvents
{
	// Token: 0x020001B3 RID: 435
	public class StateCheckEvent : ClientEvent
	{
		// Token: 0x0600186A RID: 6250 RVA: 0x000755E0 File Offset: 0x000737E0
		// Note: this type is marked as 'beforefieldinit'.
		static StateCheckEvent()
		{
			Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientEvents", "StateCheckEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr);
			StateCheckEvent.NativeFieldInfoPtr_StateChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr, "StateChecks");
			StateCheckEvent.NativeMethodInfoPtr_Allowed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr, 100667206);
			StateCheckEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr, 100667207);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0007564C File Offset: 0x0007384C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880523, RefRangeEnd = 880524, XrefRangeStart = 880507, XrefRangeEnd = 880523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateCheckEvent.NativeMethodInfoPtr_Allowed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00075688 File Offset: 0x00073888
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateCheckEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateCheckEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateCheckEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0000AB94 File Offset: 0x00008D94
		public StateCheckEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000756C4 File Offset: 0x000738C4
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000AB9D File Offset: 0x00008D9D
		public unsafe List<ConditionalState> StateChecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateCheckEvent.NativeFieldInfoPtr_StateChecks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConditionalState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateCheckEvent.NativeFieldInfoPtr_StateChecks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_StateChecks;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_Allowed_Public_Boolean_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
