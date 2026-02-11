using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011C RID: 284
	[Serializable]
	public sealed class OperatingSystem : Object
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x0007F650 File Offset: 0x0007D850
		// Note: this type is marked as 'beforefieldinit'.
		static OperatingSystem()
		{
			Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperatingSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr);
			OperatingSystem.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_version");
			OperatingSystem.NativeFieldInfoPtr__platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_platform");
			OperatingSystem.NativeFieldInfoPtr__servicePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_servicePack");
			OperatingSystem.NativeFieldInfoPtr__versionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_versionString");
			OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666554);
			OperatingSystem.NativeMethodInfoPtr__ctor_Internal_Void_PlatformID_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666555);
			OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666556);
			OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666557);
			OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666558);
			OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666559);
			OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666560);
			OperatingSystem.NativeMethodInfoPtr_get_VersionString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666561);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0007F770 File Offset: 0x0007D970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334787, RefRangeEnd = 1334788, XrefRangeStart = 1334786, XrefRangeEnd = 1334787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(PlatformID platform, Version version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0007F7CC File Offset: 0x0007D9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334809, RefRangeEnd = 1334811, XrefRangeStart = 1334788, XrefRangeEnd = 1334809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(PlatformID platform, Version version, string servicePack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(servicePack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Internal_Void_PlatformID_Version_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x0007F838 File Offset: 0x0007DA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334811, XrefRangeEnd = 1334816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x0007F894 File Offset: 0x0007DA94
		public unsafe PlatformID Platform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0007F8D0 File Offset: 0x0007DAD0
		public unsafe Version Version
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0007F910 File Offset: 0x0007DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334816, XrefRangeEnd = 1334820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0007F950 File Offset: 0x0007DB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334820, XrefRangeEnd = 1334821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0007F988 File Offset: 0x0007DB88
		public unsafe string VersionString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1334857, RefRangeEnd = 1334858, XrefRangeStart = 1334821, XrefRangeEnd = 1334857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_VersionString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0000618F File Offset: 0x0000438F
		public OperatingSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0007F9C0 File Offset: 0x0007DBC0
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00006198 File Offset: 0x00004398
		public unsafe Version _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0007F9F0 File Offset: 0x0007DBF0
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x000061B7 File Offset: 0x000043B7
		public unsafe PlatformID _platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0007FA18 File Offset: 0x0007DC18
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x000061D2 File Offset: 0x000043D2
		public unsafe string _servicePack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x0007FA40 File Offset: 0x0007DC40
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x000061F1 File Offset: 0x000043F1
		public unsafe string _versionString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__versionString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__versionString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr__platform;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr__servicePack;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr__versionString;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlatformID_Version_String_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_get_VersionString_Public_get_String_0;
	}
}
