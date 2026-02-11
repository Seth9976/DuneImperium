using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace DG.Tweening
{
	// Token: 0x02000013 RID: 19
	public sealed class Sequence : Tween
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00009384 File Offset: 0x00007584
		// Note: this type is marked as 'beforefieldinit'.
		static Sequence()
		{
			Il2CppClassPointerStore<Sequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening", "Sequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence>.NativeClassPtr);
			Sequence.NativeFieldInfoPtr_sequencedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "sequencedTweens");
			Sequence.NativeFieldInfoPtr__sequencedObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "_sequencedObjs");
			Sequence.NativeFieldInfoPtr_lastTweenInsertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence>.NativeClassPtr, "lastTweenInsertTime");
			Sequence.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663446);
			Sequence.NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663447);
			Sequence.NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663448);
			Sequence.NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663449);
			Sequence.NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663450);
			Sequence.NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663451);
			Sequence.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663452);
			Sequence.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663453);
			Sequence.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663454);
			Sequence.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663455);
			Sequence.NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663456);
			Sequence.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663457);
			Sequence.NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663458);
			Sequence.NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663459);
			Sequence.NativeMethodInfoPtr_SortSequencedObjs_Private_Static_Int32_ABSSequentiable_ABSSequentiable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence>.NativeClassPtr, 100663460);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000951C File Offset: 0x0000771C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128098, RefRangeEnd = 1128099, XrefRangeStart = 1128083, XrefRangeEnd = 1128098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sequence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sequence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00009558 File Offset: 0x00007758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128099, XrefRangeEnd = 1128105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoPrepend(Sequence inSequence, Tween t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000095B0 File Offset: 0x000077B0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1128118, RefRangeEnd = 1128132, XrefRangeStart = 1128105, XrefRangeEnd = 1128118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00009614 File Offset: 0x00007814
		[CallerCount(0)]
		public unsafe static Sequence DoAppendInterval(Sequence inSequence, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00009668 File Offset: 0x00007868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128132, XrefRangeEnd = 1128136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoPrependInterval(Sequence inSequence, float interval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000096BC File Offset: 0x000078BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1128145, RefRangeEnd = 1128148, XrefRangeStart = 1128136, XrefRangeEnd = 1128145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inSequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sequence>(intPtr3) : null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00009720 File Offset: 0x00007920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128148, XrefRangeEnd = 1128165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00009754 File Offset: 0x00007954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128165, XrefRangeEnd = 1128169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00009790 File Offset: 0x00007990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128169, XrefRangeEnd = 1128170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Startup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000097CC File Offset: 0x000079CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128170, XrefRangeEnd = 1128171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000985C File Offset: 0x00007A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128171, XrefRangeEnd = 1128185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Setup(Sequence s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00009894 File Offset: 0x00007A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128191, RefRangeEnd = 1128192, XrefRangeStart = 1128185, XrefRangeEnd = 1128191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoStartup(Sequence s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000098D8 File Offset: 0x00007AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128203, RefRangeEnd = 1128204, XrefRangeStart = 1128192, XrefRangeEnd = 1128203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevCompletedLoops;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCompletedSteps;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInversePosition;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009960 File Offset: 0x00007B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1128224, RefRangeEnd = 1128225, XrefRangeStart = 1128204, XrefRangeEnd = 1128224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toPos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInverse;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevPosIsInverse;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiCycleStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000099F8 File Offset: 0x00007BF8
		[CallerCount(0)]
		public unsafe static int SortSequencedObjs(ABSSequentiable a, ABSSequentiable b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sequence.NativeMethodInfoPtr_SortSequencedObjs_Private_Static_Int32_ABSSequentiable_ABSSequentiable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000022E1 File Offset: 0x000004E1
		public Sequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00009A4C File Offset: 0x00007C4C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000022EA File Offset: 0x000004EA
		public unsafe List<Tween> sequencedTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_sequencedTweens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_sequencedTweens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00009A7C File Offset: 0x00007C7C
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe List<ABSSequentiable> _sequencedObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr__sequencedObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ABSSequentiable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr__sequencedObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00009AAC File Offset: 0x00007CAC
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002328 File Offset: 0x00000528
		public unsafe float lastTweenInsertTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_lastTweenInsertTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sequence.NativeFieldInfoPtr_lastTweenInsertTime)) = value;
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_sequencedTweens;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr__sequencedObjs;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_lastTweenInsertTime;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_DoPrepend_Internal_Static_Sequence_Sequence_Tween_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_DoInsert_Internal_Static_Sequence_Sequence_Tween_Single_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_DoAppendInterval_Internal_Static_Sequence_Sequence_Single_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_DoPrependInterval_Internal_Static_Sequence_Sequence_Single_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_DoInsertCallback_Internal_Static_Sequence_Sequence_TweenCallback_Single_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_Void_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Virtual_Boolean_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_Startup_Internal_Virtual_Boolean_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTween_Internal_Virtual_Boolean_Single_Int32_Int32_Boolean_UpdateMode_UpdateNotice_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Static_Void_Sequence_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_DoStartup_Internal_Static_Boolean_Sequence_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_DoApplyTween_Internal_Static_Boolean_Sequence_Single_Int32_Int32_Boolean_UpdateMode_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInternalCycle_Private_Static_Boolean_Sequence_Single_Single_UpdateMode_Boolean_Boolean_Boolean_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_SortSequencedObjs_Private_Static_Int32_ABSSequentiable_ABSSequentiable_0;
	}
}
