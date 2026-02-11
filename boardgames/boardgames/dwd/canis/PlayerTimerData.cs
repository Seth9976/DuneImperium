using System;
using Canis.boardgames;
using Canis.messages.timer;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.canis
{
	// Token: 0x020000A7 RID: 167
	public class PlayerTimerData : VersionedDataComponent
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x0002A2E0 File Offset: 0x000284E0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTimerData()
		{
			Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.canis", "PlayerTimerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr);
			PlayerTimerData.NativeFieldInfoPtr_timerInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, "timerInternal");
			PlayerTimerData.NativeFieldInfoPtr_onlineMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, "onlineMatch");
			PlayerTimerData.NativeFieldInfoPtr_localEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, "localEndTime");
			PlayerTimerData.NativeFieldInfoPtr__Ended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, "<Ended>k__BackingField");
			PlayerTimerData.NativeMethodInfoPtr_get_TimeRemaining_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664548);
			PlayerTimerData.NativeMethodInfoPtr_get_Timer_Public_get_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664549);
			PlayerTimerData.NativeMethodInfoPtr_set_Timer_Public_set_Void_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664550);
			PlayerTimerData.NativeMethodInfoPtr_get_Ended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664551);
			PlayerTimerData.NativeMethodInfoPtr_set_Ended_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664552);
			PlayerTimerData.NativeMethodInfoPtr__ctor_Public_Void_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664553);
			PlayerTimerData.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664554);
			PlayerTimerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr, 100664555);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x0002A400 File Offset: 0x00028600
		public unsafe TimeSpan TimeRemaining
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 991164, RefRangeEnd = 991166, XrefRangeStart = 991150, XrefRangeEnd = 991164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_get_TimeRemaining_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x0002A43C File Offset: 0x0002863C
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0002A47C File Offset: 0x0002867C
		public unsafe DisplayTimer Timer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_get_Timer_Public_get_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DisplayTimer>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 991180, RefRangeEnd = 991181, XrefRangeStart = 991166, XrefRangeEnd = 991180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_set_Timer_Public_set_Void_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0002A4C0 File Offset: 0x000286C0
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0002A4FC File Offset: 0x000286FC
		public unsafe bool Ended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_get_Ended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_set_Ended_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0002A53C File Offset: 0x0002873C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991195, RefRangeEnd = 991196, XrefRangeStart = 991181, XrefRangeEnd = 991195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTimerData(DisplayTimer timer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTimerData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr__ctor_Public_Void_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002A588 File Offset: 0x00028788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 991197, RefRangeEnd = 991198, XrefRangeStart = 991196, XrefRangeEnd = 991197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerData.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002A5BC File Offset: 0x000287BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991198, XrefRangeEnd = 991214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTimerData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00005A07 File Offset: 0x00003C07
		public PlayerTimerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0002A600 File Offset: 0x00028800
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00005A10 File Offset: 0x00003C10
		public unsafe DisplayTimer timerInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_timerInternal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayTimer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_timerInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0002A630 File Offset: 0x00028830
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00005A2F File Offset: 0x00003C2F
		public unsafe CanisOnlineMatch onlineMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_onlineMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisOnlineMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_onlineMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0002A660 File Offset: 0x00028860
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00005A4E File Offset: 0x00003C4E
		public unsafe DateTime localEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_localEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr_localEndTime)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0002A688 File Offset: 0x00028888
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00005A69 File Offset: 0x00003C69
		public unsafe bool _Ended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr__Ended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerData.NativeFieldInfoPtr__Ended_k__BackingField)) = value;
			}
		}

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_timerInternal;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_onlineMatch;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_localEndTime;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr__Ended_k__BackingField;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeRemaining_Public_get_TimeSpan_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_get_Timer_Public_get_DisplayTimer_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_set_Timer_Public_set_Void_DisplayTimer_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_get_Ended_Public_get_Boolean_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_set_Ended_Private_set_Void_Boolean_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DisplayTimer_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
