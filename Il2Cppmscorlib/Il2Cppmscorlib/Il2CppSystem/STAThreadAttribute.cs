using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EE RID: 238
	public sealed class STAThreadAttribute : Attribute
	{
		// Token: 0x06000F35 RID: 3893 RVA: 0x00005A46 File Offset: 0x00003C46
		// Note: this type is marked as 'beforefieldinit'.
		static STAThreadAttribute()
		{
			Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "STAThreadAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr);
			STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr, 100665955);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0006CF44 File Offset: 0x0006B144
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe STAThreadAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00005A7F File Offset: 0x00003C7F
		public STAThreadAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
