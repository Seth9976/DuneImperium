using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000043 RID: 67
	public sealed class IsExternalInit : Attribute
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x00002CC8 File Offset: 0x00000EC8
		// Note: this type is marked as 'beforefieldinit'.
		static IsExternalInit()
		{
			Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "System.Runtime.CompilerServices", "IsExternalInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr);
			IsExternalInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr, 100663915);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000F660 File Offset: 0x0000D860
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsExternalInit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsExternalInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002D01 File Offset: 0x00000F01
		public IsExternalInit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
