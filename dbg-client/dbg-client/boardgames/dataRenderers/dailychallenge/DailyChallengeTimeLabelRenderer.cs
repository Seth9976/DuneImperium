using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x02000164 RID: 356
	public class DailyChallengeTimeLabelRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000FF0 RID: 4080 RVA: 0x000500FC File Offset: 0x0004E2FC
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeTimeLabelRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeTimeLabelRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr);
			DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeRemainingLabelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr, "timeRemainingLabelKey");
			DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSkirmishLabelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr, "timeUntilSkirmishLabelKey");
			DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSeasonLabelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr, "timeUntilSeasonLabelKey");
			DailyChallengeTimeLabelRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr, 100665556);
			DailyChallengeTimeLabelRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr, 100665557);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00050190 File Offset: 0x0004E390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513716, XrefRangeEnd = 513725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeTimeLabelRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000501E0 File Offset: 0x0004E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513725, XrefRangeEnd = 513735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeTimeLabelRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeTimeLabelRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimeLabelRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00009B5B File Offset: 0x00007D5B
		public DailyChallengeTimeLabelRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0005021C File Offset: 0x0004E41C
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00009B64 File Offset: 0x00007D64
		public unsafe string timeRemainingLabelKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeRemainingLabelKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeRemainingLabelKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00050244 File Offset: 0x0004E444
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00009B83 File Offset: 0x00007D83
		public unsafe string timeUntilSkirmishLabelKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSkirmishLabelKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSkirmishLabelKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0005026C File Offset: 0x0004E46C
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00009BA2 File Offset: 0x00007DA2
		public unsafe string timeUntilSeasonLabelKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSeasonLabelKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimeLabelRenderer.NativeFieldInfoPtr_timeUntilSeasonLabelKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_timeRemainingLabelKey;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilSkirmishLabelKey;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilSeasonLabelKey;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
