using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace boardgames.datarenderers
{
	// Token: 0x0200016F RID: 367
	public class EventsForCanEditPlayerRenderer : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x0005111C File Offset: 0x0004F31C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForCanEditPlayerRenderer()
		{
			Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "EventsForCanEditPlayerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr);
			EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr, "CanEdit");
			EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanNotEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr, "CanNotEdit");
			EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_cacheCanEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr, "cacheCanEdit");
			EventsForCanEditPlayerRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr, 100665588);
			EventsForCanEditPlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr, 100665589);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x000511B0 File Offset: 0x0004F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513925, XrefRangeEnd = 513965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForCanEditPlayerRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000511EC File Offset: 0x0004F3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513965, XrefRangeEnd = 513977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForCanEditPlayerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForCanEditPlayerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForCanEditPlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00009E83 File Offset: 0x00008083
		public EventsForCanEditPlayerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00051228 File Offset: 0x0004F428
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00009E8C File Offset: 0x0000808C
		public unsafe UnityEvent CanEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00051258 File Offset: 0x0004F458
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x00009EAB File Offset: 0x000080AB
		public unsafe UnityEvent CanNotEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanNotEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_CanNotEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00051288 File Offset: 0x0004F488
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00009ECA File Offset: 0x000080CA
		public Nullable<bool> cacheCanEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_cacheCanEdit);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForCanEditPlayerRenderer.NativeFieldInfoPtr_cacheCanEdit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_CanEdit;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_CanNotEdit;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_cacheCanEdit;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
