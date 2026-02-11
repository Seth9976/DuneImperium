using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020002A9 RID: 681
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06001BBE RID: 7102 RVA: 0x0006D780 File Offset: 0x0006B980
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100667348);
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x0006D7F8 File Offset: 0x0006B9F8
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

	// Token: 0x06001BC0 RID: 7104 RVA: 0x0000FFDD File Offset: 0x0000E1DD
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000784 RID: 1924
	// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0006D83C File Offset: 0x0006BA3C
	// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000FFE6 File Offset: 0x0000E1E6
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208, (void*)(&value));
		}
	}

	// Token: 0x17000785 RID: 1925
	// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0006D858 File Offset: 0x0006BA58
	// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304, (void*)(&value));
		}
	}

	// Token: 0x17000786 RID: 1926
	// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0006D874 File Offset: 0x0006BA74
	// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00010002 File Offset: 0x0000E202
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 valueTypeNPrivateSealed;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02, (void*)(&valueTypeNPrivateSealed));
			return valueTypeNPrivateSealed;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr_DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02, (void*)(&value));
		}
	}

	// Token: 0x04001007 RID: 4103
	private static readonly IntPtr NativeFieldInfoPtr__96CB801B2E11EE0811BAB347F5C71F071169C475AAF85A859A69E4E8EC055208;

	// Token: 0x04001008 RID: 4104
	private static readonly IntPtr NativeFieldInfoPtr_D338C7CFBD24E8741DD131258566A2A6062F965C156F701C380EE71B840DE304;

	// Token: 0x04001009 RID: 4105
	private static readonly IntPtr NativeFieldInfoPtr_DDBE409A74860917B21D5065EFB5477B1A2FFB899A7590EECD7216C9C949DE02;

	// Token: 0x0400100A RID: 4106
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x02000447 RID: 1095
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=16")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed0
	{
		// Token: 0x06002D74 RID: 11636 RVA: 0x00018A01 File Offset: 0x00016C01
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=16");
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00018A17 File Offset: 0x00016C17
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000448 RID: 1096
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=38025")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed1
	{
		// Token: 0x06002D76 RID: 11638 RVA: 0x00018A29 File Offset: 0x00016C29
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=38025");
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x00018A3F File Offset: 0x00016C3F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
		}
	}

	// Token: 0x02000449 RID: 1097
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=55366")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealed2
	{
		// Token: 0x06002D78 RID: 11640 RVA: 0x00018A51 File Offset: 0x00016C51
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealed2()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=55366");
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00018A67 File Offset: 0x00016C67
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
		}
	}
}
