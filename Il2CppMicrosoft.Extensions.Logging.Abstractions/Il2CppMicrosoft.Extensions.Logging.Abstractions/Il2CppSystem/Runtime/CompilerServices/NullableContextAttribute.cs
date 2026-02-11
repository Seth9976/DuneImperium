using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000006 RID: 6
	public sealed class NullableContextAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000028F4 File Offset: 0x00000AF4
		// Note: this type is marked as 'beforefieldinit'.
		static NullableContextAttribute()
		{
			Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Runtime.CompilerServices", "NullableContextAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr);
			NullableContextAttribute.NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, "Flag");
			NullableContextAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000294C File Offset: 0x00000B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullableContextAttribute(byte A_1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableContextAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000213E File Offset: 0x0000033E
		public NullableContextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002994 File Offset: 0x00000B94
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002147 File Offset: 0x00000347
		public unsafe byte Flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableContextAttribute.NativeFieldInfoPtr_Flag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableContextAttribute.NativeFieldInfoPtr_Flag)) = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_Flag;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
	}
}
