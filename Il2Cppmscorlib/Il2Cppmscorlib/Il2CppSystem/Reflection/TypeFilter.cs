using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000433 RID: 1075
	public sealed class TypeFilter : MulticastDelegate
	{
		// Token: 0x06003DE3 RID: 15843 RVA: 0x00129240 File Offset: 0x00127440
		// Note: this type is marked as 'beforefieldinit'.
		static TypeFilter()
		{
			Il2CppClassPointerStore<TypeFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TypeFilter");
			TypeFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr, 100672611);
			TypeFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr, 100672612);
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00129290 File Offset: 0x00127490
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 622948, RefRangeEnd = 622956, XrefRangeStart = 622948, XrefRangeEnd = 622956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeFilter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x001292EC File Offset: 0x001274EC
		[CallerCount(0)]
		public unsafe bool Invoke(Type m, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x000169BB File Offset: 0x00014BBB
		public TypeFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000169C4 File Offset: 0x00014BC4
		public static implicit operator TypeFilter(Func<Type, Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<TypeFilter>(A_0);
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000169CC File Offset: 0x00014BCC
		public static TypeFilter operator +(TypeFilter A_0, TypeFilter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TypeFilter>();
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000169DA File Offset: 0x00014BDA
		public static TypeFilter operator -(TypeFilter A_0, TypeFilter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TypeFilter>();
			}
			return delegate2;
		}

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Type_Object_0;
	}
}
