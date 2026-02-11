using System;
using canis.Networking.game.messages;
using dbgclient.dataRenderers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000091 RID: 145
	public class WormMatchHistoryDataRenderer : MatchHistoryDataRenderer
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x00029F5C File Offset: 0x0002815C
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchHistoryDataRenderer()
		{
			Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormMatchHistoryDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr);
			WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, "Spice");
			WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Rounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, "Rounds");
			WormMatchHistoryDataRenderer.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, "provider");
			WormMatchHistoryDataRenderer.NativeFieldInfoPtr_expansions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, "expansions");
			WormMatchHistoryDataRenderer.NativeMethodInfoPtr_GetScoreString_Protected_Virtual_String_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, 100664113);
			WormMatchHistoryDataRenderer.NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_Void_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, 100664114);
			WormMatchHistoryDataRenderer.NativeMethodInfoPtr_GetLeaderString_Private_String_MatchHistoryResultDetail_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, 100664115);
			WormMatchHistoryDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr, 100664116);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002A02C File Offset: 0x0002822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695463, XrefRangeEnd = 695470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetScoreString(MatchHistoryResultDetail localDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchHistoryDataRenderer.NativeMethodInfoPtr_GetScoreString_Protected_Virtual_String_MatchHistoryResultDetail_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002A080 File Offset: 0x00028280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695470, XrefRangeEnd = 695530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetGameSpecificValues(MatchHistoryResultDetail detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchHistoryDataRenderer.NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_Void_MatchHistoryResultDetail_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002A0D0 File Offset: 0x000282D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695530, XrefRangeEnd = 695564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLeaderString(MatchHistoryResultDetail detail)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(detail);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHistoryDataRenderer.NativeMethodInfoPtr_GetLeaderString_Private_String_MatchHistoryResultDetail_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002A118 File Offset: 0x00028318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695564, XrefRangeEnd = 695565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchHistoryDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchHistoryDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchHistoryDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004CE7 File Offset: 0x00002EE7
		public WormMatchHistoryDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0002A154 File Offset: 0x00028354
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00004CF0 File Offset: 0x00002EF0
		public unsafe TMP_Text Spice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Spice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Spice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0002A184 File Offset: 0x00028384
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00004D0F File Offset: 0x00002F0F
		public unsafe TMP_Text Rounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Rounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_Rounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0002A1B4 File Offset: 0x000283B4
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00004D2E File Offset: 0x00002F2E
		public new unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0002A1E4 File Offset: 0x000283E4
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00004D4D File Offset: 0x00002F4D
		public unsafe TMP_Text expansions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_expansions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchHistoryDataRenderer.NativeFieldInfoPtr_expansions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_Spice;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_Rounds;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_expansions;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_GetScoreString_Protected_Virtual_String_MatchHistoryResultDetail_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_SetGameSpecificValues_Protected_Virtual_Void_MatchHistoryResultDetail_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderString_Private_String_MatchHistoryResultDetail_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
