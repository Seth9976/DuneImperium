using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000C1 RID: 193
	public sealed class LabelInfo : Object
	{
		// Token: 0x06000B72 RID: 2930 RVA: 0x0004016C File Offset: 0x0003E36C
		// Note: this type is marked as 'beforefieldinit'.
		static LabelInfo()
		{
			Il2CppClassPointerStore<LabelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LabelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr);
			LabelInfo.NativeFieldInfoPtr__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "_node");
			LabelInfo.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "_label");
			LabelInfo.NativeFieldInfoPtr__definitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "_definitions");
			LabelInfo.NativeFieldInfoPtr__references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "_references");
			LabelInfo.NativeFieldInfoPtr__acrossBlockJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "_acrossBlockJump");
			LabelInfo.NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665421);
			LabelInfo.NativeMethodInfoPtr_GetLabel_Internal_BranchLabel_LightCompiler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665422);
			LabelInfo.NativeMethodInfoPtr_Reference_Internal_Void_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665423);
			LabelInfo.NativeMethodInfoPtr_Define_Internal_Void_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665424);
			LabelInfo.NativeMethodInfoPtr_ValidateJump_Private_Void_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665425);
			LabelInfo.NativeMethodInfoPtr_ValidateFinish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665426);
			LabelInfo.NativeMethodInfoPtr_EnsureLabel_Private_Void_LightCompiler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665427);
			LabelInfo.NativeMethodInfoPtr_DefinedIn_Private_Boolean_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665428);
			LabelInfo.NativeMethodInfoPtr_get_HasDefinitions_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665429);
			LabelInfo.NativeMethodInfoPtr_FirstDefinition_Private_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665430);
			LabelInfo.NativeMethodInfoPtr_AddDefinition_Private_Void_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665431);
			LabelInfo.NativeMethodInfoPtr_get_HasMultipleDefinitions_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665432);
			LabelInfo.NativeMethodInfoPtr_CommonNode_Internal_Static_T_T_T_Func_2_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, 100665433);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00040304 File Offset: 0x0003E504
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1019416, RefRangeEnd = 1019421, XrefRangeStart = 1019407, XrefRangeEnd = 1019416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelInfo(LabelTarget node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00040350 File Offset: 0x0003E550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1019423, RefRangeEnd = 1019426, XrefRangeStart = 1019421, XrefRangeEnd = 1019423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchLabel GetLabel(LightCompiler compiler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compiler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_GetLabel_Internal_BranchLabel_LightCompiler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchLabel>(intPtr3) : null;
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000403A0 File Offset: 0x0003E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019426, XrefRangeEnd = 1019432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reference(LabelScopeInfo block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_Reference_Internal_Void_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000403E4 File Offset: 0x0003E5E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1019479, RefRangeEnd = 1019483, XrefRangeStart = 1019432, XrefRangeEnd = 1019479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Define(LabelScopeInfo block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_Define_Internal_Void_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00040428 File Offset: 0x0003E628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1019518, RefRangeEnd = 1019522, XrefRangeStart = 1019483, XrefRangeEnd = 1019518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateJump(LabelScopeInfo reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_ValidateJump_Private_Void_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0004046C File Offset: 0x0003E66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019522, XrefRangeEnd = 1019523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_ValidateFinish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000404A0 File Offset: 0x0003E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019523, XrefRangeEnd = 1019525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLabel(LightCompiler compiler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compiler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_EnsureLabel_Private_Void_LightCompiler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000404E4 File Offset: 0x0003E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019525, XrefRangeEnd = 1019531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DefinedIn(LabelScopeInfo scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_DefinedIn_Private_Boolean_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00040534 File Offset: 0x0003E734
		public unsafe bool HasDefinitions
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_get_HasDefinitions_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00040570 File Offset: 0x0003E770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019545, RefRangeEnd = 1019546, XrefRangeStart = 1019531, XrefRangeEnd = 1019545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelScopeInfo FirstDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_FirstDefinition_Private_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelScopeInfo>(intPtr3) : null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000405B0 File Offset: 0x0003E7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019546, XrefRangeEnd = 1019564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefinition(LabelScopeInfo scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_AddDefinition_Private_Void_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x000405F4 File Offset: 0x0003E7F4
		public unsafe bool HasMultipleDefinitions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1019565, RefRangeEnd = 1019567, XrefRangeStart = 1019564, XrefRangeEnd = 1019565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.NativeMethodInfoPtr_get_HasMultipleDefinitions_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00040630 File Offset: 0x0003E830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019584, RefRangeEnd = 1019585, XrefRangeStart = 1019567, XrefRangeEnd = 1019584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CommonNode<T>(T first, T second, Func<T, T> parent) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = first;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref first;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = second;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref second;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LabelInfo.MethodInfoStoreGeneric_CommonNode_Internal_Static_T_T_T_Func_2_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000054FD File Offset: 0x000036FD
		public LabelInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00040700 File Offset: 0x0003E900
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00005506 File Offset: 0x00003706
		public unsafe LabelTarget _node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00040730 File Offset: 0x0003E930
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00005525 File Offset: 0x00003725
		public unsafe BranchLabel _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BranchLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00040760 File Offset: 0x0003E960
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00005544 File Offset: 0x00003744
		public unsafe Object _definitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__definitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__definitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00040790 File Offset: 0x0003E990
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00005563 File Offset: 0x00003763
		public unsafe List<LabelScopeInfo> _references
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__references);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabelScopeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__references), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000407C0 File Offset: 0x0003E9C0
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00005582 File Offset: 0x00003782
		public unsafe bool _acrossBlockJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__acrossBlockJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabelInfo.NativeFieldInfoPtr__acrossBlockJump)) = value;
			}
		}

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeFieldInfoPtr__node;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr__definitions;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr__references;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr__acrossBlockJump;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LabelTarget_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_GetLabel_Internal_BranchLabel_LightCompiler_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_Reference_Internal_Void_LabelScopeInfo_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_Define_Internal_Void_LabelScopeInfo_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_ValidateJump_Private_Void_LabelScopeInfo_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFinish_Internal_Void_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLabel_Private_Void_LightCompiler_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_DefinedIn_Private_Boolean_LabelScopeInfo_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefinitions_Private_get_Boolean_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_FirstDefinition_Private_LabelScopeInfo_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_AddDefinition_Private_Void_LabelScopeInfo_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMultipleDefinitions_Private_get_Boolean_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_CommonNode_Internal_Static_T_T_T_Func_2_T_T_0;

		// Token: 0x02000252 RID: 594
		[ObfuscatedName("System.Linq.Expressions.Interpreter.LabelInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001827 RID: 6183 RVA: 0x000740A4 File Offset: 0x000722A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabelInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr);
				LabelInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr, "<>9");
				LabelInfo.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr, "<>9__9_0");
				LabelInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr, 100665435);
				LabelInfo.__c.NativeMethodInfoPtr__ValidateJump_b__9_0_Internal_LabelScopeInfo_LabelScopeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr, 100665436);
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x00074120 File Offset: 0x00072320
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001829 RID: 6185 RVA: 0x0007415C File Offset: 0x0007235C
			[CallerCount(0)]
			public unsafe LabelScopeInfo _ValidateJump_b__9_0(LabelScopeInfo b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelInfo.__c.NativeMethodInfoPtr__ValidateJump_b__9_0_Internal_LabelScopeInfo_LabelScopeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelScopeInfo>(intPtr3) : null;
				}
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x00009D1D File Offset: 0x00007F1D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x0600182B RID: 6187 RVA: 0x000741AC File Offset: 0x000723AC
			// (set) Token: 0x0600182C RID: 6188 RVA: 0x00009D26 File Offset: 0x00007F26
			public unsafe static LabelInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LabelInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LabelInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x0600182D RID: 6189 RVA: 0x000741D4 File Offset: 0x000723D4
			// (set) Token: 0x0600182E RID: 6190 RVA: 0x00009D38 File Offset: 0x00007F38
			public unsafe static Func<LabelScopeInfo, LabelScopeInfo> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LabelInfo.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LabelScopeInfo, LabelScopeInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LabelInfo.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010A8 RID: 4264
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010A9 RID: 4265
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040010AA RID: 4266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010AB RID: 4267
			private static readonly IntPtr NativeMethodInfoPtr__ValidateJump_b__9_0_Internal_LabelScopeInfo_LabelScopeInfo_0;
		}

		// Token: 0x02000253 RID: 595
		private sealed class MethodInfoStoreGeneric_CommonNode_Internal_Static_T_T_T_Func_2_T_T_0<T>
		{
			// Token: 0x040010AC RID: 4268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LabelInfo.NativeMethodInfoPtr_CommonNode_Internal_Static_T_T_T_Func_2_T_T_0, Il2CppClassPointerStore<LabelInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
