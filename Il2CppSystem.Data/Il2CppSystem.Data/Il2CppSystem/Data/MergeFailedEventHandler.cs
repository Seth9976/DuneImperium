using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000067 RID: 103
	public sealed class MergeFailedEventHandler : MulticastDelegate
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x00033750 File Offset: 0x00031950
		// Note: this type is marked as 'beforefieldinit'.
		static MergeFailedEventHandler()
		{
			Il2CppClassPointerStore<MergeFailedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "MergeFailedEventHandler");
			MergeFailedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeFailedEventHandler>.NativeClassPtr, 100664928);
			MergeFailedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_MergeFailedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeFailedEventHandler>.NativeClassPtr, 100664929);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000337A0 File Offset: 0x000319A0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MergeFailedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MergeFailedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeFailedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000337FC File Offset: 0x000319FC
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, MergeFailedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MergeFailedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_MergeFailedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00004FD2 File Offset: 0x000031D2
		public MergeFailedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00004FDB File Offset: 0x000031DB
		public static implicit operator MergeFailedEventHandler(Action<Object, MergeFailedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<MergeFailedEventHandler>(A_0);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00004FE3 File Offset: 0x000031E3
		public static MergeFailedEventHandler operator +(MergeFailedEventHandler A_0, MergeFailedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MergeFailedEventHandler>();
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00004FF1 File Offset: 0x000031F1
		public static MergeFailedEventHandler operator -(MergeFailedEventHandler A_0, MergeFailedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MergeFailedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_MergeFailedEventArgs_0;
	}
}
