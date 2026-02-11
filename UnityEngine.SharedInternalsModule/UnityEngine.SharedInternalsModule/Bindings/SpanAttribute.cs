using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001D RID: 29
	public class SpanAttribute : Attribute
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00004618 File Offset: 0x00002818
		// Note: this type is marked as 'beforefieldinit'.
		static SpanAttribute()
		{
			Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "SpanAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr);
			SpanAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr, "<IsReadOnly>k__BackingField");
			SpanAttribute.NativeFieldInfoPtr__SizeParameter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr, "<SizeParameter>k__BackingField");
			SpanAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr, 100663358);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004684 File Offset: 0x00002884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269132, XrefRangeEnd = 1269134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpanAttribute(string sizeParameter, bool isReadOnly = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpanAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sizeParameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReadOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000026EA File Offset: 0x000008EA
		public SpanAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000046E0 File Offset: 0x000028E0
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000026F3 File Offset: 0x000008F3
		public unsafe bool _IsReadOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpanAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpanAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004708 File Offset: 0x00002908
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000270E File Offset: 0x0000090E
		public unsafe string _SizeParameter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpanAttribute.NativeFieldInfoPtr__SizeParameter_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpanAttribute.NativeFieldInfoPtr__SizeParameter_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000272D File Offset: 0x0000092D
		public bool IsReadOnly
		{
			get
			{
				return this._IsReadOnly_k__BackingField;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002735 File Offset: 0x00000935
		public string SizeParameter
		{
			get
			{
				return this._SizeParameter_k__BackingField;
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__IsReadOnly_k__BackingField;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__SizeParameter_k__BackingField;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
	}
}
