using System;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace DG.Tweening.Core
{
	// Token: 0x0200004E RID: 78
	public static class TweenManager : Object
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0001AE80 File Offset: 0x00019080
		// Note: this type is marked as 'beforefieldinit'.
		static TweenManager()
		{
			Il2CppClassPointerStore<TweenManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "TweenManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenManager>.NativeClassPtr);
			TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_DefaultMaxTweeners");
			TweenManager.NativeFieldInfoPtr__DefaultMaxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_DefaultMaxSequences");
			TweenManager.NativeFieldInfoPtr__MaxTweensReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_MaxTweensReached");
			TweenManager.NativeFieldInfoPtr_maxActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxActive");
			TweenManager.NativeFieldInfoPtr_maxTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxTweeners");
			TweenManager.NativeFieldInfoPtr_maxSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "maxSequences");
			TweenManager.NativeFieldInfoPtr_hasActiveTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveDefaultTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveLateTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveLateTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveFixedTweens");
			TweenManager.NativeFieldInfoPtr_hasActiveManualTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "hasActiveManualTweens");
			TweenManager.NativeFieldInfoPtr_totActiveTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveTweens");
			TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveDefaultTweens");
			TweenManager.NativeFieldInfoPtr_totActiveLateTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveLateTweens");
			TweenManager.NativeFieldInfoPtr_totActiveFixedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveFixedTweens");
			TweenManager.NativeFieldInfoPtr_totActiveManualTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveManualTweens");
			TweenManager.NativeFieldInfoPtr_totActiveTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveTweeners");
			TweenManager.NativeFieldInfoPtr_totActiveSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totActiveSequences");
			TweenManager.NativeFieldInfoPtr_totPooledTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totPooledTweeners");
			TweenManager.NativeFieldInfoPtr_totPooledSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totPooledSequences");
			TweenManager.NativeFieldInfoPtr_totTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totTweeners");
			TweenManager.NativeFieldInfoPtr_totSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "totSequences");
			TweenManager.NativeFieldInfoPtr_isUpdateLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "isUpdateLoop");
			TweenManager.NativeFieldInfoPtr__activeTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_activeTweens");
			TweenManager.NativeFieldInfoPtr__pooledTweeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_pooledTweeners");
			TweenManager.NativeFieldInfoPtr__PooledSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_PooledSequences");
			TweenManager.NativeFieldInfoPtr__KillList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_KillList");
			TweenManager.NativeFieldInfoPtr__maxActiveLookupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_maxActiveLookupId");
			TweenManager.NativeFieldInfoPtr__requiresActiveReorganization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_requiresActiveReorganization");
			TweenManager.NativeFieldInfoPtr__reorganizeFromId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_reorganizeFromId");
			TweenManager.NativeFieldInfoPtr__minPooledTweenerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_minPooledTweenerId");
			TweenManager.NativeFieldInfoPtr__maxPooledTweenerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_maxPooledTweenerId");
			TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, "_despawnAllCalledFromUpdateLoopCallback");
			TweenManager.NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664231);
			TweenManager.NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664232);
			TweenManager.NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664233);
			TweenManager.NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664234);
			TweenManager.NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664235);
			TweenManager.NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664236);
			TweenManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664237);
			TweenManager.NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664238);
			TweenManager.NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664239);
			TweenManager.NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664240);
			TweenManager.NativeMethodInfoPtr_Validate_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664241);
			TweenManager.NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664242);
			TweenManager.NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664243);
			TweenManager.NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664244);
			TweenManager.NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664245);
			TweenManager.NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664246);
			TweenManager.NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664247);
			TweenManager.NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664248);
			TweenManager.NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664249);
			TweenManager.NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664250);
			TweenManager.NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664251);
			TweenManager.NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664252);
			TweenManager.NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664253);
			TweenManager.NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664254);
			TweenManager.NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664255);
			TweenManager.NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664256);
			TweenManager.NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664257);
			TweenManager.NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664258);
			TweenManager.NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664259);
			TweenManager.NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664260);
			TweenManager.NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664261);
			TweenManager.NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664262);
			TweenManager.NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664263);
			TweenManager.NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664264);
			TweenManager.NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664265);
			TweenManager.NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664266);
			TweenManager.NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664267);
			TweenManager.NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenManager>.NativeClassPtr, 100664268);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0001B43C File Offset: 0x0001963C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133658, RefRangeEnd = 1133659, XrefRangeStart = 1133611, XrefRangeEnd = 1133658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.MethodInfoStoreGeneric_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweenerCore<T1, T2, TPlugOptions>>(intPtr3) : null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001B470 File Offset: 0x00019670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133706, RefRangeEnd = 1133707, XrefRangeStart = 1133659, XrefRangeEnd = 1133706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence GetSequence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001B4A4 File Offset: 0x000196A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1133728, RefRangeEnd = 1133733, XrefRangeStart = 1133707, XrefRangeEnd = 1133728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isIndependentUpdate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001B4F8 File Offset: 0x000196F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133737, RefRangeEnd = 1133738, XrefRangeStart = 1133733, XrefRangeEnd = 1133737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddActiveTweenToSequence(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001B530 File Offset: 0x00019730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133771, RefRangeEnd = 1133772, XrefRangeStart = 1133738, XrefRangeEnd = 1133771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DespawnAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001B560 File Offset: 0x00019760
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1133854, RefRangeEnd = 1133864, XrefRangeStart = 1133772, XrefRangeEnd = 1133854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Despawn(Tween t, bool modifyActiveLists = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyActiveLists;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001B5A4 File Offset: 0x000197A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133912, RefRangeEnd = 1133913, XrefRangeStart = 1133864, XrefRangeEnd = 1133912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgeAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001B5CC File Offset: 0x000197CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133928, RefRangeEnd = 1133929, XrefRangeStart = 1133913, XrefRangeEnd = 1133928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PurgePools()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001B5F4 File Offset: 0x000197F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133929, XrefRangeEnd = 1133933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetCapacities()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001B61C File Offset: 0x0001981C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1133951, RefRangeEnd = 1133955, XrefRangeStart = 1133933, XrefRangeEnd = 1133951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001B65C File Offset: 0x0001985C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133985, RefRangeEnd = 1133986, XrefRangeStart = 1133955, XrefRangeEnd = 1133985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Validate_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001B68C File Offset: 0x0001988C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1134026, RefRangeEnd = 1134030, XrefRangeStart = 1133986, XrefRangeEnd = 1134026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref independentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001B6DC File Offset: 0x000198DC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 1134117, RefRangeEnd = 1134173, XrefRangeStart = 1134030, XrefRangeEnd = 1134117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FilteredOperation(OperationType operationType, FilterType filterType, Object id, bool optionalBool, float optionalFloat, Object optionalObj = null, Il2CppReferenceArray<Object> optionalArray = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionalBool;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref optionalFloat;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalObj);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionalArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001B77C File Offset: 0x0001997C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1134180, RefRangeEnd = 1134184, XrefRangeStart = 1134173, XrefRangeEnd = 1134180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifyActiveLists;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001B7DC File Offset: 0x000199DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134184, RefRangeEnd = 1134185, XrefRangeStart = 1134184, XrefRangeEnd = 1134184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Flip(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001B820 File Offset: 0x00019A20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1134191, RefRangeEnd = 1134194, XrefRangeStart = 1134185, XrefRangeEnd = 1134191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceInit(Tween t, bool isSequenced = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSequenced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001B864 File Offset: 0x00019A64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1134202, RefRangeEnd = 1134207, XrefRangeStart = 1134194, XrefRangeEnd = 1134202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134207, RefRangeEnd = 1134208, XrefRangeStart = 1134207, XrefRangeEnd = 1134207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Pause(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001B914 File Offset: 0x00019B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134209, RefRangeEnd = 1134210, XrefRangeStart = 1134208, XrefRangeEnd = 1134209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Play(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001B958 File Offset: 0x00019B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134219, RefRangeEnd = 1134220, XrefRangeStart = 1134210, XrefRangeEnd = 1134219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlayBackwards(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001B99C File Offset: 0x00019B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134223, RefRangeEnd = 1134224, XrefRangeStart = 1134220, XrefRangeEnd = 1134223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PlayForward(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134229, RefRangeEnd = 1134230, XrefRangeStart = 1134224, XrefRangeEnd = 1134229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeDelayTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001BA40 File Offset: 0x00019C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134242, RefRangeEnd = 1134244, XrefRangeStart = 1134230, XrefRangeEnd = 1134242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Rewind(Tween t, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001BA90 File Offset: 0x00019C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134251, RefRangeEnd = 1134252, XrefRangeStart = 1134244, XrefRangeEnd = 1134251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SmoothRewind(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001BAD4 File Offset: 0x00019CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134256, RefRangeEnd = 1134257, XrefRangeStart = 1134252, XrefRangeEnd = 1134256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TogglePause(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001BB18 File Offset: 0x00019D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134257, XrefRangeEnd = 1134261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPooledTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001BB48 File Offset: 0x00019D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134275, RefRangeEnd = 1134276, XrefRangeStart = 1134261, XrefRangeEnd = 1134275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TotalPlayingTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001BB78 File Offset: 0x00019D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134301, RefRangeEnd = 1134303, XrefRangeStart = 1134276, XrefRangeEnd = 1134301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetActiveTweens(bool playing, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playing;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001BBCC File Offset: 0x00019DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134328, RefRangeEnd = 1134329, XrefRangeStart = 1134303, XrefRangeEnd = 1134328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetTweensById(Object id, bool playingOnly, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001BC30 File Offset: 0x00019E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134354, RefRangeEnd = 1134355, XrefRangeStart = 1134329, XrefRangeEnd = 1134354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Tween> GetTweensByTarget(Object target, bool playingOnly, List<Tween> fillableList = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playingOnly;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fillableList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr3) : null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001BC94 File Offset: 0x00019E94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134365, RefRangeEnd = 1134367, XrefRangeStart = 1134355, XrefRangeEnd = 1134365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkForKilling(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001BCCC File Offset: 0x00019ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134412, RefRangeEnd = 1134414, XrefRangeStart = 1134367, XrefRangeEnd = 1134412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddActiveTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001BD04 File Offset: 0x00019F04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1134437, RefRangeEnd = 1134444, XrefRangeStart = 1134414, XrefRangeEnd = 1134437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReorganizeActiveTweens()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001BD2C File Offset: 0x00019F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1134452, RefRangeEnd = 1134453, XrefRangeStart = 1134444, XrefRangeEnd = 1134452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DespawnActiveTweens(List<Tween> tweens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001BD64 File Offset: 0x00019F64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1134540, RefRangeEnd = 1134544, XrefRangeStart = 1134453, XrefRangeEnd = 1134540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveActiveTween(Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001BD9C File Offset: 0x00019F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134544, XrefRangeEnd = 1134545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearTweenArray(Il2CppReferenceArray<Tween> tweens)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tweens);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001BDD4 File Offset: 0x00019FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1134577, RefRangeEnd = 1134579, XrefRangeStart = 1134545, XrefRangeEnd = 1134577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IncreaseCapacities(TweenManager.CapacityIncreaseMode increaseMode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref increaseMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001BE08 File Offset: 0x0001A008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134579, XrefRangeEnd = 1134583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManageOnRewindCallbackWhenAlreadyRewinded(Tween t, bool isPlayBackwardsOrSmoothRewind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlayBackwardsOrSmoothRewind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenManager.NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000038D6 File Offset: 0x00001AD6
		public TweenManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001BE4C File Offset: 0x0001A04C
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000038DF File Offset: 0x00001ADF
		public unsafe static int _DefaultMaxTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__DefaultMaxTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0001BE68 File Offset: 0x0001A068
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000038ED File Offset: 0x00001AED
		public unsafe static int _DefaultMaxSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__DefaultMaxSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__DefaultMaxSequences, (void*)(&value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0001BE84 File Offset: 0x0001A084
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000038FB File Offset: 0x00001AFB
		public unsafe static string _MaxTweensReached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__MaxTweensReached, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__MaxTweensReached, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x0000390D File Offset: 0x00001B0D
		public unsafe static int maxActive
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxActive, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxActive, (void*)(&value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe static int maxTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001BEDC File Offset: 0x0001A0DC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003929 File Offset: 0x00001B29
		public unsafe static int maxSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_maxSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_maxSequences, (void*)(&value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00003937 File Offset: 0x00001B37
		public unsafe static bool hasActiveTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveTweens, (void*)(&value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001BF14 File Offset: 0x0001A114
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003945 File Offset: 0x00001B45
		public unsafe static bool hasActiveDefaultTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveDefaultTweens, (void*)(&value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0001BF30 File Offset: 0x0001A130
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00003953 File Offset: 0x00001B53
		public unsafe static bool hasActiveLateTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveLateTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveLateTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0001BF4C File Offset: 0x0001A14C
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00003961 File Offset: 0x00001B61
		public unsafe static bool hasActiveFixedTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveFixedTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0001BF68 File Offset: 0x0001A168
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0000396F File Offset: 0x00001B6F
		public unsafe static bool hasActiveManualTweens
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_hasActiveManualTweens, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_hasActiveManualTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001BF84 File Offset: 0x0001A184
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0000397D File Offset: 0x00001B7D
		public unsafe static int totActiveTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0000398B File Offset: 0x00001B8B
		public unsafe static int totActiveDefaultTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveDefaultTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001BFBC File Offset: 0x0001A1BC
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00003999 File Offset: 0x00001B99
		public unsafe static int totActiveLateTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveLateTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveLateTweens, (void*)(&value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x000039A7 File Offset: 0x00001BA7
		public unsafe static int totActiveFixedTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveFixedTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveFixedTweens, (void*)(&value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000039B5 File Offset: 0x00001BB5
		public unsafe static int totActiveManualTweens
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveManualTweens, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveManualTweens, (void*)(&value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001C010 File Offset: 0x0001A210
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000039C3 File Offset: 0x00001BC3
		public unsafe static int totActiveTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x0001C02C File Offset: 0x0001A22C
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000039D1 File Offset: 0x00001BD1
		public unsafe static int totActiveSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totActiveSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totActiveSequences, (void*)(&value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001C048 File Offset: 0x0001A248
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000039DF File Offset: 0x00001BDF
		public unsafe static int totPooledTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totPooledTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totPooledTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001C064 File Offset: 0x0001A264
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000039ED File Offset: 0x00001BED
		public unsafe static int totPooledSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totPooledSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totPooledSequences, (void*)(&value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001C080 File Offset: 0x0001A280
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000039FB File Offset: 0x00001BFB
		public unsafe static int totTweeners
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totTweeners, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totTweeners, (void*)(&value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001C09C File Offset: 0x0001A29C
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00003A09 File Offset: 0x00001C09
		public unsafe static int totSequences
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_totSequences, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_totSequences, (void*)(&value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00003A17 File Offset: 0x00001C17
		public unsafe static bool isUpdateLoop
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr_isUpdateLoop, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr_isUpdateLoop, (void*)(&value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00003A25 File Offset: 0x00001C25
		public unsafe static Il2CppReferenceArray<Tween> _activeTweens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__activeTweens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__activeTweens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001C0FC File Offset: 0x0001A2FC
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00003A37 File Offset: 0x00001C37
		public unsafe static Il2CppReferenceArray<Tween> _pooledTweeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__pooledTweeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__pooledTweeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001C124 File Offset: 0x0001A324
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00003A49 File Offset: 0x00001C49
		public unsafe static Stack<Tween> _PooledSequences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__PooledSequences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__PooledSequences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001C14C File Offset: 0x0001A34C
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00003A5B File Offset: 0x00001C5B
		public unsafe static List<Tween> _KillList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__KillList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__KillList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0001C174 File Offset: 0x0001A374
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00003A6D File Offset: 0x00001C6D
		public unsafe static int _maxActiveLookupId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__maxActiveLookupId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__maxActiveLookupId, (void*)(&value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001C190 File Offset: 0x0001A390
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00003A7B File Offset: 0x00001C7B
		public unsafe static bool _requiresActiveReorganization
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__requiresActiveReorganization, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__requiresActiveReorganization, (void*)(&value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00003A89 File Offset: 0x00001C89
		public unsafe static int _reorganizeFromId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__reorganizeFromId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__reorganizeFromId, (void*)(&value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00003A97 File Offset: 0x00001C97
		public unsafe static int _minPooledTweenerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__minPooledTweenerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__minPooledTweenerId, (void*)(&value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00003AA5 File Offset: 0x00001CA5
		public unsafe static int _maxPooledTweenerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__maxPooledTweenerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__maxPooledTweenerId, (void*)(&value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001C200 File Offset: 0x0001A400
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00003AB3 File Offset: 0x00001CB3
		public unsafe static bool _despawnAllCalledFromUpdateLoopCallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TweenManager.NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback, (void*)(&value));
			}
		}

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr__DefaultMaxTweeners;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr__DefaultMaxSequences;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr__MaxTweensReached;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_maxActive;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_maxTweeners;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_maxSequences;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveTweens;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveDefaultTweens;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveLateTweens;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveFixedTweens;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_hasActiveManualTweens;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_totActiveTweens;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_totActiveDefaultTweens;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_totActiveLateTweens;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_totActiveFixedTweens;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_totActiveManualTweens;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_totActiveTweeners;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_totActiveSequences;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_totPooledTweeners;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_totPooledSequences;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_totTweeners;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_totSequences;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_isUpdateLoop;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr__activeTweens;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr__pooledTweeners;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr__PooledSequences;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr__KillList;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr__maxActiveLookupId;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr__requiresActiveReorganization;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr__reorganizeFromId;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr__minPooledTweenerId;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr__maxPooledTweenerId;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr__despawnAllCalledFromUpdateLoopCallback;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_GetSequence_Internal_Static_Sequence_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_SetUpdateType_Internal_Static_Void_Tween_UpdateType_Boolean_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveTweenToSequence_Internal_Static_Void_Tween_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_DespawnAll_Internal_Static_Int32_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Internal_Static_Void_Tween_Boolean_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_PurgeAll_Internal_Static_Void_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_PurgePools_Internal_Static_Void_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_ResetCapacities_Internal_Static_Void_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacities_Internal_Static_Void_Int32_Int32_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Int32_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Static_Void_UpdateType_Single_Single_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_FilteredOperation_Internal_Static_Int32_OperationType_FilterType_Object_Boolean_Single_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Static_Boolean_Tween_Boolean_UpdateMode_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_ForceInit_Internal_Static_Void_Tween_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Internal_Static_Boolean_Tween_Single_Boolean_UpdateMode_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_Play_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Internal_Static_Boolean_Tween_Boolean_Single_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Internal_Static_Boolean_Tween_Boolean_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Internal_Static_Boolean_Tween_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_TotalPooledTweens_Internal_Static_Int32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_TotalPlayingTweens_Internal_Static_Int32_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveTweens_Internal_Static_List_1_Tween_Boolean_List_1_Tween_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_GetTweensById_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_GetTweensByTarget_Internal_Static_List_1_Tween_Object_Boolean_List_1_Tween_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_MarkForKilling_Private_Static_Void_Tween_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_AddActiveTween_Private_Static_Void_Tween_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_ReorganizeActiveTweens_Private_Static_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_DespawnActiveTweens_Private_Static_Void_List_1_Tween_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveTween_Private_Static_Void_Tween_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_ClearTweenArray_Private_Static_Void_Il2CppReferenceArray_1_Tween_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacities_Private_Static_Void_CapacityIncreaseMode_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_ManageOnRewindCallbackWhenAlreadyRewinded_Private_Static_Void_Tween_Boolean_0;

		// Token: 0x020000F0 RID: 240
		public enum CapacityIncreaseMode
		{
			// Token: 0x04000649 RID: 1609
			TweenersAndSequences,
			// Token: 0x0400064A RID: 1610
			TweenersOnly,
			// Token: 0x0400064B RID: 1611
			SequencesOnly
		}

		// Token: 0x020000F1 RID: 241
		private sealed class MethodInfoStoreGeneric_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0<T1, T2, TPlugOptions>
		{
			// Token: 0x0400064C RID: 1612
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenManager.NativeMethodInfoPtr_GetTweener_Internal_Static_TweenerCore_3_T1_T2_TPlugOptions_0, Il2CppClassPointerStore<TweenManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlugOptions>.NativeClassPtr))
			}))));
		}
	}
}
