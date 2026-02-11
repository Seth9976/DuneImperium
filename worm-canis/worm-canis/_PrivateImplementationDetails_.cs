using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200054E RID: 1358
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06004056 RID: 16470 RVA: 0x00176500 File Offset: 0x00174700
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100684554);
	}

	// Token: 0x06004057 RID: 16471 RVA: 0x001765A0 File Offset: 0x001747A0
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 282344, RefRangeEnd = 282378, XrefRangeStart = 282342, XrefRangeEnd = 282344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	// Token: 0x06004058 RID: 16472 RVA: 0x000144EB File Offset: 0x000126EB
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000EEE RID: 3822
	// (get) Token: 0x06004059 RID: 16473 RVA: 0x001765E4 File Offset: 0x001747E4
	// (set) Token: 0x0600405A RID: 16474 RVA: 0x000144F4 File Offset: 0x000126F4
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257, (void*)(&value));
		}
	}

	// Token: 0x17000EEF RID: 3823
	// (get) Token: 0x0600405B RID: 16475 RVA: 0x00176600 File Offset: 0x00174800
	// (set) Token: 0x0600405C RID: 16476 RVA: 0x00014502 File Offset: 0x00012702
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 _76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7, (void*)(&value));
		}
	}

	// Token: 0x17000EF0 RID: 3824
	// (get) Token: 0x0600405D RID: 16477 RVA: 0x0017661C File Offset: 0x0017481C
	// (set) Token: 0x0600405E RID: 16478 RVA: 0x00014510 File Offset: 0x00012710
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443, (void*)(&value));
		}
	}

	// Token: 0x17000EF1 RID: 3825
	// (get) Token: 0x0600405F RID: 16479 RVA: 0x00176638 File Offset: 0x00174838
	// (set) Token: 0x06004060 RID: 16480 RVA: 0x0001451E File Offset: 0x0001271E
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12, (void*)(&value));
		}
	}

	// Token: 0x17000EF2 RID: 3826
	// (get) Token: 0x06004061 RID: 16481 RVA: 0x00176654 File Offset: 0x00174854
	// (set) Token: 0x06004062 RID: 16482 RVA: 0x0001452C File Offset: 0x0001272C
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449, (void*)(&value));
		}
	}

	// Token: 0x04002ACC RID: 10956
	private static readonly IntPtr NativeFieldInfoPtr__0ACE3C4A50C5657C0ABAD3E8681E32013039576B48DBE2166405F5939E727257;

	// Token: 0x04002ACD RID: 10957
	private static readonly IntPtr NativeFieldInfoPtr__76365A67C27F798C7D3B29B153AABF7E61AC607D9182921C7BB9DEE19CC2ABC7;

	// Token: 0x04002ACE RID: 10958
	private static readonly IntPtr NativeFieldInfoPtr__9D26B14DB54658DE70051F001E42176710B9247648D3D3190A627C6360EE5443;

	// Token: 0x04002ACF RID: 10959
	private static readonly IntPtr NativeFieldInfoPtr_A5820A03D19E53063FF53151624F652304A9F06B885FDACDAF7DA388BE6C6E12;

	// Token: 0x04002AD0 RID: 10960
	private static readonly IntPtr NativeFieldInfoPtr_BE5332D71DCF09D7B05FF43DB0F3BE230C47974FFC3258BE2FE2E1FDCBE93449;

	// Token: 0x04002AD1 RID: 10961
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000CFC RID: 3324
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=16")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x0600D9C2 RID: 55746 RVA: 0x00068D85 File Offset: 0x00066F85
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=16");
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x00068D9B File Offset: 0x00066F9B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000CFD RID: 3325
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=88714")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x0600D9C4 RID: 55748 RVA: 0x00068DAD File Offset: 0x00066FAD
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=88714");
		}

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x00068DC3 File Offset: 0x00066FC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000CFE RID: 3326
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=107676")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed2
	{
		// Token: 0x0600D9C6 RID: 55750 RVA: 0x00068DD5 File Offset: 0x00066FD5
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed2()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=107676");
		}

		// Token: 0x0600D9C7 RID: 55751 RVA: 0x00068DEB File Offset: 0x00066FEB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
		}
	}
}
