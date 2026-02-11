using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x020000F6 RID: 246
	public sealed class AIEvaluateSelection : MulticastDelegate
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x00047C08 File Offset: 0x00045E08
		// Note: this type is marked as 'beforefieldinit'.
		static AIEvaluateSelection()
		{
			Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "AIEvaluateSelection");
			AIEvaluateSelection.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr, 100665664);
			AIEvaluateSelection.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AIChoice_AIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr, 100665665);
			AIEvaluateSelection.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AIChoiceContext_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr, 100665666);
			AIEvaluateSelection.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AIChoice_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr, 100665667);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00047C80 File Offset: 0x00045E80
		[CallerCount(1058)]
		[CachedScanResults(RefRangeStart = 340122, RefRangeEnd = 341180, XrefRangeStart = 340122, XrefRangeEnd = 341180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIEvaluateSelection(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIEvaluateSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIEvaluateSelection.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00047CDC File Offset: 0x00045EDC
		[CallerCount(0)]
		public unsafe AIChoice Invoke(AIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIEvaluateSelection.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AIChoice_AIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00047D2C File Offset: 0x00045F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AIChoiceContext context, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIEvaluateSelection.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AIChoiceContext_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00047DA0 File Offset: 0x00045FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIChoice EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIEvaluateSelection.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AIChoice_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00005EF6 File Offset: 0x000040F6
		public AIEvaluateSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00005EFF File Offset: 0x000040FF
		public static implicit operator AIEvaluateSelection(Func<AIChoiceContext, AIChoice> A_0)
		{
			return DelegateSupport.ConvertDelegate<AIEvaluateSelection>(A_0);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00005F07 File Offset: 0x00004107
		public static AIEvaluateSelection operator +(AIEvaluateSelection A_0, AIEvaluateSelection A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AIEvaluateSelection>();
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00005F15 File Offset: 0x00004115
		public static AIEvaluateSelection operator -(AIEvaluateSelection A_0, AIEvaluateSelection A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AIEvaluateSelection>();
			}
			return delegate2;
		}

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AIChoice_AIChoiceContext_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AIChoiceContext_AsyncCallback_Object_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AIChoice_IAsyncResult_0;
	}
}
