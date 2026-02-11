using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x02000091 RID: 145
	public sealed class SwitchLevelAttribute : Attribute
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00045158 File Offset: 0x00043358
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchLevelAttribute()
		{
			Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "SwitchLevelAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr);
			SwitchLevelAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr, "type");
			SwitchLevelAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr, 100664911);
			SwitchLevelAttribute.NativeMethodInfoPtr_set_SwitchLevelType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr, 100664912);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000451C4 File Offset: 0x000433C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442755, XrefRangeEnd = 442767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchLevelAttribute(Type switchLevelType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchLevelAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(switchLevelType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchLevelAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000315 RID: 789
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00045210 File Offset: 0x00043410
		public unsafe Type SwitchLevelType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442767, XrefRangeEnd = 442788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchLevelAttribute.NativeMethodInfoPtr_set_SwitchLevelType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00005C8D File Offset: 0x00003E8D
		public SwitchLevelAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00045254 File Offset: 0x00043454
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00005C96 File Offset: 0x00003E96
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchLevelAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchLevelAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_set_SwitchLevelType_Public_set_Void_Type_0;
	}
}
