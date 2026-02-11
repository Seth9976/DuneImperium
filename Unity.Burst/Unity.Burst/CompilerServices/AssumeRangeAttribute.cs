using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000024 RID: 36
	public class AssumeRangeAttribute : Attribute
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0000DE10 File Offset: 0x0000C010
		// Note: this type is marked as 'beforefieldinit'.
		static AssumeRangeAttribute()
		{
			Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "AssumeRangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr);
			AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr, 100666930);
			AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr, 100666931);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000DE68 File Offset: 0x0000C068
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssumeRangeAttribute(long min, long max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssumeRangeAttribute(ulong min, ulong max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssumeRangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssumeRangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002DC5 File Offset: 0x00000FC5
		public AssumeRangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;
	}
}
