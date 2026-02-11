using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.CodeDom.Compiler
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public class CompilerError : Object
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x000BB8C8 File Offset: 0x000B9AC8
		// Note: this type is marked as 'beforefieldinit'.
		static CompilerError()
		{
			Il2CppClassPointerStore<CompilerError>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.CodeDom.Compiler", "CompilerError");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilerError>.NativeClassPtr);
			CompilerError.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerError>.NativeClassPtr, 100669442);
			CompilerError.NativeMethodInfoPtr_set_ErrorText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerError>.NativeClassPtr, 100669443);
			CompilerError.NativeMethodInfoPtr_set_IsWarning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilerError>.NativeClassPtr, 100669444);
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000BB934 File Offset: 0x000B9B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 494176, RefRangeEnd = 494180, XrefRangeStart = 494173, XrefRangeEnd = 494176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompilerError()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilerError>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerError.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1D RID: 3357
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x000BB970 File Offset: 0x000B9B70
		public unsafe string ErrorText
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 494183, RefRangeEnd = 494187, XrefRangeStart = 494180, XrefRangeEnd = 494183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerError.NativeMethodInfoPtr_set_ErrorText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x000BB9B4 File Offset: 0x000B9BB4
		public unsafe bool IsWarning
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 494190, RefRangeEnd = 494192, XrefRangeStart = 494187, XrefRangeEnd = 494190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompilerError.NativeMethodInfoPtr_set_IsWarning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00011BD5 File Offset: 0x0000FDD5
		public CompilerError(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorText_Public_set_Void_String_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr_set_IsWarning_Public_set_Void_Boolean_0;
	}
}
