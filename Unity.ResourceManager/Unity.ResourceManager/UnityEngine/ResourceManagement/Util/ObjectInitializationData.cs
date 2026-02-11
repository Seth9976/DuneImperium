using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000027 RID: 39
	[Serializable]
	public sealed class ObjectInitializationData : ValueType
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectInitializationData()
		{
			Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "ObjectInitializationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr);
			ObjectInitializationData.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, "m_Id");
			ObjectInitializationData.NativeFieldInfoPtr_m_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, "m_ObjectType");
			ObjectInitializationData.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, "m_Data");
			ObjectInitializationData.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663646);
			ObjectInitializationData.NativeMethodInfoPtr_get_ObjectType_Public_get_SerializedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663647);
			ObjectInitializationData.NativeMethodInfoPtr_get_Data_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663648);
			ObjectInitializationData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663649);
			ObjectInitializationData.NativeMethodInfoPtr_CreateInstance_Public_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663650);
			ObjectInitializationData.NativeMethodInfoPtr_GetAsyncInitHandle_Public_AsyncOperationHandle_ResourceManager_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr, 100663651);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		public unsafe string Id
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		public unsafe SerializedType ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.NativeMethodInfoPtr_get_ObjectType_Public_get_SerializedType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SerializedType(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000CF24 File Offset: 0x0000B124
		public unsafe string Data
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.NativeMethodInfoPtr_get_Data_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000CF60 File Offset: 0x0000B160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138981, XrefRangeEnd = 1138987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000CF9C File Offset: 0x0000B19C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1139008, RefRangeEnd = 1139011, XrefRangeStart = 1138987, XrefRangeEnd = 1139008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TObject CreateInstance<TObject>(string idOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(idOverride);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.MethodInfoStoreGeneric_CreateInstance_Public_TObject_String_0<TObject>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1139031, RefRangeEnd = 1139032, XrefRangeStart = 1139011, XrefRangeEnd = 1139031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(idOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectInitializationData.NativeMethodInfoPtr_GetAsyncInitHandle_Public_AsyncOperationHandle_ResourceManager_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002D06 File Offset: 0x00000F06
		public ObjectInitializationData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002D0F File Offset: 0x00000F0F
		public ObjectInitializationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr))
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000D04C File Offset: 0x0000B24C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002D21 File Offset: 0x00000F21
		public unsafe string m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000D074 File Offset: 0x0000B274
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002D40 File Offset: 0x00000F40
		public SerializedType m_ObjectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_ObjectType);
				return new SerializedType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_ObjectType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SerializedType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D6E File Offset: 0x00000F6E
		public unsafe string m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_Data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectInitializationData.NativeFieldInfoPtr_m_Data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectType;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_SerializedType_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_TObject_String_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_GetAsyncInitHandle_Public_AsyncOperationHandle_ResourceManager_String_0;

		// Token: 0x0200007B RID: 123
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_TObject_String_0<TObject>
		{
			// Token: 0x0400046C RID: 1132
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectInitializationData.NativeMethodInfoPtr_CreateInstance_Public_TObject_String_0, Il2CppClassPointerStore<ObjectInitializationData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
