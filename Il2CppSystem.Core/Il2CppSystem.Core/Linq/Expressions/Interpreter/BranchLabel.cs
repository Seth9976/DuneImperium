using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000097 RID: 151
	public sealed class BranchLabel : Object
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00034CEC File Offset: 0x00032EEC
		// Note: this type is marked as 'beforefieldinit'.
		static BranchLabel()
		{
			Il2CppClassPointerStore<BranchLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "BranchLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr);
			BranchLabel.NativeFieldInfoPtr__targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, "_targetIndex");
			BranchLabel.NativeFieldInfoPtr__stackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, "_stackDepth");
			BranchLabel.NativeFieldInfoPtr__continuationStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, "_continuationStackDepth");
			BranchLabel.NativeFieldInfoPtr__forwardBranchFixups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, "_forwardBranchFixups");
			BranchLabel.NativeFieldInfoPtr__LabelIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, "<LabelIndex>k__BackingField");
			BranchLabel.NativeMethodInfoPtr_get_LabelIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664880);
			BranchLabel.NativeMethodInfoPtr_set_LabelIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664881);
			BranchLabel.NativeMethodInfoPtr_get_HasRuntimeLabel_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664882);
			BranchLabel.NativeMethodInfoPtr_get_TargetIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664883);
			BranchLabel.NativeMethodInfoPtr_ToRuntimeLabel_Internal_RuntimeLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664884);
			BranchLabel.NativeMethodInfoPtr_Mark_Internal_Void_InstructionList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664885);
			BranchLabel.NativeMethodInfoPtr_AddBranch_Internal_Void_InstructionList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664886);
			BranchLabel.NativeMethodInfoPtr_FixupBranch_Internal_Void_InstructionList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664887);
			BranchLabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr, 100664888);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00034E34 File Offset: 0x00033034
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00034E70 File Offset: 0x00033070
		public unsafe int LabelIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_get_LabelIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_set_LabelIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00034EB0 File Offset: 0x000330B0
		public unsafe bool HasRuntimeLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1015711, RefRangeEnd = 1015726, XrefRangeStart = 1015711, XrefRangeEnd = 1015711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_get_HasRuntimeLabel_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00034EEC File Offset: 0x000330EC
		public unsafe int TargetIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_get_TargetIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00034F28 File Offset: 0x00033128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015726, RefRangeEnd = 1015727, XrefRangeStart = 1015726, XrefRangeEnd = 1015726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeLabel ToRuntimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_ToRuntimeLabel_Internal_RuntimeLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00034F64 File Offset: 0x00033164
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1015744, RefRangeEnd = 1015766, XrefRangeStart = 1015727, XrefRangeEnd = 1015744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Mark(InstructionList instructions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_Mark_Internal_Void_InstructionList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00034FA8 File Offset: 0x000331A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1015777, RefRangeEnd = 1015783, XrefRangeStart = 1015766, XrefRangeEnd = 1015777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBranch(InstructionList instructions, int branchIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_AddBranch_Internal_Void_InstructionList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00034FF8 File Offset: 0x000331F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015783, XrefRangeEnd = 1015785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupBranch(InstructionList instructions, int branchIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref branchIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr_FixupBranch_Internal_Void_InstructionList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00035048 File Offset: 0x00033248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015786, RefRangeEnd = 1015787, XrefRangeStart = 1015785, XrefRangeEnd = 1015786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchLabel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchLabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchLabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000042BF File Offset: 0x000024BF
		public BranchLabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00035084 File Offset: 0x00033284
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000042C8 File Offset: 0x000024C8
		public unsafe int _targetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__targetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__targetIndex)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000350AC File Offset: 0x000332AC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000042E3 File Offset: 0x000024E3
		public unsafe int _stackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__stackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__stackDepth)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000350D4 File Offset: 0x000332D4
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000042FE File Offset: 0x000024FE
		public unsafe int _continuationStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__continuationStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__continuationStackDepth)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000350FC File Offset: 0x000332FC
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00004319 File Offset: 0x00002519
		public unsafe List<int> _forwardBranchFixups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__forwardBranchFixups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__forwardBranchFixups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0003512C File Offset: 0x0003332C
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00004338 File Offset: 0x00002538
		public unsafe int _LabelIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__LabelIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchLabel.NativeFieldInfoPtr__LabelIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeFieldInfoPtr__targetIndex;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr__stackDepth;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr__continuationStackDepth;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr__forwardBranchFixups;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr__LabelIndex_k__BackingField;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_get_LabelIndex_Internal_get_Int32_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_set_LabelIndex_Internal_set_Void_Int32_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRuntimeLabel_Internal_get_Boolean_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetIndex_Internal_get_Int32_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ToRuntimeLabel_Internal_RuntimeLabel_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_Mark_Internal_Void_InstructionList_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_AddBranch_Internal_Void_InstructionList_Int32_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_FixupBranch_Internal_Void_InstructionList_Int32_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
