using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000057 RID: 87
	[Serializable]
	public class SerializedDictionary<K, V> : SerializedDictionary<K, V, K, V>
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000247B8 File Offset: 0x000229B8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDictionary()
		{
			Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SerializedDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr);
			SerializedDictionary<K, V>.NativeMethodInfoPtr_SerializeKey_Public_Virtual_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr, 100664088);
			SerializedDictionary<K, V>.NativeMethodInfoPtr_SerializeValue_Public_Virtual_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr, 100664089);
			SerializedDictionary<K, V>.NativeMethodInfoPtr_DeserializeKey_Public_Virtual_K_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr, 100664090);
			SerializedDictionary<K, V>.NativeMethodInfoPtr_DeserializeValue_Public_Virtual_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr, 100664091);
			SerializedDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr, 100664092);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0002489C File Offset: 0x00022A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960692, XrefRangeEnd = 960695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override K SerializeKey(K key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V>.NativeMethodInfoPtr_SerializeKey_Public_Virtual_K_K_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<K>(intPtr2, false, true);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00024928 File Offset: 0x00022B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960695, XrefRangeEnd = 960698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override V SerializeValue(V val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = val;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V>.NativeMethodInfoPtr_SerializeValue_Public_Virtual_V_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000249B4 File Offset: 0x00022BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override K DeserializeKey(K key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V>.NativeMethodInfoPtr_DeserializeKey_Public_Virtual_K_K_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<K>(intPtr2, false, true);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00024A40 File Offset: 0x00022C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override V DeserializeValue(V val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = val;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDictionary<K, V>.NativeMethodInfoPtr_DeserializeValue_Public_Virtual_V_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00024ACC File Offset: 0x00022CCC
		[CallerCount(0)]
		public unsafe SerializedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDictionary<K, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00004757 File Offset: 0x00002957
		public SerializedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_SerializeKey_Public_Virtual_K_K_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_V_V_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeKey_Public_Virtual_K_K_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeValue_Public_Virtual_V_V_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
