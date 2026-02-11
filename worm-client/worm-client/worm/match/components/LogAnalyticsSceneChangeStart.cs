using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001B5 RID: 437
	public class LogAnalyticsSceneChangeStart : MonoBehaviour
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x00052BDC File Offset: 0x00050DDC
		// Note: this type is marked as 'beforefieldinit'.
		static LogAnalyticsSceneChangeStart()
		{
			Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "LogAnalyticsSceneChangeStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr);
			LogAnalyticsSceneChangeStart.NativeFieldInfoPtr_transitionToScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr, "transitionToScene");
			LogAnalyticsSceneChangeStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr, 100665943);
			LogAnalyticsSceneChangeStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr, 100665944);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00052C48 File Offset: 0x00050E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712875, XrefRangeEnd = 712888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAnalyticsSceneChangeStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00052C7C File Offset: 0x00050E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712888, XrefRangeEnd = 712892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogAnalyticsSceneChangeStart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogAnalyticsSceneChangeStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogAnalyticsSceneChangeStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0000BFB1 File Offset: 0x0000A1B1
		public LogAnalyticsSceneChangeStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00052CB8 File Offset: 0x00050EB8
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x0000BFBA File Offset: 0x0000A1BA
		public unsafe string transitionToScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAnalyticsSceneChangeStart.NativeFieldInfoPtr_transitionToScene);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogAnalyticsSceneChangeStart.NativeFieldInfoPtr_transitionToScene), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeFieldInfoPtr_transitionToScene;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
