using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.CSharp
{
	// Token: 0x02000004 RID: 4
	public class CSharpCodeProvider : CodeDomProvider
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000020B8 File Offset: 0x000002B8
		// Note: this type is marked as 'beforefieldinit'.
		static CSharpCodeProvider()
		{
			Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "Microsoft.CSharp", "CSharpCodeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr);
			CSharpCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00016478 File Offset: 0x00014678
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CSharpCodeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSharpCodeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSharpCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020F1 File Offset: 0x000002F1
		public CSharpCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
