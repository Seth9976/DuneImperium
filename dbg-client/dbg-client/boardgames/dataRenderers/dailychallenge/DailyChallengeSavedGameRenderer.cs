using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x02000162 RID: 354
	public class DailyChallengeSavedGameRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004FE3C File Offset: 0x0004E03C
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeSavedGameRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeSavedGameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr);
			DailyChallengeSavedGameRenderer.NativeFieldInfoPtr_savedGameIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr, "savedGameIcon");
			DailyChallengeSavedGameRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr, 100665552);
			DailyChallengeSavedGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr, 100665553);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513685, XrefRangeEnd = 513687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeSavedGameRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeSavedGameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeSavedGameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeSavedGameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00009ACD File Offset: 0x00007CCD
		public DailyChallengeSavedGameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0004FF34 File Offset: 0x0004E134
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00009AD6 File Offset: 0x00007CD6
		public unsafe GameObject savedGameIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSavedGameRenderer.NativeFieldInfoPtr_savedGameIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeSavedGameRenderer.NativeFieldInfoPtr_savedGameIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_savedGameIcon;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
