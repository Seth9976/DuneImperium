using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F9 RID: 1017
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		// Token: 0x06003B81 RID: 15233 RVA: 0x0011DAB0 File Offset: 0x0011BCB0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyDelaySignAttribute()
		{
			Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDelaySignAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr);
			AssemblyDelaySignAttribute.NativeFieldInfoPtr__DelaySign_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, "<DelaySign>k__BackingField");
			AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, 100672174);
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x0011DB08 File Offset: 0x0011BD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyDelaySignAttribute(bool delaySign)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delaySign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyDelaySignAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x00016298 File Offset: 0x00014498
		public AssemblyDelaySignAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x0011DB50 File Offset: 0x0011BD50
		// (set) Token: 0x06003B85 RID: 15237 RVA: 0x000162A1 File Offset: 0x000144A1
		public unsafe bool _DelaySign_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr__DelaySign_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyDelaySignAttribute.NativeFieldInfoPtr__DelaySign_k__BackingField)) = value;
			}
		}

		// Token: 0x0400301A RID: 12314
		private static readonly IntPtr NativeFieldInfoPtr__DelaySign_k__BackingField;

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
	}
}
