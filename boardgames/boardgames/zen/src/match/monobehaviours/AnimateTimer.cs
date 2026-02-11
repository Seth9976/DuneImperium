using System;
using Canis.messages.timer;
using Canis.utils.ids;
using dwd.canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006A RID: 106
	public class AnimateTimer : VersionedView<PlayerTimerData>
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00022308 File Offset: 0x00020508
		// Note: this type is marked as 'beforefieldinit'.
		static AnimateTimer()
		{
			Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "AnimateTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr);
			AnimateTimer.NativeFieldInfoPtr_timerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "timerImage");
			AnimateTimer.NativeFieldInfoPtr_timerAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "timerAnimator");
			AnimateTimer.NativeFieldInfoPtr__TimerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "<TimerID>k__BackingField");
			AnimateTimer.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "buffer");
			AnimateTimer.NativeFieldInfoPtr_BufferPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "BufferPercentage");
			AnimateTimer.NativeFieldInfoPtr_totalWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "totalWaitTime");
			AnimateTimer.NativeFieldInfoPtr_showTimerDurationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "showTimerDurationOverride");
			AnimateTimer.NativeFieldInfoPtr_minimumShowDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "minimumShowDelay");
			AnimateTimer.NativeFieldInfoPtr_blendAnimParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "blendAnimParam");
			AnimateTimer.NativeFieldInfoPtr_blendDecreases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "blendDecreases");
			AnimateTimer.NativeFieldInfoPtr_playTimerAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "playTimerAnim");
			AnimateTimer.NativeFieldInfoPtr_blendHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "blendHash");
			AnimateTimer.NativeFieldInfoPtr_lastElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "lastElapsedSeconds");
			AnimateTimer.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "Visible");
			AnimateTimer.NativeFieldInfoPtr_OnTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "OnTimeout");
			AnimateTimer.NativeFieldInfoPtr_OnTimerEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "OnTimerEnded");
			AnimateTimer.NativeMethodInfoPtr_get_TimerID_Public_get_TimerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664198);
			AnimateTimer.NativeMethodInfoPtr_set_TimerID_Private_set_Void_TimerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664199);
			AnimateTimer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664200);
			AnimateTimer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664201);
			AnimateTimer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664202);
			AnimateTimer.NativeMethodInfoPtr_Running_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664203);
			AnimateTimer.NativeMethodInfoPtr_EndTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664204);
			AnimateTimer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664205);
			AnimateTimer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664206);
			AnimateTimer.NativeMethodInfoPtr_showTimer_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664207);
			AnimateTimer.NativeMethodInfoPtr_hideTimer_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664208);
			AnimateTimer.NativeMethodInfoPtr_validateTimer_Protected_Virtual_New_Boolean_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664209);
			AnimateTimer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664210);
			AnimateTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664211);
			AnimateTimer.NativeMethodInfoPtr__Awake_b__19_0_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, 100664213);
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000225A4 File Offset: 0x000207A4
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x000225E4 File Offset: 0x000207E4
		public unsafe TimerID TimerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_get_TimerID_Public_get_TimerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_set_TimerID_Private_set_Void_TimerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00022628 File Offset: 0x00020828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987967, XrefRangeEnd = 987988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0002265C File Offset: 0x0002085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987988, XrefRangeEnd = 987997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00022698 File Offset: 0x00020898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987997, XrefRangeEnd = 988002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000226D8 File Offset: 0x000208D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988002, XrefRangeEnd = 988006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Running()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_Running_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00022714 File Offset: 0x00020914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 988009, RefRangeEnd = 988011, XrefRangeStart = 988006, XrefRangeEnd = 988009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_EndTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00022748 File Offset: 0x00020948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988011, XrefRangeEnd = 988049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00022784 File Offset: 0x00020984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988049, XrefRangeEnd = 988055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000227B8 File Offset: 0x000209B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988055, XrefRangeEnd = 988067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void showTimer(float elapsedSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsedSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_showTimer_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00022804 File Offset: 0x00020A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988067, XrefRangeEnd = 988073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hideTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_hideTimer_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00022840 File Offset: 0x00020A40
		[CallerCount(0)]
		public unsafe virtual bool validateTimer(DisplayTimer timer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_validateTimer_Protected_Virtual_New_Boolean_DisplayTimer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00022898 File Offset: 0x00020A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988073, XrefRangeEnd = 988085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimateTimer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000228D4 File Offset: 0x00020AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988085, XrefRangeEnd = 988105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimateTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00022910 File Offset: 0x00020B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 988009, RefRangeEnd = 988011, XrefRangeStart = 988009, XrefRangeEnd = 988011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__19_0(PoolableItem _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer.NativeMethodInfoPtr__Awake_b__19_0_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00004874 File Offset: 0x00002A74
		public AnimateTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00022954 File Offset: 0x00020B54
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0000487D File Offset: 0x00002A7D
		public unsafe Image timerImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_timerImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_timerImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00022984 File Offset: 0x00020B84
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0000489C File Offset: 0x00002A9C
		public unsafe Animator timerAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_timerAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_timerAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000229B4 File Offset: 0x00020BB4
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x000048BB File Offset: 0x00002ABB
		public unsafe TimerID _TimerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr__TimerID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr__TimerID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000229E4 File Offset: 0x00020BE4
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000048DA File Offset: 0x00002ADA
		public unsafe float buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_buffer)) = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00022A0C File Offset: 0x00020C0C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x000048F5 File Offset: 0x00002AF5
		public unsafe float BufferPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_BufferPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_BufferPercentage)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00022A34 File Offset: 0x00020C34
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00004910 File Offset: 0x00002B10
		public unsafe float totalWaitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_totalWaitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_totalWaitTime)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00022A5C File Offset: 0x00020C5C
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x0000492B File Offset: 0x00002B2B
		public unsafe float showTimerDurationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_showTimerDurationOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_showTimerDurationOverride)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00022A84 File Offset: 0x00020C84
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00004946 File Offset: 0x00002B46
		public unsafe float minimumShowDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_minimumShowDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_minimumShowDelay)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00022AAC File Offset: 0x00020CAC
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00004961 File Offset: 0x00002B61
		public unsafe string blendAnimParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendAnimParam);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendAnimParam), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00022AD4 File Offset: 0x00020CD4
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00004980 File Offset: 0x00002B80
		public unsafe bool blendDecreases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendDecreases);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendDecreases)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00022AFC File Offset: 0x00020CFC
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0000499B File Offset: 0x00002B9B
		public unsafe string playTimerAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_playTimerAnim);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_playTimerAnim), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00022B24 File Offset: 0x00020D24
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000049BA File Offset: 0x00002BBA
		public unsafe int blendHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_blendHash)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00022B4C File Offset: 0x00020D4C
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000049D5 File Offset: 0x00002BD5
		public Nullable<float> lastElapsedSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_lastElapsedSeconds);
				return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_lastElapsedSeconds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00022B7C File Offset: 0x00020D7C
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00004A03 File Offset: 0x00002C03
		public unsafe static int Visible
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AnimateTimer.NativeFieldInfoPtr_Visible, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimateTimer.NativeFieldInfoPtr_Visible, (void*)(&value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00022B98 File Offset: 0x00020D98
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00004A11 File Offset: 0x00002C11
		public unsafe UnityEvent OnTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_OnTimeout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_OnTimeout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00022BC8 File Offset: 0x00020DC8
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00004A30 File Offset: 0x00002C30
		public unsafe UnityEvent OnTimerEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_OnTimerEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer.NativeFieldInfoPtr_OnTimerEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_timerImage;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr_timerAnimator;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr__TimerID_k__BackingField;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr_BufferPercentage;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_totalWaitTime;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_showTimerDurationOverride;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_minimumShowDelay;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_blendAnimParam;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_blendDecreases;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_playTimerAnim;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_blendHash;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_lastElapsedSeconds;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_Visible;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_OnTimeout;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_OnTimerEnded;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerID_Public_get_TimerID_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_set_TimerID_Private_set_Void_TimerID_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_Running_Public_Boolean_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_EndTimer_Public_Void_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_showTimer_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_hideTimer_Protected_Virtual_New_Void_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_validateTimer_Protected_Virtual_New_Boolean_DisplayTimer_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__19_0_Private_Void_PoolableItem_0;

		// Token: 0x02000202 RID: 514
		[ObfuscatedName("zen.src.match.monobehaviours.AnimateTimer+<Init>d__21")]
		public sealed class _Init_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06001768 RID: 5992 RVA: 0x00059ABC File Offset: 0x00057CBC
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__21()
			{
				Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimateTimer>.NativeClassPtr, "<Init>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr);
				AnimateTimer._Init_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, "<>1__state");
				AnimateTimer._Init_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, "<>2__current");
				AnimateTimer._Init_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, "<>4__this");
				AnimateTimer._Init_d__21.NativeFieldInfoPtr__view_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, "<view>5__2");
				AnimateTimer._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664214);
				AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664215);
				AnimateTimer._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664216);
				AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664217);
				AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664218);
				AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr, 100664219);
			}

			// Token: 0x06001769 RID: 5993 RVA: 0x00059BB0 File Offset: 0x00057DB0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimateTimer._Init_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600176A RID: 5994 RVA: 0x00059BF8 File Offset: 0x00057DF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600176B RID: 5995 RVA: 0x00059C2C File Offset: 0x00057E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987944, XrefRangeEnd = 987962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x0600176C RID: 5996 RVA: 0x00059C68 File Offset: 0x00057E68
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600176D RID: 5997 RVA: 0x00059CA8 File Offset: 0x00057EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987962, XrefRangeEnd = 987967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x0600176E RID: 5998 RVA: 0x00059CDC File Offset: 0x00057EDC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimateTimer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x0000CE03 File Offset: 0x0000B003
			public _Init_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001770 RID: 6000 RVA: 0x00059D1C File Offset: 0x00057F1C
			// (set) Token: 0x06001771 RID: 6001 RVA: 0x0000CE0C File Offset: 0x0000B00C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x06001772 RID: 6002 RVA: 0x00059D44 File Offset: 0x00057F44
			// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000CE27 File Offset: 0x0000B027
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06001774 RID: 6004 RVA: 0x00059D74 File Offset: 0x00057F74
			// (set) Token: 0x06001775 RID: 6005 RVA: 0x0000CE46 File Offset: 0x0000B046
			public unsafe AnimateTimer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateTimer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x06001776 RID: 6006 RVA: 0x00059DA4 File Offset: 0x00057FA4
			// (set) Token: 0x06001777 RID: 6007 RVA: 0x0000CE65 File Offset: 0x0000B065
			public unsafe EntityView _view_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr__view_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimateTimer._Init_d__21.NativeFieldInfoPtr__view_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E2B RID: 3627
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E2C RID: 3628
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E2D RID: 3629
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E2E RID: 3630
			private static readonly IntPtr NativeFieldInfoPtr__view_5__2;

			// Token: 0x04000E2F RID: 3631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E30 RID: 3632
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E31 RID: 3633
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E32 RID: 3634
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E33 RID: 3635
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E34 RID: 3636
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
