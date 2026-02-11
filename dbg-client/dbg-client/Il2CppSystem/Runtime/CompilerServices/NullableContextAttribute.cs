using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000005 RID: 5
	public sealed class NullableContextAttribute : Attribute
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0001D878 File Offset: 0x0001BA78
		// Note: this type is marked as 'beforefieldinit'.
		static NullableContextAttribute()
		{
			Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "System.Runtime.CompilerServices", "NullableContextAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr);
			NullableContextAttribute.NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, "Flag");
			NullableContextAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0001D8D0 File Offset: 0x0001BAD0
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

		// Token: 0x06000018 RID: 24 RVA: 0x000020C3 File Offset: 0x000002C3
		public NullableContextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0001D918 File Offset: 0x0001BB18
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020CC File Offset: 0x000002CC
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

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_Flag;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
	}
}
