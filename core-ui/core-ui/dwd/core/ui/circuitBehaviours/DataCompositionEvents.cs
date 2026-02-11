using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.circuitBehaviours
{
	// Token: 0x0200001C RID: 28
	public class DataCompositionEvents : Subscriber
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00006838 File Offset: 0x00004A38
		// Note: this type is marked as 'beforefieldinit'.
		static DataCompositionEvents()
		{
			Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.circuitBehaviours", "DataCompositionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr);
			DataCompositionEvents.NativeFieldInfoPtr_dataCompositionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr, "dataCompositionEvents");
			DataCompositionEvents.NativeMethodInfoPtr_get_OnFireEvent_Public_get_UnityEventForDataComp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr, 100663445);
			DataCompositionEvents.NativeMethodInfoPtr_Event_FireEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr, 100663446);
			DataCompositionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr, 100663447);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000068B8 File Offset: 0x00004AB8
		public unsafe UnityEventForDataComp OnFireEvent
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCompositionEvents.NativeMethodInfoPtr_get_OnFireEvent_Public_get_UnityEventForDataComp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEventForDataComp>(intPtr3) : null;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000068F8 File Offset: 0x00004AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254584, XrefRangeEnd = 1254588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_FireEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCompositionEvents.NativeMethodInfoPtr_Event_FireEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000692C File Offset: 0x00004B2C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataCompositionEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataCompositionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataCompositionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000287A File Offset: 0x00000A7A
		public DataCompositionEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00006968 File Offset: 0x00004B68
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00002883 File Offset: 0x00000A83
		public unsafe UnityEventForDataComp dataCompositionEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCompositionEvents.NativeFieldInfoPtr_dataCompositionEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventForDataComp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataCompositionEvents.NativeFieldInfoPtr_dataCompositionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_dataCompositionEvents;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_get_OnFireEvent_Public_get_UnityEventForDataComp_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_Event_FireEvent_Public_Void_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
