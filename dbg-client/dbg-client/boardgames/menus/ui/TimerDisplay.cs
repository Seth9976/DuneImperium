using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.menus.ui
{
	// Token: 0x020001B2 RID: 434
	public class TimerDisplay : MonoBehaviour
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x0005CA84 File Offset: 0x0005AC84
		// Note: this type is marked as 'beforefieldinit'.
		static TimerDisplay()
		{
			Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.ui", "TimerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr);
			TimerDisplay.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "display");
			TimerDisplay.NativeFieldInfoPtr_secondsLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "secondsLocKey");
			TimerDisplay.NativeFieldInfoPtr_longLocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "longLocKey");
			TimerDisplay.NativeFieldInfoPtr_onTimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "onTimeUpdated");
			TimerDisplay.NativeFieldInfoPtr_onTimerEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "onTimerEnded");
			TimerDisplay.NativeFieldInfoPtr_getTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "getTime");
			TimerDisplay.NativeFieldInfoPtr_stops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, "stops");
			TimerDisplay.NativeMethodInfoPtr_get_SecondsLocKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666181);
			TimerDisplay.NativeMethodInfoPtr_set_SecondsLocKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666182);
			TimerDisplay.NativeMethodInfoPtr_get_LongLocKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666183);
			TimerDisplay.NativeMethodInfoPtr_set_LongLocKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666184);
			TimerDisplay.NativeMethodInfoPtr_get_Display_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666185);
			TimerDisplay.NativeMethodInfoPtr_set_Display_Public_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666186);
			TimerDisplay.NativeMethodInfoPtr_get_OnTimerEnded_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666187);
			TimerDisplay.NativeMethodInfoPtr_Init_Public_Void_Func_1_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666188);
			TimerDisplay.NativeMethodInfoPtr_Set_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666189);
			TimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_New_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666190);
			TimerDisplay.NativeMethodInfoPtr_UpdateTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666191);
			TimerDisplay.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666192);
			TimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr, 100666193);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x0005CC44 File Offset: 0x0005AE44
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0005CC7C File Offset: 0x0005AE7C
		public unsafe string SecondsLocKey
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_get_SecondsLocKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_set_SecondsLocKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x0005CCC0 File Offset: 0x0005AEC0
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
		public unsafe string LongLocKey
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_get_LongLocKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_set_LongLocKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0005CD3C File Offset: 0x0005AF3C
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0005CD7C File Offset: 0x0005AF7C
		public unsafe TMP_Text Display
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_get_Display_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_set_Display_Public_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0005CDC0 File Offset: 0x0005AFC0
		public unsafe UnityEvent OnTimerEnded
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_get_OnTimerEnded_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005CE00 File Offset: 0x0005B000
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 519459, RefRangeEnd = 519468, XrefRangeStart = 519453, XrefRangeEnd = 519459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Func<TimeSpan> timeGetter, bool endAtZero = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timeGetter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAtZero;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_Init_Public_Void_Func_1_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0005CE50 File Offset: 0x0005B050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 519475, RefRangeEnd = 519477, XrefRangeStart = 519468, XrefRangeEnd = 519475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(TimeSpan time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_Set_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0005CE90 File Offset: 0x0005B090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519477, XrefRangeEnd = 519493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDisplayText(TimeSpan time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerDisplay.NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_New_String_TimeSpan_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x0005CEE0 File Offset: 0x0005B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519493, XrefRangeEnd = 519502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_UpdateTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0005CF14 File Offset: 0x0005B114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519502, XrefRangeEnd = 519505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0005CF48 File Offset: 0x0005B148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 519523, RefRangeEnd = 519526, XrefRangeStart = 519505, XrefRangeEnd = 519523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0000B25F File Offset: 0x0000945F
		public TimerDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0005CF84 File Offset: 0x0005B184
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0000B268 File Offset: 0x00009468
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x0000B287 File Offset: 0x00009487
		public unsafe string secondsLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_secondsLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_secondsLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0005CFDC File Offset: 0x0005B1DC
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x0000B2A6 File Offset: 0x000094A6
		public unsafe string longLocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_longLocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_longLocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0005D004 File Offset: 0x0005B204
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x0000B2C5 File Offset: 0x000094C5
		public unsafe UnityEvent<float> onTimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_onTimeUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_onTimeUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x0005D034 File Offset: 0x0005B234
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x0000B2E4 File Offset: 0x000094E4
		public unsafe UnityEvent onTimerEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_onTimerEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_onTimerEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x0005D064 File Offset: 0x0005B264
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x0000B303 File Offset: 0x00009503
		public unsafe Func<TimeSpan> getTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_getTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TimeSpan>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_getTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x0005D094 File Offset: 0x0005B294
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x0000B322 File Offset: 0x00009522
		public unsafe bool stops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_stops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerDisplay.NativeFieldInfoPtr_stops)) = value;
			}
		}

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_secondsLocKey;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_longLocKey;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_onTimeUpdated;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_onTimerEnded;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_getTime;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_stops;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondsLocKey_Public_get_String_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondsLocKey_Public_set_Void_String_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_get_LongLocKey_Public_get_String_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_set_LongLocKey_Public_set_Void_String_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_get_Display_Public_get_TMP_Text_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_set_Display_Public_set_Void_TMP_Text_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_get_OnTimerEnded_Public_get_UnityEvent_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Func_1_TimeSpan_Boolean_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_TimeSpan_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayText_Protected_Virtual_New_String_TimeSpan_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimer_Private_Void_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
