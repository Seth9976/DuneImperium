using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F8 RID: 760
	[Serializable]
	public class Header : Object
	{
		// Token: 0x06002EFD RID: 12029 RVA: 0x000F2088 File Offset: 0x000F0288
		// Note: this type is marked as 'beforefieldinit'.
		static Header()
		{
			Il2CppClassPointerStore<Header>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "Header");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Header>.NativeClassPtr);
			Header.NativeFieldInfoPtr_HeaderNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "HeaderNamespace");
			Header.NativeFieldInfoPtr_MustUnderstand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "MustUnderstand");
			Header.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "Name");
			Header.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "Value");
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public Header(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x000F2108 File Offset: 0x000F0308
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x0000FF95 File Offset: 0x0000E195
		public unsafe string HeaderNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_HeaderNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_HeaderNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x000F2130 File Offset: 0x000F0330
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		public unsafe bool MustUnderstand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_MustUnderstand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_MustUnderstand)) = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x000F2158 File Offset: 0x000F0358
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x0000FFCF File Offset: 0x0000E1CF
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x000F2180 File Offset: 0x000F0380
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x0000FFEE File Offset: 0x0000E1EE
		public unsafe Object Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Header.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeFieldInfoPtr_HeaderNamespace;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeFieldInfoPtr_MustUnderstand;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
