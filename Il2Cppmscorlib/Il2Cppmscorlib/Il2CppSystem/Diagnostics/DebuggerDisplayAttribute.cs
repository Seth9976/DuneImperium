using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004A3 RID: 1187
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		// Token: 0x0600498B RID: 18827 RVA: 0x00154E48 File Offset: 0x00153048
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerDisplayAttribute()
		{
			Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerDisplayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr);
			DebuggerDisplayAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "name");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "value");
			DebuggerDisplayAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, "type");
			DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, 100674008);
			DebuggerDisplayAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, 100674009);
			DebuggerDisplayAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr, 100674010);
		}

		// Token: 0x0600498C RID: 18828 RVA: 0x00154EF0 File Offset: 0x001530F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414250, XrefRangeEnd = 1414262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerDisplayAttribute(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerDisplayAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerDisplayAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012CF RID: 4815
		// (set) Token: 0x0600498D RID: 18829 RVA: 0x00154F3C File Offset: 0x0015313C
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerDisplayAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x00154F80 File Offset: 0x00153180
		public unsafe string Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerDisplayAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0001AE90 File Offset: 0x00019090
		public DebuggerDisplayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x00154FC4 File Offset: 0x001531C4
		// (set) Token: 0x06004991 RID: 18833 RVA: 0x0001AE99 File Offset: 0x00019099
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x00154FEC File Offset: 0x001531EC
		// (set) Token: 0x06004993 RID: 18835 RVA: 0x0001AEB8 File Offset: 0x000190B8
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004994 RID: 18836 RVA: 0x00155014 File Offset: 0x00153214
		// (set) Token: 0x06004995 RID: 18837 RVA: 0x0001AED7 File Offset: 0x000190D7
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebuggerDisplayAttribute.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C4D RID: 15437
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04003C4E RID: 15438
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04003C4F RID: 15439
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04003C50 RID: 15440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003C51 RID: 15441
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04003C52 RID: 15442
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_String_0;
	}
}
