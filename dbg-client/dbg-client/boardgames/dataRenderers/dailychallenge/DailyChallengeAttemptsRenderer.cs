using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x0200015C RID: 348
	public class DailyChallengeAttemptsRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000F9F RID: 3999 RVA: 0x0004F278 File Offset: 0x0004D478
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeAttemptsRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeAttemptsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr);
			DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_textUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr, "textUI");
			DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr, "attemptsLocKey");
			DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsCompleteLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr, "attemptsCompleteLocKey");
			DailyChallengeAttemptsRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr, 100665529);
			DailyChallengeAttemptsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr, 100665530);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0004F30C File Offset: 0x0004D50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513461, XrefRangeEnd = 513486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeAttemptsRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0004F35C File Offset: 0x0004D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513486, XrefRangeEnd = 513494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeAttemptsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeAttemptsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeAttemptsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0000989D File Offset: 0x00007A9D
		public DailyChallengeAttemptsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0004F398 File Offset: 0x0004D598
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x000098A6 File Offset: 0x00007AA6
		public unsafe TMP_Text textUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_textUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_textUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0004F3C8 File Offset: 0x0004D5C8
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x000098C5 File Offset: 0x00007AC5
		public unsafe string attemptsLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0004F3F0 File Offset: 0x0004D5F0
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x000098E4 File Offset: 0x00007AE4
		public unsafe string attemptsCompleteLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsCompleteLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptsRenderer.NativeFieldInfoPtr_attemptsCompleteLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_textUI;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_attemptsLocKey;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_attemptsCompleteLocKey;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
