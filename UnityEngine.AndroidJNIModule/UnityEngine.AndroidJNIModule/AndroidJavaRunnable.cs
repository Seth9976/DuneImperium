using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class AndroidJavaRunnable : MulticastDelegate
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002CE0 File Offset: 0x00000EE0
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaRunnable()
		{
			Il2CppClassPointerStore<AndroidJavaRunnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaRunnable");
			AndroidJavaRunnable.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaRunnable>.NativeClassPtr, 100663297);
			AndroidJavaRunnable.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaRunnable>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002D30 File Offset: 0x00000F30
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaRunnable(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaRunnable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaRunnable.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002D8C File Offset: 0x00000F8C
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaRunnable.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public AndroidJavaRunnable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public static implicit operator AndroidJavaRunnable(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<AndroidJavaRunnable>(A_0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002061 File Offset: 0x00000261
		public static AndroidJavaRunnable operator +(AndroidJavaRunnable A_0, AndroidJavaRunnable A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AndroidJavaRunnable>();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206F File Offset: 0x0000026F
		public static AndroidJavaRunnable operator -(AndroidJavaRunnable A_0, AndroidJavaRunnable A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AndroidJavaRunnable>();
			}
			return delegate2;
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
