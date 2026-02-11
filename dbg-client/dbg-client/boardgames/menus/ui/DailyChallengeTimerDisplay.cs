using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.menus.ui
{
	// Token: 0x020001AE RID: 430
	public class DailyChallengeTimerDisplay : TimerDisplay
	{
		// Token: 0x06001348 RID: 4936 RVA: 0x0005C030 File Offset: 0x0005A230
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeTimerDisplay()
		{
			Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.ui", "DailyChallengeTimerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr);
			DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsSecondsLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, "betweenSeasonsSecondsLocKey");
			DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsLongLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, "betweenSeasonsLongLocKey");
			DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesSecondsLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, "betweenGamesSecondsLocKey");
			DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesLongLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, "betweenGamesLongLocKey");
			DailyChallengeTimerDisplay.NativeFieldInfoPtr__dailyChallengeProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, "<dailyChallengeProvider>k__BackingField");
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenSeasonsSecondsLocKey_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666153);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenSeasonsLongLocKey_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666154);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenGamesSecondsLocKey_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666155);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenGamesLongLocKey_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666156);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_dailyChallengeProvider_Protected_get_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666157);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_set_dailyChallengeProvider_Private_set_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666158);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666159);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_Event_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666160);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666161);
			DailyChallengeTimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr, 100666162);
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0005C18C File Offset: 0x0005A38C
		public unsafe string BetweenSeasonsSecondsLocKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenSeasonsSecondsLocKey_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
		public unsafe string BetweenSeasonsLongLocKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenSeasonsLongLocKey_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0005C1FC File Offset: 0x0005A3FC
		public unsafe string BetweenGamesSecondsLocKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenGamesSecondsLocKey_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0005C234 File Offset: 0x0005A434
		public unsafe string BetweenGamesLongLocKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_BetweenGamesLongLocKey_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0005C26C File Offset: 0x0005A46C
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x0005C2AC File Offset: 0x0005A4AC
		public unsafe DailyChallengeProvider dailyChallengeProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_get_dailyChallengeProvider_Protected_get_DailyChallengeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_set_dailyChallengeProvider_Private_set_Void_DailyChallengeProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0005C2F0 File Offset: 0x0005A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519272, XrefRangeEnd = 519289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0005C324 File Offset: 0x0005A524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 519302, RefRangeEnd = 519303, XrefRangeStart = 519289, XrefRangeEnd = 519302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr_Event_Set_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0005C358 File Offset: 0x0005A558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519303, XrefRangeEnd = 519324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayText(TimeSpan time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeTimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0005C3A8 File Offset: 0x0005A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519324, XrefRangeEnd = 519338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeTimerDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeTimerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeTimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0000B0AC File Offset: 0x000092AC
		public DailyChallengeTimerDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0000B0B5 File Offset: 0x000092B5
		public unsafe string betweenSeasonsSecondsLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsSecondsLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsSecondsLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x0005C40C File Offset: 0x0005A60C
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public unsafe string betweenSeasonsLongLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsLongLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenSeasonsLongLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x0005C434 File Offset: 0x0005A634
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0000B0F3 File Offset: 0x000092F3
		public unsafe string betweenGamesSecondsLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesSecondsLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesSecondsLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0005C45C File Offset: 0x0005A65C
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000B112 File Offset: 0x00009312
		public unsafe string betweenGamesLongLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesLongLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr_betweenGamesLongLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0005C484 File Offset: 0x0005A684
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000B131 File Offset: 0x00009331
		public unsafe DailyChallengeProvider _dailyChallengeProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr__dailyChallengeProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeTimerDisplay.NativeFieldInfoPtr__dailyChallengeProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_betweenSeasonsSecondsLocKey;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_betweenSeasonsLongLocKey;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_betweenGamesSecondsLocKey;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_betweenGamesLongLocKey;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr__dailyChallengeProvider_k__BackingField;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_get_BetweenSeasonsSecondsLocKey_Protected_get_String_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_get_BetweenSeasonsLongLocKey_Protected_get_String_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_get_BetweenGamesSecondsLocKey_Protected_get_String_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_get_BetweenGamesLongLocKey_Protected_get_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_get_dailyChallengeProvider_Protected_get_DailyChallengeProvider_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_set_dailyChallengeProvider_Private_set_Void_DailyChallengeProvider_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_Event_Set_Public_Void_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_String_TimeSpan_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
