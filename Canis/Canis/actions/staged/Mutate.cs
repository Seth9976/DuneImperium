using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions.staged
{
	// Token: 0x02000207 RID: 519
	public sealed class Mutate : MulticastDelegate
	{
		// Token: 0x060015FF RID: 5631 RVA: 0x00071C3C File Offset: 0x0006FE3C
		// Note: this type is marked as 'beforefieldinit'.
		static Mutate()
		{
			Il2CppClassPointerStore<Mutate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.staged", "Mutate");
			Mutate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutate>.NativeClassPtr, 100668289);
			Mutate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutate>.NativeClassPtr, 100668290);
			Mutate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutate>.NativeClassPtr, 100668291);
			Mutate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mutate>.NativeClassPtr, 100668292);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00071CB4 File Offset: 0x0006FEB4
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mutate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mutate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00071D10 File Offset: 0x0006FF10
		[CallerCount(0)]
		public unsafe void Invoke(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00071D54 File Offset: 0x0006FF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Match match, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00071DC8 File Offset: 0x0006FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mutate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0000AA59 File Offset: 0x00008C59
		public Mutate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0000AA62 File Offset: 0x00008C62
		public static implicit operator Mutate(Action<Match> A_0)
		{
			return DelegateSupport.ConvertDelegate<Mutate>(A_0);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000AA6A File Offset: 0x00008C6A
		public static Mutate operator +(Mutate A_0, Mutate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Mutate>();
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000AA78 File Offset: 0x00008C78
		public static Mutate operator -(Mutate A_0, Mutate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Mutate>();
			}
			return delegate2;
		}

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Match_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Match_AsyncCallback_Object_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
