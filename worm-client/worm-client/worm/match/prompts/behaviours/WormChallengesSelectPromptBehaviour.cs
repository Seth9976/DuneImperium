using System;
using boardgames.data;
using boardgames.menus.prompts;
using boardgames.utils;
using Canis;
using dwd.iap.store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C5 RID: 197
	public class WormChallengesSelectPromptBehaviour : ChallengesSelectPromptBehaviour
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x00031194 File Offset: 0x0002F394
		// Note: this type is marked as 'beforefieldinit'.
		static WormChallengesSelectPromptBehaviour()
		{
			Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormChallengesSelectPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr);
			WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_uiForSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "uiForSets");
			WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_startButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "startButton");
			WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_productUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "productUtil");
			WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "iapStoreBehaviour");
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664371);
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664372);
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_ShowChallenges_Public_Void_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664373);
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_entryRoot_Protected_Virtual_RectTransform_ChallengeEntryMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664374);
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_Void_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664375);
			WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, 100664376);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0003128C File Offset: 0x0002F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697650, XrefRangeEnd = 697658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697658, XrefRangeEnd = 697664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000312F4 File Offset: 0x0002F4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697664, XrefRangeEnd = 697722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowChallenges(Set set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_Event_ShowChallenges_Public_Void_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00031334 File Offset: 0x0002F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697722, XrefRangeEnd = 697740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RectTransform entryRoot(ChallengeEntryMatchInitData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_entryRoot_Protected_Virtual_RectTransform_ChallengeEntryMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00031390 File Offset: 0x0002F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697740, XrefRangeEnd = 697764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AutoSelectChallenge(SubscriptionProvider challengeEntryInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeEntryInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_Void_SubscriptionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000313E0 File Offset: 0x0002F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697764, XrefRangeEnd = 697769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChallengesSelectPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00006258 File Offset: 0x00004458
		public WormChallengesSelectPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0003141C File Offset: 0x0002F61C
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00006261 File Offset: 0x00004461
		public unsafe Il2CppReferenceArray<WormChallengesSelectPromptBehaviour.UIForSet> uiForSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_uiForSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormChallengesSelectPromptBehaviour.UIForSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_uiForSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0003144C File Offset: 0x0002F64C
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00006280 File Offset: 0x00004480
		public unsafe Button startButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_startButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_startButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0003147C File Offset: 0x0002F67C
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x0000629F File Offset: 0x0000449F
		public unsafe ProductUtils productUtil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_productUtil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductUtils>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_productUtil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000314AC File Offset: 0x0002F6AC
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x000062BE File Offset: 0x000044BE
		public unsafe IAPStoreBehaviour iapStoreBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.NativeFieldInfoPtr_iapStoreBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr_uiForSets;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_startButton;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_productUtil;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_iapStoreBehaviour;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowChallenges_Public_Void_Set_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_entryRoot_Protected_Virtual_RectTransform_ChallengeEntryMatchInitData_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_AutoSelectChallenge_Protected_Virtual_Void_SubscriptionProvider_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031D RID: 797
		[Serializable]
		public class UIForSet : global::Il2CppSystem.Object
		{
			// Token: 0x0600201A RID: 8218 RVA: 0x0007A148 File Offset: 0x00078348
			// Note: this type is marked as 'beforefieldinit'.
			static UIForSet()
			{
				Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "UIForSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr);
				WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr, "set");
				WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr, "toggle");
				WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr, "canvasGroup");
				WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_entryParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr, "entryParent");
				WormChallengesSelectPromptBehaviour.UIForSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr, 100664377);
			}

			// Token: 0x0600201B RID: 8219 RVA: 0x0007A1D8 File Offset: 0x000783D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIForSet()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.UIForSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.UIForSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600201C RID: 8220 RVA: 0x0001212C File Offset: 0x0001032C
			public UIForSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CA RID: 2250
			// (get) Token: 0x0600201D RID: 8221 RVA: 0x0007A214 File Offset: 0x00078414
			// (set) Token: 0x0600201E RID: 8222 RVA: 0x00012135 File Offset: 0x00010335
			public unsafe Set set
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_set);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_set)) = value;
				}
			}

			// Token: 0x170008CB RID: 2251
			// (get) Token: 0x0600201F RID: 8223 RVA: 0x0007A23C File Offset: 0x0007843C
			// (set) Token: 0x06002020 RID: 8224 RVA: 0x00012150 File Offset: 0x00010350
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CC RID: 2252
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x0007A26C File Offset: 0x0007846C
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x0001216F File Offset: 0x0001036F
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CD RID: 2253
			// (get) Token: 0x06002023 RID: 8227 RVA: 0x0007A29C File Offset: 0x0007849C
			// (set) Token: 0x06002024 RID: 8228 RVA: 0x0001218E File Offset: 0x0001038E
			public unsafe RectTransform entryParent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_entryParent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.UIForSet.NativeFieldInfoPtr_entryParent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001286 RID: 4742
			private static readonly IntPtr NativeFieldInfoPtr_set;

			// Token: 0x04001287 RID: 4743
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x04001288 RID: 4744
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x04001289 RID: 4745
			private static readonly IntPtr NativeFieldInfoPtr_entryParent;

			// Token: 0x0400128A RID: 4746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200031E RID: 798
		[ObfuscatedName("worm.match.prompts.behaviours.WormChallengesSelectPromptBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06002025 RID: 8229 RVA: 0x0007A2CC File Offset: 0x000784CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr);
				WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr, "<>9");
				WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr, "<>9__7_2");
				WormChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr, 100664379);
				WormChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__Event_ShowChallenges_b__7_2_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr, 100664380);
			}

			// Token: 0x06002026 RID: 8230 RVA: 0x0007A348 File Offset: 0x00078548
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x0007A384 File Offset: 0x00078584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ShowChallenges_b__7_2(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c.NativeMethodInfoPtr__Event_ShowChallenges_b__7_2_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x000121AD File Offset: 0x000103AD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008CE RID: 2254
			// (get) Token: 0x06002029 RID: 8233 RVA: 0x0007A3D4 File Offset: 0x000785D4
			// (set) Token: 0x0600202A RID: 8234 RVA: 0x000121B6 File Offset: 0x000103B6
			public unsafe static WormChallengesSelectPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChallengesSelectPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008CF RID: 2255
			// (get) Token: 0x0600202B RID: 8235 RVA: 0x0007A3FC File Offset: 0x000785FC
			// (set) Token: 0x0600202C RID: 8236 RVA: 0x000121C8 File Offset: 0x000103C8
			public unsafe static Func<MatchInitData, bool> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChallengesSelectPromptBehaviour.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400128B RID: 4747
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400128C RID: 4748
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x0400128D RID: 4749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400128E RID: 4750
			private static readonly IntPtr NativeMethodInfoPtr__Event_ShowChallenges_b__7_2_Internal_Boolean_MatchInitData_0;
		}

		// Token: 0x0200031F RID: 799
		[ObfuscatedName("worm.match.prompts.behaviours.WormChallengesSelectPromptBehaviour+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600202D RID: 8237 RVA: 0x0007A424 File Offset: 0x00078624
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_setString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "setString");
				WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664381);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ShowChallenges_b__0_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664382);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ShowChallenges_b__1_Internal_Boolean_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664383);
			}

			// Token: 0x0600202E RID: 8238 RVA: 0x0007A4A0 File Offset: 0x000786A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600202F RID: 8239 RVA: 0x0007A4DC File Offset: 0x000786DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697632, XrefRangeEnd = 697634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ShowChallenges_b__0(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ShowChallenges_b__0_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002030 RID: 8240 RVA: 0x0007A52C File Offset: 0x0007872C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697634, XrefRangeEnd = 697636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ShowChallenges_b__1(MatchInitData m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ShowChallenges_b__1_Internal_Boolean_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002031 RID: 8241 RVA: 0x000121DA File Offset: 0x000103DA
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D0 RID: 2256
			// (get) Token: 0x06002032 RID: 8242 RVA: 0x0007A57C File Offset: 0x0007877C
			// (set) Token: 0x06002033 RID: 8243 RVA: 0x000121E3 File Offset: 0x000103E3
			public unsafe string setString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_setString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_setString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400128F RID: 4751
			private static readonly IntPtr NativeFieldInfoPtr_setString;

			// Token: 0x04001290 RID: 4752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001291 RID: 4753
			private static readonly IntPtr NativeMethodInfoPtr__Event_ShowChallenges_b__0_Internal_Boolean_MatchInitData_0;

			// Token: 0x04001292 RID: 4754
			private static readonly IntPtr NativeMethodInfoPtr__Event_ShowChallenges_b__1_Internal_Boolean_MatchInitData_0;
		}

		// Token: 0x02000320 RID: 800
		[ObfuscatedName("worm.match.prompts.behaviours.WormChallengesSelectPromptBehaviour+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002034 RID: 8244 RVA: 0x0007A5A4 File Offset: 0x000787A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, "sets");
				WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100664384);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__entryRoot_b__0_Internal_Boolean_UIForSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr, 100664385);
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x0007A60C File Offset: 0x0007880C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002036 RID: 8246 RVA: 0x0007A648 File Offset: 0x00078848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697636, XrefRangeEnd = 697643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _entryRoot_b__0(WormChallengesSelectPromptBehaviour.UIForSet u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeMethodInfoPtr__entryRoot_b__0_Internal_Boolean_UIForSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002037 RID: 8247 RVA: 0x00012202 File Offset: 0x00010402
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D1 RID: 2257
			// (get) Token: 0x06002038 RID: 8248 RVA: 0x0007A698 File Offset: 0x00078898
			// (set) Token: 0x06002039 RID: 8249 RVA: 0x0001220B File Offset: 0x0001040B
			public unsafe List<string> sets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_sets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass8_0.NativeFieldInfoPtr_sets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001293 RID: 4755
			private static readonly IntPtr NativeFieldInfoPtr_sets;

			// Token: 0x04001294 RID: 4756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeMethodInfoPtr__entryRoot_b__0_Internal_Boolean_UIForSet_0;
		}

		// Token: 0x02000321 RID: 801
		[ObfuscatedName("worm.match.prompts.behaviours.WormChallengesSelectPromptBehaviour+<>c__DisplayClass9_0")]
		public new sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600203A RID: 8250 RVA: 0x0007A6C8 File Offset: 0x000788C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "sets");
				WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664386);
				WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__AutoSelectChallenge_b__0_Internal_Boolean_UIForSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664387);
			}

			// Token: 0x0600203B RID: 8251 RVA: 0x0007A730 File Offset: 0x00078930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600203C RID: 8252 RVA: 0x0007A76C File Offset: 0x0007896C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697643, XrefRangeEnd = 697650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AutoSelectChallenge_b__0(WormChallengesSelectPromptBehaviour.UIForSet u)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__AutoSelectChallenge_b__0_Internal_Boolean_UIForSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600203D RID: 8253 RVA: 0x0001222A File Offset: 0x0001042A
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008D2 RID: 2258
			// (get) Token: 0x0600203E RID: 8254 RVA: 0x0007A7BC File Offset: 0x000789BC
			// (set) Token: 0x0600203F RID: 8255 RVA: 0x00012233 File Offset: 0x00010433
			public unsafe List<string> sets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_sets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengesSelectPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_sets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeFieldInfoPtr_sets;

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeMethodInfoPtr__AutoSelectChallenge_b__0_Internal_Boolean_UIForSet_0;
		}
	}
}
