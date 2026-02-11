using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace validators
{
	// Token: 0x02000017 RID: 23
	public class RuntimePlatformValidator : MonoBehaviour
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00004B38 File Offset: 0x00002D38
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimePlatformValidator()
		{
			Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("validators.dll", "validators", "RuntimePlatformValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr);
			RuntimePlatformValidator.NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, "disable");
			RuntimePlatformValidator.NativeFieldInfoPtr_platforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, "platforms");
			RuntimePlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, "<Valid>k__BackingField");
			RuntimePlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, 100663373);
			RuntimePlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, 100663374);
			RuntimePlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, 100663375);
			RuntimePlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr, 100663376);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004BF4 File Offset: 0x00002DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267754, XrefRangeEnd = 1267761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePlatformValidator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00004C28 File Offset: 0x00002E28
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePlatformValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePlatformValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004CA4 File Offset: 0x00002EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267761, XrefRangeEnd = 1267769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimePlatformValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimePlatformValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimePlatformValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000257F File Offset: 0x0000077F
		public RuntimePlatformValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004CE0 File Offset: 0x00002EE0
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe bool disable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr_disable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr_disable)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004D08 File Offset: 0x00002F08
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000025A3 File Offset: 0x000007A3
		public unsafe Il2CppStructArray<RuntimePlatform> platforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr_platforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimePlatform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr_platforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004D38 File Offset: 0x00002F38
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000025C2 File Offset: 0x000007C2
		public unsafe bool _Valid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimePlatformValidator.NativeFieldInfoPtr__Valid_k__BackingField)) = value;
			}
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_disable;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_platforms;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__Valid_k__BackingField;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
