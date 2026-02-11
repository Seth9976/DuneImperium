using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200000D RID: 13
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x0600005F RID: 95 RVA: 0x00003844 File Offset: 0x00001A44
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100663361);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000038A8 File Offset: 0x00001AA8
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

	// Token: 0x06000061 RID: 97 RVA: 0x000022C5 File Offset: 0x000004C5
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000062 RID: 98 RVA: 0x000038EC File Offset: 0x00001AEC
	// (set) Token: 0x06000063 RID: 99 RVA: 0x000022CE File Offset: 0x000004CE
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3, (void*)(&value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000064 RID: 100 RVA: 0x00003908 File Offset: 0x00001B08
	// (set) Token: 0x06000065 RID: 101 RVA: 0x000022DC File Offset: 0x000004DC
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD, (void*)(&value));
		}
	}

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeFieldInfoPtr__09D2ED9309C892D5D24A15044E14AF3ADB4749982D8BFA05772B68FA800CDDC3;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeFieldInfoPtr__1885E1B437949FFA6C8F78DA3495E304168900044C4AF084C47794592F0C16BD;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000014 RID: 20
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=344")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002656 File Offset: 0x00000856
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=344");
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000266C File Offset: 0x0000086C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000015 RID: 21
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=464")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x0000267E File Offset: 0x0000087E
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=464");
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002694 File Offset: 0x00000894
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}
}
