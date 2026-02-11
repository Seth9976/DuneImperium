using System;
using boardgames.challenges;
using boardgames.data;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000155 RID: 341
	public class SelectedChallengeObject : VersionedView<SelectedData<MatchInitData>>
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x0004E600 File Offset: 0x0004C800
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedChallengeObject()
		{
			Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "SelectedChallengeObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr);
			SelectedChallengeObject.NativeFieldInfoPtr_challengeBranchRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, "challengeBranchRenderer");
			SelectedChallengeObject.NativeFieldInfoPtr_challengeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, "challengeProvider");
			SelectedChallengeObject.NativeFieldInfoPtr_selectedParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, "selectedParam");
			SelectedChallengeObject.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, "animator");
			SelectedChallengeObject.NativeFieldInfoPtr_difficultyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, "difficultyData");
			SelectedChallengeObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, 100665508);
			SelectedChallengeObject.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, 100665509);
			SelectedChallengeObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr, 100665510);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0004E6D0 File Offset: 0x0004C8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513289, XrefRangeEnd = 513300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0004E70C File Offset: 0x0004C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513300, XrefRangeEnd = 513313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeObject.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0004E748 File Offset: 0x0004C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513313, XrefRangeEnd = 513320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedChallengeObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedChallengeObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedChallengeObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00009634 File Offset: 0x00007834
		public SelectedChallengeObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0004E784 File Offset: 0x0004C984
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0000963D File Offset: 0x0000783D
		public unsafe ChallengeBranchRenderer challengeBranchRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_challengeBranchRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeBranchRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_challengeBranchRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x0000965C File Offset: 0x0000785C
		public unsafe SubscriptionProvider challengeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_challengeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_challengeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0000967B File Offset: 0x0000787B
		public unsafe string selectedParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_selectedParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_selectedParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0004E80C File Offset: 0x0004CA0C
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x0000969A File Offset: 0x0000789A
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x0004E83C File Offset: 0x0004CA3C
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x000096B9 File Offset: 0x000078B9
		public unsafe ChallengeDifficultyData difficultyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_difficultyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeDifficultyData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeObject.NativeFieldInfoPtr_difficultyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_challengeBranchRenderer;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_challengeProvider;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_selectedParam;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_difficultyData;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
