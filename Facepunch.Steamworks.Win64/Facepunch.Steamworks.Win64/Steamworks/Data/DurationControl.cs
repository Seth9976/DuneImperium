using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FA RID: 506
	[StructLayout(2)]
	public struct DurationControl
	{
		// Token: 0x0600195B RID: 6491 RVA: 0x0007B018 File Offset: 0x00079218
		// Note: this type is marked as 'beforefieldinit'.
		static DurationControl()
		{
			Il2CppClassPointerStore<DurationControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DurationControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurationControl>.NativeClassPtr);
			DurationControl.NativeFieldInfoPtr__inner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, "_inner");
			DurationControl.NativeMethodInfoPtr_get_Appid_Public_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, 100667922);
			DurationControl.NativeMethodInfoPtr_get_Applicable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, 100667923);
			DurationControl.NativeMethodInfoPtr_get_PlaytimeInLastFiveHours_Internal_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, 100667924);
			DurationControl.NativeMethodInfoPtr_get_PlaytimeToday_Internal_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, 100667925);
			DurationControl.NativeMethodInfoPtr_get_Progress_Internal_get_DurationControlProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, 100667926);
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007B0C0 File Offset: 0x000792C0
		public unsafe AppId Appid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl.NativeMethodInfoPtr_get_Appid_Public_get_AppId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0007B0F0 File Offset: 0x000792F0
		public unsafe bool Applicable
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl.NativeMethodInfoPtr_get_Applicable_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0007B120 File Offset: 0x00079320
		public unsafe TimeSpan PlaytimeInLastFiveHours
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951836, XrefRangeEnd = 951840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl.NativeMethodInfoPtr_get_PlaytimeInLastFiveHours_Internal_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0007B150 File Offset: 0x00079350
		public unsafe TimeSpan PlaytimeToday
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951840, XrefRangeEnd = 951844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl.NativeMethodInfoPtr_get_PlaytimeToday_Internal_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0007B180 File Offset: 0x00079380
		public unsafe DurationControlProgress Progress
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DurationControl.NativeMethodInfoPtr_get_Progress_Internal_get_DurationControlProgress_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00008395 File Offset: 0x00006595
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurationControl>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr__inner;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_get_Appid_Public_get_AppId_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_get_Applicable_Public_get_Boolean_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaytimeInLastFiveHours_Internal_get_TimeSpan_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_get_PlaytimeToday_Internal_get_TimeSpan_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Internal_get_DurationControlProgress_0;

		// Token: 0x04001E9F RID: 7839
		[FieldOffset(0)]
		public DurationControl_t _inner;
	}
}
