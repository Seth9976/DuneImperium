using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000014 RID: 20
	public class NotNullAttribute : Attribute
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00003EAC File Offset: 0x000020AC
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr);
			NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, "<Exception>k__BackingField");
			NotNullAttribute.NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663342);
			NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663343);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003F18 File Offset: 0x00002118
		public unsafe string Exception
		{
			get
			{
				return this._Exception_k__BackingField;
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003F5C File Offset: 0x0000215C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullAttribute(string exception = "ArgumentNullException")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002540 File Offset: 0x00000740
		public NotNullAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003FA8 File Offset: 0x000021A8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002549 File Offset: 0x00000749
		public unsafe string _Exception_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotNullAttribute.NativeFieldInfoPtr__Exception_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__Exception_k__BackingField;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_set_Exception_Public_set_Void_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
