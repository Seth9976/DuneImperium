using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using zen.src.challenges;

namespace zen.src.match.monobehaviours.renderers
{
	// Token: 0x02000078 RID: 120
	public class ChallengeCompletedSubscriber : MonoBehaviour
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00024344 File Offset: 0x00022544
		// Note: this type is marked as 'beforefieldinit'.
		static ChallengeCompletedSubscriber()
		{
			Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours.renderers", "ChallengeCompletedSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr);
			ChallengeCompletedSubscriber.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, "target");
			ChallengeCompletedSubscriber.NativeFieldInfoPtr_challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, "challenges");
			ChallengeCompletedSubscriber.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, 100664271);
			ChallengeCompletedSubscriber.NativeMethodInfoPtr_ChallengeCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, 100664272);
			ChallengeCompletedSubscriber.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, 100664273);
			ChallengeCompletedSubscriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, 100664274);
			ChallengeCompletedSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr, 100664275);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00024400 File Offset: 0x00022600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988483, XrefRangeEnd = 988499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeCompletedSubscriber.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00024434 File Offset: 0x00022634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988499, XrefRangeEnd = 988504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChallengeCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeCompletedSubscriber.NativeMethodInfoPtr_ChallengeCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00024468 File Offset: 0x00022668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988504, XrefRangeEnd = 988509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeCompletedSubscriber.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002449C File Offset: 0x0002269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988509, XrefRangeEnd = 988520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeCompletedSubscriber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000244D0 File Offset: 0x000226D0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChallengeCompletedSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeCompletedSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChallengeCompletedSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00004D6C File Offset: 0x00002F6C
		public ChallengeCompletedSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0002450C File Offset: 0x0002270C
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00004D75 File Offset: 0x00002F75
		public unsafe GameObject target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeCompletedSubscriber.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeCompletedSubscriber.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0002453C File Offset: 0x0002273C
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00004D94 File Offset: 0x00002F94
		public unsafe Challenges challenges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeCompletedSubscriber.NativeFieldInfoPtr_challenges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Challenges>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChallengeCompletedSubscriber.NativeFieldInfoPtr_challenges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_challenges;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_ChallengeCompleted_Private_Void_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
