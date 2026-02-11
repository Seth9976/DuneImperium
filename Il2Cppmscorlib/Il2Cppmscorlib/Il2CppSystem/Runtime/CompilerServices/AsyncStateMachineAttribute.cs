using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003A9 RID: 937
	[Serializable]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x060038BC RID: 14524 RVA: 0x00014D24 File Offset: 0x00012F24
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncStateMachineAttribute()
		{
			Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncStateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr);
			AsyncStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr, 100671775);
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00113DEC File Offset: 0x00111FEC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncStateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncStateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00014D5D File Offset: 0x00012F5D
		public AsyncStateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
