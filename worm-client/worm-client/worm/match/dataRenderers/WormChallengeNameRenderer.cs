using System;
using boardgames.data;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x02000104 RID: 260
	public class WormChallengeNameRenderer : VersionedSubscriber<NameLookup>
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0003B430 File Offset: 0x00039630
		// Note: this type is marked as 'beforefieldinit'.
		static WormChallengeNameRenderer()
		{
			Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormChallengeNameRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr);
			WormChallengeNameRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, "text");
			WormChallengeNameRenderer.NativeFieldInfoPtr_difficultyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, "difficultyData");
			WormChallengeNameRenderer.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, "normal");
			WormChallengeNameRenderer.NativeFieldInfoPtr_heroic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, "heroic");
			WormChallengeNameRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, "image");
			WormChallengeNameRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, 100664894);
			WormChallengeNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, 100664895);
			WormChallengeNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr, 100664896);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0003B500 File Offset: 0x00039700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703349, XrefRangeEnd = 703353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeNameRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0003B534 File Offset: 0x00039734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703353, XrefRangeEnd = 703374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChallengeNameRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003B570 File Offset: 0x00039770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703374, XrefRangeEnd = 703377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChallengeNameRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChallengeNameRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChallengeNameRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000081F9 File Offset: 0x000063F9
		public WormChallengeNameRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0003B5AC File Offset: 0x000397AC
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00008202 File Offset: 0x00006402
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0003B5DC File Offset: 0x000397DC
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00008221 File Offset: 0x00006421
		public unsafe ChallengeDifficultyData difficultyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_difficultyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChallengeDifficultyData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_difficultyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0003B60C File Offset: 0x0003980C
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00008240 File Offset: 0x00006440
		public unsafe Sprite normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0003B63C File Offset: 0x0003983C
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0000825F File Offset: 0x0000645F
		public unsafe Sprite heroic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_heroic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_heroic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0003B66C File Offset: 0x0003986C
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0000827E File Offset: 0x0000647E
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChallengeNameRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_difficultyData;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_normal;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_heroic;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
