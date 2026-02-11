using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009F RID: 159
	public class DisposeHelper : Object
	{
		// Token: 0x06000FD7 RID: 4055 RVA: 0x0000805A File Offset: 0x0000625A
		// Note: this type is marked as 'beforefieldinit'.
		static DisposeHelper()
		{
			Il2CppClassPointerStore<DisposeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DisposeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposeHelper>.NativeClassPtr);
			DisposeHelper.NativeMethodInfoPtr_NotifyDisposedUsed_Public_Static_Void_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposeHelper>.NativeClassPtr, 100665585);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00054A84 File Offset: 0x00052C84
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 308606, RefRangeEnd = 308614, XrefRangeStart = 308595, XrefRangeEnd = 308606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDisposedUsed(IDisposable disposable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(disposable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposeHelper.NativeMethodInfoPtr_NotifyDisposedUsed_Public_Static_Void_IDisposable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00008093 File Offset: 0x00006293
		public DisposeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00054ABC File Offset: 0x00052CBC
		public static void NotifyMissingDispose(IDisposable disposable)
		{
			bool flag = disposable == null;
			if (!flag)
			{
				Debug.LogError(String.Concat("An IDisposable instance of type '", disposable.GetType().FullName, "' has not been disposed."));
			}
		}

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDisposedUsed_Public_Static_Void_IDisposable_0;
	}
}
