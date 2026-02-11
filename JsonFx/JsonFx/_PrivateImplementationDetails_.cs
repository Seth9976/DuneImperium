using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200003A RID: 58
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x0600031A RID: 794 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100663773);
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000F518 File Offset: 0x0000D718
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 282344, RefRangeEnd = 282378, XrefRangeStart = 282344, XrefRangeEnd = 282378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeStringHash(string s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000325F File Offset: 0x0000145F
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x0600031D RID: 797 RVA: 0x0000F55C File Offset: 0x0000D75C
	// (set) Token: 0x0600031E RID: 798 RVA: 0x00003268 File Offset: 0x00001468
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B, (void*)(&value));
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x0600031F RID: 799 RVA: 0x0000F578 File Offset: 0x0000D778
	// (set) Token: 0x06000320 RID: 800 RVA: 0x00003276 File Offset: 0x00001476
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67, (void*)(&value));
		}
	}

	// Token: 0x04000210 RID: 528
	private static readonly IntPtr NativeFieldInfoPtr__07BFA18C3A8A17061773778A93AE90C85455A08B0661DA49722F7BA7982CDF0B;

	// Token: 0x04000211 RID: 529
	private static readonly IntPtr NativeFieldInfoPtr_DBE1B61839B05CE3E8B3CB8BA29B423AF6D4E2FC351B43F20E70F3F8B5A84E67;

	// Token: 0x04000212 RID: 530
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000054 RID: 84
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=1977")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00003C88 File Offset: 0x00001E88
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=1977");
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003C9E File Offset: 0x00001E9E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000055 RID: 85
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=2720")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00003CB0 File Offset: 0x00001EB0
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=2720");
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00003CC6 File Offset: 0x00001EC6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
