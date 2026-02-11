using System;
using Canis.actions.completions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x02000187 RID: 391
	public sealed class CompletionGenerator : MulticastDelegate
	{
		// Token: 0x06001118 RID: 4376 RVA: 0x0005EB48 File Offset: 0x0005CD48
		// Note: this type is marked as 'beforefieldinit'.
		static CompletionGenerator()
		{
			Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "CompletionGenerator");
			CompletionGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr, 100666867);
			CompletionGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr, 100666868);
			CompletionGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr, 100666869);
			CompletionGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SelectionCompletion_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr, 100666870);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		[CallerCount(210)]
		[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompletionGenerator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompletionGenerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionGenerator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0005EC1C File Offset: 0x0005CE1C
		[CallerCount(0)]
		public unsafe SelectionCompletion Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionGenerator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_SelectionCompletion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0005EC5C File Offset: 0x0005CE5C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionGenerator.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005ECC0 File Offset: 0x0005CEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionCompletion EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompletionGenerator.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SelectionCompletion_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00008924 File Offset: 0x00006B24
		public CompletionGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0000892D File Offset: 0x00006B2D
		public static implicit operator CompletionGenerator(Func<SelectionCompletion> A_0)
		{
			return DelegateSupport.ConvertDelegate<CompletionGenerator>(A_0);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00008935 File Offset: 0x00006B35
		public static CompletionGenerator operator +(CompletionGenerator A_0, CompletionGenerator A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CompletionGenerator>();
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00008943 File Offset: 0x00006B43
		public static CompletionGenerator operator -(CompletionGenerator A_0, CompletionGenerator A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<CompletionGenerator>();
			}
			return delegate2;
		}

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_SelectionCompletion_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SelectionCompletion_IAsyncResult_0;
	}
}
