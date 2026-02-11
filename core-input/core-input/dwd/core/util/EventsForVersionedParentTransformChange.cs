using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.util
{
	// Token: 0x02000035 RID: 53
	public class EventsForVersionedParentTransformChange : EventsForVersionedModelChange<VersionedParentTransform>
	{
		// Token: 0x06000193 RID: 403 RVA: 0x0000BF48 File Offset: 0x0000A148
		// Note: this type is marked as 'beforefieldinit'.
		static EventsForVersionedParentTransformChange()
		{
			Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.util", "EventsForVersionedParentTransformChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr);
			EventsForVersionedParentTransformChange.NativeFieldInfoPtr_versionedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr, "versionedTransform");
			EventsForVersionedParentTransformChange.NativeMethodInfoPtr_get_Model_Public_Virtual_get_IVersionedModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr, 100663510);
			EventsForVersionedParentTransformChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr, 100663511);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		public unsafe override IVersionedModel Model
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventsForVersionedParentTransformChange.NativeMethodInfoPtr_get_Model_Public_Virtual_get_IVersionedModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVersionedModel>(intPtr3) : null;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000C000 File Offset: 0x0000A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120153, XrefRangeEnd = 1120156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventsForVersionedParentTransformChange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventsForVersionedParentTransformChange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventsForVersionedParentTransformChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002EB2 File Offset: 0x000010B2
		public EventsForVersionedParentTransformChange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000C03C File Offset: 0x0000A23C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002EBB File Offset: 0x000010BB
		public unsafe VersionedParentTransform versionedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedParentTransformChange.NativeFieldInfoPtr_versionedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedParentTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventsForVersionedParentTransformChange.NativeFieldInfoPtr_versionedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_versionedTransform;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_Model_Public_Virtual_get_IVersionedModel_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
