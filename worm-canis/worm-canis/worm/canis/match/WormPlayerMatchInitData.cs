using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.match
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class WormPlayerMatchInitData : PlayerMatchInitData
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00070CCC File Offset: 0x0006EECC
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerMatchInitData()
		{
			Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.match", "WormPlayerMatchInitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr);
			WormPlayerMatchInitData.NativeFieldInfoPtr_StartingDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "StartingDeck");
			WormPlayerMatchInitData.NativeFieldInfoPtr_StartingIntrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "StartingIntrigue");
			WormPlayerMatchInitData.NativeFieldInfoPtr_LeaderOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "LeaderOptions");
			WormPlayerMatchInitData.NativeFieldInfoPtr_AllianceTokenVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "AllianceTokenVP");
			WormPlayerMatchInitData.NativeFieldInfoPtr_StartingAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "StartingAgents");
			WormPlayerMatchInitData.NativeFieldInfoPtr_StartingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "StartingOrder");
			WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "PlayerColor");
			WormPlayerMatchInitData.NativeFieldInfoPtr_HagalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "HagalPlayer");
			WormPlayerMatchInitData.NativeFieldInfoPtr_StartingTechTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "StartingTechTiles");
			WormPlayerMatchInitData.NativeFieldInfoPtr_PreferredLeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "PreferredLeaders");
			WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerMatchSoloOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, "PlayerMatchSoloOptions");
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663794);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663795);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663796);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663797);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Int32_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663798);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663799);
			WormPlayerMatchInitData.NativeMethodInfoPtr_CopyFrom_Private_Void_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663800);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663801);
			WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663802);
			WormPlayerMatchInitData.NativeMethodInfoPtr_Clone_Public_Virtual_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr, 100663803);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00070EA0 File Offset: 0x0006F0A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31912, RefRangeEnd = 31913, XrefRangeStart = 31911, XrefRangeEnd = 31912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00070EDC File Offset: 0x0006F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31913, XrefRangeEnd = 31914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(int ail)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ail;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00070F24 File Offset: 0x0006F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31914, XrefRangeEnd = 31915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(string n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00070F70 File Offset: 0x0006F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31915, XrefRangeEnd = 31916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(string n, AccountID aid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00070FD0 File Offset: 0x0006F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31916, XrefRangeEnd = 31917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(int ail, AccountID aid, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ail;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_Int32_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0007103C File Offset: 0x0006F23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31918, RefRangeEnd = 31919, XrefRangeStart = 31917, XrefRangeEnd = 31918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(PlayerInfoSaveData saveData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00071088 File Offset: 0x0006F288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 31946, RefRangeEnd = 31949, XrefRangeStart = 31919, XrefRangeEnd = 31946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(WormPlayerMatchInitData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr_CopyFrom_Private_Void_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000710CC File Offset: 0x0006F2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31949, XrefRangeEnd = 31951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(WormPlayerMatchInitData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00071118 File Offset: 0x0006F318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 31956, RefRangeEnd = 31958, XrefRangeStart = 31951, XrefRangeEnd = 31956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerMatchInitData(PlayerMatchInitData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00071164 File Offset: 0x0006F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31958, XrefRangeEnd = 31963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlayerMatchInitData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerMatchInitData.NativeMethodInfoPtr_Clone_Public_Virtual_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr3) : null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00003134 File Offset: 0x00001334
		public WormPlayerMatchInitData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000711B0 File Offset: 0x0006F3B0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0000313D File Offset: 0x0000133D
		public unsafe List<ArchetypeID> StartingDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000711E0 File Offset: 0x0006F3E0
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000315C File Offset: 0x0000135C
		public unsafe List<ArchetypeID> StartingIntrigue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingIntrigue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingIntrigue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00071210 File Offset: 0x0006F410
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0000317B File Offset: 0x0000137B
		public unsafe List<ArchetypeID> LeaderOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_LeaderOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_LeaderOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00071240 File Offset: 0x0006F440
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000319A File Offset: 0x0000139A
		public unsafe int AllianceTokenVP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_AllianceTokenVP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_AllianceTokenVP)) = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00071268 File Offset: 0x0006F468
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000031B5 File Offset: 0x000013B5
		public unsafe int StartingAgents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingAgents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingAgents)) = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00071290 File Offset: 0x0006F490
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000031D0 File Offset: 0x000013D0
		public unsafe int StartingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingOrder)) = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000712B8 File Offset: 0x0006F4B8
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000031EB File Offset: 0x000013EB
		public unsafe PieceColor PlayerColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerColor)) = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000712E0 File Offset: 0x0006F4E0
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00003206 File Offset: 0x00001406
		public unsafe bool HagalPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_HagalPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_HagalPlayer)) = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00071308 File Offset: 0x0006F508
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00003221 File Offset: 0x00001421
		public unsafe List<ArchetypeID> StartingTechTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingTechTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_StartingTechTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00071338 File Offset: 0x0006F538
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00003240 File Offset: 0x00001440
		public unsafe List<ArchetypeID> PreferredLeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PreferredLeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PreferredLeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00071368 File Offset: 0x0006F568
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000325F File Offset: 0x0000145F
		public unsafe WormPlayerMatchSoloOptions PlayerMatchSoloOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerMatchSoloOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerMatchSoloOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerMatchInitData.NativeFieldInfoPtr_PlayerMatchSoloOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_StartingDeck;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_StartingIntrigue;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_LeaderOptions;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_AllianceTokenVP;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_StartingAgents;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_StartingOrder;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_PlayerColor;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_HagalPlayer;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_StartingTechTiles;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_PreferredLeaders;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_PlayerMatchSoloOptions;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AccountID_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AccountID_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerInfoSaveData_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Private_Void_WormPlayerMatchInitData_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayerMatchInitData_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerMatchInitData_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_PlayerMatchInitData_0;
	}
}
