using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D6 RID: 214
	public class XmlIncludeAttribute : Attribute
	{
		// Token: 0x06001400 RID: 5120 RVA: 0x0006C9CC File Offset: 0x0006ABCC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIncludeAttribute()
		{
			Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlIncludeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr);
			XmlIncludeAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr, "type");
			XmlIncludeAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIncludeAttribute>.NativeClassPtr, 100666498);
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0006CA24 File Offset: 0x0006AC24
		public unsafe Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIncludeAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0000888C File Offset: 0x00006A8C
		public XmlIncludeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0006CA64 File Offset: 0x0006AC64
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x00008895 File Offset: 0x00006A95
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIncludeAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIncludeAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;
	}
}
