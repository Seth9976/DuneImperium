using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.attributes
{
	// Token: 0x02000164 RID: 356
	public class EventsForNullAttributeSubscriber : AttributeSubscriber
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x000488E4 File Offset: 0x00046AE4
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForNullAttributeSubscriber()
		{
			Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForNullAttributeSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr);
			EventsForNullAttributeSubscriber.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr, "onChanged");
			EventsForNullAttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr, 100665942);
			EventsForNullAttributeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr, 100665943);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00048950 File Offset: 0x00046B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000606, XrefRangeEnd = 1000612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForNullAttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0004898C File Offset: 0x00046B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000612, XrefRangeEnd = 1000620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForNullAttributeSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForNullAttributeSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForNullAttributeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0000A736 File Offset: 0x00008936
		public EventsForNullAttributeSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x000489C8 File Offset: 0x00046BC8
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x0000A73F File Offset: 0x0000893F
		public unsafe BoolUnityEvents onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForNullAttributeSubscriber.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolUnityEvents>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForNullAttributeSubscriber.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
