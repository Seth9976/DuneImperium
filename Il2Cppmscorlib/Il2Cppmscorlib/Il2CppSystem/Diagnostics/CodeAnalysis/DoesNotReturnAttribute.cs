using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.CodeAnalysis
{
	// Token: 0x020004B4 RID: 1204
	public sealed class DoesNotReturnAttribute : Attribute
	{
		// Token: 0x06004A30 RID: 18992 RVA: 0x0001B353 File Offset: 0x00019553
		// Note: this type is marked as 'beforefieldinit'.
		static DoesNotReturnAttribute()
		{
			Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "DoesNotReturnAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr);
			DoesNotReturnAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr, 100674084);
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x001572BC File Offset: 0x001554BC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoesNotReturnAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoesNotReturnAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoesNotReturnAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x0001B38C File Offset: 0x0001958C
		public DoesNotReturnAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
