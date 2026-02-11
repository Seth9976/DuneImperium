using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000414 RID: 1044
	public sealed class MemberFilter : MulticastDelegate
	{
		// Token: 0x06003C22 RID: 15394 RVA: 0x00120504 File Offset: 0x0011E704
		// Note: this type is marked as 'beforefieldinit'.
		static MemberFilter()
		{
			Il2CppClassPointerStore<MemberFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MemberFilter");
			MemberFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr, 100672264);
			MemberFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr, 100672265);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00120554 File Offset: 0x0011E754
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 622948, RefRangeEnd = 622956, XrefRangeStart = 622948, XrefRangeEnd = 622956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberFilter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x001205B0 File Offset: 0x0011E7B0
		[CallerCount(0)]
		public unsafe bool Invoke(MemberInfo m, Object filterCriteria)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x000165A1 File Offset: 0x000147A1
		public MemberFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x000165AA File Offset: 0x000147AA
		public static implicit operator MemberFilter(Func<MemberInfo, Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<MemberFilter>(A_0);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x000165B2 File Offset: 0x000147B2
		public static MemberFilter operator +(MemberFilter A_0, MemberFilter A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MemberFilter>();
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x000165C0 File Offset: 0x000147C0
		public static MemberFilter operator -(MemberFilter A_0, MemberFilter A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MemberFilter>();
			}
			return delegate2;
		}

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_MemberInfo_Object_0;
	}
}
