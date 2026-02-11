using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000227 RID: 551
	public sealed class SettingsSectionInternal : Object
	{
		// Token: 0x060024BF RID: 9407 RVA: 0x000A9470 File Offset: 0x000A7670
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSectionInternal()
		{
			Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr);
			SettingsSectionInternal.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "instance");
			SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "HttpListenerUnescapeRequestUrl");
			SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "IPProtectionLevel");
			SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100668748);
			SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100668749);
			SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100668750);
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x000A9518 File Offset: 0x000A7718
		public unsafe static SettingsSectionInternal Section
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487078, XrefRangeEnd = 487082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr3) : null;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000A954C File Offset: 0x000A774C
		public unsafe bool Ipv6Enabled
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000A9588 File Offset: 0x000A7788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487082, XrefRangeEnd = 487083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public SettingsSectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000A95C4 File Offset: 0x000A77C4
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0000FFB9 File Offset: 0x0000E1B9
		public unsafe static SettingsSectionInternal instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSectionInternal.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000A95EC File Offset: 0x000A77EC
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000FFCB File Offset: 0x0000E1CB
		public unsafe bool HttpListenerUnescapeRequestUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl)) = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000A9614 File Offset: 0x000A7814
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0000FFE6 File Offset: 0x0000E1E6
		public unsafe IPProtectionLevel IPProtectionLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSectionInternal.NativeFieldInfoPtr_IPProtectionLevel)) = value;
			}
		}

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeFieldInfoPtr_IPProtectionLevel;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
