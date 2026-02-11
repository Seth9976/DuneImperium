using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000172 RID: 370
	public sealed class TreeWalkPredicate<T> : MulticastDelegate
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x000763A8 File Offset: 0x000745A8
		// Note: this type is marked as 'beforefieldinit'.
		static TreeWalkPredicate()
		{
			Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "TreeWalkPredicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			TreeWalkPredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100666953);
			TreeWalkPredicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr, 100666954);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00076434 File Offset: 0x00074634
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 469255, RefRangeEnd = 469264, XrefRangeStart = 469251, XrefRangeEnd = 469255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeWalkPredicate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeWalkPredicate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeWalkPredicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00076490 File Offset: 0x00074690
		[CallerCount(0)]
		public unsafe bool Invoke(SortedSet<T>.Node node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeWalkPredicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00009DBE File Offset: 0x00007FBE
		public TreeWalkPredicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00009DC7 File Offset: 0x00007FC7
		public static implicit operator TreeWalkPredicate<T>(Func<SortedSet<T>.Node, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<TreeWalkPredicate<T>>(A_0);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00009DCF File Offset: 0x00007FCF
		public static TreeWalkPredicate<T>operator +(TreeWalkPredicate<T> A_0, TreeWalkPredicate<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TreeWalkPredicate<T>>();
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00009DDD File Offset: 0x00007FDD
		public static TreeWalkPredicate<T>operator -(TreeWalkPredicate<T> A_0, TreeWalkPredicate<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TreeWalkPredicate<T>>();
			}
			return delegate2;
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Node_T_0;
	}
}
