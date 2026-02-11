using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000295 RID: 661
	public class Expression : Object
	{
		// Token: 0x06003134 RID: 12596 RVA: 0x000D0E50 File Offset: 0x000CF050
		// Note: this type is marked as 'beforefieldinit'.
		static Expression()
		{
			Il2CppClassPointerStore<Expression>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets.Syntax", "Expression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Expression>.NativeClassPtr);
			Expression.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "type");
			Expression.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "multiplier");
			Expression.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "dataType");
			Expression.NativeFieldInfoPtr_combinator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "combinator");
			Expression.NativeFieldInfoPtr_subExpressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "subExpressions");
			Expression.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Expression>.NativeClassPtr, "keyword");
			Expression.NativeMethodInfoPtr__ctor_Public_Void_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Expression>.NativeClassPtr, 100670445);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000D0F0C File Offset: 0x000CF10C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358930, RefRangeEnd = 358934, XrefRangeStart = 358927, XrefRangeEnd = 358930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression(ExpressionType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Expression>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Expression.NativeMethodInfoPtr__ctor_Public_Void_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000140B9 File Offset: 0x000122B9
		public Expression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x000D0F54 File Offset: 0x000CF154
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x000140C2 File Offset: 0x000122C2
		public unsafe ExpressionType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x000D0F7C File Offset: 0x000CF17C
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x000140DD File Offset: 0x000122DD
		public unsafe ExpressionMultiplier multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x000D0FA4 File Offset: 0x000CF1A4
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x000140F8 File Offset: 0x000122F8
		public unsafe DataType dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_dataType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_dataType)) = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000D0FCC File Offset: 0x000CF1CC
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x00014113 File Offset: 0x00012313
		public unsafe ExpressionCombinator combinator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_combinator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_combinator)) = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000D0FF4 File Offset: 0x000CF1F4
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0001412E File Offset: 0x0001232E
		public unsafe Il2CppReferenceArray<Expression> subExpressions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_subExpressions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_subExpressions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000D1024 File Offset: 0x000CF224
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0001414D File Offset: 0x0001234D
		public unsafe string keyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_keyword);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Expression.NativeFieldInfoPtr_keyword), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_combinator;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_subExpressions;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_keyword;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExpressionType_0;
	}
}
