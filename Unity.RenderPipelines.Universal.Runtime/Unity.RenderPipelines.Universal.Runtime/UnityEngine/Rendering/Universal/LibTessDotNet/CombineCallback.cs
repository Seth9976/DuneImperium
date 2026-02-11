using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x02000115 RID: 277
	public sealed class CombineCallback : MulticastDelegate
	{
		// Token: 0x06001715 RID: 5909 RVA: 0x00062B18 File Offset: 0x00060D18
		// Note: this type is marked as 'beforefieldinit'.
		static CombineCallback()
		{
			Il2CppClassPointerStore<CombineCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "CombineCallback");
			CombineCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineCallback>.NativeClassPtr, 100666018);
			CombineCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineCallback>.NativeClassPtr, 100666019);
			CombineCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineCallback>.NativeClassPtr, 100666020);
			CombineCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineCallback>.NativeClassPtr, 100666021);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00062B90 File Offset: 0x00060D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 624326, RefRangeEnd = 624327, XrefRangeStart = 624323, XrefRangeEnd = 624326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombineCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombineCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00062BEC File Offset: 0x00060DEC
		[CallerCount(0)]
		public unsafe Object Invoke(Vec3 position, Il2CppReferenceArray<Object> data, Il2CppStructArray<float> weights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00062C5C File Offset: 0x00060E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 624327, XrefRangeEnd = 624331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Vec3 position, Il2CppReferenceArray<Object> data, Il2CppStructArray<float> weights, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(weights);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00062CF4 File Offset: 0x00060EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0000D402 File Offset: 0x0000B602
		public CombineCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0000D40B File Offset: 0x0000B60B
		public static implicit operator CombineCallback(Func<Vec3, Il2CppReferenceArray<Object>, Il2CppStructArray<float>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<CombineCallback>(A_0);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0000D413 File Offset: 0x0000B613
		public static CombineCallback operator +(CombineCallback A_0, CombineCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CombineCallback>();
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0000D421 File Offset: 0x0000B621
		public static CombineCallback operator -(CombineCallback A_0, CombineCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CombineCallback>();
			}
			return delegate2;
		}

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vec3_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Single_AsyncCallback_Object_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0;
	}
}
