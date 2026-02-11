using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace worm.networking.responses
{
	// Token: 0x02000066 RID: 102
	public class ActiveEvents : NetworkMessageEvent
	{
		// Token: 0x060003DE RID: 990 RVA: 0x000250DC File Offset: 0x000232DC
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveEvents()
		{
			Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "ActiveEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr);
			ActiveEvents.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr, "events");
			ActiveEvents.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr, "entries");
			ActiveEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr, 100663923);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00025148 File Offset: 0x00023348
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public ActiveEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00025184 File Offset: 0x00023384
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003BB9 File Offset: 0x00001DB9
		public unsafe Il2CppReferenceArray<EventDefinition> events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveEvents.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveEvents.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000251B4 File Offset: 0x000233B4
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003BD8 File Offset: 0x00001DD8
		public unsafe Il2CppReferenceArray<EventEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveEvents.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveEvents.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
