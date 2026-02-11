using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015D RID: 349
	public sealed class TimeMsFunction : MulticastDelegate
	{
		// Token: 0x0600197A RID: 6522 RVA: 0x00077408 File Offset: 0x00075608
		// Note: this type is marked as 'beforefieldinit'.
		static TimeMsFunction()
		{
			Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimeMsFunction");
			TimeMsFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr, 100667045);
			TimeMsFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr, 100667046);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00077458 File Offset: 0x00075658
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320756, XrefRangeEnd = 320759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeMsFunction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeMsFunction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeMsFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000774B4 File Offset: 0x000756B4
		[CallerCount(0)]
		public unsafe long Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeMsFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0000B97E File Offset: 0x00009B7E
		public TimeMsFunction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0000B987 File Offset: 0x00009B87
		public static implicit operator TimeMsFunction(Func<long> A_0)
		{
			return DelegateSupport.ConvertDelegate<TimeMsFunction>(A_0);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0000B98F File Offset: 0x00009B8F
		public static TimeMsFunction operator +(TimeMsFunction A_0, TimeMsFunction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TimeMsFunction>();
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0000B99D File Offset: 0x00009B9D
		public static TimeMsFunction operator -(TimeMsFunction A_0, TimeMsFunction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TimeMsFunction>();
			}
			return delegate2;
		}

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int64_0;
	}
}
