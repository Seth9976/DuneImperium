using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000011 RID: 17
	public static class TweenExtensions : global::Il2CppSystem.Object
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00008658 File Offset: 0x00006858
		// Note: this type is marked as 'beforefieldinit'.
		static TweenExtensions()
		{
			Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "TweenExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr);
			TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663410);
			TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663411);
			TweenExtensions.NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663412);
			TweenExtensions.NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663413);
			TweenExtensions.NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663414);
			TweenExtensions.NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663415);
			TweenExtensions.NativeMethodInfoPtr_Pause_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663416);
			TweenExtensions.NativeMethodInfoPtr_Play_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663417);
			TweenExtensions.NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663418);
			TweenExtensions.NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663419);
			TweenExtensions.NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663420);
			TweenExtensions.NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663421);
			TweenExtensions.NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663422);
			TweenExtensions.NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663423);
			TweenExtensions.NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663424);
			TweenExtensions.NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663425);
			TweenExtensions.NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663426);
			TweenExtensions.NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663427);
			TweenExtensions.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663428);
			TweenExtensions.NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663429);
			TweenExtensions.NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663430);
			TweenExtensions.NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663431);
			TweenExtensions.NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663432);
			TweenExtensions.NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663433);
			TweenExtensions.NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663434);
			TweenExtensions.NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663435);
			TweenExtensions.NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663436);
			TweenExtensions.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663437);
			TweenExtensions.NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663438);
			TweenExtensions.NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663439);
			TweenExtensions.NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663440);
			TweenExtensions.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663441);
			TweenExtensions.NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663442);
			TweenExtensions.NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663443);
			TweenExtensions.NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663444);
			TweenExtensions.NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr, 100663445);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00008958 File Offset: 0x00006B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127825, XrefRangeEnd = 1127838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Complete(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008990 File Offset: 0x00006B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127838, XrefRangeEnd = 1127852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Complete(this Tween t, bool withCallbacks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000089D4 File Offset: 0x00006BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127852, XrefRangeEnd = 1127863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Flip(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008A0C File Offset: 0x00006C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127863, XrefRangeEnd = 1127874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceInit(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00008A44 File Offset: 0x00006C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127874, XrefRangeEnd = 1127879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Goto(this Tween t, float to, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008A98 File Offset: 0x00006C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127879, XrefRangeEnd = 1127889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Kill(this Tween t, bool complete = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008ADC File Offset: 0x00006CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1127894, RefRangeEnd = 1127895, XrefRangeStart = 1127889, XrefRangeEnd = 1127894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Pause<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.MethodInfoStoreGeneric_Pause_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008B50 File Offset: 0x00006D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127895, XrefRangeEnd = 1127900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Play<T>(this T t) where T : Tween
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.MethodInfoStoreGeneric_Play_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008BC4 File Offset: 0x00006DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127900, XrefRangeEnd = 1127911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayBackwards(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008BFC File Offset: 0x00006DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127911, XrefRangeEnd = 1127922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayForward(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008C34 File Offset: 0x00006E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127922, XrefRangeEnd = 1127933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Restart(this Tween t, bool includeDelay = true, float changeDelayTo = -1f)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008C88 File Offset: 0x00006E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127933, XrefRangeEnd = 1127944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Rewind(this Tween t, bool includeDelay = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008CCC File Offset: 0x00006ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127944, XrefRangeEnd = 1127955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SmoothRewind(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008D04 File Offset: 0x00006F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127955, XrefRangeEnd = 1127966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TogglePause(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00008D3C File Offset: 0x00006F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127966, XrefRangeEnd = 1127978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waypointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andPlay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008D90 File Offset: 0x00006F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1127987, RefRangeEnd = 1127988, XrefRangeStart = 1127978, XrefRangeEnd = 1127987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForCompletion(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127988, XrefRangeEnd = 1127997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForRewind(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008E18 File Offset: 0x00007018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127997, XrefRangeEnd = 1128006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForKill(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00008E5C File Offset: 0x0000705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128006, XrefRangeEnd = 1128015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008EB0 File Offset: 0x000070B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128015, XrefRangeEnd = 1128024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static YieldInstruction WaitForPosition(this Tween t, float position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<YieldInstruction>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00008F04 File Offset: 0x00007104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128024, XrefRangeEnd = 1128033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine WaitForStart(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00008F48 File Offset: 0x00007148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128033, XrefRangeEnd = 1128034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompletedLoops(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00008F8C File Offset: 0x0000718C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128034, XrefRangeEnd = 1128035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Delay(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008FD0 File Offset: 0x000071D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128035, XrefRangeEnd = 1128036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Duration(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00009020 File Offset: 0x00007220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128036, XrefRangeEnd = 1128037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Elapsed(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009070 File Offset: 0x00007270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128037, XrefRangeEnd = 1128038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ElapsedPercentage(this Tween t, bool includeLoops = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000090C0 File Offset: 0x000072C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1128039, RefRangeEnd = 1128042, XrefRangeStart = 1128038, XrefRangeEnd = 1128039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ElapsedDirectionalPercentage(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009104 File Offset: 0x00007304
		[CallerCount(0)]
		public unsafe static bool IsActive(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00009148 File Offset: 0x00007348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128042, XrefRangeEnd = 1128043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBackwards(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000918C File Offset: 0x0000738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128043, XrefRangeEnd = 1128044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsComplete(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000091D0 File Offset: 0x000073D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128044, XrefRangeEnd = 1128045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInitialized(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00009214 File Offset: 0x00007414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128045, XrefRangeEnd = 1128046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPlaying(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00009258 File Offset: 0x00007458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128046, XrefRangeEnd = 1128047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Loops(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000929C File Offset: 0x0000749C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128047, XrefRangeEnd = 1128071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 PathGetPoint(this Tween t, float pathPercentage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pathPercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000092EC File Offset: 0x000074EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128071, XrefRangeEnd = 1128079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Vector3> PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref subdivisionsXSegment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00009340 File Offset: 0x00007540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128079, XrefRangeEnd = 1128083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PathLength(this Tween t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweenExtensions.NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022D8 File Offset: 0x000004D8
		public TweenExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Static_Void_Tween_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_ForceInit_Public_Static_Void_Tween_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Static_Void_Tween_Single_Boolean_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_T_T_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_T_T_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_PlayBackwards_Public_Static_Void_Tween_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_PlayForward_Public_Static_Void_Tween_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Void_Tween_Boolean_Single_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Rewind_Public_Static_Void_Tween_Boolean_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_SmoothRewind_Public_Static_Void_Tween_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_TogglePause_Public_Static_Void_Tween_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_GotoWaypoint_Public_Static_Void_Tween_Int32_Boolean_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRewind_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_WaitForKill_Public_Static_YieldInstruction_Tween_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_WaitForElapsedLoops_Public_Static_YieldInstruction_Tween_Int32_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPosition_Public_Static_YieldInstruction_Tween_Single_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_WaitForStart_Public_Static_Coroutine_Tween_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_CompletedLoops_Public_Static_Int32_Tween_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Static_Single_Tween_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Duration_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Elapsed_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_ElapsedPercentage_Public_Static_Single_Tween_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_ElapsedDirectionalPercentage_Public_Static_Single_Tween_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_Tween_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_IsBackwards_Public_Static_Boolean_Tween_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_IsComplete_Public_Static_Boolean_Tween_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_IsInitialized_Public_Static_Boolean_Tween_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_Tween_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_Loops_Public_Static_Int32_Tween_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_PathGetPoint_Public_Static_Vector3_Tween_Single_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_PathGetDrawPoints_Public_Static_Il2CppStructArray_1_Vector3_Tween_Int32_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_PathLength_Public_Static_Single_Tween_0;

		// Token: 0x02000061 RID: 97
		private sealed class MethodInfoStoreGeneric_Pause_Public_Static_T_T_0<T>
		{
			// Token: 0x04000462 RID: 1122
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenExtensions.NativeMethodInfoPtr_Pause_Public_Static_T_T_0, Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000062 RID: 98
		private sealed class MethodInfoStoreGeneric_Play_Public_Static_T_T_0<T>
		{
			// Token: 0x04000463 RID: 1123
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TweenExtensions.NativeMethodInfoPtr_Play_Public_Static_T_T_0, Il2CppClassPointerStore<TweenExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
