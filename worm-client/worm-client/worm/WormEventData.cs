using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.networking.responses;

namespace worm
{
	// Token: 0x0200004C RID: 76
	public class WormEventData : DataComponent
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00022B54 File Offset: 0x00020D54
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventData()
		{
			Il2CppClassPointerStore<WormEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventData>.NativeClassPtr);
			WormEventData.NativeFieldInfoPtr__Event_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventData>.NativeClassPtr, "<Event>k__BackingField");
			WormEventData.NativeMethodInfoPtr__ctor_Public_Void_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventData>.NativeClassPtr, 100663810);
			WormEventData.NativeMethodInfoPtr_get_ID_Public_get_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventData>.NativeClassPtr, 100663811);
			WormEventData.NativeMethodInfoPtr_get_Event_Public_get_EventDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventData>.NativeClassPtr, 100663812);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00022BD4 File Offset: 0x00020DD4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventData(EventDefinition eventDefinition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventData.NativeMethodInfoPtr__ctor_Public_Void_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00022C20 File Offset: 0x00020E20
		public unsafe EventID ID
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventData.NativeMethodInfoPtr_get_ID_Public_get_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr3) : null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00022C60 File Offset: 0x00020E60
		public unsafe EventDefinition Event
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventData.NativeMethodInfoPtr_get_Event_Public_get_EventDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000037A1 File Offset: 0x000019A1
		public WormEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00022CA0 File Offset: 0x00020EA0
		// (set) Token: 0x06000338 RID: 824 RVA: 0x000037AA File Offset: 0x000019AA
		public unsafe EventDefinition _Event_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventData.NativeFieldInfoPtr__Event_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventData.NativeFieldInfoPtr__Event_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr__Event_k__BackingField;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventDefinition_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_EventID_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_get_Event_Public_get_EventDefinition_0;
	}
}
