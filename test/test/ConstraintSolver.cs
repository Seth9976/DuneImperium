using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.constraint
{
	// Token: 0x02000005 RID: 5
	public static class ConstraintSolver : Object
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002AC4 File Offset: 0x00000CC4
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintSolver()
		{
			Il2CppClassPointerStore<ConstraintSolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("test.dll", "dwd.constraint", "ConstraintSolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintSolver>.NativeClassPtr);
			ConstraintSolver.NativeMethodInfoPtr_IsSolved_Public_Static_Boolean_List_1_IConstraintSubject_List_1_ConstraintRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintSolver>.NativeClassPtr, 100663308);
			ConstraintSolver.NativeMethodInfoPtr_GetFailingRules_Public_Static_List_1_ConstraintRule_List_1_IConstraintSubject_List_1_ConstraintRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintSolver>.NativeClassPtr, 100663309);
			ConstraintSolver.NativeMethodInfoPtr_Solve_Public_Static_Boolean_byref_List_1_IConstraintSubject_List_1_ConstraintRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintSolver>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002B30 File Offset: 0x00000D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272636, RefRangeEnd = 1272637, XrefRangeStart = 1272615, XrefRangeEnd = 1272636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSolved(List<IConstraintSubject> subjects, List<ConstraintRule> rules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintSolver.NativeMethodInfoPtr_IsSolved_Public_Static_Boolean_List_1_IConstraintSubject_List_1_ConstraintRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002B84 File Offset: 0x00000D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272677, RefRangeEnd = 1272678, XrefRangeStart = 1272637, XrefRangeEnd = 1272677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ConstraintRule> GetFailingRules(List<IConstraintSubject> subjects, List<ConstraintRule> rules)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rules);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintSolver.NativeMethodInfoPtr_GetFailingRules_Public_Static_List_1_ConstraintRule_List_1_IConstraintSubject_List_1_ConstraintRule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ConstraintRule>>(intPtr3) : null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002BDC File Offset: 0x00000DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272712, RefRangeEnd = 1272713, XrefRangeStart = 1272678, XrefRangeEnd = 1272712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Solve(ref List<IConstraintSubject> subjects, List<ConstraintRule> rules)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(subjects);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rules);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstraintSolver.NativeMethodInfoPtr_Solve_Public_Static_Boolean_byref_List_1_IConstraintSubject_List_1_ConstraintRule_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			subjects = ((intPtr4 == 0) ? null : new List<IConstraintSubject>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002192 File Offset: 0x00000392
		public ConstraintSolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_IsSolved_Public_Static_Boolean_List_1_IConstraintSubject_List_1_ConstraintRule_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_GetFailingRules_Public_Static_List_1_ConstraintRule_List_1_IConstraintSubject_List_1_ConstraintRule_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Solve_Public_Static_Boolean_byref_List_1_IConstraintSubject_List_1_ConstraintRule_0;
	}
}
