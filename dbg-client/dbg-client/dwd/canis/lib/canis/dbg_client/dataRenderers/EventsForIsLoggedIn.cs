using System;
using dwd.core.account;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.canis.lib.canis.dbg_client.dataRenderers
{
	// Token: 0x02000059 RID: 89
	public class EventsForIsLoggedIn : VersionedView<AccountProvider>
	{
		// Token: 0x06000369 RID: 873 RVA: 0x000286A0 File Offset: 0x000268A0
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForIsLoggedIn()
		{
			Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataRenderers", "EventsForIsLoggedIn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr);
			EventsForIsLoggedIn.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr, "events");
			EventsForIsLoggedIn.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr, 100663835);
			EventsForIsLoggedIn.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr, 100663836);
			EventsForIsLoggedIn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr, 100663837);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00028720 File Offset: 0x00026920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499811, XrefRangeEnd = 499817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForIsLoggedIn.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0002875C File Offset: 0x0002695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499817, XrefRangeEnd = 499821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForIsLoggedIn.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00028798 File Offset: 0x00026998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499821, XrefRangeEnd = 499829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForIsLoggedIn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForIsLoggedIn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForIsLoggedIn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000037B8 File Offset: 0x000019B8
		public EventsForIsLoggedIn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000287D4 File Offset: 0x000269D4
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000037C1 File Offset: 0x000019C1
		public unsafe BoolUnityEvents events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIsLoggedIn.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIsLoggedIn.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
