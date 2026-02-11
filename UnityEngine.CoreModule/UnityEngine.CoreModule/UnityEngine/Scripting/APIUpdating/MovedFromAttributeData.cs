using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020001BB RID: 443
	public sealed class MovedFromAttributeData : ValueType
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x0008F5C0 File Offset: 0x0008D7C0
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttributeData()
		{
			Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
			MovedFromAttributeData.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "className");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpace");
			MovedFromAttributeData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assembly");
			MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "classHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpaceHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assemblyHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "autoUdpateAPI");
			MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100667678);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0008F690 File Offset: 0x0008D890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680053, RefRangeEnd = 680054, XrefRangeStart = 680050, XrefRangeEnd = 680053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoUpdateAPI;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0000C321 File Offset: 0x0000A521
		public MovedFromAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0000C32A File Offset: 0x0000A52A
		public MovedFromAttributeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0008F70C File Offset: 0x0008D90C
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x0000C33C File Offset: 0x0000A53C
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0008F734 File Offset: 0x0008D934
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x0000C35B File Offset: 0x0000A55B
		public unsafe string nameSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0008F75C File Offset: 0x0008D95C
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0000C37A File Offset: 0x0000A57A
		public unsafe string assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0008F784 File Offset: 0x0008D984
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x0000C399 File Offset: 0x0000A599
		public unsafe bool classHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged)) = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0008F7AC File Offset: 0x0008D9AC
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0000C3B4 File Offset: 0x0000A5B4
		public unsafe bool nameSpaceHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0008F7D4 File Offset: 0x0008D9D4
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0000C3CF File Offset: 0x0000A5CF
		public unsafe bool assemblyHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged)) = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0008F7FC File Offset: 0x0008D9FC
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0000C3EA File Offset: 0x0000A5EA
		public unsafe bool autoUdpateAPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI)) = value;
			}
		}

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_classHasChanged;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_assemblyHasChanged;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_autoUdpateAPI;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;
	}
}
