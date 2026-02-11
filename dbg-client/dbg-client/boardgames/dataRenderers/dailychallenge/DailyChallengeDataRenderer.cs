using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x0200015F RID: 351
	public class DailyChallengeDataRenderer : VersionedView<DailyChallengeProvider>
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeDataRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr);
			DailyChallengeDataRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr, 100665536);
			DailyChallengeDataRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr, 100665537);
			DailyChallengeDataRenderer.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr, 100665538);
			DailyChallengeDataRenderer.NativeMethodInfoPtr_Event_Init_Public_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr, 100665539);
			DailyChallengeDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr, 100665540);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004F74C File Offset: 0x0004D94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513509, XrefRangeEnd = 513515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeDataRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004F788 File Offset: 0x0004D988
		[CallerCount(0)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeDataRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		[CallerCount(0)]
		public unsafe virtual void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeDataRenderer.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0004F814 File Offset: 0x0004DA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 513515, RefRangeEnd = 513516, XrefRangeStart = 513515, XrefRangeEnd = 513515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Init(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeDataRenderer.NativeMethodInfoPtr_Event_Init_Public_Void_DailyChallengeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0004F858 File Offset: 0x0004DA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00009953 File Offset: 0x00007B53
		public DailyChallengeDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Void_DailyChallengeProvider_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_Event_Init_Public_Void_DailyChallengeProvider_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
