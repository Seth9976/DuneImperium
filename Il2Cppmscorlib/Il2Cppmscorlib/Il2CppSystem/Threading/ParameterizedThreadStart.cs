using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018B RID: 395
	public sealed class ParameterizedThreadStart : MulticastDelegate
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterizedThreadStart()
		{
			Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ParameterizedThreadStart");
			ParameterizedThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr, 100667843);
			ParameterizedThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr, 100667844);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000A0648 File Offset: 0x0009E848
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterizedThreadStart(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000A06A4 File Offset: 0x0009E8A4
		[CallerCount(0)]
		public unsafe void Invoke(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000084B0 File Offset: 0x000066B0
		public ParameterizedThreadStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000084B9 File Offset: 0x000066B9
		public static implicit operator ParameterizedThreadStart(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ParameterizedThreadStart>(A_0);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000084C1 File Offset: 0x000066C1
		public static ParameterizedThreadStart operator +(ParameterizedThreadStart A_0, ParameterizedThreadStart A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ParameterizedThreadStart>();
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000084CF File Offset: 0x000066CF
		public static ParameterizedThreadStart operator -(ParameterizedThreadStart A_0, ParameterizedThreadStart A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ParameterizedThreadStart>();
			}
			return delegate2;
		}

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
