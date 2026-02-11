using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003BF RID: 959
	[Serializable]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x00015287 File Offset: 0x00013487
		// Note: this type is marked as 'beforefieldinit'.
		static IteratorStateMachineAttribute()
		{
			Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IteratorStateMachineAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr);
			IteratorStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr, 100671831);
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x001151E4 File Offset: 0x001133E4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IteratorStateMachineAttribute(Type stateMachineType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IteratorStateMachineAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IteratorStateMachineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x000152C0 File Offset: 0x000134C0
		public IteratorStateMachineAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
