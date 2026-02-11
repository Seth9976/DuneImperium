using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000239 RID: 569
	[StructLayout(2)]
	public struct RasterState
	{
		// Token: 0x06002615 RID: 9749 RVA: 0x000A1C54 File Offset: 0x0009FE54
		// Note: this type is marked as 'beforefieldinit'.
		static RasterState()
		{
			Il2CppClassPointerStore<RasterState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RasterState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RasterState>.NativeClassPtr);
			RasterState.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "defaultValue");
			RasterState.NativeFieldInfoPtr_m_CullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_CullingMode");
			RasterState.NativeFieldInfoPtr_m_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetUnits");
			RasterState.NativeFieldInfoPtr_m_OffsetFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetFactor");
			RasterState.NativeFieldInfoPtr_m_DepthClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_DepthClip");
			RasterState.NativeFieldInfoPtr_m_Conservative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Conservative");
			RasterState.NativeFieldInfoPtr_m_Padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding1");
			RasterState.NativeFieldInfoPtr_m_Padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding2");
			RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668185);
			RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668186);
			RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668187);
			RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668188);
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000A1D74 File Offset: 0x0009FF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683774, RefRangeEnd = 683775, XrefRangeStart = 683769, XrefRangeEnd = 683774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0f, bool depthClip = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetUnits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetFactor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthClip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x000A1DD0 File Offset: 0x0009FFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683775, XrefRangeEnd = 683776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RasterState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000A1E10 File Offset: 0x000A0010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683776, XrefRangeEnd = 683782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x000A1E54 File Offset: 0x000A0054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683782, XrefRangeEnd = 683785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0000EEC9 File Offset: 0x0000D0C9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RasterState>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000A1E84 File Offset: 0x000A0084
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x0000EEDB File Offset: 0x0000D0DB
		public unsafe static RasterState defaultValue
		{
			get
			{
				RasterState rasterState;
				IL2CPP.il2cpp_field_static_get_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*)(&rasterState));
				return rasterState;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*)(&value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x000A1EA0 File Offset: 0x000A00A0
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
		public CullMode cullingMode
		{
			get
			{
				return this.m_CullingMode;
			}
			set
			{
				this.m_CullingMode = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x000A1EB8 File Offset: 0x000A00B8
		// (set) Token: 0x06002620 RID: 9760 RVA: 0x0000EEF3 File Offset: 0x0000D0F3
		public bool depthClip
		{
			get
			{
				return Convert.ToBoolean(this.m_DepthClip);
			}
			set
			{
				this.m_DepthClip = Convert.ToByte(value);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x000A1ED8 File Offset: 0x000A00D8
		// (set) Token: 0x06002622 RID: 9762 RVA: 0x0000EF02 File Offset: 0x0000D102
		public bool conservative
		{
			get
			{
				return Convert.ToBoolean(this.m_Conservative);
			}
			set
			{
				this.m_Conservative = Convert.ToByte(value);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000A1EF8 File Offset: 0x000A00F8
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x0000EF11 File Offset: 0x0000D111
		public int offsetUnits
		{
			get
			{
				return this.m_OffsetUnits;
			}
			set
			{
				this.m_OffsetUnits = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x000A1F10 File Offset: 0x000A0110
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x0000EF1B File Offset: 0x0000D11B
		public float offsetFactor
		{
			get
			{
				return this.m_OffsetFactor;
			}
			set
			{
				this.m_OffsetFactor = value;
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000A1F28 File Offset: 0x000A0128
		public static bool operator ==(RasterState left, RasterState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000A1F44 File Offset: 0x000A0144
		public static bool operator !=(RasterState left, RasterState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMode;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetUnits;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetFactor;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthClip;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeFieldInfoPtr_m_Conservative;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding1;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding2;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002221 RID: 8737
		[FieldOffset(0)]
		public CullMode m_CullingMode;

		// Token: 0x04002222 RID: 8738
		[FieldOffset(4)]
		public int m_OffsetUnits;

		// Token: 0x04002223 RID: 8739
		[FieldOffset(8)]
		public float m_OffsetFactor;

		// Token: 0x04002224 RID: 8740
		[FieldOffset(12)]
		public byte m_DepthClip;

		// Token: 0x04002225 RID: 8741
		[FieldOffset(13)]
		public byte m_Conservative;

		// Token: 0x04002226 RID: 8742
		[FieldOffset(14)]
		public byte m_Padding1;

		// Token: 0x04002227 RID: 8743
		[FieldOffset(15)]
		public byte m_Padding2;
	}
}
