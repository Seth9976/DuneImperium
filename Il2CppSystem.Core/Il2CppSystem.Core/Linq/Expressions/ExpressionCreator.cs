using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200005A RID: 90
	public static class ExpressionCreator<TDelegate> : Object
	{
		// Token: 0x06000541 RID: 1345 RVA: 0x00029F18 File Offset: 0x00028118
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionCreator()
		{
			Il2CppClassPointerStore<ExpressionCreator<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ExpressionCreator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionCreator<TDelegate>>.NativeClassPtr);
			ExpressionCreator<TDelegate>.NativeMethodInfoPtr_CreateExpressionFunc_Public_Static_LambdaExpression_Expression_String_Boolean_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionCreator<TDelegate>>.NativeClassPtr, 100664471);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00029F98 File Offset: 0x00028198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014068, XrefRangeEnd = 1014119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailCall;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionCreator<TDelegate>.NativeMethodInfoPtr_CreateExpressionFunc_Public_Static_LambdaExpression_Expression_String_Boolean_ReadOnlyCollection_1_ParameterExpression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr3) : null;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000032D4 File Offset: 0x000014D4
		public ExpressionCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_CreateExpressionFunc_Public_Static_LambdaExpression_Expression_String_Boolean_ReadOnlyCollection_1_ParameterExpression_0;
	}
}
