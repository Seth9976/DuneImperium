using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200003E RID: 62
	public class FullConditionalExpression : ConditionalExpression
	{
		// Token: 0x06000384 RID: 900 RVA: 0x000215D0 File Offset: 0x0001F7D0
		// Note: this type is marked as 'beforefieldinit'.
		static FullConditionalExpression()
		{
			Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "FullConditionalExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr);
			FullConditionalExpression.NativeFieldInfoPtr__false = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr, "_false");
			FullConditionalExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr, 100664158);
			FullConditionalExpression.NativeMethodInfoPtr_GetFalse_Internal_Virtual_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr, 100664159);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0002163C File Offset: 0x0001F83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012167, XrefRangeEnd = 1012169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullConditionalExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifFalse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullConditionalExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000216AC File Offset: 0x0001F8AC
		[CallerCount(0)]
		public unsafe override Expression GetFalse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullConditionalExpression.NativeMethodInfoPtr_GetFalse_Internal_Virtual_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002D16 File Offset: 0x00000F16
		public FullConditionalExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000216F8 File Offset: 0x0001F8F8
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00002D1F File Offset: 0x00000F1F
		public unsafe Expression _false
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullConditionalExpression.NativeFieldInfoPtr__false);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullConditionalExpression.NativeFieldInfoPtr__false), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr__false;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_GetFalse_Internal_Virtual_Expression_0;
	}
}
