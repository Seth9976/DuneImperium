using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200002C RID: 44
	public class MethodBinaryExpression : SimpleBinaryExpression
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x000180F8 File Offset: 0x000162F8
		// Note: this type is marked as 'beforefieldinit'.
		static MethodBinaryExpression()
		{
			Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MethodBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr);
			MethodBinaryExpression.NativeFieldInfoPtr__method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr, "_method");
			MethodBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr, 100663844);
			MethodBinaryExpression.NativeMethodInfoPtr_GetMethod_Internal_Virtual_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr, 100663845);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00018164 File Offset: 0x00016364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1007255, RefRangeEnd = 1007256, XrefRangeStart = 1007252, XrefRangeEnd = 1007255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000181F8 File Offset: 0x000163F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodBinaryExpression.NativeMethodInfoPtr_GetMethod_Internal_Virtual_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002819 File Offset: 0x00000A19
		public MethodBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00018244 File Offset: 0x00016444
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002822 File Offset: 0x00000A22
		public unsafe MethodInfo _method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBinaryExpression.NativeFieldInfoPtr__method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodBinaryExpression.NativeFieldInfoPtr__method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr__method;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_MethodInfo_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_Virtual_MethodInfo_0;
	}
}
