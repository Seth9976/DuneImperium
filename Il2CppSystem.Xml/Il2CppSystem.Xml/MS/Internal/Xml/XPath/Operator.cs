using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000204 RID: 516
	public class Operator : AstNode
	{
		// Token: 0x06002D4D RID: 11597 RVA: 0x000D0908 File Offset: 0x000CEB08
		// Note: this type is marked as 'beforefieldinit'.
		static Operator()
		{
			Il2CppClassPointerStore<Operator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Operator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Operator>.NativeClassPtr);
			Operator.NativeFieldInfoPtr_s_invertOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "s_invertOp");
			Operator.NativeFieldInfoPtr__opType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opType");
			Operator.NativeFieldInfoPtr__opnd1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opnd1");
			Operator.NativeFieldInfoPtr__opnd2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Operator>.NativeClassPtr, "_opnd2");
			Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100669840);
			Operator.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100669841);
			Operator.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Operator>.NativeClassPtr, 100669842);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000D09C4 File Offset: 0x000CEBC4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 425621, RefRangeEnd = 425634, XrefRangeStart = 425618, XrefRangeEnd = 425621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Operator(Operator.Op op, AstNode opnd1, AstNode opnd2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Operator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(opnd1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(opnd2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000D0A30 File Offset: 0x000CEC30
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operator.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000D0A78 File Offset: 0x000CEC78
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Operator.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00012B1E File Offset: 0x00010D1E
		public Operator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000D0AC0 File Offset: 0x000CECC0
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x00012B27 File Offset: 0x00010D27
		public unsafe static Il2CppStructArray<Operator.Op> s_invertOp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Operator.NativeFieldInfoPtr_s_invertOp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Operator.Op>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Operator.NativeFieldInfoPtr_s_invertOp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x000D0AE8 File Offset: 0x000CECE8
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x00012B39 File Offset: 0x00010D39
		public unsafe Operator.Op _opType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opType)) = value;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000D0B10 File Offset: 0x000CED10
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x00012B54 File Offset: 0x00010D54
		public unsafe AstNode _opnd1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opnd1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opnd1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000D0B40 File Offset: 0x000CED40
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x00012B73 File Offset: 0x00010D73
		public unsafe AstNode _opnd2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opnd2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Operator.NativeFieldInfoPtr__opnd2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeFieldInfoPtr_s_invertOp;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeFieldInfoPtr__opType;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeFieldInfoPtr__opnd1;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeFieldInfoPtr__opnd2;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_AstNode_AstNode_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x02000283 RID: 643
		public enum Op
		{
			// Token: 0x0400281C RID: 10268
			INVALID,
			// Token: 0x0400281D RID: 10269
			OR,
			// Token: 0x0400281E RID: 10270
			AND,
			// Token: 0x0400281F RID: 10271
			EQ,
			// Token: 0x04002820 RID: 10272
			NE,
			// Token: 0x04002821 RID: 10273
			LT,
			// Token: 0x04002822 RID: 10274
			LE,
			// Token: 0x04002823 RID: 10275
			GT,
			// Token: 0x04002824 RID: 10276
			GE,
			// Token: 0x04002825 RID: 10277
			PLUS,
			// Token: 0x04002826 RID: 10278
			MINUS,
			// Token: 0x04002827 RID: 10279
			MUL,
			// Token: 0x04002828 RID: 10280
			DIV,
			// Token: 0x04002829 RID: 10281
			MOD,
			// Token: 0x0400282A RID: 10282
			UNION
		}
	}
}
