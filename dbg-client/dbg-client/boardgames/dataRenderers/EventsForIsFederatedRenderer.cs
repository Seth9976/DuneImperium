using System;
using boardgames.data;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.datarenderers
{
	// Token: 0x02000171 RID: 369
	public class EventsForIsFederatedRenderer : VersionedSubscriber<FederationData>
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x000513CC File Offset: 0x0004F5CC
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForIsFederatedRenderer()
		{
			Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "EventsForIsFederatedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr);
			EventsForIsFederatedRenderer.NativeFieldInfoPtr_onFederated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr, "onFederated");
			EventsForIsFederatedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr, 100665593);
			EventsForIsFederatedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr, 100665594);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00051438 File Offset: 0x0004F638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513993, XrefRangeEnd = 513996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForIsFederatedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00051474 File Offset: 0x0004F674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513996, XrefRangeEnd = 514004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForIsFederatedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForIsFederatedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForIsFederatedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00009F20 File Offset: 0x00008120
		public EventsForIsFederatedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x000514B0 File Offset: 0x0004F6B0
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00009F29 File Offset: 0x00008129
		public unsafe BoolUnityEvents onFederated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIsFederatedRenderer.NativeFieldInfoPtr_onFederated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIsFederatedRenderer.NativeFieldInfoPtr_onFederated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_onFederated;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
