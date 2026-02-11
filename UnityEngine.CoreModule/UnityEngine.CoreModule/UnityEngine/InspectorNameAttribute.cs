using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010E RID: 270
	public class InspectorNameAttribute : PropertyAttribute
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x0006C9F0 File Offset: 0x0006ABF0
		// Note: this type is marked as 'beforefieldinit'.
		static InspectorNameAttribute()
		{
			Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InspectorNameAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr);
			InspectorNameAttribute.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, "displayName");
			InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, 100666426);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0006CA48 File Offset: 0x0006AC48
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InspectorNameAttribute(string displayName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00008DCB File Offset: 0x00006FCB
		public InspectorNameAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x0006CA94 File Offset: 0x0006AC94
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00008DD4 File Offset: 0x00006FD4
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
