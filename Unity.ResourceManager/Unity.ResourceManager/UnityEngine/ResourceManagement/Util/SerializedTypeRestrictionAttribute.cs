using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000023 RID: 35
	public class SerializedTypeRestrictionAttribute : Attribute
	{
		// Token: 0x060001DD RID: 477 RVA: 0x0000C454 File Offset: 0x0000A654
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedTypeRestrictionAttribute()
		{
			Il2CppClassPointerStore<SerializedTypeRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "SerializedTypeRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedTypeRestrictionAttribute>.NativeClassPtr);
			SerializedTypeRestrictionAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedTypeRestrictionAttribute>.NativeClassPtr, "type");
			SerializedTypeRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedTypeRestrictionAttribute>.NativeClassPtr, 100663628);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedTypeRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedTypeRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedTypeRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002BED File Offset: 0x00000DED
		public SerializedTypeRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTypeRestrictionAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedTypeRestrictionAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
