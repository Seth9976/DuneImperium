using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000012 RID: 18
	[StructLayout(2)]
	public struct MeshId
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000058A0 File Offset: 0x00003AA0
		// Note: this type is marked as 'beforefieldinit'.
		static MeshId()
		{
			Il2CppClassPointerStore<MeshId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "MeshId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshId>.NativeClassPtr);
			MeshId.NativeFieldInfoPtr_s_InvalidId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "s_InvalidId");
			MeshId.NativeFieldInfoPtr_m_SubId1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "m_SubId1");
			MeshId.NativeFieldInfoPtr_m_SubId2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshId>.NativeClassPtr, "m_SubId2");
			MeshId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663360);
			MeshId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663361);
			MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663362);
			MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshId>.NativeClassPtr, 100663363);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000595C File Offset: 0x00003B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258851, XrefRangeEnd = 1258861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005988 File Offset: 0x00003B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000059B8 File Offset: 0x00003BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258861, XrefRangeEnd = 1258866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000059FC File Offset: 0x00003BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 657862, RefRangeEnd = 657864, XrefRangeStart = 657862, XrefRangeEnd = 657864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MeshId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002A3F File Offset: 0x00000C3F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshId>.NativeClassPtr, ref this));
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00005A3C File Offset: 0x00003C3C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe static MeshId s_InvalidId
		{
			get
			{
				MeshId meshId;
				IL2CPP.il2cpp_field_static_get_value(MeshId.NativeFieldInfoPtr_s_InvalidId, (void*)(&meshId));
				return meshId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshId.NativeFieldInfoPtr_s_InvalidId, (void*)(&value));
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005A58 File Offset: 0x00003C58
		public static bool operator ==(MeshId id1, MeshId id2)
		{
			return id1.m_SubId1 == id2.m_SubId1 && id1.m_SubId2 == id2.m_SubId2;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00005A8C File Offset: 0x00003C8C
		public static bool operator !=(MeshId id1, MeshId id2)
		{
			return id1.m_SubId1 != id2.m_SubId1 || id1.m_SubId2 != id2.m_SubId2;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00005AC0 File Offset: 0x00003CC0
		public static MeshId InvalidId
		{
			get
			{
				return MeshId.s_InvalidId;
			}
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidId;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_SubId1;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_SubId2;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshId_0;

		// Token: 0x040000EC RID: 236
		[FieldOffset(0)]
		public ulong m_SubId1;

		// Token: 0x040000ED RID: 237
		[FieldOffset(8)]
		public ulong m_SubId2;
	}
}
