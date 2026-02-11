using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.attributes
{
	// Token: 0x02000168 RID: 360
	public class EventsForIntListAttributeContainsView : AttributeView
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x00048EBC File Offset: 0x000470BC
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForIntListAttributeContainsView()
		{
			Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForIntListAttributeContainsView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr);
			EventsForIntListAttributeContainsView.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr, "value");
			EventsForIntListAttributeContainsView.NativeFieldInfoPtr_onContains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr, "onContains");
			EventsForIntListAttributeContainsView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr, 100665953);
			EventsForIntListAttributeContainsView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr, 100665954);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00048F3C File Offset: 0x0004713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000703, XrefRangeEnd = 1000723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForIntListAttributeContainsView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00048F78 File Offset: 0x00047178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000723, XrefRangeEnd = 1000731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForIntListAttributeContainsView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForIntListAttributeContainsView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForIntListAttributeContainsView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0000A82F File Offset: 0x00008A2F
		public EventsForIntListAttributeContainsView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00048FB4 File Offset: 0x000471B4
		// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000A838 File Offset: 0x00008A38
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntListAttributeContainsView.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntListAttributeContainsView.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00048FDC File Offset: 0x000471DC
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x0000A853 File Offset: 0x00008A53
		public unsafe BoolUnityEvents onContains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntListAttributeContainsView.NativeFieldInfoPtr_onContains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForIntListAttributeContainsView.NativeFieldInfoPtr_onContains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_onContains;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
