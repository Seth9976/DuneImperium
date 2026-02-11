using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000004 RID: 4
	public sealed class NullableContextAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002704 File Offset: 0x00000904
		// Note: this type is marked as 'beforefieldinit'.
		static NullableContextAttribute()
		{
			Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "System.Runtime.CompilerServices", "NullableContextAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr);
			NullableContextAttribute.NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, "Flag");
			NullableContextAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000275C File Offset: 0x0000095C
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

		// Token: 0x0600000C RID: 12 RVA: 0x000020BA File Offset: 0x000002BA
		public NullableContextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000027A4 File Offset: 0x000009A4
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020C3 File Offset: 0x000002C3
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

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_Flag;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
	}
}
