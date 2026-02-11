using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E7 RID: 231
	public sealed class LocalVariables : Object
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalVariables()
		{
			Il2CppClassPointerStore<LocalVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LocalVariables");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr);
			LocalVariables.NativeFieldInfoPtr__variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, "_variables");
			LocalVariables.NativeFieldInfoPtr__closureVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, "_closureVariables");
			LocalVariables.NativeFieldInfoPtr__localCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, "_localCount");
			LocalVariables.NativeFieldInfoPtr__maxLocalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, "_maxLocalCount");
			LocalVariables.NativeMethodInfoPtr_DefineLocal_Public_LocalDefinition_ParameterExpression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665844);
			LocalVariables.NativeMethodInfoPtr_UndefineLocal_Public_Void_LocalDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665845);
			LocalVariables.NativeMethodInfoPtr_Box_Internal_Void_ParameterExpression_InstructionList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665846);
			LocalVariables.NativeMethodInfoPtr_get_LocalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665847);
			LocalVariables.NativeMethodInfoPtr_TryGetLocalOrClosure_Public_Boolean_ParameterExpression_byref_LocalVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665848);
			LocalVariables.NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665849);
			LocalVariables.NativeMethodInfoPtr_AddClosureVariable_Internal_LocalVariable_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665850);
			LocalVariables.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, 100665851);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0004D910 File Offset: 0x0004BB10
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1024848, RefRangeEnd = 1024861, XrefRangeStart = 1024811, XrefRangeEnd = 1024848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDefinition DefineLocal(ParameterExpression variable, int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_DefineLocal_Public_LocalDefinition_ParameterExpression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LocalDefinition(intPtr);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004D968 File Offset: 0x0004BB68
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1024868, RefRangeEnd = 1024881, XrefRangeStart = 1024861, XrefRangeEnd = 1024868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UndefineLocal(LocalDefinition definition, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(definition));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_UndefineLocal_Public_Void_LocalDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0004D9C0 File Offset: 0x0004BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024881, XrefRangeEnd = 1024895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Box(ParameterExpression variable, InstructionList instructions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_Box_Internal_Void_ParameterExpression_InstructionList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0004DA14 File Offset: 0x0004BC14
		public unsafe int LocalCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_get_LocalCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0004DA50 File Offset: 0x0004BC50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1024902, RefRangeEnd = 1024908, XrefRangeStart = 1024895, XrefRangeEnd = 1024902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(var);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_TryGetLocalOrClosure_Public_Boolean_ParameterExpression_byref_LocalVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			local = ((intPtr4 == 0) ? null : new LocalVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		public unsafe Dictionary<ParameterExpression, LocalVariable> ClosureVariables
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0004DB00 File Offset: 0x0004BD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1024925, RefRangeEnd = 1024926, XrefRangeStart = 1024908, XrefRangeEnd = 1024925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariable AddClosureVariable(ParameterExpression variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr_AddClosureVariable_Internal_LocalVariable_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalVariable>(intPtr3) : null;
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0004DB50 File Offset: 0x0004BD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1024934, RefRangeEnd = 1024935, XrefRangeStart = 1024926, XrefRangeEnd = 1024934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariables()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000062D9 File Offset: 0x000044D9
		public LocalVariables(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0004DB8C File Offset: 0x0004BD8C
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x000062E2 File Offset: 0x000044E2
		public unsafe HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x0004DBBC File Offset: 0x0004BDBC
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00006301 File Offset: 0x00004501
		public unsafe Dictionary<ParameterExpression, LocalVariable> _closureVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__closureVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__closureVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00006320 File Offset: 0x00004520
		public unsafe int _localCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__localCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__localCount)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0004DC14 File Offset: 0x0004BE14
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0000633B File Offset: 0x0000453B
		public unsafe int _maxLocalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__maxLocalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.NativeFieldInfoPtr__maxLocalCount)) = value;
			}
		}

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr__variables;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr__closureVariables;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr__localCount;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr__maxLocalCount;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_DefineLocal_Public_LocalDefinition_ParameterExpression_Int32_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_UndefineLocal_Public_Void_LocalDefinition_Int32_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_Box_Internal_Void_ParameterExpression_InstructionList_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalCount_Public_get_Int32_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalOrClosure_Public_Boolean_ParameterExpression_byref_LocalVariable_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_get_ClosureVariables_Internal_get_Dictionary_2_ParameterExpression_LocalVariable_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_AddClosureVariable_Internal_LocalVariable_ParameterExpression_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002BF RID: 703
		public sealed class VariableScope : Object
		{
			// Token: 0x06001957 RID: 6487 RVA: 0x0007ABE4 File Offset: 0x00078DE4
			// Note: this type is marked as 'beforefieldinit'.
			static VariableScope()
			{
				Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalVariables>.NativeClassPtr, "VariableScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr);
				LocalVariables.VariableScope.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, "Start");
				LocalVariables.VariableScope.NativeFieldInfoPtr_Stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, "Stop");
				LocalVariables.VariableScope.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, "Variable");
				LocalVariables.VariableScope.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, "Parent");
				LocalVariables.VariableScope.NativeFieldInfoPtr_ChildScopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, "ChildScopes");
				LocalVariables.VariableScope.NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_VariableScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr, 100665852);
			}

			// Token: 0x06001958 RID: 6488 RVA: 0x0007AC88 File Offset: 0x00078E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024802, XrefRangeEnd = 1024811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VariableScope(LocalVariable variable, int start, LocalVariables.VariableScope parent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalVariables.VariableScope>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalVariables.VariableScope.NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_VariableScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001959 RID: 6489 RVA: 0x0000A0A8 File Offset: 0x000082A8
			public VariableScope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x0600195A RID: 6490 RVA: 0x0007ACF4 File Offset: 0x00078EF4
			// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000A0B1 File Offset: 0x000082B1
			public unsafe int Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007AD1C File Offset: 0x00078F1C
			// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000A0CC File Offset: 0x000082CC
			public unsafe int Stop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Stop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Stop)) = value;
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x0600195E RID: 6494 RVA: 0x0007AD44 File Offset: 0x00078F44
			// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000A0E7 File Offset: 0x000082E7
			public unsafe LocalVariable Variable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Variable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalVariable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Variable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x06001960 RID: 6496 RVA: 0x0007AD74 File Offset: 0x00078F74
			// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000A106 File Offset: 0x00008306
			public unsafe LocalVariables.VariableScope Parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalVariables.VariableScope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x06001962 RID: 6498 RVA: 0x0007ADA4 File Offset: 0x00078FA4
			// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000A125 File Offset: 0x00008325
			public unsafe List<LocalVariables.VariableScope> ChildScopes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_ChildScopes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalVariables.VariableScope>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalVariables.VariableScope.NativeFieldInfoPtr_ChildScopes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400116D RID: 4461
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x0400116E RID: 4462
			private static readonly IntPtr NativeFieldInfoPtr_Stop;

			// Token: 0x0400116F RID: 4463
			private static readonly IntPtr NativeFieldInfoPtr_Variable;

			// Token: 0x04001170 RID: 4464
			private static readonly IntPtr NativeFieldInfoPtr_Parent;

			// Token: 0x04001171 RID: 4465
			private static readonly IntPtr NativeFieldInfoPtr_ChildScopes;

			// Token: 0x04001172 RID: 4466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalVariable_Int32_VariableScope_0;
		}
	}
}
