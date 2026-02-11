using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000274 RID: 628
	public class RC2Transform : SymmetricTransform
	{
		// Token: 0x06002892 RID: 10386 RVA: 0x000DA6D0 File Offset: 0x000D88D0
		// Note: this type is marked as 'beforefieldinit'.
		static RC2Transform()
		{
			Il2CppClassPointerStore<RC2Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RC2Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr);
			RC2Transform.NativeFieldInfoPtr_R0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R0");
			RC2Transform.NativeFieldInfoPtr_R1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R1");
			RC2Transform.NativeFieldInfoPtr_R2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R2");
			RC2Transform.NativeFieldInfoPtr_R3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "R3");
			RC2Transform.NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "K");
			RC2Transform.NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "j");
			RC2Transform.NativeFieldInfoPtr_pitable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, "pitable");
			RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100669952);
			RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr, 100669953);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000DA7B4 File Offset: 0x000D89B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374894, RefRangeEnd = 1374896, XrefRangeStart = 1374866, XrefRangeEnd = 1374894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RC2Transform(RC2 rc2Algo, bool encryption, Il2CppStructArray<byte> key, Il2CppStructArray<byte> iv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RC2Transform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rc2Algo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RC2Transform.NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000DA834 File Offset: 0x000D8A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374896, XrefRangeEnd = 1374897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RC2Transform.NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0000D5A6 File Offset: 0x0000B7A6
		public RC2Transform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000DA894 File Offset: 0x000D8A94
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x0000D5AF File Offset: 0x0000B7AF
		public unsafe ushort R0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R0)) = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000DA8BC File Offset: 0x000D8ABC
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0000D5CA File Offset: 0x0000B7CA
		public unsafe ushort R1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R1)) = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000DA8E4 File Offset: 0x000D8AE4
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x0000D5E5 File Offset: 0x0000B7E5
		public unsafe ushort R2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R2)) = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000DA90C File Offset: 0x000D8B0C
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x0000D600 File Offset: 0x0000B800
		public unsafe ushort R3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_R3)) = value;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000DA934 File Offset: 0x000D8B34
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x0000D61B File Offset: 0x0000B81B
		public unsafe Il2CppStructArray<ushort> K
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_K), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000DA964 File Offset: 0x000D8B64
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0000D63A File Offset: 0x0000B83A
		public unsafe int j
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RC2Transform.NativeFieldInfoPtr_j)) = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000DA98C File Offset: 0x000D8B8C
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x0000D655 File Offset: 0x0000B855
		public unsafe static Il2CppStructArray<byte> pitable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RC2Transform.NativeFieldInfoPtr_pitable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RC2Transform.NativeFieldInfoPtr_pitable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeFieldInfoPtr_R0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeFieldInfoPtr_R1;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeFieldInfoPtr_R2;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeFieldInfoPtr_R3;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeFieldInfoPtr_K;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeFieldInfoPtr_j;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeFieldInfoPtr_pitable;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RC2_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;
	}
}
