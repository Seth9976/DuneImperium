using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000025 RID: 37
	public static class Constant : Object
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000DF18 File Offset: 0x0000C118
		// Note: this type is marked as 'beforefieldinit'.
		static Constant()
		{
			Il2CppClassPointerStore<Constant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "Constant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constant>.NativeClassPtr);
			Constant.NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constant>.NativeClassPtr, 100666932);
			Constant.NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constant>.NativeClassPtr, 100666933);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000DF70 File Offset: 0x0000C170
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConstantExpression<T>(T t) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t2 = t;
					intPtr = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref t;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Constant.MethodInfoStoreGeneric_IsConstantExpression_Public_Static_Boolean_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsConstantExpression(void* t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constant.NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002DCE File Offset: 0x00000FCE
		public Constant(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_T_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_ptr_Void_0;

		// Token: 0x0200005F RID: 95
		private sealed class MethodInfoStoreGeneric_IsConstantExpression_Public_Static_Boolean_T_0<T>
		{
			// Token: 0x040011D1 RID: 4561
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Constant.NativeMethodInfoPtr_IsConstantExpression_Public_Static_Boolean_T_0, Il2CppClassPointerStore<Constant>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
