using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200029E RID: 670
	public class FormatterData : ProviderData
	{
		// Token: 0x06002B07 RID: 11015 RVA: 0x0000E5FC File Offset: 0x0000C7FC
		// Note: this type is marked as 'beforefieldinit'.
		static FormatterData()
		{
			Il2CppClassPointerStore<FormatterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "FormatterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatterData>.NativeClassPtr);
			FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatterData>.NativeClassPtr, 100670267);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000E38D0 File Offset: 0x000E1AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormatterData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatterData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormatterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x0000E635 File Offset: 0x0000C835
		public FormatterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400247B RID: 9339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
