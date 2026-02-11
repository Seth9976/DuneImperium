using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lib.canis.voodoo.src.voodoo.renderAnimator
{
	// Token: 0x02000013 RID: 19
	public class GenericEventLocator : MonoBehaviour
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000AD0C File Offset: 0x00008F0C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericEventLocator()
		{
			Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo.renderAnimator", "GenericEventLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr);
			GenericEventLocator.NativeFieldInfoPtr_eventTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr, "eventTriggers");
			GenericEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr, 100663364);
			GenericEventLocator.NativeMethodInfoPtr_RegisterEventTrigger_Public_Void_EventTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr, 100663365);
			GenericEventLocator.NativeMethodInfoPtr_DeregisterEventTrigger_Public_Void_EventTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr, 100663366);
			GenericEventLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106825, XrefRangeEnd = 1106841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeEvent(string triggerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106841, XrefRangeEnd = 1106844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEventTrigger(EventTrigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(trigger));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocator.NativeMethodInfoPtr_RegisterEventTrigger_Public_Void_EventTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AE2C File Offset: 0x0000902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106844, XrefRangeEnd = 1106847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterEventTrigger(EventTrigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(trigger));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocator.NativeMethodInfoPtr_DeregisterEventTrigger_Public_Void_EventTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000AE74 File Offset: 0x00009074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106847, XrefRangeEnd = 1106855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericEventLocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericEventLocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericEventLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000025E2 File Offset: 0x000007E2
		public GenericEventLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000AEB0 File Offset: 0x000090B0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000025EB File Offset: 0x000007EB
		public unsafe List<EventTrigger> eventTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocator.NativeFieldInfoPtr_eventTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventTrigger>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericEventLocator.NativeFieldInfoPtr_eventTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_eventTriggers;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEvent_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventTrigger_Public_Void_EventTrigger_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterEventTrigger_Public_Void_EventTrigger_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
