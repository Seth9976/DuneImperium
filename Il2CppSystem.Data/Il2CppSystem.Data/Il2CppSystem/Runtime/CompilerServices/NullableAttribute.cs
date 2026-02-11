using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000003 RID: 3
	public sealed class NullableAttribute : Attribute
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000082CC File Offset: 0x000064CC
		// Note: this type is marked as 'beforefieldinit'.
		static NullableAttribute()
		{
			Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Runtime.CompilerServices", "NullableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr);
			NullableAttribute.NativeFieldInfoPtr_NullableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, "NullableFlags");
			NullableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableAttribute>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00008324 File Offset: 0x00006524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886884, XrefRangeEnd = 886891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000006 RID: 6 RVA: 0x00002092 File Offset: 0x00000292
		public NullableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000836C File Offset: 0x0000656C
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000209B File Offset: 0x0000029B
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

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_NullableFlags;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
	}
}
