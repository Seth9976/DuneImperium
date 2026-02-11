using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x0200015B RID: 347
	public class DailyChallengeAttemptScoreRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000F97 RID: 3991 RVA: 0x0004F114 File Offset: 0x0004D314
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeAttemptScoreRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeAttemptScoreRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr);
			DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_attempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr, "attempt");
			DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr, "text");
			DailyChallengeAttemptScoreRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr, 100665527);
			DailyChallengeAttemptScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr, 100665528);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0004F194 File Offset: 0x0004D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513449, XrefRangeEnd = 513458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeAttemptScoreRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513458, XrefRangeEnd = 513461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeAttemptScoreRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeAttemptScoreRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeAttemptScoreRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0000985A File Offset: 0x00007A5A
		public DailyChallengeAttemptScoreRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x0004F220 File Offset: 0x0004D420
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00009863 File Offset: 0x00007A63
		public unsafe int attempt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_attempt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_attempt)) = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0004F248 File Offset: 0x0004D448
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x0000987E File Offset: 0x00007A7E
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeAttemptScoreRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr_attempt;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
