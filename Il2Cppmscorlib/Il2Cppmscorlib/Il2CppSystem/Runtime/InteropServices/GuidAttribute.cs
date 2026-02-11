using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200038C RID: 908
	public sealed class GuidAttribute : Attribute
	{
		// Token: 0x060037B6 RID: 14262 RVA: 0x001103A4 File Offset: 0x0010E5A4
		// Note: this type is marked as 'beforefieldinit'.
		static GuidAttribute()
		{
			Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "GuidAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr);
			GuidAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, "_val");
			GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr, 100671635);
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x001103FC File Offset: 0x0010E5FC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuidAttribute(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuidAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00014603 File Offset: 0x00012803
		public GuidAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x00110448 File Offset: 0x0010E648
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x0001460C File Offset: 0x0001280C
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuidAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D8F RID: 11663
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x04002D90 RID: 11664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
