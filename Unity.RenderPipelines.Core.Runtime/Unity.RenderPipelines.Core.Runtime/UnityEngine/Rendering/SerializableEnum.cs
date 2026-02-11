using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000056 RID: 86
	[Serializable]
	public class SerializableEnum : Object
	{
		// Token: 0x06000611 RID: 1553 RVA: 0x0002460C File Offset: 0x0002280C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableEnum()
		{
			Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SerializableEnum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr);
			SerializableEnum.NativeFieldInfoPtr_m_EnumValueAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, "m_EnumValueAsString");
			SerializableEnum.NativeFieldInfoPtr_m_EnumTypeAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, "m_EnumTypeAsString");
			SerializableEnum.NativeMethodInfoPtr_get_value_Public_get_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664085);
			SerializableEnum.NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664086);
			SerializableEnum.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664087);
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000246A0 File Offset: 0x000228A0
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000246DC File Offset: 0x000228DC
		public unsafe Enum value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960667, XrefRangeEnd = 960681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEnum.NativeMethodInfoPtr_get_value_Public_get_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960681, XrefRangeEnd = 960683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEnum.NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0002471C File Offset: 0x0002291C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960683, XrefRangeEnd = 960692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableEnum(Type enumType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableEnum.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00004710 File Offset: 0x00002910
		public SerializableEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00024768 File Offset: 0x00022968
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00004719 File Offset: 0x00002919
		public unsafe string m_EnumValueAsString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEnum.NativeFieldInfoPtr_m_EnumValueAsString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEnum.NativeFieldInfoPtr_m_EnumValueAsString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00024790 File Offset: 0x00022990
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00004738 File Offset: 0x00002938
		public unsafe string m_EnumTypeAsString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEnum.NativeFieldInfoPtr_m_EnumTypeAsString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableEnum.NativeFieldInfoPtr_m_EnumTypeAsString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumValueAsString;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumTypeAsString;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Enum_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
