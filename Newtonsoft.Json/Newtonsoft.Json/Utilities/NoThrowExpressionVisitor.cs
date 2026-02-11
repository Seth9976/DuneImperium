using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000056 RID: 86
	public class NoThrowExpressionVisitor : ExpressionVisitor
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00037398 File Offset: 0x00035598
		// Note: this type is marked as 'beforefieldinit'.
		static NoThrowExpressionVisitor()
		{
			Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "NoThrowExpressionVisitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr);
			NoThrowExpressionVisitor.NativeFieldInfoPtr_ErrorResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr, "ErrorResult");
			NoThrowExpressionVisitor.NativeMethodInfoPtr_VisitConditional_Protected_Virtual_Expression_ConditionalExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr, 100664823);
			NoThrowExpressionVisitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr, 100664824);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00037404 File Offset: 0x00035604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743106, XrefRangeEnd = 743126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression VisitConditional(ConditionalExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoThrowExpressionVisitor.NativeMethodInfoPtr_VisitConditional_Protected_Virtual_Expression_ConditionalExpression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00037460 File Offset: 0x00035660
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoThrowExpressionVisitor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoThrowExpressionVisitor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoThrowExpressionVisitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0000467D File Offset: 0x0000287D
		public NoThrowExpressionVisitor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0003749C File Offset: 0x0003569C
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00004686 File Offset: 0x00002886
		public unsafe static Object ErrorResult
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NoThrowExpressionVisitor.NativeFieldInfoPtr_ErrorResult, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoThrowExpressionVisitor.NativeFieldInfoPtr_ErrorResult, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr_ErrorResult;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_VisitConditional_Protected_Virtual_Expression_ConditionalExpression_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
