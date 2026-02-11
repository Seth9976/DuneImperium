using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace analytics
{
	// Token: 0x02000007 RID: 7
	public static class AnalyticsSingleton : Object
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002844 File Offset: 0x00000A44
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSingleton()
		{
			Il2CppClassPointerStore<AnalyticsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "AnalyticsSingleton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSingleton>.NativeClassPtr);
			AnalyticsSingleton.NativeFieldInfoPtr__manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSingleton>.NativeClassPtr, "_manager");
			AnalyticsSingleton.NativeMethodInfoPtr_setAnalytics_Public_Static_Void_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSingleton>.NativeClassPtr, 100663309);
			AnalyticsSingleton.NativeMethodInfoPtr_getManager_Public_Static_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSingleton>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000028B0 File Offset: 0x00000AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273372, XrefRangeEnd = 1273378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void setAnalytics(IAnalyticsManager manager)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSingleton.NativeMethodInfoPtr_setAnalytics_Public_Static_Void_IAnalyticsManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000028E8 File Offset: 0x00000AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273378, XrefRangeEnd = 1273382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAnalyticsManager getManager()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSingleton.NativeMethodInfoPtr_getManager_Public_Static_IAnalyticsManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAnalyticsManager>(intPtr3) : null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020F0 File Offset: 0x000002F0
		public AnalyticsSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000291C File Offset: 0x00000B1C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe static IAnalyticsManager _manager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnalyticsSingleton.NativeFieldInfoPtr__manager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAnalyticsManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnalyticsSingleton.NativeFieldInfoPtr__manager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__manager;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_setAnalytics_Public_Static_Void_IAnalyticsManager_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_getManager_Public_Static_IAnalyticsManager_0;
	}
}
