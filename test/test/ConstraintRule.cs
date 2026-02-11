using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.constraint
{
	// Token: 0x02000004 RID: 4
	public class ConstraintRule : Object
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000274C File Offset: 0x0000094C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintRule()
		{
			Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("test.dll", "dwd.constraint", "ConstraintRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr);
			ConstraintRule.NativeFieldInfoPtr_ConstraintTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "ConstraintTrue");
			ConstraintRule.NativeFieldInfoPtr_ConstraintFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "ConstraintFalse");
			ConstraintRule.NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "l");
			ConstraintRule.NativeFieldInfoPtr_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "op");
			ConstraintRule.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "r");
			ConstraintRule.NativeFieldInfoPtr_failedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, "failedMessage");
			ConstraintRule.NativeMethodInfoPtr_Evaluate_Public_Int32_List_1_IConstraintSubject_IConstraintSubject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, 100663303);
			ConstraintRule.NativeMethodInfoPtr_AttemptSolve_Public_Boolean_byref_List_1_IConstraintSubject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, 100663304);
			ConstraintRule.NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, 100663305);
			ConstraintRule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, 100663306);
			ConstraintRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002858 File Offset: 0x00000A58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1272510, RefRangeEnd = 1272515, XrefRangeStart = 1272510, XrefRangeEnd = 1272510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Evaluate(List<IConstraintSubject> allsubjects, IConstraintSubject currentSubject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allsubjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSubject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintRule.NativeMethodInfoPtr_Evaluate_Public_Int32_List_1_IConstraintSubject_IConstraintSubject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028B8 File Offset: 0x00000AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272560, RefRangeEnd = 1272561, XrefRangeStart = 1272515, XrefRangeEnd = 1272560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AttemptSolve(ref List<IConstraintSubject> allsubjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(allsubjects);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConstraintRule.NativeMethodInfoPtr_AttemptSolve_Public_Boolean_byref_List_1_IConstraintSubject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				allsubjects = ((intPtr4 == 0) ? null : new List<IConstraintSubject>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000291C File Offset: 0x00000B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272598, RefRangeEnd = 1272599, XrefRangeStart = 1272561, XrefRangeEnd = 1272598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<string> GetMutableProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintRule.NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000295C File Offset: 0x00000B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272599, XrefRangeEnd = 1272615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintRule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029A0 File Offset: 0x00000BA0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020F5 File Offset: 0x000002F5
		public ConstraintRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000029DC File Offset: 0x00000BDC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020FE File Offset: 0x000002FE
		public unsafe static int ConstraintTrue
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConstraintRule.NativeFieldInfoPtr_ConstraintTrue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstraintRule.NativeFieldInfoPtr_ConstraintTrue, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000029F8 File Offset: 0x00000BF8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000210C File Offset: 0x0000030C
		public unsafe static int ConstraintFalse
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConstraintRule.NativeFieldInfoPtr_ConstraintFalse, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstraintRule.NativeFieldInfoPtr_ConstraintFalse, (void*)(&value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002A14 File Offset: 0x00000C14
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000211A File Offset: 0x0000031A
		public unsafe ConstraintOperand l
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_l);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintOperand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_l), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002A44 File Offset: 0x00000C44
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002139 File Offset: 0x00000339
		public unsafe ConstraintRule.ConstraintOperator op
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_op);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_op)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002A6C File Offset: 0x00000C6C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002154 File Offset: 0x00000354
		public unsafe ConstraintOperand r
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_r);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintOperand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_r), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002A9C File Offset: 0x00000C9C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002173 File Offset: 0x00000373
		public unsafe string failedMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_failedMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintRule.NativeFieldInfoPtr_failedMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_ConstraintTrue;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_ConstraintFalse;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_l;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_op;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_failedMessage;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Int32_List_1_IConstraintSubject_IConstraintSubject_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_AttemptSolve_Public_Boolean_byref_List_1_IConstraintSubject_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000B RID: 11
		public enum ConstraintOperator
		{
			// Token: 0x04000030 RID: 48
			Equals,
			// Token: 0x04000031 RID: 49
			NotEquals,
			// Token: 0x04000032 RID: 50
			LessThan,
			// Token: 0x04000033 RID: 51
			LessThanOrEqual,
			// Token: 0x04000034 RID: 52
			GreaterThan,
			// Token: 0x04000035 RID: 53
			GreaterThanOrEqual,
			// Token: 0x04000036 RID: 54
			And,
			// Token: 0x04000037 RID: 55
			Or,
			// Token: 0x04000038 RID: 56
			Implies
		}
	}
}
