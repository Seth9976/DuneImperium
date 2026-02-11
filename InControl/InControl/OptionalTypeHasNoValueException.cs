using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000064 RID: 100
	public class OptionalTypeHasNoValueException : SystemException
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x00005CB3 File Offset: 0x00003EB3
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalTypeHasNoValueException()
		{
			Il2CppClassPointerStore<OptionalTypeHasNoValueException>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "OptionalTypeHasNoValueException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalTypeHasNoValueException>.NativeClassPtr);
			OptionalTypeHasNoValueException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalTypeHasNoValueException>.NativeClassPtr, 100664510);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00028E1C File Offset: 0x0002701C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451998, RefRangeEnd = 452001, XrefRangeStart = 451998, XrefRangeEnd = 452001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalTypeHasNoValueException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalTypeHasNoValueException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalTypeHasNoValueException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00005CEC File Offset: 0x00003EEC
		public OptionalTypeHasNoValueException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
