using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace boardgames.attributes
{
	// Token: 0x02000163 RID: 355
	public class EventsForBoolAttributeSubscriber : AttributeSubscriber
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x00048748 File Offset: 0x00046948
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForBoolAttributeSubscriber()
		{
			Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EventsForBoolAttributeSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr);
			EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr, "onChanged");
			EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr, "onTrue");
			EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onElse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr, "onElse");
			EventsForBoolAttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr, 100665940);
			EventsForBoolAttributeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr, 100665941);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x000487DC File Offset: 0x000469DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000574, XrefRangeEnd = 1000587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForBoolAttributeSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00048818 File Offset: 0x00046A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000587, XrefRangeEnd = 1000606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForBoolAttributeSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForBoolAttributeSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForBoolAttributeSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public EventsForBoolAttributeSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00048854 File Offset: 0x00046A54
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000A6D9 File Offset: 0x000088D9
		public unsafe UnityEvent<bool> onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00048884 File Offset: 0x00046A84
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000A6F8 File Offset: 0x000088F8
		public unsafe UnityEvent onTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onTrue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000488B4 File Offset: 0x00046AB4
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x0000A717 File Offset: 0x00008917
		public unsafe UnityEvent onElse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onElse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForBoolAttributeSubscriber.NativeFieldInfoPtr_onElse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_onTrue;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeFieldInfoPtr_onElse;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
