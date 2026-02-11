using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x0200001F RID: 31
	public class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000048A4 File Offset: 0x00002AA4
		// Note: this type is marked as 'beforefieldinit'.
		static RequiredByNativeCodeAttribute()
		{
			Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Scripting", "RequiredByNativeCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr);
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<Name>k__BackingField");
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<Optional>k__BackingField");
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<GenerateProxy>k__BackingField");
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663362);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663363);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663364);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663365);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663366);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004974 File Offset: 0x00002B74
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiredByNativeCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000049B0 File Offset: 0x00002BB0
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiredByNativeCodeAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000027CB File Offset: 0x000009CB
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000049FC File Offset: 0x00002BFC
		public unsafe string Name
		{
			get
			{
				return this._Name_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000027D3 File Offset: 0x000009D3
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe bool Optional
		{
			get
			{
				return this._Optional_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000027DB File Offset: 0x000009DB
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00004A80 File Offset: 0x00002C80
		public unsafe bool GenerateProxy
		{
			get
			{
				return this._GenerateProxy_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000276D File Offset: 0x0000096D
		public RequiredByNativeCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004AC0 File Offset: 0x00002CC0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002776 File Offset: 0x00000976
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00004AE8 File Offset: 0x00002CE8
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002795 File Offset: 0x00000995
		public unsafe bool _Optional_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00004B10 File Offset: 0x00002D10
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000027B0 File Offset: 0x000009B0
		public unsafe bool _GenerateProxy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField)) = value;
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__Optional_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr__GenerateProxy_k__BackingField;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0;
	}
}
