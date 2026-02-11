using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003B3 RID: 947
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		// Token: 0x06003901 RID: 14593 RVA: 0x00114BB8 File Offset: 0x00112DB8
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalConstantAttribute()
		{
			Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DecimalConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr);
			DecimalConstantAttribute.NativeFieldInfoPtr__dec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, "_dec");
			DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100671810);
			DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100671811);
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00114C24 File Offset: 0x00112E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392926, XrefRangeEnd = 1392928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref low;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x00114CA4 File Offset: 0x00112EA4
		public unsafe Decimal Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00014FE9 File Offset: 0x000131E9
		public DecimalConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x00114CE0 File Offset: 0x00112EE0
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x00014FF2 File Offset: 0x000131F2
		public unsafe Decimal _dec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr__dec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr__dec)) = value;
			}
		}

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr__dec;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;
	}
}
