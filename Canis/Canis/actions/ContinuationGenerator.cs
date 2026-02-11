using System;
using Canis.actions.continuations;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x02000186 RID: 390
	public sealed class ContinuationGenerator : MulticastDelegate
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x0005E980 File Offset: 0x0005CB80
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuationGenerator()
		{
			Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ContinuationGenerator");
			ContinuationGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr, 100666863);
			ContinuationGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr, 100666864);
			ContinuationGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr, 100666865);
			ContinuationGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ActionContinuation_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr, 100666866);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0005E9F8 File Offset: 0x0005CBF8
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinuationGenerator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationGenerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0005EA54 File Offset: 0x0005CC54
		[CallerCount(0)]
		public unsafe ActionContinuation Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ActionContinuation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005EA94 File Offset: 0x0005CC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583232, XrefRangeEnd = 583233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005EAF8 File Offset: 0x0005CCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionContinuation EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinuationGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ActionContinuation_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000088F4 File Offset: 0x00006AF4
		public ContinuationGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x000088FD File Offset: 0x00006AFD
		public static implicit operator ContinuationGenerator(Func<ActionContinuation> A_0)
		{
			return DelegateSupport.ConvertDelegate<ContinuationGenerator>(A_0);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00008905 File Offset: 0x00006B05
		public static ContinuationGenerator operator +(ContinuationGenerator A_0, ContinuationGenerator A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ContinuationGenerator>();
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00008913 File Offset: 0x00006B13
		public static ContinuationGenerator operator -(ContinuationGenerator A_0, ContinuationGenerator A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ContinuationGenerator>();
			}
			return delegate2;
		}

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ActionContinuation_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ActionContinuation_IAsyncResult_0;
	}
}
