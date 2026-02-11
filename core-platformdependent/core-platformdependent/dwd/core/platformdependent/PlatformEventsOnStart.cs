using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platformdependent
{
	// Token: 0x02000024 RID: 36
	public sealed class PlatformEventsOnStart : PlatformDependentEvents
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00006B04 File Offset: 0x00004D04
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformEventsOnStart()
		{
			Il2CppClassPointerStore<PlatformEventsOnStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformEventsOnStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformEventsOnStart>.NativeClassPtr);
			PlatformEventsOnStart.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEventsOnStart>.NativeClassPtr, 100663427);
			PlatformEventsOnStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEventsOnStart>.NativeClassPtr, 100663428);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006B5C File Offset: 0x00004D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEventsOnStart.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006B90 File Offset: 0x00004D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformEventsOnStart()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformEventsOnStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEventsOnStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002937 File Offset: 0x00000B37
		public PlatformEventsOnStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
