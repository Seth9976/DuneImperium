using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000247 RID: 583
	[StructLayout(2)]
	public struct ShaderTagId
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x000A6940 File Offset: 0x000A4B40
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderTagId()
		{
			Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderTagId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr);
			ShaderTagId.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "none");
			ShaderTagId.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "m_Id");
			ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668362);
			ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668363);
			ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668364);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668365);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668366);
			ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668367);
			ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668368);
			ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100668369);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000A6A38 File Offset: 0x000A4C38
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 684936, RefRangeEnd = 684960, XrefRangeStart = 684935, XrefRangeEnd = 684936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderTagId(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000A6A70 File Offset: 0x000A4C70
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x000A6AA0 File Offset: 0x000A4CA0
		public unsafe int id
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000A6AD4 File Offset: 0x000A4CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684960, XrefRangeEnd = 684963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000A6B18 File Offset: 0x000A4D18
		[CallerCount(0)]
		public unsafe bool Equals(ShaderTagId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000A6B58 File Offset: 0x000A4D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684963, XrefRangeEnd = 684964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000A6B88 File Offset: 0x000A4D88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 323148, RefRangeEnd = 323154, XrefRangeStart = 323148, XrefRangeEnd = 323154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000A6BD4 File Offset: 0x000A4DD4
		[CallerCount(0)]
		public unsafe static bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0000F559 File Offset: 0x0000D759
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000A6C20 File Offset: 0x000A4E20
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0000F56B File Offset: 0x0000D76B
		public unsafe static ShaderTagId none
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000A6C3C File Offset: 0x000A4E3C
		public string name
		{
			get
			{
				return Shader.IDToTag(this.id);
			}
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000A6C5C File Offset: 0x000A4E5C
		public static explicit operator ShaderTagId(string name)
		{
			return new ShaderTagId(name);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000A6C74 File Offset: 0x000A4E74
		public static explicit operator string(ShaderTagId tagId)
		{
			return tagId.name;
		}

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Internal_get_Int32_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;

		// Token: 0x04002337 RID: 9015
		[FieldOffset(0)]
		public int m_Id;
	}
}
