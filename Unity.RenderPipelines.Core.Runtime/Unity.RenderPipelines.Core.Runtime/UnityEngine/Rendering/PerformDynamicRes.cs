using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000041 RID: 65
	public sealed class PerformDynamicRes : MulticastDelegate
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00020B30 File Offset: 0x0001ED30
		// Note: this type is marked as 'beforefieldinit'.
		static PerformDynamicRes()
		{
			Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "PerformDynamicRes");
			PerformDynamicRes.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr, 100663961);
			PerformDynamicRes.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr, 100663962);
			PerformDynamicRes.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr, 100663963);
			PerformDynamicRes.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr, 100663964);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 959837, RefRangeEnd = 959915, XrefRangeStart = 959834, XrefRangeEnd = 959837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformDynamicRes(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformDynamicRes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformDynamicRes.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00020C04 File Offset: 0x0001EE04
		[CallerCount(0)]
		public unsafe float Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformDynamicRes.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00020C40 File Offset: 0x0001EE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformDynamicRes.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00020CA4 File Offset: 0x0001EEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959915, XrefRangeEnd = 959917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformDynamicRes.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000040CE File Offset: 0x000022CE
		public PerformDynamicRes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000040D7 File Offset: 0x000022D7
		public static implicit operator PerformDynamicRes(Func<float> A_0)
		{
			return DelegateSupport.ConvertDelegate<PerformDynamicRes>(A_0);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000040DF File Offset: 0x000022DF
		public static PerformDynamicRes operator +(PerformDynamicRes A_0, PerformDynamicRes A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PerformDynamicRes>();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000040ED File Offset: 0x000022ED
		public static PerformDynamicRes operator -(PerformDynamicRes A_0, PerformDynamicRes A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PerformDynamicRes>();
			}
			return delegate2;
		}

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
	}
}
