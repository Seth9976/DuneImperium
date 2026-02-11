using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platformdependent
{
	// Token: 0x02000023 RID: 35
	public sealed class PlatformEventsOnAwake : PlatformDependentEvents
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00006A3C File Offset: 0x00004C3C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformEventsOnAwake()
		{
			Il2CppClassPointerStore<PlatformEventsOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformEventsOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformEventsOnAwake>.NativeClassPtr);
			PlatformEventsOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEventsOnAwake>.NativeClassPtr, 100663425);
			PlatformEventsOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformEventsOnAwake>.NativeClassPtr, 100663426);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006A94 File Offset: 0x00004C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239649, XrefRangeEnd = 1239650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEventsOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239650, XrefRangeEnd = 1239651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformEventsOnAwake()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformEventsOnAwake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformEventsOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000292E File Offset: 0x00000B2E
		public PlatformEventsOnAwake(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
