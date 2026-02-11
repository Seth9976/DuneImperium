using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000033 RID: 51
	public sealed class MonoBtlsSelectCallback : MulticastDelegate
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00027418 File Offset: 0x00025618
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsSelectCallback()
		{
			Il2CppClassPointerStore<MonoBtlsSelectCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsSelectCallback");
			MonoBtlsSelectCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSelectCallback>.NativeClassPtr, 100663844);
			MonoBtlsSelectCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsSelectCallback>.NativeClassPtr, 100663845);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00027468 File Offset: 0x00025668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430642, RefRangeEnd = 430643, XrefRangeStart = 430638, XrefRangeEnd = 430642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsSelectCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsSelectCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSelectCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000274C4 File Offset: 0x000256C4
		[CallerCount(0)]
		public unsafe int Invoke(Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsSelectCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000030ED File Offset: 0x000012ED
		public MonoBtlsSelectCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000030F6 File Offset: 0x000012F6
		public static implicit operator MonoBtlsSelectCallback(Func<Il2CppStringArray, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoBtlsSelectCallback>(A_0);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000030FE File Offset: 0x000012FE
		public static MonoBtlsSelectCallback operator +(MonoBtlsSelectCallback A_0, MonoBtlsSelectCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoBtlsSelectCallback>();
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000310C File Offset: 0x0000130C
		public static MonoBtlsSelectCallback operator -(MonoBtlsSelectCallback A_0, MonoBtlsSelectCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoBtlsSelectCallback>();
			}
			return delegate2;
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStringArray_0;
	}
}
