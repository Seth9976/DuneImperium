using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200000D RID: 13
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06000085 RID: 133 RVA: 0x00004314 File Offset: 0x00002514
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-data.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100663377);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00004378 File Offset: 0x00002578
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

	// Token: 0x06000087 RID: 135 RVA: 0x00002388 File Offset: 0x00000588
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000088 RID: 136 RVA: 0x000043BC File Offset: 0x000025BC
	// (set) Token: 0x06000089 RID: 137 RVA: 0x00002391 File Offset: 0x00000591
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704, (void*)(&value));
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600008A RID: 138 RVA: 0x000043D8 File Offset: 0x000025D8
	// (set) Token: 0x0600008B RID: 139 RVA: 0x0000239F File Offset: 0x0000059F
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C, (void*)(&value));
		}
	}

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeFieldInfoPtr__5BF897A8BBE60CECD7B94C09A61E7075E4A43B6C3B5FCF74CA514D8AC88DF704;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeFieldInfoPtr_BA643E841AD0A9DD57030F8ED0594B9D0C0DABFE60D48D21DD806D0D609CA44C;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000014 RID: 20
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=558")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002548 File Offset: 0x00000748
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=558");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000255E File Offset: 0x0000075E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000015 RID: 21
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=593")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00002570 File Offset: 0x00000770
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=593");
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002586 File Offset: 0x00000786
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
