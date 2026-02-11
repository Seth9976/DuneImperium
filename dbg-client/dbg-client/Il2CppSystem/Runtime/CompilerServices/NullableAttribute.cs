using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000004 RID: 4
	public sealed class NullableAttribute : Attribute
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0001D748 File Offset: 0x0001B948
		// Note: this type is marked as 'beforefieldinit'.
		static NullableAttribute()
		{
			Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "System.Runtime.CompilerServices", "NullableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr);
			NullableAttribute.NativeFieldInfoPtr_NullableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, "NullableFlags");
			NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, 100663304);
			NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494315, XrefRangeEnd = 494322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullableAttribute(byte A_1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0001D7FC File Offset: 0x0001B9FC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullableAttribute(Il2CppStructArray<byte> A_1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000209B File Offset: 0x0000029B
		public NullableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0001D848 File Offset: 0x0001BA48
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020A4 File Offset: 0x000002A4
		public unsafe Il2CppStructArray<byte> NullableFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableAttribute.NativeFieldInfoPtr_NullableFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NullableAttribute.NativeFieldInfoPtr_NullableFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_NullableFlags;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
