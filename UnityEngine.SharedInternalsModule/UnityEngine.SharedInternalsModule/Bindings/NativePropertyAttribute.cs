using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000010 RID: 16
	public class NativePropertyAttribute : NativeMethodAttribute
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003894 File Offset: 0x00001A94
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyAttribute()
		{
			Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativePropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr);
			NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, "<TargetType>k__BackingField");
			NativePropertyAttribute.NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663329);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663330);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663331);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663332);
			NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr, 100663333);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000247C File Offset: 0x0000067C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000393C File Offset: 0x00001B3C
		public unsafe TargetType TargetType
		{
			get
			{
				return this._TargetType_k__BackingField;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000397C File Offset: 0x00001B7C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269103, XrefRangeEnd = 1269104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003A04 File Offset: 0x00001C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269104, XrefRangeEnd = 1269105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute(string name, bool isFree, TargetType targetType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003A6C File Offset: 0x00001C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269105, XrefRangeEnd = 1269106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativePropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFree;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativePropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002458 File Offset: 0x00000658
		public NativePropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003AE4 File Offset: 0x00001CE4
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002461 File Offset: 0x00000661
		public unsafe TargetType _TargetType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativePropertyAttribute.NativeFieldInfoPtr__TargetType_k__BackingField)) = value;
			}
		}

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr__TargetType_k__BackingField;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetType_Public_set_Void_TargetType_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_TargetType_Boolean_0;
	}
}
