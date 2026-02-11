using System;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace zen.analytics.messages
{
	// Token: 0x02000098 RID: 152
	public class AnalyticsSceneChangeStart : ClientAnalyticsMessage
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00027F14 File Offset: 0x00026114
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsSceneChangeStart()
		{
			Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "AnalyticsSceneChangeStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr);
			AnalyticsSceneChangeStart.NativeFieldInfoPtr_sceneTransitionInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr, "sceneTransitionInstanceId");
			AnalyticsSceneChangeStart.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr, "Timestamp");
			AnalyticsSceneChangeStart.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr, 100664474);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00027F80 File Offset: 0x00026180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990760, RefRangeEnd = 990762, XrefRangeStart = 990725, XrefRangeEnd = 990760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsSceneChangeStart(Guid sceneTransitionInstanceId, string leavingSceneName, string enteringSceneName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsSceneChangeStart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneTransitionInstanceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(leavingSceneName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(enteringSceneName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsSceneChangeStart.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0000547C File Offset: 0x0000367C
		public AnalyticsSceneChangeStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00027FEC File Offset: 0x000261EC
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005485 File Offset: 0x00003685
		public unsafe Guid sceneTransitionInstanceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSceneChangeStart.NativeFieldInfoPtr_sceneTransitionInstanceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSceneChangeStart.NativeFieldInfoPtr_sceneTransitionInstanceId)) = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00028014 File Offset: 0x00026214
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x000054A0 File Offset: 0x000036A0
		public unsafe long Timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSceneChangeStart.NativeFieldInfoPtr_Timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsSceneChangeStart.NativeFieldInfoPtr_Timestamp)) = value;
			}
		}

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_sceneTransitionInstanceId;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_String_0;
	}
}
