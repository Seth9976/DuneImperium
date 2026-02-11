using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x02000034 RID: 52
	public sealed class MonoBtlsServerNameCallback : MulticastDelegate
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00027514 File Offset: 0x00025714
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsServerNameCallback()
		{
			Il2CppClassPointerStore<MonoBtlsServerNameCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsServerNameCallback");
			MonoBtlsServerNameCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsServerNameCallback>.NativeClassPtr, 100663846);
			MonoBtlsServerNameCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsServerNameCallback>.NativeClassPtr, 100663847);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00027564 File Offset: 0x00025764
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 430646, RefRangeEnd = 430700, XrefRangeStart = 430643, XrefRangeEnd = 430646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsServerNameCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsServerNameCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsServerNameCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000275C0 File Offset: 0x000257C0
		[CallerCount(0)]
		public unsafe int Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsServerNameCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000311D File Offset: 0x0000131D
		public MonoBtlsServerNameCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003126 File Offset: 0x00001326
		public static implicit operator MonoBtlsServerNameCallback(Func<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoBtlsServerNameCallback>(A_0);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000312E File Offset: 0x0000132E
		public static MonoBtlsServerNameCallback operator +(MonoBtlsServerNameCallback A_0, MonoBtlsServerNameCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoBtlsServerNameCallback>();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000313C File Offset: 0x0000133C
		public static MonoBtlsServerNameCallback operator -(MonoBtlsServerNameCallback A_0, MonoBtlsServerNameCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoBtlsServerNameCallback>();
			}
			return delegate2;
		}

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_0;
	}
}
