using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000005 RID: 5
	public sealed class NullableAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000027C4 File Offset: 0x000009C4
		// Note: this type is marked as 'beforefieldinit'.
		static NullableAttribute()
		{
			Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "System.Runtime.CompilerServices", "NullableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr);
			NullableAttribute.NativeFieldInfoPtr_NullableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, "NullableFlags");
			NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, 100663300);
			NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, 100663301);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002830 File Offset: 0x00000A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264441, XrefRangeEnd = 1264448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600000C RID: 12 RVA: 0x00002878 File Offset: 0x00000A78
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

		// Token: 0x0600000D RID: 13 RVA: 0x00002116 File Offset: 0x00000316
		public NullableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000211F File Offset: 0x0000031F
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

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_NullableFlags;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;
	}
}
