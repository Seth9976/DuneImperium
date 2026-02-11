using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000121 RID: 289
	public class AsyncInstantiateOperationHelper : Object
	{
		// Token: 0x06001748 RID: 5960 RVA: 0x00009295 File Offset: 0x00007495
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncInstantiateOperationHelper()
		{
			Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr);
			AsyncInstantiateOperationHelper.NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr, 100666493);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660478, XrefRangeEnd = 660480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, Il2CppReferenceArray<Object> result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperationHelper.NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000092CE File Offset: 0x000074CE
		public AsyncInstantiateOperationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_SetAsyncInstantiateOperationResult_Public_Static_Void_AsyncInstantiateOperation_Il2CppReferenceArray_1_Object_0;
	}
}
