using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200012A RID: 298
	public class WormGameResultsLeaderArchetypeImageRenderer : Subscriber<WormGameResultsPlayerData>
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x000411CC File Offset: 0x0003F3CC
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsLeaderArchetypeImageRenderer()
		{
			Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormGameResultsLeaderArchetypeImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr);
			WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_archetypeSpritePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr, "archetypeSpritePairs");
			WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr, "image");
			WormGameResultsLeaderArchetypeImageRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr, 100665142);
			WormGameResultsLeaderArchetypeImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr, 100665143);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0004124C File Offset: 0x0003F44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705761, XrefRangeEnd = 705783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGameResultsLeaderArchetypeImageRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00041288 File Offset: 0x0003F488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705783, XrefRangeEnd = 705793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsLeaderArchetypeImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsLeaderArchetypeImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000092CC File Offset: 0x000074CC
		public WormGameResultsLeaderArchetypeImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000412C4 File Offset: 0x0003F4C4
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000092D5 File Offset: 0x000074D5
		public unsafe List<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair> archetypeSpritePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_archetypeSpritePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_archetypeSpritePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000412F4 File Offset: 0x0003F4F4
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000092F4 File Offset: 0x000074F4
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_archetypeSpritePairs;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000386 RID: 902
		[Serializable]
		public class ArchetypeSpritePair : global::Il2CppSystem.Object
		{
			// Token: 0x06002448 RID: 9288 RVA: 0x00085DA0 File Offset: 0x00083FA0
			// Note: this type is marked as 'beforefieldinit'.
			static ArchetypeSpritePair()
			{
				Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer>.NativeClassPtr, "ArchetypeSpritePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr);
				WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr, "ArchetypeID");
				WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr, "Sprite");
				WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr, 100665144);
			}

			// Token: 0x06002449 RID: 9289 RVA: 0x00085E08 File Offset: 0x00084008
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeSpritePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600244A RID: 9290 RVA: 0x00014412 File Offset: 0x00012612
			public ArchetypeSpritePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x0600244B RID: 9291 RVA: 0x00085E44 File Offset: 0x00084044
			// (set) Token: 0x0600244C RID: 9292 RVA: 0x0001441B File Offset: 0x0001261B
			public unsafe ArchetypeID ArchetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_ArchetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x0600244D RID: 9293 RVA: 0x00085E74 File Offset: 0x00084074
			// (set) Token: 0x0600244E RID: 9294 RVA: 0x0001443A File Offset: 0x0001263A
			public unsafe Sprite Sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_Sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsLeaderArchetypeImageRenderer.ArchetypeSpritePair.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
