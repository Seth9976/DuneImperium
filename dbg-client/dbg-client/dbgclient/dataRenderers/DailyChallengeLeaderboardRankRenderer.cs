using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B5 RID: 181
	public class DailyChallengeLeaderboardRankRenderer : Subscriber<DailyChallengeLeaderboardData>
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00034908 File Offset: 0x00032B08
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboardRankRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "DailyChallengeLeaderboardRankRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr);
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "rank");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "score");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "highlight");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_recentScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "recentScore");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinumMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "platinumMedals");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "goldMedals");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "silverMedals");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "bronzeMedals");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "platinum");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "gold");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "silver");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronze = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "bronze");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "scrollView");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_usePlatinum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "usePlatinum");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "goldThreshold");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "silverThreshold");
			DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "bronzeThreshold");
			DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, 100664414);
			DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr_delayedScroll_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, 100664415);
			DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, 100664416);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00034AC8 File Offset: 0x00032CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504179, XrefRangeEnd = 504204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00034B04 File Offset: 0x00032D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504204, XrefRangeEnd = 504209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator delayedScroll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr_delayedScroll_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00034B44 File Offset: 0x00032D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504209, XrefRangeEnd = 504212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboardRankRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00005583 File Offset: 0x00003783
		public DailyChallengeLeaderboardRankRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00034B80 File Offset: 0x00032D80
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0000558C File Offset: 0x0000378C
		public unsafe TMP_Text rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_rank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_rank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00034BB0 File Offset: 0x00032DB0
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x000055AB File Offset: 0x000037AB
		public unsafe TMP_Text score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_score);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00034BE0 File Offset: 0x00032DE0
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x000055CA File Offset: 0x000037CA
		public unsafe GameObject highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00034C10 File Offset: 0x00032E10
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000055E9 File Offset: 0x000037E9
		public unsafe TMP_Text recentScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_recentScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_recentScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00034C40 File Offset: 0x00032E40
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00005608 File Offset: 0x00003808
		public unsafe TMP_Text platinumMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinumMedals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinumMedals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00034C70 File Offset: 0x00032E70
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00005627 File Offset: 0x00003827
		public unsafe TMP_Text goldMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldMedals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldMedals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00034CA0 File Offset: 0x00032EA0
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00005646 File Offset: 0x00003846
		public unsafe TMP_Text silverMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverMedals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverMedals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00034CD0 File Offset: 0x00032ED0
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00005665 File Offset: 0x00003865
		public unsafe TMP_Text bronzeMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeMedals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeMedals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00034D00 File Offset: 0x00032F00
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00005684 File Offset: 0x00003884
		public unsafe GameObject platinum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_platinum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00034D30 File Offset: 0x00032F30
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x000056A3 File Offset: 0x000038A3
		public unsafe GameObject gold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_gold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_gold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00034D60 File Offset: 0x00032F60
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x000056C2 File Offset: 0x000038C2
		public unsafe GameObject silver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00034D90 File Offset: 0x00032F90
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x000056E1 File Offset: 0x000038E1
		public unsafe GameObject bronze
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronze);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronze), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00034DC0 File Offset: 0x00032FC0
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00005700 File Offset: 0x00003900
		public unsafe ScrollRect scrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_scrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00034DF0 File Offset: 0x00032FF0
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000571F File Offset: 0x0000391F
		public unsafe static bool usePlatinum
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_usePlatinum, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_usePlatinum, (void*)(&value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00034E0C File Offset: 0x0003300C
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x0000572D File Offset: 0x0000392D
		public unsafe static int goldThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_goldThreshold, (void*)(&value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00034E28 File Offset: 0x00033028
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x0000573B File Offset: 0x0000393B
		public unsafe static int silverThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_silverThreshold, (void*)(&value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00034E44 File Offset: 0x00033044
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00005749 File Offset: 0x00003949
		public unsafe static int bronzeThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DailyChallengeLeaderboardRankRenderer.NativeFieldInfoPtr_bronzeThreshold, (void*)(&value));
			}
		}

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_recentScore;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_platinumMedals;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_goldMedals;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_silverMedals;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_bronzeMedals;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_platinum;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_gold;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_silver;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_bronze;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_scrollView;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_usePlatinum;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_goldThreshold;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_silverThreshold;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_bronzeThreshold;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_delayedScroll_Private_IEnumerator_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031D RID: 797
		[ObfuscatedName("dbgclient.dataRenderers.DailyChallengeLeaderboardRankRenderer+<delayedScroll>d__18")]
		public sealed class _delayedScroll_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x06002599 RID: 9625 RVA: 0x00098EF4 File Offset: 0x000970F4
			// Note: this type is marked as 'beforefieldinit'.
			static _delayedScroll_d__18()
			{
				Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer>.NativeClassPtr, "<delayedScroll>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, "<>1__state");
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, "<>2__current");
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, "<>4__this");
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664417);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664418);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664419);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664420);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664421);
				DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr, 100664422);
			}

			// Token: 0x0600259A RID: 9626 RVA: 0x00098FD4 File Offset: 0x000971D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _delayedScroll_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600259B RID: 9627 RVA: 0x0009901C File Offset: 0x0009721C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600259C RID: 9628 RVA: 0x00099050 File Offset: 0x00097250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504168, XrefRangeEnd = 504174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x0600259D RID: 9629 RVA: 0x0009908C File Offset: 0x0009728C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600259E RID: 9630 RVA: 0x000990CC File Offset: 0x000972CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504174, XrefRangeEnd = 504179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x0600259F RID: 9631 RVA: 0x00099100 File Offset: 0x00097300
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025A0 RID: 9632 RVA: 0x00013851 File Offset: 0x00011A51
			public _delayedScroll_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x060025A1 RID: 9633 RVA: 0x00099140 File Offset: 0x00097340
			// (set) Token: 0x060025A2 RID: 9634 RVA: 0x0001385A File Offset: 0x00011A5A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00099168 File Offset: 0x00097368
			// (set) Token: 0x060025A4 RID: 9636 RVA: 0x00013875 File Offset: 0x00011A75
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00099198 File Offset: 0x00097398
			// (set) Token: 0x060025A6 RID: 9638 RVA: 0x00013894 File Offset: 0x00011A94
			public unsafe DailyChallengeLeaderboardRankRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardRankRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardRankRenderer._delayedScroll_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
