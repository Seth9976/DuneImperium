using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000222 RID: 546
	public sealed class Win32_IP_ADDR_STRING : ValueType
	{
		// Token: 0x060024A5 RID: 9381 RVA: 0x000A90A8 File Offset: 0x000A72A8
		// Note: this type is marked as 'beforefieldinit'.
		static Win32_IP_ADDR_STRING()
		{
			Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32_IP_ADDR_STRING");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr);
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Next");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpAddress");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "IpMask");
			Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr, "Context");
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0000FEA5 File Offset: 0x0000E0A5
		public Win32_IP_ADDR_STRING(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0000FEAE File Offset: 0x0000E0AE
		public Win32_IP_ADDR_STRING()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32_IP_ADDR_STRING>.NativeClassPtr))
		{
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000A9128 File Offset: 0x000A7328
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		public unsafe IntPtr Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Next)) = value;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000A9150 File Offset: 0x000A7350
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0000FEDB File Offset: 0x0000E0DB
		public unsafe string IpAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000A9178 File Offset: 0x000A7378
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0000FEFA File Offset: 0x0000E0FA
		public unsafe string IpMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_IpMask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000A91A0 File Offset: 0x000A73A0
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0000FF19 File Offset: 0x0000E119
		public unsafe uint Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Win32_IP_ADDR_STRING.NativeFieldInfoPtr_Context)) = value;
			}
		}

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeFieldInfoPtr_IpAddress;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeFieldInfoPtr_IpMask;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_Context;
	}
}
