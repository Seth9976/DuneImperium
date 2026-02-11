using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031C RID: 796
	public sealed class SerializationEventHandler : MulticastDelegate
	{
		// Token: 0x060030BC RID: 12476 RVA: 0x000F8480 File Offset: 0x000F6680
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventHandler()
		{
			Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEventHandler");
			SerializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr, 100670973);
			SerializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr, 100670974);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000F84D0 File Offset: 0x000F66D0
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 677891, RefRangeEnd = 677960, XrefRangeStart = 677891, XrefRangeEnd = 677960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x000F852C File Offset: 0x000F672C
		[CallerCount(0)]
		public unsafe void Invoke(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public SerializationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00010C55 File Offset: 0x0000EE55
		public static implicit operator SerializationEventHandler(Action<StreamingContext> A_0)
		{
			return DelegateSupport.ConvertDelegate<SerializationEventHandler>(A_0);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x00010C5D File Offset: 0x0000EE5D
		public static SerializationEventHandler operator +(SerializationEventHandler A_0, SerializationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SerializationEventHandler>();
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00010C6B File Offset: 0x0000EE6B
		public static SerializationEventHandler operator -(SerializationEventHandler A_0, SerializationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SerializationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0;
	}
}
