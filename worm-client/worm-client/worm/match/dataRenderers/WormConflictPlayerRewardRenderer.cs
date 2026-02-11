using System;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200010E RID: 270
	public class WormConflictPlayerRewardRenderer : Subscriber<WormConflictPlayerRewardData>
	{
		// Token: 0x06000C38 RID: 3128 RVA: 0x0003D474 File Offset: 0x0003B674
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictPlayerRewardRenderer()
		{
			Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormConflictPlayerRewardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr);
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "placementText");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementOrdinalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "placementOrdinalText");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementTextObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "placementTextObject");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "conflictRewardRoot");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_bonusConflictRewardRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "bonusConflictRewardRoot");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardPrefabByFlavorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "conflictRewardPrefabByFlavorLookup");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_playerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "playerNameText");
			WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_strengthText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, "strengthText");
			WormConflictPlayerRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, 100664995);
			WormConflictPlayerRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr, 100664996);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003D56C File Offset: 0x0003B76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704128, XrefRangeEnd = 704226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictPlayerRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704226, XrefRangeEnd = 704229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictPlayerRewardRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictPlayerRewardRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictPlayerRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000086A3 File Offset: 0x000068A3
		public WormConflictPlayerRewardRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x000086AC File Offset: 0x000068AC
		public unsafe TMP_Text placementText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0003D614 File Offset: 0x0003B814
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000086CB File Offset: 0x000068CB
		public unsafe TMP_Text placementOrdinalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementOrdinalText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementOrdinalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003D644 File Offset: 0x0003B844
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000086EA File Offset: 0x000068EA
		public unsafe GameObject placementTextObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementTextObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_placementTextObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0003D674 File Offset: 0x0003B874
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00008709 File Offset: 0x00006909
		public unsafe Transform conflictRewardRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00008728 File Offset: 0x00006928
		public unsafe Transform bonusConflictRewardRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_bonusConflictRewardRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_bonusConflictRewardRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00008747 File Offset: 0x00006947
		public unsafe PrefabByFlavorLookup conflictRewardPrefabByFlavorLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardPrefabByFlavorLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_conflictRewardPrefabByFlavorLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0003D704 File Offset: 0x0003B904
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00008766 File Offset: 0x00006966
		public unsafe TMP_Text playerNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_playerNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_playerNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0003D734 File Offset: 0x0003B934
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00008785 File Offset: 0x00006985
		public unsafe TMP_Text strengthText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_strengthText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictPlayerRewardRenderer.NativeFieldInfoPtr_strengthText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_placementText;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeFieldInfoPtr_placementOrdinalText;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_placementTextObject;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_conflictRewardRoot;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_bonusConflictRewardRoot;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_conflictRewardPrefabByFlavorLookup;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_playerNameText;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_strengthText;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
