using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace DG.Tweening
{
	// Token: 0x02000018 RID: 24
	public class Tween : ABSSequentiable
	{
		// Token: 0x060001ED RID: 493 RVA: 0x000101F4 File Offset: 0x0000E3F4
		// Note: this type is marked as 'beforefieldinit'.
		static Tween()
		{
			Il2CppClassPointerStore<Tween>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Tween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tween>.NativeClassPtr);
			Tween.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "timeScale");
			Tween.NativeFieldInfoPtr_isBackwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isBackwards");
			Tween.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "id");
			Tween.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "stringId");
			Tween.NativeFieldInfoPtr_intId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "intId");
			Tween.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "target");
			Tween.NativeFieldInfoPtr_updateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "updateType");
			Tween.NativeFieldInfoPtr_isIndependentUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isIndependentUpdate");
			Tween.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onPlay");
			Tween.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onPause");
			Tween.NativeFieldInfoPtr_onRewind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onRewind");
			Tween.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onUpdate");
			Tween.NativeFieldInfoPtr_onStepComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onStepComplete");
			Tween.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onComplete");
			Tween.NativeFieldInfoPtr_onKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onKill");
			Tween.NativeFieldInfoPtr_onWaypointChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "onWaypointChange");
			Tween.NativeFieldInfoPtr_isFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isFrom");
			Tween.NativeFieldInfoPtr_isBlendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isBlendable");
			Tween.NativeFieldInfoPtr_isRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isRecyclable");
			Tween.NativeFieldInfoPtr_isSpeedBased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isSpeedBased");
			Tween.NativeFieldInfoPtr_autoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "autoKill");
			Tween.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "duration");
			Tween.NativeFieldInfoPtr_loops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "loops");
			Tween.NativeFieldInfoPtr_loopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "loopType");
			Tween.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "delay");
			Tween.NativeFieldInfoPtr_isRelative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isRelative");
			Tween.NativeFieldInfoPtr_easeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easeType");
			Tween.NativeFieldInfoPtr_customEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "customEase");
			Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easeOvershootOrAmplitude");
			Tween.NativeFieldInfoPtr_easePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "easePeriod");
			Tween.NativeFieldInfoPtr_typeofT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofT1");
			Tween.NativeFieldInfoPtr_typeofT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofT2");
			Tween.NativeFieldInfoPtr_typeofTPlugOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "typeofTPlugOptions");
			Tween.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "active");
			Tween.NativeFieldInfoPtr_isSequenced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isSequenced");
			Tween.NativeFieldInfoPtr_sequenceParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "sequenceParent");
			Tween.NativeFieldInfoPtr_activeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "activeId");
			Tween.NativeFieldInfoPtr_specialStartupMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "specialStartupMode");
			Tween.NativeFieldInfoPtr_creationLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "creationLocked");
			Tween.NativeFieldInfoPtr_startupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "startupDone");
			Tween.NativeFieldInfoPtr_playedOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "playedOnce");
			Tween.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "position");
			Tween.NativeFieldInfoPtr_fullDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "fullDuration");
			Tween.NativeFieldInfoPtr_completedLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "completedLoops");
			Tween.NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isPlaying");
			Tween.NativeFieldInfoPtr_isComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "isComplete");
			Tween.NativeFieldInfoPtr_elapsedDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "elapsedDelay");
			Tween.NativeFieldInfoPtr_delayComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "delayComplete");
			Tween.NativeFieldInfoPtr_miscInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tween>.NativeClassPtr, "miscInt");
			Tween.NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663913);
			Tween.NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663914);
			Tween.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663915);
			Tween.NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663916);
			Tween.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663917);
			Tween.NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663918);
			Tween.NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663919);
			Tween.NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663920);
			Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663921);
			Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663922);
			Tween.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tween>.NativeClassPtr, 100663923);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000106D4 File Offset: 0x0000E8D4
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00010710 File Offset: 0x0000E910
		public unsafe float fullPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131594, XrefRangeEnd = 1131595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131595, XrefRangeEnd = 1131600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00010750 File Offset: 0x0000E950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131613, RefRangeEnd = 1131614, XrefRangeStart = 1131600, XrefRangeEnd = 1131613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001078C File Offset: 0x0000E98C
		[CallerCount(0)]
		public unsafe virtual bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000107D4 File Offset: 0x0000E9D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float UpdateDelay(float elapsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref elapsed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00010828 File Offset: 0x0000EA28
		[CallerCount(0)]
		public unsafe virtual bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00010870 File Offset: 0x0000EA70
		[CallerCount(0)]
		public unsafe virtual bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref prevPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateNotice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tween.NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001090C File Offset: 0x0000EB0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1131631, RefRangeEnd = 1131636, XrefRangeStart = 1131614, XrefRangeEnd = 1131631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toCompletedLoops;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00010978 File Offset: 0x0000EB78
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1131640, RefRangeEnd = 1131659, XrefRangeStart = 1131636, XrefRangeEnd = 1131640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnTweenCallback(TweenCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000109BC File Offset: 0x0000EBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1131664, RefRangeEnd = 1131665, XrefRangeStart = 1131659, XrefRangeEnd = 1131664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnTweenCallback<T>(TweenCallback<T> callback, T param)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = param;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref param;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tween.MethodInfoStoreGeneric_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00010A48 File Offset: 0x0000EC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131665, XrefRangeEnd = 1131666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tween()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tween>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tween.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002609 File Offset: 0x00000809
		public Tween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00010A84 File Offset: 0x0000EC84
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002612 File Offset: 0x00000812
		public unsafe float timeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_timeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_timeScale)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00010AAC File Offset: 0x0000ECAC
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000262D File Offset: 0x0000082D
		public unsafe bool isBackwards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBackwards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBackwards)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002648 File Offset: 0x00000848
		public unsafe Object id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00010B04 File Offset: 0x0000ED04
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002667 File Offset: 0x00000867
		public unsafe string stringId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_stringId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_stringId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00010B2C File Offset: 0x0000ED2C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002686 File Offset: 0x00000886
		public unsafe int intId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_intId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_intId)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00010B54 File Offset: 0x0000ED54
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000026A1 File Offset: 0x000008A1
		public unsafe Object target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00010B84 File Offset: 0x0000ED84
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe UpdateType updateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_updateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_updateType)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00010BAC File Offset: 0x0000EDAC
		// (set) Token: 0x06000209 RID: 521 RVA: 0x000026DB File Offset: 0x000008DB
		public unsafe bool isIndependentUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isIndependentUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isIndependentUpdate)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000026F6 File Offset: 0x000008F6
		public unsafe TweenCallback onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00010C04 File Offset: 0x0000EE04
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002715 File Offset: 0x00000915
		public unsafe TweenCallback onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00010C34 File Offset: 0x0000EE34
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002734 File Offset: 0x00000934
		public unsafe TweenCallback onRewind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onRewind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onRewind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00010C64 File Offset: 0x0000EE64
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002753 File Offset: 0x00000953
		public unsafe TweenCallback onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00010C94 File Offset: 0x0000EE94
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002772 File Offset: 0x00000972
		public unsafe TweenCallback onStepComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onStepComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onStepComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002791 File Offset: 0x00000991
		public unsafe TweenCallback onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000027B0 File Offset: 0x000009B0
		public unsafe TweenCallback onKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onKill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onKill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00010D24 File Offset: 0x0000EF24
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000027CF File Offset: 0x000009CF
		public unsafe TweenCallback<int> onWaypointChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onWaypointChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenCallback<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_onWaypointChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00010D54 File Offset: 0x0000EF54
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000027EE File Offset: 0x000009EE
		public unsafe bool isFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isFrom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isFrom)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00010D7C File Offset: 0x0000EF7C
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002809 File Offset: 0x00000A09
		public unsafe bool isBlendable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBlendable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isBlendable)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00010DA4 File Offset: 0x0000EFA4
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002824 File Offset: 0x00000A24
		public unsafe bool isRecyclable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRecyclable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRecyclable)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00010DCC File Offset: 0x0000EFCC
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0000283F File Offset: 0x00000A3F
		public unsafe bool isSpeedBased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSpeedBased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSpeedBased)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0000285A File Offset: 0x00000A5A
		public unsafe bool autoKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_autoKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_autoKill)) = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00010E1C File Offset: 0x0000F01C
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002875 File Offset: 0x00000A75
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00010E44 File Offset: 0x0000F044
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002890 File Offset: 0x00000A90
		public unsafe int loops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loops)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00010E6C File Offset: 0x0000F06C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000028AB File Offset: 0x00000AAB
		public unsafe LoopType loopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_loopType)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00010E94 File Offset: 0x0000F094
		// (set) Token: 0x0600022B RID: 555 RVA: 0x000028C6 File Offset: 0x00000AC6
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00010EBC File Offset: 0x0000F0BC
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000028E1 File Offset: 0x00000AE1
		public unsafe bool isRelative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRelative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isRelative)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00010EE4 File Offset: 0x0000F0E4
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000028FC File Offset: 0x00000AFC
		public unsafe Ease easeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeType)) = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00010F0C File Offset: 0x0000F10C
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002917 File Offset: 0x00000B17
		public unsafe EaseFunction customEase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_customEase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EaseFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_customEase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00010F3C File Offset: 0x0000F13C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002936 File Offset: 0x00000B36
		public unsafe float easeOvershootOrAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easeOvershootOrAmplitude)) = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00010F64 File Offset: 0x0000F164
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002951 File Offset: 0x00000B51
		public unsafe float easePeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easePeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_easePeriod)) = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00010F8C File Offset: 0x0000F18C
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe Type typeofT1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00010FBC File Offset: 0x0000F1BC
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000298B File Offset: 0x00000B8B
		public unsafe Type typeofT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00010FEC File Offset: 0x0000F1EC
		// (set) Token: 0x0600023B RID: 571 RVA: 0x000029AA File Offset: 0x00000BAA
		public unsafe Type typeofTPlugOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofTPlugOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_typeofTPlugOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0001101C File Offset: 0x0000F21C
		// (set) Token: 0x0600023D RID: 573 RVA: 0x000029C9 File Offset: 0x00000BC9
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00011044 File Offset: 0x0000F244
		// (set) Token: 0x0600023F RID: 575 RVA: 0x000029E4 File Offset: 0x00000BE4
		public unsafe bool isSequenced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSequenced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isSequenced)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001106C File Offset: 0x0000F26C
		// (set) Token: 0x06000241 RID: 577 RVA: 0x000029FF File Offset: 0x00000BFF
		public unsafe Sequence sequenceParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_sequenceParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_sequenceParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0001109C File Offset: 0x0000F29C
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002A1E File Offset: 0x00000C1E
		public unsafe int activeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_activeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_activeId)) = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000244 RID: 580 RVA: 0x000110C4 File Offset: 0x0000F2C4
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002A39 File Offset: 0x00000C39
		public unsafe SpecialStartupMode specialStartupMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_specialStartupMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_specialStartupMode)) = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000110EC File Offset: 0x0000F2EC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002A54 File Offset: 0x00000C54
		public unsafe bool creationLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_creationLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_creationLocked)) = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00011114 File Offset: 0x0000F314
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002A6F File Offset: 0x00000C6F
		public unsafe bool startupDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_startupDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_startupDone)) = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0001113C File Offset: 0x0000F33C
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002A8A File Offset: 0x00000C8A
		public unsafe bool playedOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_playedOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_playedOnce)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00011164 File Offset: 0x0000F364
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002AA5 File Offset: 0x00000CA5
		public unsafe float position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0001118C File Offset: 0x0000F38C
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002AC0 File Offset: 0x00000CC0
		public unsafe float fullDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_fullDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_fullDuration)) = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000111B4 File Offset: 0x0000F3B4
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002ADB File Offset: 0x00000CDB
		public unsafe int completedLoops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_completedLoops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_completedLoops)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000111DC File Offset: 0x0000F3DC
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public unsafe bool isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isPlaying)) = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00011204 File Offset: 0x0000F404
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002B11 File Offset: 0x00000D11
		public unsafe bool isComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_isComplete)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001122C File Offset: 0x0000F42C
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002B2C File Offset: 0x00000D2C
		public unsafe float elapsedDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_elapsedDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_elapsedDelay)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00011254 File Offset: 0x0000F454
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002B47 File Offset: 0x00000D47
		public unsafe bool delayComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delayComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_delayComplete)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0001127C File Offset: 0x0000F47C
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002B62 File Offset: 0x00000D62
		public unsafe int miscInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_miscInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tween.NativeFieldInfoPtr_miscInt)) = value;
			}
		}

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_isBackwards;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_stringId;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeFieldInfoPtr_intId;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeFieldInfoPtr_updateType;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeFieldInfoPtr_isIndependentUpdate;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr_onRewind;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr_onStepComplete;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr_onKill;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr_onWaypointChange;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_isFrom;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_isBlendable;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_isRecyclable;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_isSpeedBased;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeFieldInfoPtr_autoKill;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_loops;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_loopType;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_isRelative;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_easeType;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_customEase;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_easeOvershootOrAmplitude;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_easePeriod;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_typeofT1;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_typeofT2;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_typeofTPlugOptions;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_isSequenced;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_sequenceParent;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_activeId;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_specialStartupMode;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_creationLocked;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_startupDone;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_playedOnce;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_fullDuration;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_completedLoops;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_isComplete;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_elapsedDelay;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_delayComplete;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_miscInt;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_fullPosition_Public_get_Single_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_set_fullPosition_Public_set_Void_Single_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDelay_Internal_Virtual_New_Single_Single_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Abstract_Virtual_New_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_DoGoto_Internal_Static_Boolean_Tween_Single_Int32_UpdateMode_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000DB RID: 219
		private sealed class MethodInfoStoreGeneric_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0<T>
		{
			// Token: 0x040005FE RID: 1534
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tween.NativeMethodInfoPtr_OnTweenCallback_Internal_Static_Boolean_TweenCallback_1_T_T_0, Il2CppClassPointerStore<Tween>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
