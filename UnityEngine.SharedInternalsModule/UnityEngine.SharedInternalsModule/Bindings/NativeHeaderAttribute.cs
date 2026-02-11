using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000B RID: 11
	public class NativeHeaderAttribute : Attribute
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000309C File Offset: 0x0000129C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeHeaderAttribute()
		{
			Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeHeaderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr);
			NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, "<Header>k__BackingField");
			NativeHeaderAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, 100663314);
			NativeHeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr, 100663315);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000231E File Offset: 0x0000051E
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00003108 File Offset: 0x00001308
		public unsafe virtual string Header
		{
			get
			{
				return this._Header_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeHeaderAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000314C File Offset: 0x0000134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269039, XrefRangeEnd = 1269057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeHeaderAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeHeaderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeHeaderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022F6 File Offset: 0x000004F6
		public NativeHeaderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000022FF File Offset: 0x000004FF
		public unsafe string _Header_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeHeaderAttribute.NativeFieldInfoPtr__Header_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr__Header_k__BackingField;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
