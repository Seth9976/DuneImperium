using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.CSharp
{
	// Token: 0x02000003 RID: 3
	public class CodeDomProvider : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002076 File Offset: 0x00000276
		// Note: this type is marked as 'beforefieldinit'.
		static CodeDomProvider()
		{
			Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "Microsoft.CSharp", "CodeDomProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr);
			CodeDomProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0001643C File Offset: 0x0001463C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CodeDomProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodeDomProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CodeDomProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020AF File Offset: 0x000002AF
		public CodeDomProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
