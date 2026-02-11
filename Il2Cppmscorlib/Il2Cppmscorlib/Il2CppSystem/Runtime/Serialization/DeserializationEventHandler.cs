using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031B RID: 795
	public sealed class DeserializationEventHandler : MulticastDelegate
	{
		// Token: 0x060030B5 RID: 12469 RVA: 0x000F8390 File Offset: 0x000F6590
		// Note: this type is marked as 'beforefieldinit'.
		static DeserializationEventHandler()
		{
			Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "DeserializationEventHandler");
			DeserializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr, 100670971);
			DeserializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr, 100670972);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000F83E0 File Offset: 0x000F65E0
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x000F843C File Offset: 0x000F663C
		[CallerCount(0)]
		public unsafe void Invoke(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public DeserializationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00010C25 File Offset: 0x0000EE25
		public static implicit operator DeserializationEventHandler(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<DeserializationEventHandler>(A_0);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00010C2D File Offset: 0x0000EE2D
		public static DeserializationEventHandler operator +(DeserializationEventHandler A_0, DeserializationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DeserializationEventHandler>();
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00010C3B File Offset: 0x0000EE3B
		public static DeserializationEventHandler operator -(DeserializationEventHandler A_0, DeserializationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DeserializationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
