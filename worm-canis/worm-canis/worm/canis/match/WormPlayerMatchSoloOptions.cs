using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.match
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class WormPlayerMatchSoloOptions : Object
	{
		// Token: 0x0600023C RID: 572 RVA: 0x00071398 File Offset: 0x0006F598
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerMatchSoloOptions()
		{
			Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.match", "WormPlayerMatchSoloOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr);
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingDiscard");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingDeckOrder");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle1DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "Reshuffle1DeckOrder");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle2DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "Reshuffle2DeckOrder");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle3DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "Reshuffle3DeckOrder");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingGarrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "BonusStartingGarrison");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "BonusStartingWater");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_ControlLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "ControlLocations");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "BonusStartingVP");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSwordmaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingSwordmaster");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingHighCouncil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingHighCouncil");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingSolari");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingSpice");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingWater");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingGarrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingGarrison");
			WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpecimens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, "StartingSpecimens");
			WormPlayerMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, 100663804);
			WormPlayerMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchSoloOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, 100663805);
			WormPlayerMatchSoloOptions.NativeMethodInfoPtr_Clone_Public_WormPlayerMatchSoloOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr, 100663806);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00071544 File Offset: 0x0006F744
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchSoloOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00071580 File Offset: 0x0006F780
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31985, RefRangeEnd = 31987, XrefRangeStart = 31963, XrefRangeEnd = 31985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchSoloOptions(WormPlayerMatchSoloOptions other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchSoloOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchSoloOptions.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchSoloOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000715CC File Offset: 0x0006F7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31987, XrefRangeEnd = 31991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchSoloOptions Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchSoloOptions.NativeMethodInfoPtr_Clone_Public_WormPlayerMatchSoloOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayerMatchSoloOptions>(intPtr3) : null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000327E File Offset: 0x0000147E
		public WormPlayerMatchSoloOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0007160C File Offset: 0x0006F80C
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003287 File Offset: 0x00001487
		public unsafe List<ArchetypeID> StartingDiscard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDiscard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDiscard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0007163C File Offset: 0x0006F83C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x000032A6 File Offset: 0x000014A6
		public unsafe List<ArchetypeID> StartingDeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingDeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0007166C File Offset: 0x0006F86C
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000032C5 File Offset: 0x000014C5
		public unsafe List<ArchetypeID> Reshuffle1DeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle1DeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle1DeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0007169C File Offset: 0x0006F89C
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000032E4 File Offset: 0x000014E4
		public unsafe List<ArchetypeID> Reshuffle2DeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle2DeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle2DeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000716CC File Offset: 0x0006F8CC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00003303 File Offset: 0x00001503
		public unsafe List<ArchetypeID> Reshuffle3DeckOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle3DeckOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_Reshuffle3DeckOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000716FC File Offset: 0x0006F8FC
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00003322 File Offset: 0x00001522
		public unsafe int BonusStartingGarrison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingGarrison);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingGarrison)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00071724 File Offset: 0x0006F924
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000333D File Offset: 0x0000153D
		public unsafe int BonusStartingWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingWater);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingWater)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0007174C File Offset: 0x0006F94C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe List<ArchetypeID> ControlLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_ControlLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_ControlLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0007177C File Offset: 0x0006F97C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00003377 File Offset: 0x00001577
		public unsafe int BonusStartingVP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingVP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_BonusStartingVP)) = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000717A4 File Offset: 0x0006F9A4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003392 File Offset: 0x00001592
		public unsafe bool StartingSwordmaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSwordmaster);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSwordmaster)) = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000717CC File Offset: 0x0006F9CC
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000033AD File Offset: 0x000015AD
		public unsafe bool StartingHighCouncil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingHighCouncil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingHighCouncil)) = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000717F4 File Offset: 0x0006F9F4
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000033C8 File Offset: 0x000015C8
		public unsafe int StartingSolari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSolari);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSolari)) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0007181C File Offset: 0x0006FA1C
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000033E3 File Offset: 0x000015E3
		public unsafe int StartingSpice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpice)) = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00071844 File Offset: 0x0006FA44
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000033FE File Offset: 0x000015FE
		public unsafe int StartingWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingWater);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingWater)) = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0007186C File Offset: 0x0006FA6C
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003419 File Offset: 0x00001619
		public unsafe int StartingGarrison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingGarrison);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingGarrison)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00071894 File Offset: 0x0006FA94
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003434 File Offset: 0x00001634
		public unsafe int StartingSpecimens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpecimens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchSoloOptions.NativeFieldInfoPtr_StartingSpecimens)) = value;
			}
		}

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_StartingDiscard;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_StartingDeckOrder;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle1DeckOrder;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle2DeckOrder;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle3DeckOrder;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_BonusStartingGarrison;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_BonusStartingWater;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_ControlLocations;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_BonusStartingVP;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_StartingSwordmaster;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_StartingHighCouncil;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_StartingSolari;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_StartingSpice;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_StartingWater;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_StartingGarrison;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_StartingSpecimens;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchSoloOptions_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_WormPlayerMatchSoloOptions_0;
	}
}
