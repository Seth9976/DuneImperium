using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000058 RID: 88
	[Serializable]
	public class SerializedDictionary<K, V, SK, SV> : Dictionary<K, V>
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x00024B08 File Offset: 0x00022D08
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDictionary()
		{
			Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SerializedDictionary`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SK>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<SV>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr);
			SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, "m_Keys");
			SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, "m_Values");
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_SerializeKey_Public_Abstract_Virtual_New_SK_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664093);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_SerializeValue_Public_Abstract_Virtual_New_SV_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664094);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_DeserializeKey_Public_Abstract_Virtual_New_K_SK_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664095);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_DeserializeValue_Public_Abstract_Virtual_New_V_SV_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664096);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664097);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664098);
			SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr, 100664099);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00024C60 File Offset: 0x00022E60
		[CallerCount(0)]
		public unsafe virtual SK SerializeKey(K key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = key;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_SerializeKey_Public_Abstract_Virtual_New_SK_K_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<SK>(intPtr2, false, true);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00024CEC File Offset: 0x00022EEC
		[CallerCount(0)]
		public unsafe virtual SV SerializeValue(V value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = value;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_SerializeValue_Public_Abstract_Virtual_New_SV_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<SV>(intPtr2, false, true);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00024D78 File Offset: 0x00022F78
		[CallerCount(0)]
		public unsafe virtual K DeserializeKey(SK serializedKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(SK).IsValueType)
				{
					SK sk = serializedKey;
					intPtr = ((sk is string) ? IL2CPP.ManagedStringToIl2Cpp(sk as string) : IL2CPP.Il2CppObjectBaseToPtr(sk as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref serializedKey;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_DeserializeKey_Public_Abstract_Virtual_New_K_SK_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<K>(intPtr2, false, true);
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00024E04 File Offset: 0x00023004
		[CallerCount(0)]
		public unsafe virtual V DeserializeValue(SV serializedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(SV).IsValueType)
				{
					SV sv = serializedValue;
					intPtr = ((sv is string) ? IL2CPP.ManagedStringToIl2Cpp(sv as string) : IL2CPP.Il2CppObjectBaseToPtr(sv as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref serializedValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_DeserializeValue_Public_Abstract_Virtual_New_V_SV_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00024E90 File Offset: 0x00023090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960698, XrefRangeEnd = 960718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00024EC4 File Offset: 0x000230C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960718, XrefRangeEnd = 960725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00024EF8 File Offset: 0x000230F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960725, XrefRangeEnd = 960731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDictionary<K, V, SK, SV>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDictionary<K, V, SK, SV>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00004760 File Offset: 0x00002960
		public SerializedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00024F34 File Offset: 0x00023134
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00004769 File Offset: 0x00002969
		public unsafe List<SK> m_Keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SK>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00024F64 File Offset: 0x00023164
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe List<SV> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SV>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDictionary<K, V, SK, SV>.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_Keys;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_SerializeKey_Public_Abstract_Virtual_New_SK_K_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Public_Abstract_Virtual_New_SV_V_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeKey_Public_Abstract_Virtual_New_K_SK_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeValue_Public_Abstract_Virtual_New_V_SV_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
