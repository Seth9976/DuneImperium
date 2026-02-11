using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000081 RID: 129
	public sealed class PrimitiveParameterExpression<T> : ParameterExpression
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x0002EE28 File Offset: 0x0002D028
		// Note: this type is marked as 'beforefieldinit'.
		static PrimitiveParameterExpression()
		{
			Il2CppClassPointerStore<PrimitiveParameterExpression<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "PrimitiveParameterExpression`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimitiveParameterExpression<T>>.NativeClassPtr);
			PrimitiveParameterExpression<T>.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveParameterExpression<T>>.NativeClassPtr, 100664611);
			PrimitiveParameterExpression<T>.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimitiveParameterExpression<T>>.NativeClassPtr, 100664612);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002EEBC File Offset: 0x0002D0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014717, RefRangeEnd = 1014718, XrefRangeStart = 1014668, XrefRangeEnd = 1014717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimitiveParameterExpression(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimitiveParameterExpression<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveParameterExpression<T>.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002EF08 File Offset: 0x0002D108
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014718, XrefRangeEnd = 1014734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimitiveParameterExpression<T>.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00003ACB File Offset: 0x00001CCB
		public PrimitiveParameterExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
