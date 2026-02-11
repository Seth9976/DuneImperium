using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000BC RID: 188
	public sealed class ScaleFunc : MulticastDelegate
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x0003DC24 File Offset: 0x0003BE24
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleFunc()
		{
			Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ScaleFunc");
			ScaleFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr, 100665221);
			ScaleFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr, 100665222);
			ScaleFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2Int_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr, 100665223);
			ScaleFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2Int_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr, 100665224);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0003DC9C File Offset: 0x0003BE9C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 972515, RefRangeEnd = 972523, XrefRangeStart = 972512, XrefRangeEnd = 972515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleFunc(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleFunc>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0003DCF8 File Offset: 0x0003BEF8
		[CallerCount(0)]
		public unsafe Vector2Int Invoke(Vector2Int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0003DD44 File Offset: 0x0003BF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972523, XrefRangeEnd = 972527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Vector2Int size, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2Int_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0003DDB4 File Offset: 0x0003BFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2Int_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00007D84 File Offset: 0x00005F84
		public ScaleFunc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00007D8D File Offset: 0x00005F8D
		public static implicit operator ScaleFunc(Func<Vector2Int, Vector2Int> A_0)
		{
			return DelegateSupport.ConvertDelegate<ScaleFunc>(A_0);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00007D95 File Offset: 0x00005F95
		public static ScaleFunc operator +(ScaleFunc A_0, ScaleFunc A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ScaleFunc>();
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public static ScaleFunc operator -(ScaleFunc A_0, ScaleFunc A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ScaleFunc>();
			}
			return delegate2;
		}

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector2Int_Vector2Int_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2Int_AsyncCallback_Object_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector2Int_IAsyncResult_0;
	}
}
