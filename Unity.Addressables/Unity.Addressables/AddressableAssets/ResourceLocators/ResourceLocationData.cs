using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x02000023 RID: 35
	[Serializable]
	public class ResourceLocationData : Object
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x00010EFC File Offset: 0x0000F0FC
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocationData()
		{
			Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "ResourceLocationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr);
			ResourceLocationData.NativeFieldInfoPtr_m_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "m_Keys");
			ResourceLocationData.NativeFieldInfoPtr_m_InternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "m_InternalId");
			ResourceLocationData.NativeFieldInfoPtr_m_Provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "m_Provider");
			ResourceLocationData.NativeFieldInfoPtr_m_Dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "m_Dependencies");
			ResourceLocationData.NativeFieldInfoPtr_m_ResourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "m_ResourceType");
			ResourceLocationData.NativeFieldInfoPtr_SerializedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "SerializedData");
			ResourceLocationData.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, "_Data");
			ResourceLocationData.NativeMethodInfoPtr_get_Keys_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663862);
			ResourceLocationData.NativeMethodInfoPtr_get_InternalId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663863);
			ResourceLocationData.NativeMethodInfoPtr_get_Provider_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663864);
			ResourceLocationData.NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663865);
			ResourceLocationData.NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663866);
			ResourceLocationData.NativeMethodInfoPtr_get_Data_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663867);
			ResourceLocationData.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663868);
			ResourceLocationData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_String_Type_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr, 100663869);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00011058 File Offset: 0x0000F258
		public unsafe Il2CppStringArray Keys
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_Keys_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00011098 File Offset: 0x0000F298
		public unsafe string InternalId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_InternalId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x000110D0 File Offset: 0x0000F2D0
		public unsafe string Provider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_Provider_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00011108 File Offset: 0x0000F308
		public unsafe Il2CppStringArray Dependencies
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00011148 File Offset: 0x0000F348
		public unsafe Type ResourceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164226, XrefRangeEnd = 1164227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00011188 File Offset: 0x0000F388
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x000111C8 File Offset: 0x0000F3C8
		public unsafe Object Data
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1164229, RefRangeEnd = 1164231, XrefRangeStart = 1164227, XrefRangeEnd = 1164229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_get_Data_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164231, XrefRangeEnd = 1164243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001120C File Offset: 0x0000F40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164243, XrefRangeEnd = 1164260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationData(Il2CppStringArray keys, string id, Type provider, Type t, Il2CppStringArray dependencies = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocationData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_String_Type_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002E4D File Offset: 0x0000104D
		public ResourceLocationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000112A4 File Offset: 0x0000F4A4
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00002E56 File Offset: 0x00001056
		public unsafe Il2CppStringArray m_Keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000112D4 File Offset: 0x0000F4D4
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00002E75 File Offset: 0x00001075
		public unsafe string m_InternalId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_InternalId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_InternalId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000112FC File Offset: 0x0000F4FC
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002E94 File Offset: 0x00001094
		public unsafe string m_Provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Provider);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Provider), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00011324 File Offset: 0x0000F524
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00002EB3 File Offset: 0x000010B3
		public unsafe Il2CppStringArray m_Dependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Dependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_Dependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00011354 File Offset: 0x0000F554
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00002ED2 File Offset: 0x000010D2
		public SerializedType m_ResourceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_ResourceType);
				return new SerializedType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_m_ResourceType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00011384 File Offset: 0x0000F584
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002F00 File Offset: 0x00001100
		public unsafe Il2CppStructArray<byte> SerializedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_SerializedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr_SerializedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000113B4 File Offset: 0x0000F5B4
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00002F1F File Offset: 0x0000111F
		public unsafe Object _Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr__Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationData.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_m_Keys;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalId;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_m_Provider;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_m_Dependencies;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceType;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_SerializedData;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr__Data;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_Il2CppStringArray_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_get_String_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_Provider_Public_get_String_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_get_Il2CppStringArray_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_get_Type_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Object_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_String_Type_Type_Il2CppStringArray_0;
	}
}
