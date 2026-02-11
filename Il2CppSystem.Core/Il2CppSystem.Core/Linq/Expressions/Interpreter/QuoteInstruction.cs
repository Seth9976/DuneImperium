using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000104 RID: 260
	public sealed class QuoteInstruction : Instruction
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x00053014 File Offset: 0x00051214
		// Note: this type is marked as 'beforefieldinit'.
		static QuoteInstruction()
		{
			Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "QuoteInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr);
			QuoteInstruction.NativeFieldInfoPtr__operand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, "_operand");
			QuoteInstruction.NativeFieldInfoPtr__hoistedVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, "_hoistedVariables");
			QuoteInstruction.NativeMethodInfoPtr__ctor_Public_Void_Expression_Dictionary_2_ParameterExpression_LocalVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, 100666223);
			QuoteInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, 100666224);
			QuoteInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, 100666225);
			QuoteInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, 100666226);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000530BC File Offset: 0x000512BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hoistedVariables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.NativeMethodInfoPtr__ctor_Public_Void_Expression_Dictionary_2_ParameterExpression_LocalVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0005311C File Offset: 0x0005131C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00053158 File Offset: 0x00051358
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026789, XrefRangeEnd = 1026791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00053190 File Offset: 0x00051390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026791, XrefRangeEnd = 1026805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00006E4E File Offset: 0x0000504E
		public QuoteInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000531E0 File Offset: 0x000513E0
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x00006E57 File Offset: 0x00005057
		public unsafe Expression _operand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.NativeFieldInfoPtr__operand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.NativeFieldInfoPtr__operand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00053210 File Offset: 0x00051410
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x00006E76 File Offset: 0x00005076
		public unsafe Dictionary<ParameterExpression, LocalVariable> _hoistedVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.NativeFieldInfoPtr__hoistedVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.NativeFieldInfoPtr__hoistedVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr__operand;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr__hoistedVariables;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_Dictionary_2_ParameterExpression_LocalVariable_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x0200032A RID: 810
		public sealed class ExpressionQuoter : ExpressionVisitor
		{
			// Token: 0x06001B1F RID: 6943 RVA: 0x0008112C File Offset: 0x0007F32C
			// Note: this type is marked as 'beforefieldinit'.
			static ExpressionQuoter()
			{
				Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuoteInstruction>.NativeClassPtr, "ExpressionQuoter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr);
				QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, "_variables");
				QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, "_frame");
				QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__shadowedVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, "_shadowedVars");
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_ParameterExpression_LocalVariable_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666227);
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666228);
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666229);
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666230);
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666231);
				QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_GetBox_Private_IStrongBox_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr, 100666232);
			}

			// Token: 0x06001B20 RID: 6944 RVA: 0x0008120C File Offset: 0x0007F40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026707, XrefRangeEnd = 1026717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoistedVariables);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_ParameterExpression_LocalVariable_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B21 RID: 6945 RVA: 0x0008126C File Offset: 0x0007F46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026717, XrefRangeEnd = 1026732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitLambda<T>(Expression<T> node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B22 RID: 6946 RVA: 0x000812BC File Offset: 0x0007F4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026732, XrefRangeEnd = 1026754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitBlock(BlockExpression node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B23 RID: 6947 RVA: 0x0008130C File Offset: 0x0007F50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026754, XrefRangeEnd = 1026770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override CatchBlock VisitCatchBlock(CatchBlock node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CatchBlock>(intPtr3) : null;
				}
			}

			// Token: 0x06001B24 RID: 6948 RVA: 0x0008135C File Offset: 0x0007F55C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026770, XrefRangeEnd = 1026785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitParameter(ParameterExpression node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B25 RID: 6949 RVA: 0x000813AC File Offset: 0x0007F5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026785, XrefRangeEnd = 1026789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IStrongBox GetBox(ParameterExpression variable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_GetBox_Private_IStrongBox_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStrongBox>(intPtr3) : null;
				}
			}

			// Token: 0x06001B26 RID: 6950 RVA: 0x0000A53C File Offset: 0x0000873C
			public ExpressionQuoter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x06001B27 RID: 6951 RVA: 0x000813FC File Offset: 0x0007F5FC
			// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0000A545 File Offset: 0x00008745
			public unsafe Dictionary<ParameterExpression, LocalVariable> _variables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__variables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, LocalVariable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__variables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0008142C File Offset: 0x0007F62C
			// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0000A564 File Offset: 0x00008764
			public unsafe InterpretedFrame _frame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__frame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__frame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0008145C File Offset: 0x0007F65C
			// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0000A583 File Offset: 0x00008783
			public unsafe Stack<HashSet<ParameterExpression>> _shadowedVars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__shadowedVars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<HashSet<ParameterExpression>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuoteInstruction.ExpressionQuoter.NativeFieldInfoPtr__shadowedVars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001258 RID: 4696
			private static readonly IntPtr NativeFieldInfoPtr__variables;

			// Token: 0x04001259 RID: 4697
			private static readonly IntPtr NativeFieldInfoPtr__frame;

			// Token: 0x0400125A RID: 4698
			private static readonly IntPtr NativeFieldInfoPtr__shadowedVars;

			// Token: 0x0400125B RID: 4699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_ParameterExpression_LocalVariable_InterpretedFrame_0;

			// Token: 0x0400125C RID: 4700
			private static readonly IntPtr NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0;

			// Token: 0x0400125D RID: 4701
			private static readonly IntPtr NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0;

			// Token: 0x0400125E RID: 4702
			private static readonly IntPtr NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0;

			// Token: 0x0400125F RID: 4703
			private static readonly IntPtr NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0;

			// Token: 0x04001260 RID: 4704
			private static readonly IntPtr NativeMethodInfoPtr_GetBox_Private_IStrongBox_ParameterExpression_0;

			// Token: 0x0200036B RID: 875
			private sealed class MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>
			{
				// Token: 0x04001337 RID: 4919
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(QuoteInstruction.ExpressionQuoter.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0, Il2CppClassPointerStore<QuoteInstruction.ExpressionQuoter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
