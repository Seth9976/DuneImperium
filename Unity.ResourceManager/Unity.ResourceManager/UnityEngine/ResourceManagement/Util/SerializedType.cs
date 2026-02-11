using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000026 RID: 38
	[Serializable]
	public sealed class SerializedType : ValueType
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedType()
		{
			Il2CppClassPointerStore<SerializedType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "SerializedType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedType>.NativeClassPtr);
			SerializedType.NativeFieldInfoPtr_m_AssemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, "m_AssemblyName");
			SerializedType.NativeFieldInfoPtr_m_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, "m_ClassName");
			SerializedType.NativeFieldInfoPtr_m_CachedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, "m_CachedType");
			SerializedType.NativeFieldInfoPtr__ValueChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, "<ValueChanged>k__BackingField");
			SerializedType.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663639);
			SerializedType.NativeMethodInfoPtr_get_ClassName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663640);
			SerializedType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663641);
			SerializedType.NativeMethodInfoPtr_get_Value_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663642);
			SerializedType.NativeMethodInfoPtr_set_Value_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663643);
			SerializedType.NativeMethodInfoPtr_get_ValueChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663644);
			SerializedType.NativeMethodInfoPtr_set_ValueChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, 100663645);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000CB58 File Offset: 0x0000AD58
		public unsafe string AssemblyName
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000CB94 File Offset: 0x0000AD94
		public unsafe string ClassName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_get_ClassName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138935, XrefRangeEnd = 1138942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public unsafe Type Value
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1138962, RefRangeEnd = 1138970, XrefRangeStart = 1138942, XrefRangeEnd = 1138962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_get_Value_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1138979, RefRangeEnd = 1138981, XrefRangeStart = 1138970, XrefRangeEnd = 1138979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_set_Value_Public_set_Void_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000CC98 File Offset: 0x0000AE98
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		public unsafe bool ValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_get_ValueChanged_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedType.NativeMethodInfoPtr_set_ValueChanged_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002C73 File Offset: 0x00000E73
		public SerializedType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002C7C File Offset: 0x00000E7C
		public SerializedType()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedType>.NativeClassPtr))
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000CD20 File Offset: 0x0000AF20
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002C8E File Offset: 0x00000E8E
		public unsafe string m_AssemblyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_AssemblyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_AssemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000CD48 File Offset: 0x0000AF48
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002CAD File Offset: 0x00000EAD
		public unsafe string m_ClassName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_ClassName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_ClassName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000CD70 File Offset: 0x0000AF70
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002CCC File Offset: 0x00000ECC
		public unsafe Type m_CachedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_CachedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr_m_CachedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002CEB File Offset: 0x00000EEB
		public unsafe bool _ValueChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr__ValueChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedType.NativeFieldInfoPtr__ValueChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_m_AssemblyName;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_ClassName;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedType;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr__ValueChanged_k__BackingField;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyName_Public_get_String_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassName_Public_get_String_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Type_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Type_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueChanged_Public_get_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueChanged_Public_set_Void_Boolean_0;
	}
}
