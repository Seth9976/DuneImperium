using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000236 RID: 566
	[StructLayout(2)]
	public struct LODParameters
	{
		// Token: 0x060025F6 RID: 9718 RVA: 0x000A194C File Offset: 0x0009FB4C
		// Note: this type is marked as 'beforefieldinit'.
		static LODParameters()
		{
			Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LODParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
			LODParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_IsOrthographic");
			LODParameters.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPosition");
			LODParameters.NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_FieldOfView");
			LODParameters.NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_OrthoSize");
			LODParameters.NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPixelHeight");
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668181);
			LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668182);
			LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668183);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000A1A1C File Offset: 0x0009FC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683758, RefRangeEnd = 683759, XrefRangeStart = 683756, XrefRangeEnd = 683758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LODParameters other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000A1A5C File Offset: 0x0009FC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683759, XrefRangeEnd = 683763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000A1AA0 File Offset: 0x0009FCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683768, RefRangeEnd = 683769, XrefRangeStart = 683763, XrefRangeEnd = 683768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0000EDE7 File Offset: 0x0000CFE7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x000A1AD0 File Offset: 0x0009FCD0
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x0000EDF9 File Offset: 0x0000CFF9
		public bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			set
			{
				this.m_IsOrthographic = Convert.ToInt32(value);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x000A1AF0 File Offset: 0x0009FCF0
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x0000EE08 File Offset: 0x0000D008
		public Vector3 cameraPosition
		{
			get
			{
				return this.m_CameraPosition;
			}
			set
			{
				this.m_CameraPosition = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x000A1B08 File Offset: 0x0009FD08
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x0000EE12 File Offset: 0x0000D012
		public float fieldOfView
		{
			get
			{
				return this.m_FieldOfView;
			}
			set
			{
				this.m_FieldOfView = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000A1B20 File Offset: 0x0009FD20
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x0000EE1C File Offset: 0x0000D01C
		public float orthoSize
		{
			get
			{
				return this.m_OrthoSize;
			}
			set
			{
				this.m_OrthoSize = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A1B38 File Offset: 0x0009FD38
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x0000EE26 File Offset: 0x0000D026
		public int cameraPixelHeight
		{
			get
			{
				return this.m_CameraPixelHeight;
			}
			set
			{
				this.m_CameraPixelHeight = value;
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000A1B50 File Offset: 0x0009FD50
		public static bool operator ==(LODParameters left, LODParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000A1B6C File Offset: 0x0009FD6C
		public static bool operator !=(LODParameters left, LODParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPosition;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeFieldInfoPtr_m_FieldOfView;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeFieldInfoPtr_m_OrthoSize;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002201 RID: 8705
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x04002202 RID: 8706
		[FieldOffset(4)]
		public Vector3 m_CameraPosition;

		// Token: 0x04002203 RID: 8707
		[FieldOffset(16)]
		public float m_FieldOfView;

		// Token: 0x04002204 RID: 8708
		[FieldOffset(20)]
		public float m_OrthoSize;

		// Token: 0x04002205 RID: 8709
		[FieldOffset(24)]
		public int m_CameraPixelHeight;
	}
}
