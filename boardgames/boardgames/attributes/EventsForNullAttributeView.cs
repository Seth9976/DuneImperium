using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.attributes
{
	// Token: 0x02000169 RID: 361
	public class EventsForNullAttributeView : AttributeView
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x0004900C File Offset: 0x0004720C
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForNullAttributeView()
		{
			Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForNullAttributeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr);
			EventsForNullAttributeView.NativeFieldInfoPtr_isNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr, "isNull");
			EventsForNullAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr, 100665955);
			EventsForNullAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr, 100665956);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00049078 File Offset: 0x00047278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000731, XrefRangeEnd = 1000736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForNullAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000490B4 File Offset: 0x000472B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000736, XrefRangeEnd = 1000744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForNullAttributeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForNullAttributeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForNullAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0000A872 File Offset: 0x00008A72
		public EventsForNullAttributeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x000490F0 File Offset: 0x000472F0
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000A87B File Offset: 0x00008A7B
		public unsafe BoolUnityEvents isNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForNullAttributeView.NativeFieldInfoPtr_isNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForNullAttributeView.NativeFieldInfoPtr_isNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_isNull;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
