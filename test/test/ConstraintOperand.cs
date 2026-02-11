using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.constraint
{
	// Token: 0x02000003 RID: 3
	public class ConstraintOperand : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002464 File Offset: 0x00000664
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintOperand()
		{
			Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr = IL2CPP.GetIl2CppClass("test.dll", "dwd.constraint", "ConstraintOperand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr);
			ConstraintOperand.NativeFieldInfoPtr_operandType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, "operandType");
			ConstraintOperand.NativeFieldInfoPtr_variableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, "variableName");
			ConstraintOperand.NativeFieldInfoPtr_childRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, "childRule");
			ConstraintOperand.NativeFieldInfoPtr_constantValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, "constantValue");
			ConstraintOperand.NativeFieldInfoPtr_countPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, "countPredicate");
			ConstraintOperand.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Int32_List_1_IConstraintSubject_IConstraintSubject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, 100663299);
			ConstraintOperand.NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, 100663300);
			ConstraintOperand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, 100663301);
			ConstraintOperand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002548 File Offset: 0x00000748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272495, XrefRangeEnd = 1272499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetValue(List<IConstraintSubject> allSubjects, IConstraintSubject currentSubject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allSubjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSubject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintOperand.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Int32_List_1_IConstraintSubject_IConstraintSubject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000025B4 File Offset: 0x000007B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1272503, RefRangeEnd = 1272505, XrefRangeStart = 1272499, XrefRangeEnd = 1272503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<string> GetMutableProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintOperand.NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025F4 File Offset: 0x000007F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272505, XrefRangeEnd = 1272510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintOperand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002638 File Offset: 0x00000838
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintOperand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintOperand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintOperand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002059 File Offset: 0x00000259
		public ConstraintOperand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002674 File Offset: 0x00000874
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe ConstraintOperand.OperandType operandType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_operandType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_operandType)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe string variableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_variableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_variableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000026C4 File Offset: 0x000008C4
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		public unsafe ConstraintRule childRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_childRule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_childRule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000026F4 File Offset: 0x000008F4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020BB File Offset: 0x000002BB
		public unsafe int constantValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_constantValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_constantValue)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000271C File Offset: 0x0000091C
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020D6 File Offset: 0x000002D6
		public unsafe ConstraintRule countPredicate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_countPredicate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintRule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintOperand.NativeFieldInfoPtr_countPredicate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_operandType;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_variableName;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_childRule;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_constantValue;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_countPredicate;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_New_Int32_List_1_IConstraintSubject_IConstraintSubject_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_GetMutableProperties_Public_HashSet_1_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000A RID: 10
		public enum OperandType
		{
			// Token: 0x0400002B RID: 43
			Variable,
			// Token: 0x0400002C RID: 44
			Child,
			// Token: 0x0400002D RID: 45
			Constant,
			// Token: 0x0400002E RID: 46
			Count
		}
	}
}
