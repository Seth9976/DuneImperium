using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D9 RID: 217
	[StructLayout(2)]
	public struct HashFNV1A32
	{
		// Token: 0x06001002 RID: 4098 RVA: 0x0004A3B8 File Offset: 0x000485B8
		// Note: this type is marked as 'beforefieldinit'.
		static HashFNV1A32()
		{
			Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HashFNV1A32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr);
			HashFNV1A32.NativeFieldInfoPtr_k_Prime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "k_Prime");
			HashFNV1A32.NativeFieldInfoPtr_k_OffsetBasis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "k_OffsetBasis");
			HashFNV1A32.NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "m_Hash");
			HashFNV1A32.NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665673);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665674);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665675);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665676);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665677);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665678);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665679);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665680);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665681);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665682);
			HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665683);
			HashFNV1A32.NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665684);
			HashFNV1A32.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665685);
			HashFNV1A32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100665686);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004A53C File Offset: 0x0004873C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 977313, RefRangeEnd = 977316, XrefRangeStart = 977313, XrefRangeEnd = 977313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashFNV1A32 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0004A56C File Offset: 0x0004876C
		[CallerCount(0)]
		public unsafe void Append([In] ref int input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004A5A0 File Offset: 0x000487A0
		[CallerCount(0)]
		public unsafe void Append([In] ref uint input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0004A5D4 File Offset: 0x000487D4
		[CallerCount(0)]
		public unsafe void Append([In] ref bool input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0004A608 File Offset: 0x00048808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977316, XrefRangeEnd = 977317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append([In] ref float input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0004A63C File Offset: 0x0004883C
		[CallerCount(0)]
		public unsafe void Append([In] ref double input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0004A670 File Offset: 0x00048870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977317, XrefRangeEnd = 977319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append([In] ref Vector2 input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0004A6A4 File Offset: 0x000488A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977319, XrefRangeEnd = 977322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append([In] ref Vector3 input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0004A6D8 File Offset: 0x000488D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977322, XrefRangeEnd = 977326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append([In] ref Vector4 input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0004A70C File Offset: 0x0004890C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977326, XrefRangeEnd = 977331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append<T>(T input) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = input;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref input;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.MethodInfoStoreGeneric_Append_Public_Void_T_0<T>.Pointer, ref this, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0004A778 File Offset: 0x00048978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977331, XrefRangeEnd = 977334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(Delegate del)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_Delegate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0004A7B0 File Offset: 0x000489B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977334, XrefRangeEnd = 977336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFuncHashCode(Delegate del)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0004A7F4 File Offset: 0x000489F4
		public unsafe int value
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0004A824 File Offset: 0x00048A24
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashFNV1A32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00008842 File Offset: 0x00006A42
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, ref this));
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0004A854 File Offset: 0x00048A54
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00008854 File Offset: 0x00006A54
		public unsafe static uint k_Prime
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(HashFNV1A32.NativeFieldInfoPtr_k_Prime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashFNV1A32.NativeFieldInfoPtr_k_Prime, (void*)(&value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0004A870 File Offset: 0x00048A70
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00008862 File Offset: 0x00006A62
		public unsafe static uint k_OffsetBasis
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(HashFNV1A32.NativeFieldInfoPtr_k_OffsetBasis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashFNV1A32.NativeFieldInfoPtr_k_OffsetBasis, (void*)(&value));
			}
		}

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_k_Prime;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr_k_OffsetBasis;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_m_Hash;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Single_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Double_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_T_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Void_Delegate_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C48 RID: 3144
		[FieldOffset(0)]
		public uint m_Hash;

		// Token: 0x020001FF RID: 511
		private sealed class MethodInfoStoreGeneric_Append_Public_Void_T_0<T>
		{
			// Token: 0x0400138F RID: 5007
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashFNV1A32.NativeMethodInfoPtr_Append_Public_Void_T_0, Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
